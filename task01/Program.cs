Console.WriteLine("Введите число: ");

string input = Console.ReadLine();

int number = int.Parse(input);

int square = number * number;

Console.WriteLine($"Число {input} в квадрате равно {square}");