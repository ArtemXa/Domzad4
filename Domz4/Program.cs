
void Zadacha25()
{
    Console.WriteLine("Введите число А:");
    int number_a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число Б:");
    int number_b = Convert.ToInt32(Console.ReadLine());
    int prod = 1;
    for (int i = 0; i < number_b; i++)
    {
        prod *= number_a;
    }
    Console.Write($"{prod}");
}
void Zadacha27()
{
    Console.WriteLine("Введите число:");
    int numbers = Convert.ToInt32(Console.ReadLine());
    int sum = 0;
    while (numbers > 0)
    {
        sum += numbers % 10;
        numbers /= 10;
    }
    Console.WriteLine(sum);
}

void Zadacha29()
{
    Random random = new Random();
    int size = 8;
    int[] numbers = new int[size];
    Console.WriteLine(size);

    FillArray(numbers);
    SortArray(numbers);
    PrintArray(numbers);
}

void FillArray(int[] num)
{
    Random random = new Random();
    for (int i = 0; i < num.Length; i++)
    {
        num[i] = random.Next(-100, 100);
    }
}

void SortArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
        for (int j = 0; j < num.Length - 1; j++)
            if (Math.Abs(num[j]) > (Math.Abs(num[j + 1])))
            {
                int t = num[j + 1];
                num[j + 1] = num[j];
                num[j] = t;
            }
}

void PrintArray(int[] num)
{
    for (int i = 0; i < num.Length; i++)
    {
        Console.Write(num[i] + " ");
    }
    Console.WriteLine();
}

//Zadacha25();
//Zadacha27();
//Zadacha29();