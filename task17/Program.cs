// Задача 17. Напишите программу, которая принимает на вход координаты 
// точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости,
// в которой находится эта точка.

int GetQuarterFromCoordinate(int userX, int userY)
{
    int quarter = 0;
    if (userX > 0 && userY > 0)
    {
        quarter = 1;
    }
    else if (userX < 0 && userY > 0)
    {
        quarter = 2;
    }
    else if (userX < 0 && userY < 0)
    {
        quarter = 3;
    }
    else if (userX > 0 && userY < 0)
    {
        quarter = 4;
    }
return quarter;
}
Console.WriteLine("Введите координату X");
int userX = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату Y");
int userY = Convert.ToInt32(Console.ReadLine());

int quarter = GetQuarterFromCoordinate(userX, userY);
if (quarter != 0)
{
    Console.WriteLine($"Точка с координатами [{userX}: {userY}] находится в {quarter} четверти");
}
else
{
    Console.WriteLine($"Точка с координатами [{userX}: {userY}] находится на одной из осей");
}


// Задача 18: Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// Задача 22: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4
