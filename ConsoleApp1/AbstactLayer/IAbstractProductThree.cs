namespace ConsoleApp1.AbstactLayer
{
    public interface IAbstractProductThree
    {
        /// <summary>
		/// Наименование.
		/// </summary>
		string Name { get; }

        /// <summary>
        /// Работа, выполняемая первым и третьим продуктом.
        /// </summary>
        /// <returns> Результат работы. </returns>
        string DoWorkThree();
    }
}