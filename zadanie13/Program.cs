// Задача 13: Напишите программу, которая выводит третью цифру
//  заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("ВВедите число");
int num = Convert.ToInt32(Console.ReadLine());

int x = 1;
int ostatok = 10;

while (num > 99)
{
   
   if ((num < 1000 * x) && (num > 100 * x ))
     { 
      int result = num%ostatok/x;
      Console.WriteLine ( result );
      break;
     }
     x = x*10;
     ostatok = ostatok*10;
}  
if (num < 100)
     {
      Console.WriteLine("Третьей цифры нет");
     }