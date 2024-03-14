//Задание 1
using System;

class Student
{
    public string LastName{get;set;}
    public DateTime DateOfBirth{get;set;}
    public string GroupNumber{get;set;}
    public int[] Grades{get;set;}

    public void UpdateInfo(string lastName, DateTime dateOfBirth, string groupNumber)
    {
        LastName = lastName;
        DateOfBirth = dateOfBirth;
        GroupNumber = groupNumber;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Фамилия: {LastName}");
        Console.WriteLine("Дата рождения: " + DateOfBirth.ToString("dd.MM.yyyy"));
        Console.WriteLine($"Номер группы: {GroupNumber}");
    }

    public void GenerateRandomGrades(int numberOfGrades)
    {
        Random random = new Random();
        Grades = new int[numberOfGrades];
        for (int i = 0; i < numberOfGrades; i++)
        {
            Grades[i] = random.Next(2,5); 
        }
    }

    public void ChangeInfo(string newLastName, DateTime newDateOfBirth, string newGroupNumber)
    {
        LastName = newLastName;
        DateOfBirth = newDateOfBirth;
        GroupNumber = newGroupNumber;
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        
        Console.Write("Введите фамилию студента: ");
        string lastName = Console.ReadLine();
        
        Console.Write("Введите дату рождения студента (дд.мм.гггг): ");
        DateTime dateOfBirth = DateTime.ParseExact(Console.ReadLine(),"dd.MM.yyyy",null);
        
        Console.Write("Введите номер группы студента: ");
        string groupNumber = Console.ReadLine();

        student.UpdateInfo(lastName, dateOfBirth, groupNumber);

        Console.WriteLine("\nИнформация о студенте:");
        student.DisplayInfo();

        student.GenerateRandomGrades(5);

        Console.WriteLine("\nУспеваемость студента:");
        foreach (int grade in student.Grades)
        {
            Console.WriteLine($"Оценка: {grade}");
        }

        Console.WriteLine("\nИзменение информации о студенте:");
        Console.Write("Введите новую фамилию студента: ");
        string newLastName = Console.ReadLine();
        
        Console.Write("Введите новую дату рождения студента (дд.мм.гггг): ");
        DateTime newDateOfBirth = DateTime.ParseExact(Console.ReadLine(),"dd.MM.yyyy",null);
        
        Console.Write("Введите новый номер группы студента: ");
        string newGroupNumber = Console.ReadLine();

        student.ChangeInfo(newLastName, newDateOfBirth, newGroupNumber);

        Console.WriteLine("\nОбновленная информация о студенте:");
        student.DisplayInfo();
    }
}

//Задание 2
using System;

class Train
{
    public string Destination{get;set;}
    public int TrainNumber{get; set;}
    public DateTime DepartureTime{get;set;}

    public void DisplayTrainInfo()
    {
        Console.WriteLine($"Название пункта назначения: {Destination}");
        Console.WriteLine($"Номер поезда: {TrainNumber}");
        Console.WriteLine($"Время отправления: {DepartureTime.ToString("HH:mm")}");
    }
}

class Program
{
    static void Main()
    {
        Train[] trains = new Train[5];

        trains[0] = new Train {Destination = "Москва",TrainNumber = 104, DepartureTime = new DateTime(2023,2,5,8,30,0)};
        trains[1] = new Train {Destination = "Санкт-Петербург",TrainNumber = 201, DepartureTime = new DateTime(2023,2,5,10,45,0)};
        trains[2] = new Train {Destination = "Екатеринбург",TrainNumber = 323, DepartureTime = new DateTime(2023,2,5,12,0,0)};
		trains[3] = new Train {Destination = "Новосибирск",TrainNumber = 410, DepartureTime = new DateTime(2023,2,5,15,10,0)};
        trains[4] = new Train {Destination = "Красноярск",TrainNumber = 503, DepartureTime = new DateTime(2023,2,5,18,30,0)};

        Console.WriteLine("Введите номер поезда для получения информации: ");
        int trainNumberInput = int.Parse(Console.ReadLine());

        bool trainFound = false;
        foreach (Train train in trains)
        {
            if (train.TrainNumber == trainNumberInput)
            {
                train.DisplayTrainInfo();
                trainFound = true;
                break;
            }
        }

        if (!trainFound)
        {
            Console.WriteLine("Поезд с таким номером не найден.");
        }
    }
}

