//Задача 3:*(Дополнительная, не обязательная задача): Назовём число «интересным» если его
//произведение цифр делится на их сумму.
//Напишите программу, которая заполняет массив на N «интересных» случайных целых чисел.
//(Каждый эл-т массива должен быть сгенерирован случайно)
int [] array = new int [new Random().Next(1,10)];
int j = 0;
double work=1;
double sum =0;


for (j = 0; j < array.Length; j++)
{
int num = new Random().Next(1,2147483647);
int countOfDigits = 0;
int tmp = num;
while (tmp != 0)
{
tmp = tmp / 10;
countOfDigits++;
}
int[] digits;
digits = new int[countOfDigits];
int i = 0;
tmp = num;
while (tmp != 0)
{
digits[i] = tmp % 10;
tmp /= 10;
i++;
}

//Console.WriteLine("  ");
for (i=0; i<digits.Length; i++)
{
    sum += digits[i];
    work *= digits[i];
}
//Console.WriteLine(sum);
//Console.WriteLine(work);

if(work % sum == 0)
{
    array[j] = num;
}
Console.WriteLine(array[j]);
}












//for(int i = 0; i<array.Length; i++)

//if(number)