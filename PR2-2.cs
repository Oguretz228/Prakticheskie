using System;

class MyClass
{
    private int n = 0;

    public bool SetNumber(int number)
    {
        if (number == n + 1)
        {
            n = number;
            return true;
        }
        else
        {
            n = 0;
            return false;
        }
    }

    public int GetExpectedNumber()
    {
        return n + 1;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();

        while (true)
        {
            Console.Write("Введите число: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (myObject.SetNumber(number))
            {
                Console.WriteLine("Ожидаемое значение: " + myObject.GetExpectedNumber());
            }
            else
            {
                Console.WriteLine("Введенное число не равно ожидаемому значению. Повторите ввод.");
            }
        }
    }
}
