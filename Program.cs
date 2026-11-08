// // Задание 1
// PrintHeader("привет");
// PrintHeader("пока");

// static void PrintLine() {
//     Console.WriteLine("^_^");
// }

// static void PrintHeader(string title) {
//     PrintLine();
//     Console.WriteLine(title);
//     PrintLine();
// }


// Задание 2.1
//Console.WriteLine(Max(1, 2));
//Console.WriteLine(Max(3, 2));

int Max(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}


// // Задание 2.2
// Console.WriteLine(IsEven(4));
// Console.WriteLine(IsEven(7));
// Console.WriteLine(IsEven(0));

// bool IsEven(int n) {
//     if (n % 2 == 0) {
//         return true;
//     }
//     else {
//         return false;
//     }
// } 




// Задание 3
// int[] marks = { 120, 45, 300, 80, 15, 210 };
// Console.WriteLine(Average(marks));
// Console.WriteLine(CountGreater(marks, 100));

// double Average(int[] arr) {
//     int sum = 0;
//     foreach (int i in arr) {
//         sum += i;
//     }
//     return (double)sum / arr.Length;
// }

// int CountGreater(int[] arr, int limit) {
//     int count = 0;
//     foreach (int i in arr ) {
//         if (i > limit) {
//             count++;
//         }
//     }
//     return count;
// }





// Задание 4
// ToFahrenheit(0);
// ToFahrenheit(100);
// ToFahrenheit(37);

// double ToFahrenheit(double celsius) {
//     double f = celsius * 9 / 5 + 32;
//     Console.WriteLine($"{celsius} °C = {f} °F");
//     return f;
// }



// Задание 5
//Console.WriteLine(Factorial(5));

// for (int i = 2; i <= 50; i++) {
//     if (IsPrime(i)) {
//         Console.Write(i + " ");
//     }
// }
// Console.WriteLine();

static long Factorial(int n) {
    int sum = 1;
    for (int i = 1; i <= n; i++) {
        sum *= i;
    }
    return sum;
}

// static bool IsPrime(int n) {
//     if (n < 2) {
//         return false;
//     }
//     for (int i = 2; i < n; i++) {
//         if (n % i == 0) {
//             return false;
//         }
//     }
//     return true;
// }



// Задание 6
// int a = ReadPositive("Введите первое число: ");
// int b = ReadPositive("Введите второе число: ");

// Console.WriteLine(a + b);

// static int ReadPositive(string message) {
//     int number;
//     do {
//         Console.Write(message);
//         number = int.Parse(Console.ReadLine());
//     }
//     while (number <= 0);
//     return number;
// }








// Итоговая задача. «Меню-калькулятор»
string choice = "";

while (choice != "0") {
    PrintMenu();
    choice = Console.ReadLine();

    switch (choice) {
        case "1":
            Console.Write("Первое число: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"Сумма: {Sum(a, b)}");
            break;
        case "2":
            Console.Write("Первое число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Второе число: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Большее: {Max(x, y)}");
            break;
        case "3":
            Console.Write("Введите число: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine($"Факториал: {Factorial(n)}");
            break;
        case "0":
            Console.WriteLine("Выход");
            break;
        default:
            Console.WriteLine("Нет такого пункта");
            break;
    }
}

static void PrintMenu() {
    Console.WriteLine("1 — сумма двух чисел");
    Console.WriteLine("2 — большее из двух чисел");
    Console.WriteLine("3 — факториал");
    Console.WriteLine("0 — выход");
    Console.Write("Выберите пункт: ");
}

static int Sum(int a, int b) {
    return a + b;
}