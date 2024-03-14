//Задание 1
using System;

class Worker
{
    public string Name{get;set;}
    public string Surname{get;set;}
    public double Rate{get;set;}
    public int Days{get;set;}

    public Worker(string name,string surname,double rate,int days)
    {
        Name = name;
        Surname = surname;
        Rate = rate;
        Days = days;
    }

    public double GetSalary()
    {
        return Rate * Days;
    }
}

class Program
{
    static void Main()
    {
        Worker worker1 = new Worker("Владислав","Белкин",1250.0,20);
        Worker worker2 = new Worker("Александр","Шишкин",1520.5,25);

        Console.WriteLine($"Зарплата {worker1.Name} {worker1.Surname}: {worker1.GetSalary()} рублей");
        Console.WriteLine($"Зарплата {worker2.Name} {worker2.Surname}: {worker2.GetSalary()} рублей");
    }
}

//Задание 2
using System;

class Worker
{
    private string name;
    private string surname;
    private double rate;
    private int days;

    public Worker(string name, string surname, double rate, int days)
    {
        this.name = name;
        this.surname = surname;
        this.rate = rate;
        this.days = days;
    }

    public string GetName()
    {
        return name;
    }

    public string GetSurname()
    {
        return surname;
    }

    public double GetRate()
    {
        return rate;
    }

    public int GetDays()
    {
        return days;
    }

    public double GetSalary()
    {
        return rate * days;
    }
}

class Program
{
    static void Main()
    {
        Worker worker1 = new Worker("Владислав","Белкин",1250.0,20);
        Worker worker2 = new Worker("Александр","Шишкин",1520.5,25);

        Console.WriteLine($"Зарплата {worker1.GetName()} {worker1.GetSurname()}: {worker1.GetSalary()} рублей");
        Console.WriteLine($"Зарплата {worker2.GetName()} {worker2.GetSurname()}: {worker2.GetSalary()} рублей");
    }
}

//Задание 3
using System;

class Calculation
{
    private string calculationLine;

    public void SetCalculationLine(string line)
    {
        calculationLine = line;
    }

    public void SetLastSymbolCalculationLine(char symbol)
    {
        calculationLine += symbol;
    }

    public string GetCalculationLine()
    {
        return calculationLine;
    }

    public char GetLastSymbol()
    {
        if (!string.IsNullOrEmpty(calculationLine))
        {
            return calculationLine[calculationLine.Length - 1];
        }
        return '\0';
    }

    public void DeleteLastSymbol()
    {
        if (!string.IsNullOrEmpty(calculationLine))
        {
            calculationLine = calculationLine.Remove(calculationLine.Length - 1);
        }
    }
}

class Program
{
    static void Main()
    {
        Calculation calc = new Calculation();
        calc.SetCalculationLine("2 + 3 ");
        Console.WriteLine("Calculation Line: " + calc.GetCalculationLine());
        
        calc.SetLastSymbolCalculationLine('=');
        Console.WriteLine("Calculation Line after adding symbol: " + calc.GetCalculationLine());

        Console.WriteLine("Last Symbol: " + calc.GetLastSymbol());

        calc.DeleteLastSymbol();
        Console.WriteLine("Calculation Line after deleting last symbol: " + calc.GetCalculationLine());
    }
}