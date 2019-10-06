namespace ConsoleApp1.AbstactLayer
{
    /// <summary>
    /// Абстрактная фабрика.
    /// Здесь мы просто объявляем фабричные методы для каждого из продуктов,
    /// не конкретизируя, какой именно это будет продукт. Только его интерфейс.
    /// </summary>
    interface IAbstractFactory
    {
        /// <summary>
		/// Фабричный метод для первого продукта.
		/// </summary>
		/// <returns> Первый продукт. </returns>
		IAbstractProductOne CreateProductOne();

        /// <summary>
        /// Фабричный метод для второго продукта.
        /// </summary>
        /// <returns> Второй продукт. </returns>
        IAbstractProductTwo CreateProductTwo();
        /// <summary>
        /// Фабричный метод для третьего продукта.
        /// </summary>
        /// <returns> Третий продукт. </returns>
        IAbstractProductThree CreateProductThree();
        /// <summary>
        /// Фабричный метод для четвертого продукта.
        /// </summary>
        /// <returns> Четвертый продукт. </returns>
        IAbstractProductFour CreateProductFour();
    }
}
