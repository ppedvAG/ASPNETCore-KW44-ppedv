using System;

namespace DependencyInversionSample
{
    class Program
    {
        static void Main(string[] args)
        {
            ICarSevice carService = new CarService();

            ICar myCar = new MockCar();
            ICar releasedCar = new Car();
            carService.RepairCar(myCar);
        }
    }

    #region BadCode - Dauert 7-8 Tage + unflexibel
    public class BadCar //Programmierer A: 5 Tage
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ConstructionYear { get; set; }
    }

    public class BadCarService //Programmierer B: 3 Tage
    {
        public void RepairCar(BadCar car)
        {
            // Repariere Auto
        }
    }
    #endregion

    #region Dependency Inversion

    //Interface Definition 1 Tag
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


    // 3 Tage
    public class CarService : ICarSevice
    {
        public void RepairCar(ICar car)
        {
            //Repariere Auto
        }
    }

    public class MockCar : ICar
    {
        public int Id { get; set; } = 1;
        public string Brand { get; set; } = "VW";
        public string Model { get; set; } = "Polo";
        public DateTime ConstructionYear { get; set; } = new DateTime(2012, 12, 12);
    }

    #endregion
}
