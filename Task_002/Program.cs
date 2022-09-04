//Задача 2:* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе,
//которые являются делителями этого числа.
//(для получения цифр числа операцию приведения числа к строке не использовать)
//452 -> 6
//82 -> 2
//9012 -> 3
//23 -> 0
Console.WriteLine("Введите число: ");
int number = Int32.Parse(Console.ReadLine());
int numberClone = number;
int i = 0;
int sum =0;
int numberClone1 = number;
Console.WriteLine(" ");
for(i = 0; number != 0;i++)
{
    number /= 10;
}
int [] array = new int [i];
for(i = 0;i<array.Length;i++)
{
    array[i]=numberClone%10;
    numberClone /= 10;
    Console.WriteLine(array[i]);
}
Console.WriteLine(" ");
for(i=0;i<array.Length;i++)
{
    if(array[i] != 0)
    {
        if(numberClone1%array[i] == 0)
            {
            sum += array[i];
            }
    }
}
Console.WriteLine(sum);