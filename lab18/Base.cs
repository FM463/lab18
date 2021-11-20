/*2.Напишите главную программу, создающую и обрабатывающую объект этого класса,  
 * используя различные варианты подключения пространства имен.
 *3.Создайте многомодульный проект с двумя узлами : главный модуль и модуль класса.
 *4.Создайте проект для создания библиотеки классов из модуля класса.
 *5.Создайте многомодульный проект с двумя узлами : главный модуль и библиотека класса.
 *3-5 лабораторных не сделано так как модулей на C# нет, а сборка - это не модуль.*/


using Base; // подключение пространства имен Base
/*- пространства имен на C# не подключаются*/

global using Base;

/*1 Заменить на алиас*/
using Person = Base.Person;

Person tom = new("Tom");
tom.Print();

namespace Base
{
    class Person
    {
        string name;
        public Person(string name) => this.name = name;
        public void Print() => Console.WriteLine($"Имя: {name}");
    }
}
/*2 Не использовать using*/
Base.Person tom = new("Tom");
tom.Print();

namespace Base
{
    class Person
    {
        string name;
        public Person(string name) => this.name = name;
        public void Print() => Console.WriteLine($"Имя: {name}");
    }
}
/*3 Еще вот так можно*/
using global::Base;
 
Person tom = new("Tom");
tom.Print();

namespace Base
{
    class Person
    {
        string name;
        public Person(string name) => this.name = name;
        public void Print() => Console.WriteLine($"Имя: {name}");
    }
}
/*4 Еще в csproj можно глобальный using добавить или алиас в csproj.
 * алиас - это синоним пространству имен + сущности:
 * using Person = Base.Person;
 * Например можно Person назвать слева как Person, но нам ничего не мешает назвать его как угодно 
 * или объявить алиас, но использовать Base.Person вместо него.
 * Можно еще открывать все публичные статические методы класса:
 * using static Base.Person;*/