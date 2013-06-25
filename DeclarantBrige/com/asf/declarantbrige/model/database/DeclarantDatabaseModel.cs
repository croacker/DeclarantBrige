using System.Data;
using System.IO;
using com.asf.util;

namespace com.asf.declarantbrige.model.database {
    
    class DeclarantDatabaseModel : AbstractModel
    {
        public const string TABLE_NAME = "bases";

        public static class Query
        {
            public static string GET_ALL = "SELECT * FROM {0}";
        }

        public const string DB_PASSWORD = "7338a7e6-fd3b-49d1-8d90-ddbbc1b39fa1";

        public string ConnectionString
        {
            get {return ConnectionStringHelper.getSqlCe(Basepath, DB_PASSWORD);}
        }

        public static class Properties
        {
            public static string ID = "Id";
            public static string ORGANIZATION_NAME = "Orgname";
            public static string INN = "INN";
            public static string PATH = "Basepath";
        }

        public DeclarantDatabaseModel()
        {
            
        }

        public DeclarantDatabaseModel(DataRow row)
        {
             Id = (int) row.ItemArray[0];
             Orgname = row.ItemArray[1].ToString();
             Inn = row.ItemArray[2].ToString();
             Basepath = new FileInfo(row.ItemArray[3].ToString()).FullName;
        }

        public string Description
        {
            get
            {
                if (!string.IsNullOrEmpty(Inn) || !string.IsNullOrEmpty(Orgname))
                {
                    return "ИНН " + Inn + " " + Orgname;
                }
                else
                {
                    return Basepath;
                }
            }
        }

        public int Id
        {
            get { return getInt(Properties.ID); }
            set { setProperty(Properties.ID, value); }
        }

        public string Orgname
        {
            get { return getString(Properties.ORGANIZATION_NAME); }
            set { setProperty(Properties.ORGANIZATION_NAME, value); }
        }

        public string Inn
        {
            get { return getString(Properties.INN); }
            set { setProperty(Properties.INN, value); }
        }

        public string Basepath
        {
            get { return getString(Properties.PATH); }
            set { setProperty(Properties.PATH, value); }
        }

        public bool Exists
        {
            get { return File.Exists(Basepath); }
        }

    }
}
