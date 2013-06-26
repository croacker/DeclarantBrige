using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Spring.Context;
using Spring.Context.Support;
using com.asf.declarantbrige.csv;
using com.asf.declarantbrige.model;
using com.asf.declarantbrige.model.proxy;
using com.asf.declarantbrige.processing;
using declarant.xml;
using log4net;
//TODO Split to strategies
namespace com.asf.declarantbrige.service {

    /// <summary>
    /// Сервис обработки
    /// </summary>
    internal class ProcessingService : AbstractService, IProcessingService {
        private static readonly ILog log = LogManager.GetLogger(typeof(ProcessingService));

        protected override void addLogLine(string msg) {
            base.addLogLine(msg);
            if (log != null) {
                log.Info(msg);
            }
        }

        /// <summary>
        /// Заполнить список деклараций
        /// </summary>
        public void fillDeclarationHeadersList(ListControl listControl, AbstractContext context) {
            List<DecHeader> lst = context.Hibernate.getDecHeaders();
            var proxyList = new List<DecHeaderProxy>();
            foreach (var decHeader in lst) {
                proxyList.Add(new DecHeaderProxy(decHeader));
            }

            listControl.DataSource = proxyList;
            listControl.DisplayMember = "ModelDescription";
            listControl.ValueMember = "Model";
        }

        /// <summary>
        /// Заполнить список деклараций
        /// </summary>
        public void fillOrganizationsList(ListControl listControl, AbstractContext context) {
            listControl.DataSource = context.Hibernate.getOrganizations();
            listControl.DisplayMember = "OrgName";
        }

        /// <summary>
        /// Найти контрагента в кэше
        /// </summary>
        /// <returns></returns>
        private WrkContragent getContragentByInn(string inn) {
            return ServiceFactory.getInstance().HibernateService.getContragentByInn(inn);
        }

        /// <summary>
        /// Найти контрагента в кэше
        /// </summary>
        /// <returns></returns>
        private WrkContragent getContragentByInnKpp(string inn, string kpp) {
            return ServiceFactory.getInstance().HibernateService.getContragentByInnKpp(inn, kpp);
        }

        /// <summary>
        /// Найти контрагента в кэше
        /// </summary>
        /// <returns></returns>
        private WrkContragent getContragentByName(string name) {
            return ServiceFactory.getInstance().HibernateService.getContragentByName(name);
        }

        /// <summary>
        /// Найти вид алкоголя в Кэше
        /// </summary>
        /// <param name="code"></param>
        /// <returns></returns>
        private RefAlckind getAlcoholFromCache(string code) {
            return ServiceFactory.getInstance().HibernateService.getAlcoholByCode(code);
        }

        /// <summary>
        /// Запись контрагентов
        /// </summary>
        /// <param name="references"></param>
        public void processReferences() {
            Справочники references = ServiceFactory.getInstance().XmlService.getReferences(
                ServiceFactory.getInstance().ConfigurationService.getAppConfiguration().getExchangePath());

            foreach (var contragent in references.Контрагенты) {
                WrkContragent wrkContragent;
                if (contragent.isResident()) {
                    wrkContragent =
                        getContragentByInn(contragent.getContragentSearchIndex());
                } else {
                    wrkContragent =
                        getContragentByName(contragent.getContragentSearchIndex());
                }

                writeContragent(wrkContragent, contragent);
            }
        }

