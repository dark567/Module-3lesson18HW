using ConsoleApp1.AbstactLayer;
using System;

namespace ConsoleApp1.ProductLayer
{
    public class ProductTwo: IAbstractProductFour, IAbstractProductTwo
    {
        /// <summary>
		/// Наименование.
		/// </summary>
		public string Name => "Two";

        /// <summary>
        /// Какие-либо действия, которые может выполнять продукт Two.
        /// </summary>
        /// <returns> Результаты работы. </returns>
        public string DoWorkFour()
        {
            return "Two выполнил свою работу.";
        }

        public string DoWorkTwo()
        {
            return "Two выполнил свою работу.";
        }

        /// <summary>
        /// Совместная работа различных продуктов.
        /// Продукты вполне могут между собой взаимодействовать.
        /// При этом фабрика будет гарантировать, что эти продукты будут совместимы,
        /// не смотря на то, что в объявлении указывается абстрактный продукт.
        /// </summary>
        /// <param name="productOne"> Первый продукт. </param>
        /// <returns> Результат взаимодействия первого и второго продукта. </returns>
        public string WorkWithProductOne(IAbstractProductOne productA)
        {
            return $"Two выполнил работу совместно с ({productA.Name})";
        }
    }
}
