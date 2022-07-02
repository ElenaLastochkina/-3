// Задача 19 Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.WriteLine ("введите  пятизначное число:");
string number = Console.ReadLine();
Zadacha19(number);

void Zadacha19(string number)
{
    if (number[0] == number[4] & number[1] == number[3])
    {
        Console.WriteLine("да");
    }
    else Console.WriteLine("нет");
}

//Задача 21 Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine ("введите x1:");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите y1:");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите z1:");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите x2:");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите y2:");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine ("введите z2:");
int z2 = Convert.ToInt32(Console.ReadLine());
Zadacha21();

void Zadacha21()
{
  Console.WriteLine (Math.Sqrt ((y2-y1)*(y2-y1) + (x2-x1)*(x2-x1) + (z2-z1)*(z2-z1)));
}

//Задача 23 Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine ("введите число:");
int number1 = Convert.ToInt32(Console.ReadLine());
Zadacha23();

void Zadacha23()
{
  int index = 1;
  while (index < number1)
  {
    index++;
    Console.WriteLine(index*index*index);
  }

}