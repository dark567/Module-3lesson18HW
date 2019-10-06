namespace ConsoleApp1.AbstactLayer
{
    public interface IAbstractProductOne
    {
        /// <summary>
		/// Наименование.
		/// </summary>
		string Name { get; }

        /// <summary>
        /// Работа, выполняемая первым продуктом.
        /// </summary>
        /// <returns> Результат работы. </returns>
        string DoWorkOne();
    }
}