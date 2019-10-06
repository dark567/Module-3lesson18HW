using ConsoleApp1.ProductLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AbstactLayer
{
    /// <summary>
	/// Первая конкретная фабрика.
	/// Определяет семейство продуктов.
	/// </summary>
    public class FactoryOne : IAbstractFactory
    {
        /// <summary>
		/// Создание первого конкретного продукта первого вида. 
		/// При этом возвращается первый абстрактный продукт,
		/// но конфигурация фабрики точно определяет, 
		/// какой именно это будет продукт (первый вид).
		/// По сути - это фабричный метод.
		/// </summary>
		/// <returns> Первый конкретный продукт первого вида. </returns>
        public IAbstractProductFour CreateProductFour()
        {
            // Здесь могут быть дополнительные действия.
            return new ProductTwo();
        }

        /// <summary>
		/// Создание первого конкретного продукта первого вида. 
		/// При этом возвращается первый абстрактный продукт,
		/// но конфигурация фабрики точно определяет, 
		/// какой именно это будет продукт (первый вид).
		/// По сути - это фабричный метод.
		/// </summary>
		/// <returns> Первый конкретный продукт первого вида. </returns>
        public IAbstractProductOne CreateProductOne()
        {
            return new ProductOne();
        }

        /// <summary>
		/// Создание первого конкретного продукта первого вида. 
		/// При этом возвращается первый абстрактный продукт,
		/// но конфигурация фабрики точно определяет, 
		/// какой именно это будет продукт (первый вид).
		/// По сути - это фабричный метод.
		/// </summary>
		/// <returns> Первый конкретный продукт первого вида. </returns>
        public IAbstractProductThree CreateProductThree()
        {
            return new ProductOne();
        }

        /// <summary>
		/// Создание первого конкретного продукта первого вида. 
		/// При этом возвращается первый абстрактный продукт,
		/// но конфигурация фабрики точно определяет, 
		/// какой именно это будет продукт (первый вид).
		/// По сути - это фабричный метод.
		/// </summary>
		/// <returns> Первый конкретный продукт первого вида. </returns>
        public IAbstractProductTwo CreateProductTwo()
        {
            return new ProductTwo();
        }
    }
}
