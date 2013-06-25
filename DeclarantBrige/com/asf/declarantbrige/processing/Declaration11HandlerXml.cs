using System.Collections.Generic;
using com.asf.declarantbrige.model;

namespace com.asf.declarantbrige.processing {

    /// <summary>
    /// Обработчик декларации 11 в XML
    /// </summary>
    class Declaration11HandlerXml : DeclarationHandler
    {
        private declarant.xml11.Файл DeclarationFile { get; set; }

        public override void handle()
        {
            declarant.xml11.Файл declaration = ServiceFactory.getInstance().XmlService.getDeclaration11(
                ServiceFactory.getInstance().ConfigurationService.getAppConfiguration().getExchangePath());

            if (DeletePrevious) {
                addLogLine("Удаление строк декларации 11...");
                deleteDeclarationRows(DeclarationHeader, Organization, "DecF11");
                DeclarationHeader.Lines11.Clear();
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
                            addLogLine("Не найден Производитель " + producerName + " " + producerInn);
                            continue;
                        }
                    }

                    //Остатки!!!
                    foreach (var remains in producer.Движение) {
                        DecF11 decF11 = DeclarationHeader.getLine11(Organization.Id.ToString(), alcoholCode, producerContragent.Id);

                        decimal remainsBegin = 0;
                        if (decF11 == null) {
                            decF11 = modelFactory.createLine11();
                        }

                        if (DeletePrevious) {
                            remainsBegin = remains.П100000000006;
                        }

                        decF11.VidCode = alcoholCode;
                        decF11.IdOrg = Organization.Id.ToString();
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

                        DeclarationHeader.addLine11(decF11);
                    }

                    //Движения!!!
                    foreach (var document in producer.Продукция) {
                        DecF11 decF11 = modelFactory.createLine11();

                        decF11.VidCode = alcoholCode;
                        decF11.IdOrg = Organization.Id.ToString();
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

                        DeclarationHeader.addLine11(decF11);
                    }
                }
            }
            DeclarationHeader.calcRemains11();
            addLogLine("Сохранение декларации 11, количество строк:" + DeclarationHeader.Lines11.Count);
            ServiceFactory.getInstance().HibernateService.saveOrUpdate(DeclarationHeader);
        }
    }
}
