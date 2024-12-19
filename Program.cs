using System;

// Батьківський клас для дробово-лінійної функції
class FractionalLinearFunction
{
    protected double a1, a0, b1, b0;

    // Конструктор для ініціалізації коефіцієнтів
    public FractionalLinearFunction(double a1, double a0, double b1, double b0)
    {
        this.a1 = a1;
        this.a0 = a0;
        this.b1 = b1;
        this.b0 = b0;
    }

    // Віртуальний метод для виведення коефіцієнтів
    public virtual void DisplayCoefficients()
    {
        Console.WriteLine($"a1 = {a1}, a0 = {a0}, b1 = {b1}, b0 = {b0}");
    }

    // Віртуальний метод для обчислення значення функції в точці x0
    public virtual double CalculateValue(double x0)
    {
        return (a1 * x0 + a0) / (b1 * x0 + b0);
    }
}

// Похідний клас, що розширює функціональність батьківського класу
class AdvancedFractionalLinearFunction : FractionalLinearFunction
{
    public AdvancedFractionalLinearFunction(double a1, double a0, double b1, double b0)
        : base(a1, a0, b1, b0)
    {
    }

    // Перевантаження методу для виведення коефіцієнтів
    public override void DisplayCoefficients()
    {
        Console.WriteLine($"Advanced Coefficients - a1: {a1}, a0: {a0}, b1: {b1}, b0: {b0}");
    }

    // Перевантаження методу для обчислення значення в точці x0
    public override double CalculateValue(double x0)
    {
        double result = (a1 * x0 * x0 + a1 * x0 + a0) / (b1 * x0 * x0 + b1 * x0 + b0);
        return result;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Запитуємо користувача, який об'єкт створити
        Console.WriteLine("Choose an option (1 - Regular, 2 - Advanced): ");
        char userChoose = Console.ReadKey().KeyChar;
        Console.WriteLine();

        FractionalLinearFunction flf;  // Показник на базовий клас

        // Вибір об'єкта залежно від вибору користувача
        if (userChoose == '1')
        {
            // Створюємо об'єкт базового класу
            flf = new FractionalLinearFunction(1, 2, 3, 4);
        }
        else
        {
            // Створюємо об'єкт похідного класу
            flf = new AdvancedFractionalLinearFunction(1, 2, 3, 4);
        }

        // Викликаємо методи через показник на базовий клас
        flf.DisplayCoefficients();
        Console.WriteLine($"Value at x0 = 2: {flf.CalculateValue(2)}");
    }
}
