using System;
using System.Collections.Generic;

namespace WhatToWatchNext
{
    // ---------- Task 2: Constants ----------
    class Circle
    {
        public const double PI = 3.14;

        public static double CalculateArea(double radius)
        {
            return PI * radius * radius;
        }

        public static double CalculatePerimeter(double radius)
        {
            return 2 * PI * radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ---------- Task 1: Variables and String Interpolation ----------
            string userName = "Sankalpa Singh Chauhan";
            int luckyNumber = 10;
            Console.WriteLine($"Hello, {userName}! Your lucky number is {luckyNumber}.");
            Console.WriteLine();

            // ---------- Task 2: Constants ----------
            // Circle.PI = 3.14159; // ❌ This line would cause a compilation error.
            // ERROR: The left-hand side of an assignment must be a variable, property, or indexer.
            // Explanation: Constants are fixed at compile time and cannot be modified.

            double radius = 5.0;
            Console.WriteLine($"Area of Circle: {Circle.CalculateArea(radius)}");
            Console.WriteLine($"Perimeter of Circle: {Circle.CalculatePerimeter(radius)}");
            Console.WriteLine();

            // ---------- Task 3: Data Types and Type Conversion ----------
            byte b = 10;
            short s = 200;
            int i = 1000;
            long l = 100000L;
            float f = 3.5f;
            double d = 9.99;
            decimal dec = 123.456m;
            char c = 'A';
            bool flag = true;

            string intToString = i.ToString();
            double stringToDouble = Convert.ToDouble("3.14");

            Console.WriteLine("---- Data Types ----");
            Console.WriteLine($"byte: {b}");
            Console.WriteLine($"short: {s}");
            Console.WriteLine($"int: {i}");
            Console.WriteLine($"long: {l}");
            Console.WriteLine($"float: {f}");
            Console.WriteLine($"double: {d}");
            Console.WriteLine($"decimal: {dec}");
            Console.WriteLine($"char: {c}");
            Console.WriteLine($"bool: {flag}");
            Console.WriteLine($"Converted int to string: {intToString}");
            Console.WriteLine($"Converted string to double: {stringToDouble}");
            Console.WriteLine();

            // ---------- Task 4: Arrays ----------
            int[] favoriteNumbers = { 9, 3, 7, 1, 5 };
            Array.Sort(favoriteNumbers); // Ascending order
            Array.Reverse(favoriteNumbers); // Descending order

            Console.WriteLine("---- Favorite Numbers (Descending) ----");
            for (int index = 0; index < favoriteNumbers.Length; index++)
            {
                Console.WriteLine($"Index {index}: {favoriteNumbers[index]}");
            }

            int searchNumber = 7;
            int position = Array.IndexOf(favoriteNumbers, searchNumber);
            Console.WriteLine($"\nThe number {searchNumber} is at position: {position}");
            Console.WriteLine();

            // ---------- Task 5: DateTime and Age Calculation ----------
            DateTime birthDate = new DateTime(2003, 5, 15); // Example birthdate
            DateTime currentDate = DateTime.Now;
            TimeSpan ageSpan = currentDate - birthDate;
            int ageInYears = (int)(ageSpan.Days / 365.25);

            Console.WriteLine("---- DateTime Example ----");
            Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Current Date: {currentDate.ToShortDateString()}");
            Console.WriteLine($"Age: {ageInYears} years");

            DateTime newDate = birthDate.AddDays(10);
            Console.WriteLine($"Birthdate + 10 days: {newDate.ToShortDateString()}");
            Console.WriteLine();

            // ---------- Task 6: List and Dictionary ----------
            List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };
            fruits.Add("Orange");
            fruits.Remove("Apple");

            Console.WriteLine("---- Favorite Fruits ----");
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            Dictionary<int, string> fruitDict = new Dictionary<int, string>
            {
                { 1, "Mango" },
                { 2, "Banana" },
                { 3, "Orange" }
            };
            fruitDict.Add(4, "Grapes");

            Console.WriteLine("\n---- Fruit Dictionary ----");
            foreach (var kvp in fruitDict)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }
        }
    }
}
