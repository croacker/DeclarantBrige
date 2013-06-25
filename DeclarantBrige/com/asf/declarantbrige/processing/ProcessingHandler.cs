namespace com.asf.declarantbrige.processing {

    /// <summary>
    /// Объект обработки
    /// </summary>
    abstract class ProcessingHandler : IProcessingHandler
    {
        public AbstractContext context { get; set; }

        public abstract void handle();
    }
}