//Задание 3
using System;

class Numbers
{
    public int Number1{get;private set;}
    public int Number2{get;private set;}

    public Numbers(int num1, int num2)
    {
        Number1 = num1;
        Number2 = num2;
    }

    public void DisplayNumbers()
    {
        Console.WriteLine($"Первое число: {Number1}");
        Console.WriteLine($"Второе число: {Number2}");
    }

    public void ChangeNumbers(int newNum1, int newNum2)
    {
        Number1 = newNum1;
        Number2 = newNum2;
        Console.WriteLine("Числа успешно изменены.");
    }

    public int GetSum()
    {
        return Number1 + Number2;
    }

    public int GetMax()
    {
        return Math.Max(Number1, Number2);
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Введите первое число: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Введите второе число: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Numbers numbers = new Numbers(num1,num2);

        Console.WriteLine("\nИсходные числа:");
        numbers.DisplayNumbers();

        Console.WriteLine($"\nСумма чисел: {numbers.GetSum()}");
        Console.WriteLine($"Наибольшее число: {numbers.GetMax()}");

        Console.WriteLine("\nВведите новые числа для изменения:");
        int newNum1 = Convert.ToInt32(Console.ReadLine());
        int newNum2 = Convert.ToInt32(Console.ReadLine());

        numbers.ChangeNumbers(newNum1, newNum2);

        Console.WriteLine("\nИзмененные числа:");
        numbers.DisplayNumbers();
    }
}

//Задание 4
using System;

class Counter
{
    private int count;

    public Counter()
    {
        count = 0; 
    }

    public Counter(int initialValue)
    {
        count = initialValue; 
    }

    public void Increment()
    {
        count++;
    }

    public void Decrement()
    {
        count--;
    }

    public int CurrentCount
    {
        get {return count;}
    }
}

class Program
{
    static void Main()
    {
        Counter counter1 = new Counter(); 
        Console.WriteLine("Текущее значение счетчика с начальным значением: " + counter1.CurrentCount);

        counter1.Increment();
        Console.WriteLine("Увеличили этот счетчик. Текущее значение: " + counter1.CurrentCount);
		
		Console.WriteLine(" ");

        Counter counter2 = new Counter(6); 
        Console.WriteLine("Текущее значение счетчика с значением по умолчанию: " + counter2.CurrentCount);

        counter2.Decrement();
        Console.WriteLine("Уменьшили этот счетчик. Текущее значение: " + counter2.CurrentCount);
    }
}

//Задание 5
using System;

class MyClass
{
    private int property1;
    private string property2;

    public MyClass(int value1, string value2)
    {
        property1 = value1;
        property2 = value2;
    }

    public MyClass()
    {
        property1 = 0;
        property2 = "default";
    }

    ~MyClass()
    {
        Console.WriteLine("Объект MyClass удален.");
    }

    public void DisplayProperties()
    {
        Console.WriteLine("1 свойство: " + property1);
        Console.WriteLine("2 свойство: " + property2);
    }
}

class Program
{
    static void Main()
    {
		Console.WriteLine("Конструктор с входными параметрами: ");
        MyClass obj2 = new MyClass(25, "Хлеб");
        obj2.DisplayProperties();
		
		Console.WriteLine();
		
		Console.WriteLine("Конструктор с параметрами по умолчанию: ");
		MyClass obj1 = new MyClass();
        obj1.DisplayProperties();
    }
}