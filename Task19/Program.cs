Console.Write("Введите положительное пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0){
    string num_in_string = Convert.ToString(number);
    if (num_in_string.Length == 5){
        int count = 0;
        for (int i = 0; i < num_in_string.Length/2; i++){
            if(num_in_string[i]==num_in_string[num_in_string.Length - 1 - i]){
                count++;
            }
        }
        if (count == num_in_string.Length/2){
            Console.WriteLine("Палиндром");
        }
        else {
            Console.WriteLine("Число не является палиндромом");
        }
    }
    else {
        Console.WriteLine("Число не пятизначное");
    }
}
else {
    Console.WriteLine("Число отрицательное");
}