        /// <summary>
        /// Записать контрагента
        /// </summary>
        /// <param name="wrkContragent"></param>
        /// <param name="contragent"></param>
        private void writeContragent(WrkContragent wrkContragent, СправочникиКонтрагенты contragent) {
            if (wrkContragent == null) {
                wrkContragent = ModelFactory.getInstance().createContragent(contragent);
            }

            wrkContragent.KPP = contragent.getContragentKpp();
            wrkContragent.CCode = contragent.getContragentCountryCode();
            wrkContragent.Index = contragent.getContragentIndex();
            wrkContragent.RCode = contragent.getContragentRegion();
            wrkContragent.Area = contragent.getContragentArea();
            wrkContragent.City = contragent.getContragentCity();
            wrkContragent.Place = contragent.getContragentPlace();
            wrkContragent.Street = contragent.getContragentStreet();
            wrkContragent.Building = contragent.getContragentBuilding();
            wrkContragent.Korp = contragent.getContragentKorp();
            wrkContragent.Flat = contragent.getContragentFlat();
            //wrkContragent.RefOrgId = //НЕИСПОЛЬЗУЕТСЯ
            //wrkContragent.FlSurname = //НЕИСПОЛЬЗУЕТСЯ 
            //wrkContragent.FlName = //НЕИСПОЛЬЗУЕТСЯ
            //wrkContragent.FlSecname = //НЕИСПОЛЬЗУЕТСЯ
            //wrkContragent.FlAddress = //НЕИСПОЛЬЗУЕТСЯ
            wrkContragent.ForeignAddres = contragent.getContragentForeignAddres();
            wrkContragent.OrgType = contragent.getContragentOrgType();
            wrkContragent.Producer = contragent.getContragentProducer();
            wrkContragent.Liter = contragent.getContragentLiter();
            wrkContragent.Carrier = contragent.getContragentCarrier();
            //wrkContragent.Varnumber =  //НЕИСПОЛЬЗУЕТСЯ

            //ВРЕМЕННО Только для контрагентов, у которых нет лицензий
            if (wrkContragent.Licenses.Count == 0
                && contragent.isResident()) {
                writeContragentLicense(wrkContragent, contragent.getLicenses());
            }

            ServiceFactory.getInstance().HibernateService.saveOrUpdate(wrkContragent);
        }

        /// <summary>
        /// Записать лицензии контрагента
        /// </summary>
        /// <param name="wrkContragent"></param>
        /// <param name="licenses"></param>
        private void writeContragentLicense(WrkContragent wrkContragent, СправочникиКонтрагентыРезидентЛицензии[] licenses) {
            foreach (var license in licenses) {
                string[] licenseNum = license.Лицензия.П000000000011.Split(',');
                if (licenseNum.Length == 0) {
                    licenseNum[0] = "";
                    licenseNum[1] = license.Лицензия.П000000000011;
                }

                WrkContrLicense wrkContrLicense = wrkContragent.findLicense(licenseNum);
                if (wrkContrLicense == null) {
                    wrkContrLicense = ModelFactory.getInstance().createContragentLicense(license.Лицензия);
                }

                wrkContrLicense.RefContrId = license.Лицензия.ИдЛицензии;
                wrkContrLicense.Series = licenseNum[0]; //Серия
                wrkContrLicense.Number = licenseNum[1]; //номер
                wrkContrLicense.DateBegin = license.Лицензия.П000000000012;//Дата выдачи
                wrkContrLicense.DateEnd = license.Лицензия.П000000000013;//Дата окончания
                wrkContrLicense.Vidana = license.Лицензия.П000000000014;//Орган
                wrkContragent.addLicense(wrkContrLicense);
            }
        }

        /// <summary>
        /// Очистить декларацию(удалить строки)
        /// </summary>
        /// <param name="?"></param>
        public void deleteDeclarationRows(DecHeader decHeader, WrkOrg organization, string linesTable) {
            ServiceFactory.getInstance().HibernateService.deleteDeclarationRows(decHeader.Id, organization.Id, linesTable);
        }

        public void processDeclaration(DecHeader decHeader, WrkOrg wrkOrg, bool clearDeclaration) {
            string exchangeFolder =
                ServiceFactory.getInstance().ConfigurationService.getAppConfiguration().getExchangePath();
            if (decHeader.TypeId == 11) {

                if (clearDeclaration) {
                    addLogLine("Удаление строк декларации 11...");
                    deleteDeclarationRows(decHeader, wrkOrg, "DecF11");
                    decHeader.Lines11.Clear();
                }

                if (File.Exists(exchangeFolder + XmlService.XmlFiles.DECLARATION_11)) {
                    processDeclaration11(decHeader, wrkOrg, clearDeclaration);
                } else {
                    processDeclaration11Csv(decHeader, wrkOrg, clearDeclaration);
                }

            } else if (decHeader.TypeId == 12) {

                if (clearDeclaration) {
                    addLogLine("Удаление строк декларации 12...");
                    deleteDeclarationRows(decHeader, wrkOrg, "DecF12");
                    decHeader.Lines12.Clear();
                }

                if (File.Exists(exchangeFolder + XmlService.XmlFiles.DECLARATION_12)) {
                    processDeclaration12(decHeader, wrkOrg, clearDeclaration);
                } else {
                    processDeclaration12Csv(decHeader, wrkOrg, clearDeclaration);
                }

            }
        }



