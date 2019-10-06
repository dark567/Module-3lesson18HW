using ConsoleApp1.AbstactLayer;

namespace ConsoleApp1.ProductLayer
{
    public class ProductOne: IAbstractProductOne, IAbstractProductThree
    {
        /// <summary>
		/// Наименование.
		/// </summary>
		public string Name => "One";

        /// <summary>
        /// Какие-либо действия, которые может выполнять продукт One.
        /// </summary>
        /// <returns> Результаты работы. </returns>
         public string DoWorkOne()
        {
            return "One выполнил свою работу.";
        }

        public string DoWorkThree()
        {
            return "One выполнил свою работу.";
        }
    }
}
