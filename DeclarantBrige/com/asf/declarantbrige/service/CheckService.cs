using System;
using System.Collections.Generic;
using com.asf.declarantbrige.checker;
using com.asf.declarantbrige.model;

namespace com.asf.declarantbrige.service{

    /// <summary>
    /// Сервис проверки объектов
    /// </summary>
    class CheckService : AbstractService
    {
        /// <summary>
        /// Обработчики проверки
        /// </summary>
        private Dictionary<Type, IModelChecker> checkers;

        /// <summary>
        /// Получить обработчик, для указанного типа
        /// </summary>
        /// <param name="modelType"></param>
        /// <returns></returns>
        public IModelChecker getChecker(Type modelType)
        {
            if (checkers.ContainsKey(modelType))
            {
                return checkers[modelType];
            }
            return null;
        }

        private CheckService()
        {
            checkers = new Dictionary<Type, IModelChecker>();
            checkers.Add(typeof(DecHeader), new DeclarationChecker());
        }

        /// <summary>
        /// Проверить декларацию
        /// </summary>
        /// <param name="decHeader"></param>
        public void checkDeclaration(DecHeader decHeader)
        {
            ((DeclarationChecker)getChecker(decHeader.GetType())).checkModel(decHeader);
            addLogLine("Проверка декларации завершена...");
        }
    }
}