        /// <summary>
        /// Обработать декларацию 11
        /// </summary>
        public void processDeclaration11(DecHeader decHeader, WrkOrg wrkOrg, bool clearDeclaration) {
            declarant.xml11.Файл declaration = ServiceFactory.getInstance().XmlService.getDeclaration11(
                ServiceFactory.getInstance().ConfigurationService.getAppConfiguration().getExchangePath());

            ModelFactory modelFactory = ModelFactory.getInstance();

            foreach (var turnover in declaration.Документ) {
                string alcoholCode = turnover.П000000000003.ToString().Replace("Item", "");
                foreach (var producer in turnover.СведПроизвИмпорт) {
                    string producerInn = producer.INN;
                    string producerKpp = producer.KPP;
                    string producerName = producer.NameOrg;

                    //Производитель
                    WrkContragent producerContragent = getContragentByName(producerName);
                    if (producerContragent == null) {
                        producerContragent = getContragentByInnKpp(producerInn, producerKpp);
                        if (producerContragent == null) {
                            addLogLine("Не найден Производитель " + producerName + " " + producerInn);
                            continue;
                        }
                    }

                    //Остатки!!!
                    foreach (var remains in producer.Движение) {
                        DecF11 decF11 = decHeader.getLine11(wrkOrg.Id.ToString(), alcoholCode, producerContragent.Id);

                        decimal remainsBegin = 0;
                        if (decF11 == null) {
                            decF11 = modelFactory.createLine11();
                        }

                        if (clearDeclaration) {
                            remainsBegin = remains.П100000000006;
                        }

                        decF11.VidCode = alcoholCode;
                        decF11.IdOrg = wrkOrg.Id.ToString();
                        decF11.ProdId = producerContragent.Id;
                        decF11.TTYPE = 1;

                        decF11.P106 += remainsBegin;// Остаток на начало
                        decF11.P107 = remains.П100000000007; // Поступление от производителя
                        decF11.P108 = remains.П100000000008; // Поступление от оптовика
                        decF11.P109 = remains.П100000000009; // Поступление по импорту
                        decF11.P110 = remains.П100000000010; // Закупки итого
                        decF11.P111 = remains.П100000000011; // Возврат от покупателя
                        decF11.P112 = remains.П100000000012; // Прочее поступление
                        decF11.P113 = remains.П100000000013; // Перемещение
                        decF11.P114 = remains.П100000000014; // Поступление всего
                        decF11.P115 = remains.П100000000015; // Расход продажи
                        decF11.P116 = remains.П100000000016; // Прочий расход
                        decF11.P117 = remains.П100000000017; // Возврат поставщику
                        decF11.P118 = remains.П100000000018; // Расход перемещение
                        decF11.P119 = remains.П100000000019; // Расход всего
                        //decF11.P120 += (decF11.P106 + decF11.P114 - decF11.P119); // Остаток на конец

                        decHeader.addLine11(decF11);
                    }

                    //Движения!!!
                    foreach (var document in producer.Продукция) {
                        DecF11 decF11 = modelFactory.createLine11();

                        decF11.VidCode = alcoholCode;
                        decF11.IdOrg = wrkOrg.Id.ToString();
                        decF11.ProdId = producerContragent.Id;
                        decF11.TTYPE = 2;

                        //Пустая запись в выгрузке
                        if (document.SUPPLIER_INN == null) {
                            continue;
                        }

                        WrkContragent supplierContragent = getContragentByInn(document.SUPPLIER_INN);
                        if (supplierContragent == null) {
                            addLogLine("Не найден Поставщик с ИНН: " + document.SUPPLIER_INN);
                            continue;
                        }

                        decF11.IdPost = supplierContragent.Id;
                        if (supplierContragent.Licenses.Count != 0) {
                            IEnumerator<WrkContrLicense> e = supplierContragent.Licenses.GetEnumerator();
                            e.MoveNext();
                            decF11.IdLic = e.Current.Id;
                        }

                        decF11.P213 = document.П200000000013;
                        decF11.P214 = document.П200000000014;
                        decF11.P215 = document.П200000000015;
                        decF11.P216 = document.П200000000016;

                        decHeader.addLine11(decF11);
                    }
                }
            }
            decHeader.calcRemains11();
            addLogLine("Сохранение декларации 11, количество строк:" + decHeader.Lines11.Count);
            ServiceFactory.getInstance().HibernateService.saveOrUpdate(decHeader);
        }

