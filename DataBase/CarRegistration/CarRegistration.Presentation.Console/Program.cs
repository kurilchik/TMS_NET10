using CarRegistration.BusinessLogicLayer.Services;
using CarRegistration.BusinessLogicLayer.Services.Interfaces;
using CarRegistration.DataAccessLayer.DataModels;
using System.Collections.Generic;

namespace CarRegistration.Presentation.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeveloperService developerService = new DeveloperService();

            System.Console.WriteLine("Enter name:");
            var name = System.Console.ReadLine();
            System.Console.WriteLine("Enter age:");
            var age = int.Parse(System.Console.ReadLine());
            developerService.Add(name, age);
            System.Console.WriteLine("New developer added!");

            System.Console.WriteLine("Enter Id:");
            var id = int.Parse(System.Console.ReadLine());
            Develorer develorer = developerService.GetByID(id);
            System.Console.WriteLine($"Developer with ID {develorer.Id} found! Name: {develorer.Name} Age: {develorer.Age}");

            List<Develorer> develorers = developerService.GetList();
            System.Console.WriteLine("List of all developers:");
            foreach (var item in develorers)
            {
                System.Console.WriteLine($"ID: {item.Id} Name: {item.Name} Age: {item.Age}");
            }

            System.Console.WriteLine("Enter Id(Update):");
            var idUpdate = int.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter new name:");
            var nameUpdate = System.Console.ReadLine();
            System.Console.WriteLine("Enter new age:");
            var ageUpdate = int.Parse(System.Console.ReadLine());
            developerService.Update(idUpdate, nameUpdate, ageUpdate);
            System.Console.WriteLine("Developer updated!");

            System.Console.WriteLine("Enter Id(Delete):");
            var idDelete = int.Parse(System.Console.ReadLine());
            developerService.Delete(idDelete);
            System.Console.WriteLine("Developer deleted!");
        }
    }
}
