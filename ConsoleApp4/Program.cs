//Задание 1 
using System;
using System.IO;
using System.Reflection;

namespace PhoneApp
{
    class Phone
    {
        public string Model { get; set; }
        public string Number { get; set; }

        public Phone(string model, string number)
        {
            Model = model;
            Number = number;
        }

        public void Call(string number)
        {
            Console.WriteLine($"{Model} is calling {number}");
            WriteToLog($"{Model} called {number}");
        }

        protected void WriteToLog(string text)
        {
            string path = @"..\..\log.txt";

            File.AppendAllText(path, $"{Model},{DateTime.Now}:{text}{Environment.NewLine}");
        }
    }

    class Smartphone : Phone
    {
        private double _cameraResolution;

        public double CameraResolution
        {
            get { return _cameraResolution; }
            set { _cameraResolution = value; }
        }
        
    public Smartphone(string model, string number, double cameraResolution) : base(model, number)
        {
            CameraResolution = cameraResolution;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone iphone = new Smartphone("Iphone", "123 - 45 - 67", 8.0);
            iphone.Call("911");
        }
    }
}

//Задание 2 
//using System;


namespace TransportVehicleExample
{
    public class TransportVehicle
    {
        public TransportVehicle(string name, int maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }

        public string Name { get; set; }
        public int MaxSpeed { get; set; }
    }

    public class PolitechCar : TransportVehicle
    {
        public PolitechCar(string name, int maxSpeed)
        {
            Name = name;
            MaxSpeed = maxSpeed;
        }

        public void PlayBadMusicLoudly()
        {
            Console.WriteLine($"Playing bad music loudly in {Name}");
        }
    }

    public class Airplane : TransportVehicle
    {
        public Airplane(string name, int maxSpeed) : base(name, maxSpeed)
        {
      
        }

        public void DustField()
        {
            Console.WriteLine($"Spraying field in {Name}");
        }
    }

    public class ConcreteMixer : TransportVehicle
    {
        public ConcreteMixer(string name, int maxSpeed) : base(name, maxSpeed)
        {
        }
        
    public void MixConcrete()
        {
            Console.WriteLine($" Mixing concrete in { Name}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            PolitechCar politechCar = new PolitechCar("Politech-car", 200);
            politechCar.PlayBadMusicLoudly();

            Airplane airplane = new Airplane("Airplane", 600);
            airplane.DustField();

            ConcreteMixer concreteMixer = new ConcreteMixer("Concrete mixer", 100);
            concreteMixer.MixConcrete();
        }
    }
}
//Задание 3 
//using System;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Gender { get; set; }

    public Person(string name, int age, string gender)
    {
        Name = name;
        Age = age;
        Gender = gender;
    }
}

public class Employee : Person
{
    public string Position { get; set; }

    public Employee(string name, int age, string gender, string position)
        : base(name, age, gender)
    {
        Position = position;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person("Ivan", 30, "Muzhskoy");
        Console.WriteLine($"Человек: { person.Name}, { person.Age}, { person.Gender}");

        Employee employee = new Employee("Иван", 30, "Мужской", "Менеджер");
        Console.WriteLine($"Сотрудник: {employee.Name}, {employee.Age}, {employee.Gender}, {employee.Position}");
    }
}