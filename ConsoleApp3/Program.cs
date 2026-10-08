using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    abstract class Employee
    {
        private double baseSalary;

        public double GetSalary()
        {
            return baseSalary;
        }

        public void SetSalary(double salary)
        {
            baseSalary = salary;
        }

        public abstract double CalculateBonus();
    }

    class Manager : Employee
    {
        public override double CalculateBonus()
        {
            return GetSalary() * 0.20;
        }
    }

    class Intern : Employee
    {
        public override double CalculateBonus()
        {
            return 100;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();

            Manager manager1 = new Manager();
            manager1.SetSalary(2000);

            Manager manager2 = new Manager();
            manager2.SetSalary(3000);

            Intern intern1 = new Intern();
            intern1.SetSalary(800);

            Intern intern2 = new Intern();
            intern2.SetSalary(1000);

            employees.Add(manager1);
            employees.Add(manager2);
            employees.Add(intern1);
            employees.Add(intern2);

            foreach (Employee employee in employees)
            {
                double salary = employee.GetSalary();
                double bonus = employee.CalculateBonus();
                double totalSalary = salary + bonus;

                Console.WriteLine("Əsas maaş: " + salary + " AZN");
                Console.WriteLine("Bonus: " + bonus + " AZN");
                Console.WriteLine("Ümumi maaş: " + totalSalary + " AZN");
                Console.WriteLine();
            }
        }
    }

    //1
    //class Vehicle
    //{
    //    public string Brand;
    //    public int Speed;

    //    public virtual void MakeSound()
    //    {
    //        Console.WriteLine("Nəqliyyat vasitəsi səs çıxarır.");
    //    }
    //}

    //class Car : Vehicle
    //{
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine(Brand + ": Maşın siqnal verir");
    //    }
    //}

    //class Motorcycle : Vehicle
    //{
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine(Brand + ": Motosiklet səsi");
    //    }
    //}

    //class Bicycle : Vehicle
    //{
    //    public override void MakeSound()
    //    {
    //        Console.WriteLine(Brand + ": Velosiped zəngi");
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<Vehicle> vehicles = new List<Vehicle>();

    //        vehicles.Add(new Car
    //        {
    //            Brand = "BMW",
    //            Speed = 200
    //        });

    //        vehicles.Add(new Motorcycle
    //        {
    //            Brand = "Honda",
    //            Speed = 150
    //        });

    //        vehicles.Add(new Bicycle
    //        {
    //            Brand = "Giant",
    //            Speed = 30
    //        });

    //        foreach (Vehicle vehicle in vehicles)
    //        {
    //            vehicle.MakeSound();
    //        }
    //    }
    //}

    //2
    //interface IShape
    //{
    //    double CalculateArea();
    //    double CalculatePerimeter();
    //}

    //class Circle : IShape
    //{
    //    public double Radius;

    //    public Circle(double radius)
    //    {
    //        Radius = radius;
    //    }

    //    public double CalculateArea()
    //    {
    //        return Math.PI * Radius * Radius;
    //    }

    //    public double CalculatePerimeter()
    //    {
    //        return 2 * Math.PI * Radius;
    //    }
    //}

    //class Rectangle : IShape
    //{
    //    public double Width;
    //    public double Height;

    //    public Rectangle(double width, double height)
    //    {
    //        Width = width;
    //        Height = height;
    //    }

    //    public double CalculateArea()
    //    {
    //        return Width * Height;
    //    }

    //    public double CalculatePerimeter()
    //    {
    //        return 2 * (Width + Height);
    //    }
    //}

    //class Triangle : IShape
    //{
    //    public double A;
    //    public double B;
    //    public double C;

    //    public Triangle(double a, double b, double c)
    //    {
    //        A = a;
    //        B = b;
    //        C = c;
    //    }

    //    public double CalculateArea()
    //    {
    //        double s = (A + B + C) / 2;
    //        return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
    //    }

    //    public double CalculatePerimeter()
    //    {
    //        return A + B + C;
    //    }
    //}

    //class ShapeHelper
    //{
    //    public double CalculateArea(double radius)
    //    {
    //        return Math.PI * radius * radius;
    //    }

    //    public double CalculateArea(double width, double height)
    //    {
    //        return width * height;
    //    }
    //}

    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<IShape> shapes = new List<IShape>();

    //        shapes.Add(new Circle(5));
    //        shapes.Add(new Rectangle(4, 6));
    //        shapes.Add(new Triangle(3, 4, 5));

    //        foreach (IShape shape in shapes)
    //        {
    //            Console.WriteLine("Sahə: " + shape.CalculateArea());
    //            Console.WriteLine("Perimetr: " + shape.CalculatePerimeter());
    //            Console.WriteLine();
    //        }

    //        ShapeHelper helper = new ShapeHelper();

    //        Console.WriteLine("Circle sahəsi: " + helper.CalculateArea(5));
    //        Console.WriteLine("Rectangle sahəsi: " + helper.CalculateArea(4, 6));
    //    }
    //}

    //1 
    //class Book
    //{
    //    public string Title;
    //    public string Author;
    //    public string ISBN;
    //    private bool isAvailable = true;

    //    public void BorrowBook()
    //    {
    //        if (isAvailable)
    //        {
    //            isAvailable = false;
    //            Console.WriteLine(Title + " kitabı götürüldü.");
    //        }
    //        else
    //        {
    //            Console.WriteLine(Title + " kitabı artıq götürülüb.");
    //        }
    //    }
    //    public void ReturnBook()
    //    {
    //        isAvailable = true;
    //        Console.WriteLine(Title + " kitabı qaytarıldı.");
    //    }
    //    public void ShowInfo()
    //    {
    //        Console.WriteLine("Kitab: " + Title);
    //        Console.WriteLine("Müəllif: " + Author);
    //        Console.WriteLine("ISBN: " + ISBN);
    //        Console.WriteLine("Mövcuddur: " + isAvailable);
    //        Console.WriteLine();
    //    }
    //}
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        List<Book> kitabxana = new List<Book>();

    //        kitabxana.Add(new Book
    //        {
    //            Title = "1984",
    //            Author = "George Orwell",
    //            ISBN = "111"
    //        });

    //        kitabxana.Add(new Book
    //        {
    //            Title = "Cinayət və Cəza",
    //            Author = "Fyodor Dostoyevski",
    //            ISBN = "222"
    //        });

    //        kitabxana.Add(new Book
    //        {
    //            Title = "Səfillər",
    //            Author = "Victor Hugo",
    //            ISBN = "333"
    //        });

    //        kitabxana.Add(new Book
    //        {
    //            Title = "Anna Karenina",
    //            Author = "Lev Tolstoy",
    //            ISBN = "444"
    //        });

    //        kitabxana.Add(new Book
    //        {
    //            Title = "Şerlok Holms",
    //            Author = "Arthur Conan Doyle",
    //            ISBN = "555"
    //        });
    //        kitabxana[0].BorrowBook();
    //        kitabxana[1].BorrowBook();

    //        Console.WriteLine("\nKitabxananın vəziyyəti:");

    //        foreach (Book kitab in kitabxana)
    //        {
    //            kitab.ShowInfo();
    //        }
    //    }
    //}
}