using HandwritingAutofac.Fruits;
using MyAutofac;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandwritingAutofac
{
    class Program
    {
        static MyAutofac.IContainer _container;
        static void Main(string[] args)
        {
            ////4.注册MyAutofac
            IntilIOC();

            ////5.实例化
            FruitGetterController fruitGetterController= _container.Resolve<FruitGetterController>();
            var name = fruitGetterController.GetFruit();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(name);
            Console.Read();
        }

        static void IntilIOC()
        {
            ////1.创建factory
            var containerBuilder = new ContainerBuilder();

            ////2.注册类型
            containerBuilder.RegisterTyper<AppleFruitGetter>().AsImplementedInterfaces();
            containerBuilder.RegisterTyper<BananaFruitGetter>().AsImplementedInterfaces();
            containerBuilder.RegisterTyper<FruitGetterController>();

            ////3.创建Builder
            _container = containerBuilder.Builder();
        }
    }
}
