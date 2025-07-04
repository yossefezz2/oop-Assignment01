// See https://aka.ms/new-console-template for more information

namespace Demo;

using Shared;
using System;
using System.Drawing;

internal class Program
{
    private static void Main(string[] args)
    {
        #region task 1 

        //WeekDayClass weekDayClass = new WeekDayClass();
        //weekDayClass.GetWeeksDays();
        #endregion

        #region task 2
        //Person[] persons = new Person[4];
        //persons[0] = new Person("Youssef", 22);
        //persons[1] = new Person("Ahmed", 25);
        //persons[2] = new Person("Mazen", 21);
        //persons[3] = new Person("Mona", 24);

        //foreach (var person in persons)
        //{
        //    Console.WriteLine(person.GetPersonDate());
        //}
        #endregion

        #region task 3
        //string input = Console.ReadLine();

        //SeasOn SeasOn;


        //if (Enum.TryParse(input, true, out SeasOn))
        //{
        //    switch (SeasOn)
        //    {
        //        case SeasOn.Spring:
        //            Console.WriteLine("Spring: March to May");
        //            break;
        //        case SeasOn.Summer:
        //            Console.WriteLine("Summer: June to August");
        //            break;
        //        case SeasOn.Autumn:
        //            Console.WriteLine("Autumn: September to November");
        //            break;
        //        case SeasOn.Winter:
        //            Console.WriteLine("Winter: December to February");
        //            break;
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("Invalid season input.");
        //}


        #endregion

        #region task 4
        //string? input = Console.ReadLine();
        //if(Enum.IsDefined(typeof(PrimaryColor), input.ToUpper()))
        //{
        //    Console.WriteLine("input color is a primary color");
        //}else
        //{
        //    Console.WriteLine("input color is not a primary color");
        //}
        #endregion


        #region task 5

        //point p1, p2;

        //Console.Write("Enter X1: ");
        //p1.x = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Enter Y1: ");
        //p1.y = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Enter X2: ");
        //p2.x = Convert.ToDouble(Console.ReadLine());

        //Console.Write("Enter Y2: ");
        //p2.y = Convert.ToDouble(Console.ReadLine());

        //double distance = Math.Sqrt(Math.Pow(p2.x - p1.x, 2) + Math.Pow(p2.y - p1.y, 2));
        //Console.WriteLine($"Distance between points: {distance}");
        #endregion

        #region task 6

        Person[] persons = new Person[4];
        persons[0] = new Person("Youssef", 22);
        persons[1] = new Person("Ahmed", 25);
        persons[2] = new Person("Mazen", 21);
        persons[3] = new Person("Mona", 24);

        int maxAge = persons[0].age;
        string oldestPersonName = persons[0].name;

        foreach (var item in persons)
        {
            if (item.age > maxAge)
            {
                maxAge = item.age;
                oldestPersonName = item.name;
            }
        }
        Console.WriteLine($"The oldest person is: {oldestPersonName} with age {maxAge}");
        #endregion


    }
}
