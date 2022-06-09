/* Задача 2: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("max = " + a);
}
else
{
    Console.WriteLine(b);
} 
*/


/*Задача 4: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.

int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());

if (a > b & a > c){
    Console.WriteLine(a);
}
else if (b > a & b > c){
    Console.WriteLine(b);
}
else Console.WriteLine(c);
*/

/* Задача 6: Напишите программу, которая на вход
принимает число и выдаёт, является ли число чётным 

int a = int.Parse(Console.ReadLine());

if (a % 2 == 0){
    Console.WriteLine("да");
}
else{
    Console.WriteLine("нет");
}
*/

/* Задача 8: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N. */

int a = int.Parse(Console.ReadLine());

for (int x = 1; x <= a; x++)       
if (x%2==0)            
Console.WriteLine(x);