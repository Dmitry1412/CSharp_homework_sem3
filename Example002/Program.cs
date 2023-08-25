/*Внутри класса Answer напишите метод DistanceBetweenPoints, 
который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел, 
и возвращает расстояние между ними в 3D пространстве.
*/

// Решение через массив
/*
double Length(int[] pointA, int[] pointB)
{
    double sum = default;
    int[] arrSum = new int[3];
    for (int i = 0; i < pointB.Length; i++)
    {
        arrSum[i] = pointA[i] - pointB[i];
        sum = sum + Math.Pow(arrSum[i], 2);
    }
    double result = Math.Sqrt(sum);
    return result;
}
*/

//Решение через переменную
double Length(int[] pointA, int[] pointB)
{
    double sum = default;
    for (int i = 0; i < pointB.Length; i++)
    {
        sum = sum + Math.Pow(pointA[i] - pointB[i], 2);
    }
    double result = Math.Sqrt(sum);
    return result;
}

/*int[] ar1 = {7, -5, 0};
int[] ar2 = {1, -1, 9};

double c = Length(ar1, ar2);
System.Console.WriteLine("{0:f2}", c);
*/