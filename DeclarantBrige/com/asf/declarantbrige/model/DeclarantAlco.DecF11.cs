namespace com.asf.declarantbrige.model
{

    /// <summary>
    /// Строка декларации 11
    /// </summary>
    public partial class DecF11 {
        #region Extensibility Method Definitions
        
        partial void OnCreated();
        
        #endregion

        public DecF11()
        {
            OnCreated();
        }


        /// <summary>
        /// There are no comments for Id in the schema.
        /// </summary>
        public virtual int Id { get; set; }


        /// <summary>
        /// Id заголовка
        /// </summary>
        public virtual int? Hid { get; set; }

        /// <summary>
        /// Заголовок
        /// </summary>
        //public virtual DecHeader Header { get; set; }

        /// <summary>
        /// Код вида алкогольной продукции
        /// </summary>
        public virtual string VidCode { get; set; }

        /// <summary>
        /// Вид алкогольной продукции
        /// </summary>
        //public virtual RefAlckind AlkoholKind { get; set; }

        /// <summary>
        /// Id Производителя
        /// </summary>
        public virtual int? ProdId { get; set; }

        /// <summary>
        /// Производитель
        /// </summary>
        //public virtual WrkContragent Producer { get; set; }

        /// <summary>
        /// Id Поставщика
        /// </summary>
        public virtual int? IdPost { get; set; }

        /// <summary>
        /// Поставщик IdPost
        /// </summary>
       // public virtual WrkContragent Suplier { get; set; }

        /// <summary>
        /// Id Лицензии поставщика
        /// </summary>
        public virtual int? IdLic { get; set; }

        /// <summary>
        /// Дата закупки
        /// </summary>
        public virtual string P213 { get; set; }


        /// <summary>
        /// ТТН
        /// </summary>
        public virtual string P214 { get; set; }


        /// <summary>
        /// Таможенная декларация
        /// </summary>
        public virtual string P215 { get; set; }


        /// <summary>
        /// Объем продукции
        /// </summary>
        public virtual decimal? P216 { get; set; }


        /// <summary>
        /// Остаток на начало
        /// </summary>
        public virtual decimal? P106 { get; set; }


        /// <summary>
        /// Поступление от производителя
        /// </summary>
        public virtual decimal? P107 { get; set; }


        /// <summary>
        /// Поступление от оптовика
        /// </summary>
        public virtual decimal? P108 { get; set; }


        /// <summary>
        /// Поступление по импорту
        /// </summary>
        public virtual decimal? P109 { get; set; }


        /// <summary>
        /// Закупки итого
        /// </summary>
        public virtual decimal? P110 { get; set; }


        /// <summary>
        /// Возврат от покупателя
        /// </summary>
        public virtual decimal? P111 { get; set; }


        /// <summary>
        /// Прочее поступление
        /// </summary>
        public virtual decimal? P112 { get; set; }


        /// <summary>
        /// Перемещение
        /// </summary>
        public virtual decimal? P113 { get; set; }


        /// <summary>
        /// Поступление всего
        /// </summary>
        public virtual decimal? P114 { get; set; }


        /// <summary>
        /// Расход продажи
        /// </summary>
        public virtual decimal? P115 { get; set; }


        /// <summary>
        /// Прочий расход
        /// </summary>
        public virtual decimal? P116 { get; set; }


        /// <summary>
        /// Возврат поставщику
        /// </summary>
        public virtual decimal? P117 { get; set; }


        /// <summary>
        /// Расход перемещение
        /// </summary>
        public virtual decimal? P118 { get; set; }


        /// <summary>
        /// Расход всего
        /// </summary>
        public virtual decimal? P119 { get; set; }


        /// <summary>
        /// Остаток на конец
        /// </summary>
        public virtual decimal? P120 { get; set; }


        /// <summary>
        /// Лист 1 или 2
        /// </summary>
        public virtual int? TTYPE { get; set; }


        /// <summary>
        /// id Организации/подразделения
        /// </summary>
        public virtual string IdOrg { get; set; }
    }

}
