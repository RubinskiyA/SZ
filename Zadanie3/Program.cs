int x, y;
Console.Write("Введите первое число: ");
int.TryParse(Console.ReadLine(), out x);
Console.Write("Введите Второе число: ");
int.TryParse(Console.ReadLine(), out y);
Console.WriteLine($"{x} + {y} = {x+y}");