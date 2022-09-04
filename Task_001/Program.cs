//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную 
//степень B. Не использовать функцию Math.Pow()
//3, 5 -> 243
//2, 4 -> 16
Console.WriteLine("Введите натуральное число, которое будет возводиться в степень ");
int FirstNumber = Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите натуральное число, которое показывает в какую степень нужно число возводить ");
int SecondNumber = Int32.Parse(Console.ReadLine());

int finish = 1;
for(int i=1;i<=SecondNumber;i++)
{
    finish = finish*FirstNumber;
}
Console.WriteLine(finish);