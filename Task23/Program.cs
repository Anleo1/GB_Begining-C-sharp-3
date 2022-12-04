Console.Write("Введите положительное натуральное число (больше нуля), N = ");
int N = Convert.ToInt32(Console.ReadLine());
if (N <= 0){
    Console.WriteLine(" Вы ввели число меньше нуля или равное нулю ");
}
else {
    Console.WriteLine("Кубы натуральных чисел от 1 до N");
    
    for (int i = 1; i <= N; i++) {
        Console.WriteLine($"{i} : {Math.Pow(i, 3)}");
    }
}