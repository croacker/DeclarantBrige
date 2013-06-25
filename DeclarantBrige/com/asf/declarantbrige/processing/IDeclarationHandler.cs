using com.asf.declarantbrige.model;

namespace com.asf.declarantbrige.processing {

    /// <summary>
    /// Интерфейс обработчика декларации
    /// </summary>
    interface IDeclarationHandler :IProcessingHandler{
        DecHeader DeclarationHeader { get; set; }

        WrkOrg Organization { get; set; }

        bool DeletePrevious { get; set; }
    }
}
