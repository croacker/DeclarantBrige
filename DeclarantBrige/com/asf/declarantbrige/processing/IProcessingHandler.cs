namespace com.asf.declarantbrige.processing {

    /// <summary>
    /// Интерфейс обработчика
    /// </summary>
    interface IProcessingHandler
    {
        AbstractContext context { get; set; }

        void handle();
    }
}