        /// <summary>
        /// 
        /// </summary>
        private void processDeclaration11Csv(DecHeader decHeader, WrkOrg wrkOrg, bool clearDeclaration) {
            Declaration11Csv declaration11Csv = ServiceFactory.getInstance().CsvService.getDeclaration11(
                ServiceFactory.getInstance().ConfigurationService.getAppConfiguration().getExchangePath());

            var modelFactory = ModelFactory.getInstance();

            //Остатки!!!
            foreach (var turnover in declaration11Csv.Turnovers11) {
                string alcoholCode = turnover.VidCode;
                string producerInn = turnover.ProdInn;
                string producerKpp = turnover.ProdKpp;
                string producerName = turnover.ProdName;

                //Производитель
                WrkContragent producerContragent = getContragentByName(producerName);
                if (producerContragent == null) {
                    producerContragent = getContragentByInnKpp(producerInn, producerKpp);
                    if (producerContragent == null) {
                        addLogLine("Не найден Производитель " + producerName + " " + producerInn);
                        continue;
                    }
                }


                DecF11 decF11 = decHeader.getLine11(wrkOrg.Id.ToString(), alcoholCode, producerContragent.Id);

                decimal remainsBegin = 0;
                if (decF11 == null) {
                    decF11 = modelFactory.createLine11();
                }

                if (clearDeclaration) {
                    remainsBegin = turnover.P106;
                }

                decF11.VidCode = alcoholCode;
                decF11.IdOrg = wrkOrg.Id.ToString();
                decF11.ProdId = producerContragent.Id;
                decF11.TTYPE = 1;

                decF11.P106 += remainsBegin; // Остаток на начало
                decF11.P107 = turnover.P107; // Поступление от производителя
                decF11.P108 = turnover.P108; // Поступление от оптовика
                decF11.P109 = turnover.P109; // Поступление по импорту
                decF11.P110 = turnover.P110; // Закупки итого
                decF11.P111 = turnover.P111; // Возврат от покупателя
                decF11.P112 = turnover.P112; // Прочее поступление
                decF11.P113 = turnover.P113; // Перемещение
                decF11.P114 = turnover.P114; // Поступление всего
                decF11.P115 = turnover.P115; // Расход продажи
                decF11.P116 = turnover.P116; // Прочий расход
                decF11.P117 = turnover.P117; // Возврат поставщику
                decF11.P118 = turnover.P118; // Расход перемещение
                decF11.P119 = turnover.P119; // Расход всего
                //decF11.P120 += (decF11.P106 + decF11.P114 - decF11.P119); // Остаток на конец

                decHeader.addLine11(decF11);
            }

            //Движения!!!
            foreach (var document in declaration11Csv.Invoices) {
                DecF11 decF11 = modelFactory.createLine11();

                string producerInn = document.ProdInn;
                string producerKpp = document.ProdKpp;
                string producerName = document.ProdName;
                //Производитель
                WrkContragent producerContragent = getContragentByName(producerName);
                if (producerContragent == null) {
                    producerContragent = getContragentByInnKpp(producerInn, producerKpp);
                    if (producerContragent == null) {
                        addLogLine("Не найден Производитель " + producerName + " " + producerInn);
                        continue;
                    }
                }

                decF11.VidCode = document.VidCode;
                decF11.IdOrg = wrkOrg.Id.ToString();
                decF11.ProdId = producerContragent.Id;
                decF11.TTYPE = 2;

                WrkContragent supplierContragent = getContragentByInn(document.SupplierInn);
                if (supplierContragent == null) {
                    addLogLine("Не найден Поставщик с ИНН: " + document.SupplierInn);
                    continue;
                }

                decF11.IdPost = supplierContragent.Id;
                if (supplierContragent.Licenses.Count != 0) {
                    IEnumerator<WrkContrLicense> e = supplierContragent.Licenses.GetEnumerator();
                    e.MoveNext();
                    decF11.IdLic = e.Current.Id;
                }

                decF11.P213 = document.P29;
                decF11.P214 = document.P210;
                decF11.P215 = document.P211;
                decF11.P216 = document.P212;

                decHeader.addLine11(decF11);
            }

            decHeader.calcRemains11();
            addLogLine("Сохранение декларации 11, количество строк:" + decHeader.Lines11.Count);
            ServiceFactory.getInstance().HibernateService.saveOrUpdate(decHeader);
        }

