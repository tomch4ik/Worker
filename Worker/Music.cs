using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workers
{
    internal class Music
    {
        static void Main(string[] args)
        {
            MusicalInstrument[] instruments = new MusicalInstrument[]
            {
                new Violin("Скрипка", "Струнный инструмент с высоким звуком."),
                new Trombone("Тромбон", "Духовой инструмент с характерным слайдом."),
                new Ukulele("Укулеле", "Маленький струнный инструмент с Гавайев."),
                new Cello("Виолончель", "Струнный инструмент с глубоким и насыщенным звучанием.")
            };

            foreach (MusicalInstrument instrument in instruments)
            {
                instrument.Show();
                instrument.Desc();
                instrument.Sound();
                instrument.History();
                Console.WriteLine();
            }
        }
        abstract class MusicalInstrument
        {
            public string Name { get; set; }
            public string Description { get; set; }

            public MusicalInstrument(string name, string description)
            {
                this.Name = name;
                this.Description = description;
            }
            public abstract void Sound(); 
            public virtual void Show() 
            {
                Console.WriteLine($"Инструмент: {Name}");
            }
            public virtual void Desc() 
            {
                Console.WriteLine($"Описание: {Description}");
            }
            public abstract void History(); 
        }
        class Violin : MusicalInstrument
        {
            public Violin(string name, string description) : base(name, description) { }

            public override void Sound()
            {
                Console.WriteLine("Звук: Скрипка издает мелодичный, высокий звук.");
            }

            public override void History()
            {
                Console.WriteLine("История: Скрипка возникла в Италии в начале 16 века.");
            }
        }
        class Trombone : MusicalInstrument
        {
            public Trombone(string name, string description) : base(name, description) { }

            public override void Sound()
            {
                Console.WriteLine("Звук: Тромбон издает резкий, медный звук.");
            }

            public override void History()
            {
                Console.WriteLine("История: Тромбон был разработан в 15 веке в Европе.");
            }
        }
        class Ukulele : MusicalInstrument
        {
            public Ukulele(string name, string description) : base(name, description) { }

            public override void Sound()
            {
                Console.WriteLine("Звук: Гавайская гитара издает веселый, мягкий звук.");
            }
            public override void History()
            {
                Console.WriteLine("История: Гавайская гитара возникла на Гавайях в 19 веке.");
            }
        }
        class Cello : MusicalInstrument
        {
            public Cello(string name, string description) : base(name, description) { }

            public override void Sound()
            {
                Console.WriteLine("Звук: Виолончель издает глубокий, резонансный звук.");
            }
            public override void History()
            {
                Console.WriteLine("История: Виолончель возникла в 16 веке, главным образом в Италии.");
            }
        }
    }
}
