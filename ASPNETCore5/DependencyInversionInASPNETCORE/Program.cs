using Microsoft.Extensions.DependencyInjection;
using System;

namespace DependencyInversionInASPNETCORE
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        IServiceCollection serviceCollection = new ServiceCollection();

    //        serviceCollection.AddSingleton<ICar, MockCar>();
    //        ServiceProvider provider = serviceCollection.BuildServiceProvider();

    //        //Ich brauche jetzt eine Instanz meiner von Car 

    //        ICar car = provider.GetRequiredService<ICar>();

    //        Console.WriteLine(car.Id);
    //        Console.WriteLine(car.Brand);
    //        Console.WriteLine(car.Model);
    //        Console.WriteLine(car.ConstructionYear.ToShortDateString());
    //    }
    //}



    public interface ICar
    {
        int Id { get; set; }
        string Brand { get; set; }
        string Model { get; set; }
        DateTime ConstructionYear { get; set; }
    }

    public interface ICarSevice
    {
        void RepairCar(ICar car);
    }

    //Programmerer A: 5 Tage
    public class Car : ICar
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ConstructionYear { get; set; }
    }

    public class MockCar : ICar
    {
        public int Id { get; set; } = 1;
        public string Brand { get; set; } = "BMW";
        public string Model { get; set; } = "Z8";
        public DateTime ConstructionYear { get; set; } = DateTime.Now;
    }

    public class MockCar2 : ICar
    {
        public int Id { get; set; } = 1;
        public string Brand { get; set; } = "VW";
        public string Model { get; set; } = "Polo";
        public DateTime ConstructionYear { get; set; } = DateTime.Now;
    }


    // 3 Tage
    public class CarService : ICarSevice
    {
        public void RepairCar(ICar car)
        {
            //Repariere Auto
        }
    }
}
