using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork_7_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Prison prison = new Prison();
            prison.Start();
        }
    }

    class Prison
    {
        private List<Prisoner> _prisoners;

        public Prison()
        {
            _prisoners = new List<Prisoner>()
            {
                new Prisoner("Alphonse Gabriel Capone",true,180,80,"italian"),
                new Prisoner("Charles Milles Manson", false, 175, 90, "american"),
                new Prisoner("John Herbert Dillinger",true, 190,85,"american"),
                new Prisoner("Andrey Romanovich Chikatilo",false,170,70,"russian"),
                new Prisoner("Ricardo Munoz Ramirez",true,192,85,"american"),
                new Prisoner("Theodore Robert «Ted» Bundy",false,170,60,"american")
            };
        }

        public void Start()
        {
            Console.WriteLine("База данных преступников");
            Console.WriteLine("Введите данный для поиска по базе:");
            Console.Write("Введите рост: ");
            int height = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите вес: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите национальность: ");
            string nationality = Console.ReadLine();

            var prisoners = _prisoners.Where(prisoner => prisoner.Height == height && prisoner.Weight == weight && prisoner.Nationality == nationality && prisoner.IsArrest == false);

            if (prisoners.Count() == 0)
            {
                Console.WriteLine("Преступники по таким пораметрам не найдены!");
            }
            else
            {

                foreach (var prisoner in prisoners)
                {
                    Console.WriteLine("Преступники:");
                    Console.WriteLine(prisoner.FullName);
                }
                Console.ReadKey();
            }
        }
    }

    class Prisoner
    {
        public string FullName { get; private set; }
        public bool IsArrest { get; private set; }
        public int Height { get; private set; }
        public int Weight { get; private set; }
        public string Nationality { get; private set; }

        public Prisoner(string fio, bool isArrest, int height, int weight, string nationality)
        {
            FullName = fio;
            IsArrest = isArrest;
            Height = height;
            Weight = weight;
            Nationality = nationality;
        }
    }
}
