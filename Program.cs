//Задача 34: Задайте массив заполненный случайными положительными 
//трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] ArrayOfRandomNumbers(int size,int smallvalue ,int higvalue)
{
int[]array=new int [size];
for(int i=0; i<size;i++)
    array[i]=new Random().Next(smallvalue,higvalue+1);
    return array;
}
void ArrayDispley(int[]array)
{
    for(int i=0;i<array.Length;i++)
    Console.Write(array[i]+" ");
    Console.WriteLine();
}
int NumberOfEvenElements(int[]arr)
{
int c=0;   
    for(int i=0;i<arr.Length;i++)
    {
     if (arr[i]%2 == 0)
     c=c+1;
    }
    return c;
}
Console.WriteLine ("Зададим массив случайных положительных трёхзначных чисел");
Console.Write("Введите,пожалуйста,количество элементов массива: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите,пожалуйста,левую границу: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите,пожалуйста,правую границу: ");
int b=Convert.ToInt32(Console.ReadLine());
int [] myarrey=ArrayOfRandomNumbers(n,a,b);
Console.WriteLine("сгенерированный массив: ");
ArrayDispley(myarrey);
int m=NumberOfEvenElements(myarrey);
Console.Write($"Количество чётных элементов в массиве {m}");
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
double[] InputArrayOfRealNumbers(int size, int smallvalue ,int higvalue)
{
double[]array=new double [size];
    for(int i=0; i<size;i++)
    array[i]= new Random().Next(smallvalue,higvalue+1) + new Random().NextDouble ();
return array;
}
void ArrayDispley(double[]array)
{
    for(int i=0;i<array.Length;i++)
    Console.WriteLine(array[i]+" ");
    Console.WriteLine();
}
/*double SumOfElInOddPos (double[]array)
{
    double sum = 0;
    for(int i=1;i<array.Length;i=i+2)
    {
    sum =sum + array[i];
    }
return sum;
} 
Console.Write("Введите,пожалуйста,количество элементов массива: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите,пожалуйста,левую границу: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите,пожалуйста,правую границу: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("полученный массив:");
double[]arr = InputArrayOfRealNumbers(n,a,b);
ArrayDispley(arr);
Console.Write($"Сумма элементов массива стоящих на нечётных позициях = {SumOfElInOddPos (arr)} ");
*/
//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементом массива.
double Diff (double[]array)
{
double min = array[0];
double max = array[0];
    for(int i=1;i<array.Length;i++)
    {
     if(min>array[i])
     min=array[i];
     if(max<array[i])
     max=array[i];
    }
double d=max-min;
return d;
}
Console.Write("Введите,пожалуйста,количество элементов массива: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите,пожалуйста,левую границу: ");
int a=Convert.ToInt32(Console.ReadLine());
Console.Write("Введите,пожалуйста,правую границу: ");
int b=Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("полученный массив:");
Console.WriteLine();
double[]arr = InputArrayOfRealNumbers(n,a,b);
ArrayDispley(arr);
Console.Write($"разницa между максимальным и минимальным элементом массива = {Diff(arr)} ");
