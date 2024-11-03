using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Worker
{
    internal class Work
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[]
            {
                new President("Петр Петров", "Президент компании с видением будущего роста"),
                new Security("Иван Иванов", "Обеспечивает безопасность помещений компании."),
                new Manager("Александер Александров", "Управляет маркетинговой командой"),
                new Engineer("Василий Васильев", "Разрабатывает и поддерживает программные системы компании.")
            };

            foreach (Worker worker in workers)
            {
                worker.Print();
                Console.WriteLine();
            }
        }
        abstract class Worker
        {
            public string Name { get; set; }
            public string Description { get; set; }

            public Worker(string name, string description)
            {
                this.Name = name;
                this.Description = description;
            }
            public abstract void Print(); 
        }
        class President : Worker
        {
            public President(string name, string description) : base(name, description) { }
            public override void Print()
            {
                Console.WriteLine("Должность: Президент");
                Console.WriteLine($"Имя: {Name}");
                Console.WriteLine($"Описание: {Description}");
            }
        }
        class Security : Worker
        {
            public Security(string name, string description) : base(name, description) { }
            public override void Print()
            {
                Console.WriteLine("Должность: Охранник");
                Console.WriteLine($"Имя: {Name}");
                Console.WriteLine($"Описание: {Description}");
            }
        }
        class Manager : Worker
        {
            public Manager(string name, string description) : base(name, description) { }
            public override void Print()
            {
                Console.WriteLine("Должность: Менеджер");
                Console.WriteLine($"Имя: {Name}");
                Console.WriteLine($"Описание: {Description}");
            }
        }
        class Engineer : Worker
        {
            public Engineer(string name, string description) : base(name, description) { }
            public override void Print()
            {
                Console.WriteLine("Должность: Инженер");
                Console.WriteLine($"Имя: {Name}");
                Console.WriteLine($"Описание: {Description}");
            }
        }
    }
}
