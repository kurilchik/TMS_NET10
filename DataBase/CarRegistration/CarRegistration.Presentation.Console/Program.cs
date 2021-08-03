using CarRegistration.BusinessLogicLayer.Services;
using CarRegistration.BusinessLogicLayer.Services.Interfaces;
using System;

namespace CarRegistration.Presentation.Console
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeveloperService developerService = new DeveloperService();
            var name = System.Console.ReadLine();
            var age = int.Parse(System.Console.ReadLine());
            developerService.Add(name, age);
        }
    }
}
