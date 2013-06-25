using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Ionic.Zip;
using com.asf.declarantbrige.model.database;
using com.asf.declarantbrige.service;
using com.asf.util;

namespace com.asf.declarantbrige.service {

    /// <summary>
    /// Сервис резервного копирования
    /// </summary>
    class BackUpService:AbstractService
    {
        private const string BACKUP_FOLDER = "backupDb";

        private FileInfo getDatabaseFileInfo(DeclarantDatabaseModel declarantDatabase)
        {
            return new FileInfo(declarantDatabase.Basepath);
        }

        /// <summary>
        /// Получить путь к каталогу резервных копий
        /// </summary>
        /// <param name="databaseFileInfo"></param>
        /// <returns></returns>
        private string getBackUpPath(FileInfo databaseFileInfo)
        {
            string folderName = FsUtil.includeTrailingBackslash(databaseFileInfo.DirectoryName) + BACKUP_FOLDER;
            if(!Directory.Exists(folderName))
            {
                Directory.CreateDirectory(folderName);
            }
            return FsUtil.includeTrailingBackslash(folderName) + databaseFileInfo.Name;
        }

        /// <summary>
        /// Скопировать файл БД в каталог для резервных копий
        /// </summary>
        /// <param name="declarantDatabase"></param>
        /// <returns></returns>
        private FileInfo copyFile(DeclarantDatabaseModel declarantDatabase)
        {
            FileInfo databaseFileInfo = getDatabaseFileInfo(declarantDatabase);
            FileInfo backDatabaseFileInfo = new FileInfo(getBackUpPath(databaseFileInfo));
            File.Copy(databaseFileInfo.FullName, backDatabaseFileInfo.FullName, true);
            return backDatabaseFileInfo;
        }

        /// <summary>
        /// Заархивировать файл
        /// </summary>
        /// <param name="backDatabaseFileInfo"></param>
        private void archiveFile(FileInfo backDatabaseFileInfo)
        {
            string zipFileName = FsUtil.includeTrailingBackslash(backDatabaseFileInfo.DirectoryName) 
                //+ backDatabaseFileInfo.Name 
                //+ "_"
                + string.Format("{0:yyyyMMddHHmmss}", DateTime.Now) + ".zip";
            using (ZipFile zipFile = new ZipFile(zipFileName, Encoding.GetEncoding("cp866")))
            {
                zipFile.AddFile(backDatabaseFileInfo.FullName, string.Empty);
                zipFile.Save(zipFileName);
            }
            File.Delete(backDatabaseFileInfo.FullName);
        }
        
        /// <summary>
        /// Создать резервную копию базы
        /// </summary>
        /// <param name="declarantDatabase"></param>
        public void createBackUp(DeclarantDatabaseModel declarantDatabase)
        {
            FileInfo backDatabaseFileInfo = copyFile(declarantDatabase);
            archiveFile(backDatabaseFileInfo);
        }

    }
}
