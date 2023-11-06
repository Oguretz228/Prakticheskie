using System;

class Car
{
    public string Name { get; set; }
    public int Speed { get; set; }

    public Car(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car[] cars = new Car[4];

        for (int i = 0; i < cars.Length; i++)
        {
            Console.Write("Введите имя автомобиля {0}: ", i + 1);
            string name = Console.ReadLine();
            Console.Write("Введите скорость автомобиля {0}: ", i + 1);
            int speed = Convert.ToInt32(Console.ReadLine());

            cars[i] = new Car(name, speed);
        }

        Car fastestCar = GetFastestCar(cars);

        Console.WriteLine("Самый быстрый автомобиль: {0}, со скоростью {1} км/ч.", fastestCar.Name, fastestCar.Speed);
    }

    static Car GetFastestCar(Car[] cars)
    {
        Car fastestCar = cars[0];

        for (int i = 1; i < cars.Length; i++)
        {
            if (cars[i].Speed > fastestCar.Speed)
            {
                fastestCar = cars[i];
            }
        }

        return fastestCar;
    }
}
