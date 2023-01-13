//Напишите программу,которая принимает на вход пятизначное число и проверяет,
//является ли оно палиндромом.
// System.Console.WriteLine("Введите пятизначное  число");
// int number = int.Parse(Console.ReadLine()!);
//  string Strnumber = number.ToString();
//  if(Strnumber.Length == 5);
//  {
   // if(Strnumber[0] == Strnumber[4] && Strnumber[1] == Strnumber[3])
 
//  { 
   // System.Console.WriteLine("Это палиндром");
//  }
   // else
//   {
   // System.Console.WriteLine("Это не палиндром");
//   }
//  }
// Напишите программу,которая принимает на вход координаты двух точек и 
//находит расстояние между ними в 3D пространстве
//  System.Console.WriteLine("Введите координату x точки A");
//  int x1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату y точки A");
//  int y1 = Convert.ToInt32(Console.ReadLine());
//  System.Console.WriteLine("Введите координату z точки A");
//  int z1 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату x точки B");
//  int x2 = Convert.ToInt32(Console.ReadLine());
//  System.Console.WriteLine("Введите координату y точки B");
// int y2 = Convert.ToInt32(Console.ReadLine());
// System.Console.WriteLine("Введите координату z точки B");
// int z2 = Convert.ToInt32(Console.ReadLine());
// double d = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2));
 
//  Console.WriteLine($"d={d:f3}");
// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N
System.Console.WriteLine("Введите число N");
int N = Convert.ToInt32(Console.ReadLine());
for(int i=1; i<=N;i++)
{
   System.Console.WriteLine($"{i*i*i}");
}

