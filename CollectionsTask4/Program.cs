using System;
using System.Collections.Generic;

namespace CollectionsTask4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary <string, string> dossier = CreateDossier();
            string userInput = "";
            bool isRun = true;

            Console.WriteLine("Команды:\n1 - Добавить досье\n2 - Вывести все досье\n3 - Удалить досье\n4 - Выход");

            while (isRun)
            {
                Console.Write("Введите команду: ");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        AddDossier(dossier);
                        break;
                    case "2":
                        ShowDossier(dossier);
                        break;
                    case "3":
                        DeleteDossier(dossier);
                        break;
                    case "4":
                        isRun = false;
                        break;
                    default:
                        Console.WriteLine("Неизвестная команда");
                        break;
                }
            }
        }

        static Dictionary<string, string> CreateDossier()
        {
            Dictionary<string, string> dossier = new Dictionary<string, string>()
            {
                { "Иванов Иван Иванович", "Директор" },
                { "Петров Петр Петрович", "Программист" },
                { "Смирнова Вера Сергеевна", "Бухгалтер" },
            };
            
            return dossier;
        }

        static void AddDossier(Dictionary<string, string> dossier) 
        {
            Console.Write("Введите ФИО:");
            string fio = Console.ReadLine();

            Console.Write("Введите должность:");
            string post = Console.ReadLine();

            if (dossier.ContainsKey(fio) == false)
            {
                dossier.Add(fio, post);
            }
            else
            {
                Console.WriteLine("Сотрудник с таким ФИО существует");
            }
        }    

        static void ShowDossier(Dictionary<string, string> dossier)
        {
            Console.WriteLine("Список сотрудников");

            foreach (var worker in dossier)
            {
                Console.WriteLine($"{worker.Key} - {worker.Value}");
            }
        }

        static void DeleteDossier(Dictionary<string, string> dossier)
        {
            Console.WriteLine("Введите ФИО сотрудника чьё досье нужно удалить");
            string fio = Console.ReadLine();

            if (dossier.ContainsKey(fio))
            {
                dossier.Remove(fio);
                Console.WriteLine("Сотрудник удален");
            }
            else
            {
                Console.WriteLine("Сотрудника с таким ФИО не существует");
            }
        }
    }
}
