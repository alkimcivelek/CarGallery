using CarGallery.Business.Abstract;
using CarGallery.Business.CrossCuttingConcerns.DependencyResolvers.Ninject;
using System;

namespace CarGallery.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var carService = InstanceFactory.Get<ICarService>();
            var list = carService.GetAll();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
