/* Задача 21

Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


int Coord(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число или некорректное число. Повторите ввод");
        }
    }
    return result;
}
double distance(int ax, int ay, int az, int bx, int by, int bz)
{
    double result = Math.Sqrt(Math.Pow(ax-bx,2)+Math.Pow(ay-by,2)+Math.Pow(az-bz,2));
    return result;
}

int ax = Coord("Введите координату Ax");
int ay = Coord("Введите координату Ay");
int az = Coord("Введите координату Az");

int bx = Coord("Введите координату Bx");
int by = Coord("Введите координату By");
int bz = Coord("Введите координату Bz");

double distance2 = distance(ax, ay, az, bx, by, bz);

Console.WriteLine($"Расстояние между точкой А и B равно {distance2}");
