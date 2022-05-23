using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //            Person classı olsun
            //Name, Surname, Age, İsAdult propertyləri olsun.
            //                Və name, surname, age parametrlərini qəbul edən Constructoru olsun
            //                .Obyekt yarananda əgər yaşı 18dən böyükdürsə İsAdult - ı true əks halda false olsun

            Person prsn = new Person("Tural","Ismayilov",20);
            Console.WriteLine($"{prsn.Name} {prsn.Surname} {prsn.Age} {prsn.IsAdult}");
        }
    }
}
