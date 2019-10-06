using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AbstactLayer
{
    /// <summary>
	/// Класс, который эмулирует работу клиентского кода с абстрактной фабрикой.
	/// </summary>
    public class Customer
    {
        /// <summary>
        /// Создать продукты двух видов.
        /// </summary>
        public void DoWork()
        {
            CreateProducts(new FactoryTwo());
            CreateProducts(new FactoryTwo());
        }

        /// <summary>
        /// Метод выполняет производство различных продуктов в зависимости от используемой фабрики.
        /// </summary>
        /// <param name="factory"> Фабрика. </param>
        private void CreateProducts(IAbstractFactory factory)
        {
            var productOne = factory.CreateProductOne();
            var productTwo = factory.CreateProductFour();

             Console.WriteLine(productOne.DoWorkOne());
             Console.WriteLine(productTwo.WorkWithProductOne(productOne));
        }

    }
}
