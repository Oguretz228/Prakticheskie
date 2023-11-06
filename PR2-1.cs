using System;

class QuadraticEquationSolver
{
    private double a;
    private double b;
    private double c;
    private double discriminant;
    private double root1;
    private double root2;

    public QuadraticEquationSolver(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    private void CalculateDiscriminant()
    {
        discriminant = b * b - 4 * a * c;
    }

    public void CalculateRoots()
    {
        CalculateDiscriminant();

        if (discriminant > 0)
        {
            root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine("Корни уравнения: x1 = {0}, x2 = {1}", root1, root2);
        }
        else if (discriminant == 0)
        {
            root1 = -b / (2 * a);
            Console.WriteLine("Уравнение имеет один корень: x = {0}", root1);
        }
        else
        {
            Console.WriteLine("Уравнение не имеет действительных корней");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите коэффициенты квадратного уравнения:");
        Console.Write("a = ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("b = ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("c = ");
        double c = double.Parse(Console.ReadLine());

        QuadraticEquationSolver equationSolver = new QuadraticEquationSolver(a, b, c);
        equationSolver.CalculateRoots();

        Console.ReadKey();
    }
}
