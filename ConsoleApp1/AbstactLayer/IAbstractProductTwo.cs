namespace ConsoleApp1.AbstactLayer
{
    public interface IAbstractProductTwo
    {
        /// <summary>
		/// Наименование.
		/// </summary>
		string Name { get; }

        /// <summary>
        /// Работа, выполняемая первым продуктом.
        /// </summary>
        /// <returns> Результат работы. </returns>
        string DoWorkTwo();

        /// <summary>
        /// Взаимодействие продуктов.
        /// (если оно нужно)
        /// </summary>
        /// <param name="product"> продукт. </param>
        /// <returns> Результат взаимодействия. </returns>
        string WorkWithProductOne(IAbstractProductOne product);
    }
}