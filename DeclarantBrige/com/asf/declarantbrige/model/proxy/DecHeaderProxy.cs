namespace com.asf.declarantbrige.model.proxy {
    class DecHeaderProxy :IHibernateModelProxy
    {
        public DecHeader Header { get; set; }

        public DecHeaderProxy(DecHeader header)
        {
            Header = header;
        }
        
        public string Quartal
        {
            get{
                    switch (Header.PrizPeriod)
                    {
                        case "3":
                            return "1";
                        case "6":
                            return "2";
                        case "9":
                            return "3";
                        case "12":
                            return "4";
                        default:
                            return "не задан";
                    }
            }
        }

        public string ModelDescription {
            get { return "№ " + Header.Id + " "
                + " квартал " + Quartal + ", "
                + Header.Yearotch + "г."
                + " Декларация " + Header.TypeId;
            }
        }

        public object Model { get { return Header; } }
    }
}
