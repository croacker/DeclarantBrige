using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using com.asf.declarantbrige.service;
using com.asf.configuration;
using com.asf.declarantbrige.model.database;
using com.asf.util;
using com.asf.collection;

namespace com.asf.declarantbrige.configuration {
    
    /// <summary>
    /// Конфигурация декларанта
    /// </summary>
    class DeclarantConfiguration: AbstractConfiguration
    {
        /// <summary>
        /// Расширение файла БД
        /// </summary>
        private const string DB_EXTENSION = ".sdf";

        /// <summary>
        /// Имя файла БД параметров Декларант
        /// </summary>
        private const string CONFIGURATION_DB_FILE_NAME = "sys" + DB_EXTENSION;
        
        /// <summary>
        /// Имя базы декларант
        /// </summary>
        //[Obsolete("Not used anymore",true)]
        private const string DB_NAME_END = "base" + DB_EXTENSION;

        /// <summary>
        /// Список БД Декларант. Ключ - полный путь к БД
        /// </summary>
        private Dictionary<string, DeclarantDatabaseModel> declarantDatabases = new Dictionary<string, DeclarantDatabaseModel>();
        //public HashMap<string, DeclarantDatabaseModel> DeclarantDatabases;
        public List<DeclarantDatabaseModel> DeclarantDatabases
        {
            get { List<DeclarantDatabaseModel> list =
                new List<DeclarantDatabaseModel>();
                list.AddRange(declarantDatabases.Values);
                return list;
            }
        }

        private string declarantFolder;
        public string DeclarantFolder
        {
            get { return declarantFolder;}
            set { declarantFolder = value; }
        }

        public override string getName()
        {
            return "DeclarantConfiguration";
        }

        public override void init()
        {
            declarantDatabases.Clear();
            if(Directory.Exists(DeclarantFolder))
            {
                getDatabasesFromDeclarantConf();
                findDbInFolder();
            }
        }

        /// <summary>
        /// Получить БД из конфигурации Декларанта
        /// </summary>
        private void getDatabasesFromDeclarantConf()
        {
            string fullPath = FsUtil.includeTrailingBackslash(DeclarantFolder);
            fullPath += CONFIGURATION_DB_FILE_NAME;
            if (File.Exists(fullPath))
            {
                SqlService sqlService = ServiceFactory.getInstance().SqlService;
                sqlService.ConnectionString = ConnectionStringHelper.getSqlCe(fullPath);
                DataTable table = sqlService.getTable(DeclarantDatabaseModel.TABLE_NAME);
                foreach (DataRow row in table.Rows) {
                    DeclarantDatabaseModel database = new DeclarantDatabaseModel(row);
                    addDatabase(database);
                }
            }
        }

        /// <summary>
        /// Поиск файлов БД в директории Декларант
        /// </summary>
        private void findDbInFolder()
        {
            int counter = 100;
            foreach (var filename in Directory.GetFiles(DeclarantFolder))
            {
                if(!filename.EndsWith(DB_NAME_END))
                {
                    continue;
                }
                DeclarantDatabaseModel database = new DeclarantDatabaseModel();
                database.Id = counter;
                database.Basepath = filename;
                database.Orgname = string.Format("Организация {0}", counter);

                addDatabase(database);
                counter++;
            }
        }

        /// <summary>
        /// Добавить БД в список
        /// </summary>
        /// <param name="database"></param>
        private void addDatabase(DeclarantDatabaseModel database)
        {
            if (!declarantDatabases.ContainsKey(database.Basepath))
            {
                declarantDatabases.Add(database.Basepath, database);
            }
        }

        public override void save()
        {}
    }

}
