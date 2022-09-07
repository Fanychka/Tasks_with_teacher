        Console.WriteLine("Введите первое число: ");

        string first_input = Console.ReadLine();

        int first_number = int.Parse(first_input);

        Console.WriteLine("Введите второе число: ");

        string second_input = Console.ReadLine();
        
        int second_number = int.Parse(second_input);

        int maxNumber = second_number;
        int minNumber;
        
        if (second_number < first_number) maxNumber = first_number; minNumber = second_number;
        if (second_number > first_number) minNumber = first_number;
    
        Console.WriteLine($"Большее число здесь {maxNumber}, а меньшее {minNumber}");