        /// <summary>
        /// Обработать декларацию 12
        /// </summary>
        public void processDeclaration12(DecHeader decHeader, WrkOrg wrkOrg, bool clearDeclaration) {

            declarant.xml12.Файл declaration = ServiceFactory.getInstance().XmlService.getDeclaration12(
                ServiceFactory.getInstance().ConfigurationService.getAppConfiguration().getExchangePath());

            if (clearDeclaration) {
                addLogLine("Удаление строк декларации 12...");
                deleteDeclarationRows(decHeader, wrkOrg, "DecF12");
                decHeader.Lines12.Clear();
            }

            ModelFactory modelFactory = ModelFactory.getInstance();

            foreach (var turnover in declaration.Документ) {
                string alcoholCode = turnover.П000000000003.ToString().Replace("Item", "");
                foreach (var producer in turnover.СведПроизвИмпорт) {
                    string producerInn = producer.INN;
                    string producerKpp = producer.KPP;
                    string producerName = producer.NameOrg;

                    //Производитель
                    WrkContragent producerContragent = getContragentByName(producerName);
                    if (producerContragent == null) {
                        producerContragent = getContragentByInnKpp(producerInn, producerKpp);
                        if (producerContragent == null) {
                            addLogLine("Не найден Производитель " + producerName + " " + producerInn + "...");
                            continue;
                        }
                    }

                    //Остатки!!!
                    foreach (var remains in producer.Движение) {
                        DecF12 decF12 = decHeader.getLine12(wrkOrg.Id.ToString(), alcoholCode, producerContragent.Id);

                        decimal remainsBegin = 0;
                        if (decF12 == null) {
                            decF12 = modelFactory.createLine12();
                        }

                        if (clearDeclaration) {
                            remainsBegin = remains.П100000000006;
                        }

                        decF12.VidCode = alcoholCode;
                        decF12.IdOrg = wrkOrg.Id.ToString();
                        decF12.ProdId = producerContragent.Id;
                        decF12.TTYPE = 1;

                        decF12.P106 += remainsBegin;// Остаток на начало
                        decF12.P107 = remains.П100000000007;
                        decF12.P108 = remains.П100000000008;
                        decF12.P109 = remains.П100000000009;
                        decF12.P110 = remains.П100000000010;
                        decF12.P111 = remains.П100000000011;
                        decF12.P112 = remains.П100000000012;
                        decF12.P113 = remains.П100000000013;
                        decF12.P114 = remains.П100000000014;
                        decF12.P115 = remains.П100000000015;
                        decF12.P116 = remains.П100000000016;
                        decF12.P117 = remains.П100000000017;
                        //decF12.P118 = remains.П100000000018;

                        decHeader.addLine12(decF12);
                    }

                    //Движения!!!
                    foreach (var document in producer.Продукция) {
                        DecF12 decF12 = modelFactory.createLine12();

                        decF12.VidCode = alcoholCode;
                        decF12.IdOrg = wrkOrg.Id.ToString();
                        decF12.ProdId = producerContragent.Id;
                        decF12.TTYPE = 2;

                        WrkContragent supplierContragent = getContragentByInn(document.SUPPLIER_INN);
                        if (supplierContragent == null) {
                            addLogLine("Не найден Поставщик с ИНН: " + document.SUPPLIER_INN);
                            continue;
                        }

                        decF12.IdPost = supplierContragent.Id;

                        decF12.P29 = document.П200000000013;
                        decF12.P210 = document.П200000000014;
                        decF12.P211 = document.П200000000015;
                        decF12.P212 = document.П200000000016;

                        decHeader.addLine12(decF12);
                    }
                }
            }
            decHeader.calcRemains12();
            addLogLine("Сохранение декларации 12, количество строк:" + decHeader.Lines12.Count);
            ServiceFactory.getInstance().HibernateService.saveOrUpdate(decHeader);
        }

