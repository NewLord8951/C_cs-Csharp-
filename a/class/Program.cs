using System;
public class Counter
{
    private int _value;
    public Counter(int value)
    {
        this._value = value;
    }
    public int Increment()
    {
        _value++;
        return _value;
    }
    public int Decrement()
    {
        _value--;
        return _value;
    }
    public int GetValue()
    {
        return _value;
    }
    public override string ToString()
    {
        return $"Текущее значение счётчика: {_value}";
    }
}

class Program
{
    static void Main()
    {
        Counter counter = new Counter(0);
        string input;   
        while (true)
        {
            Console.WriteLine("\nВведите: 1(Прибавить), 2(Убавить), 3(Вывести), 0(Выход)");
            input = Console.ReadLine();
            if (!int.TryParse(input, out int a))
            {
                Console.WriteLine("Ошибка: введите число!");
                continue;
            }
            if (a == 0)
            {
                break;
            }
            else if (a == 1)
            {
                counter.Increment();
                Console.WriteLine($"Значение увеличено. Текущее: {counter.GetValue()}");
            }
            else if (a == 2)
            {
                counter.Decrement();
                Console.WriteLine($"Значение уменьшено. Текущее: {counter.GetValue()}");
            }
            else if (a == 3)
            {
                Console.WriteLine(counter);
            }

        }
    }
}
