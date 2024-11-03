using System.Security.Cryptography;
using System.Xml.Linq;

namespace Worker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Device[] devices = new Device[]
            {
                new Kettle("Электрочайник", "Мощный электрочайник с функцией быстрого закипания."),
                new Microwave("Микроволновка", "Микроволновая печь для быстрого приготовления"),
                new Car("BMW X5", "Комфортный автомобиль на механике."),
                new Steamship("Параход", "Большой пароход для туристических плаваний")
            };
            foreach (Device device in devices)
            {
                device.Show();
                device.Desc();
                device.Sound();
                Console.WriteLine();
            }
        }
        abstract class Device
        {
            public string Name { get; set; }
            public string Description { get; set; }
            public Device(string name, string description)
            {
                this.Name = name;
                this.Description = description;
            }
            public abstract void Sound(); 
            public virtual void Show() 
            {
                Console.WriteLine($"Устройство: {Name}");
            }
            public virtual void Desc() 
            {
                Console.WriteLine($"Описание: {Description}");
            }
        }
        class Kettle : Device
        {
            public Kettle(string name, string description) : base(name, description) { }

            public override void Sound()
            {
                Console.WriteLine("Звук: Чайник свистит");
            }
        }
        class Microwave : Device
        {
            public Microwave(string name, string description) : base(name, description) { }

            public override void Sound()
            {
                Console.WriteLine("Звук: Микроволновка щелкнула");
            }
        }
        class Car : Device
        {
            public Car(string name, string description) : base(name, description) { }

            public override void Sound()
            {
                Console.WriteLine("Звук: Мотор ревет");
            }
        }
        class Steamship : Device
        {
            public Steamship(string name, string description) : base(name, description) { }

            public override void Sound()
            {
                Console.WriteLine("Звук: Параход мощно гудит");
            }
        }
    }
}