        private void processDeclaration12Csv(DecHeader decHeader, WrkOrg wrkOrg, bool clearDeclaration) {
            Declaration12Csv declaration12Csv = ServiceFactory.getInstance().CsvService.getDeclaration12(
                ServiceFactory.getInstance().ConfigurationService.getAppConfiguration().getExchangePath());

            var modelFactory = ModelFactory.getInstance();

            //Остатки!!!
            foreach (var turnover in declaration12Csv.Turnovers12) {
                string alcoholCode = turnover.VidCode;
                string producerInn = turnover.ProdInn;
                string producerKpp = turnover.ProdKpp;
                string producerName = turnover.ProdName;

                //Производитель
                WrkContragent producerContragent = getContragentByName(producerName);
                if (producerContragent == null) {
                    producerContragent = getContragentByInnKpp(producerInn, producerKpp);
                    if (producerContragent == null) {
                        addLogLine("Не найден Производитель " + producerName + " " + producerInn);
                        continue;
                    }
                }


                DecF12 decF12 = decHeader.getLine12(wrkOrg.Id.ToString(), alcoholCode, producerContragent.Id);

                decimal remainsBegin = 0;
                if (decF12 == null) {
                    decF12 = modelFactory.createLine12();
                }

                if (clearDeclaration) {
                    remainsBegin = turnover.P106;
                }

                decF12.VidCode = alcoholCode;
                decF12.IdOrg = wrkOrg.Id.ToString();
                decF12.ProdId = producerContragent.Id;
                decF12.TTYPE = 1;

                decF12.P106 += remainsBegin; // Остаток на начало
                decF12.P107 = turnover.P107; // Поступление от производителя
                decF12.P108 = turnover.P108; // Поступление от оптовика
                decF12.P109 = turnover.P109; // Поступление по импорту
                decF12.P110 = turnover.P110; // Закупки итого
                decF12.P111 = turnover.P111; // Возврат от покупателя
                decF12.P112 = turnover.P112; // Прочее поступление
                decF12.P113 = turnover.P113; // Перемещение
                decF12.P114 = turnover.P114; // Поступление всего
                decF12.P115 = turnover.P115; // Расход продажи
                decF12.P116 = turnover.P116; // Прочий расход
                decF12.P117 = turnover.P117; // Расход всего
                decF12.P118 = turnover.P118; // Остаток на конец

                decHeader.addLine12(decF12);
            }

            //Движения!!!
            foreach (var document in declaration12Csv.Invoices) {
                DecF12 decF12 = modelFactory.createLine12();

                string alcoholCode = document.VidCode;
                string producerInn = document.ProdInn;
                string producerKpp = document.ProdKpp;
                string producerName = document.ProdName;

                //Производитель
                WrkContragent producerContragent = getContragentByName(producerName);
                if (producerContragent == null) {
                    producerContragent = getContragentByInnKpp(producerInn, producerKpp);
                    if (producerContragent == null) {
                        addLogLine("Не найден Производитель " + producerName + " " + producerInn);
                        continue;
                    }
                }

                decF12.VidCode = alcoholCode;
                decF12.IdOrg = wrkOrg.Id.ToString();
                decF12.ProdId = producerContragent.Id;
                decF12.TTYPE = 2;

                decF12.IdPost = producerContragent.Id;

                decF12.P29 = document.P29;
                decF12.P210 = document.P210;
                decF12.P211 = document.P211;
                decF12.P212 = document.P212;

                decHeader.addLine12(decF12);
            }

            decHeader.calcRemains12();
            addLogLine("Сохранение декларации 11, количество строк:" + decHeader.Lines11.Count);
            ServiceFactory.getInstance().HibernateService.saveOrUpdate(decHeader);
        }

    }
}
