﻿/*1.Измените ранее разработанный класс на класс внутри пространства имен.*/

using Base; // подключение пространства имен Base
 
Person tom = new("Tom");
tom.Print();     // Имя: Tom

namespace Base
{
    class Person
    {
        string name;
        public Person(string name) => this.name = name;
        public void Print() => Console.WriteLine($"Имя: {name}");
    }
}