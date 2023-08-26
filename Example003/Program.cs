/*Внутри класса Answer напишите метод ShowCube, 
который принимает на вход число (N)
и выводит таблицу кубов чисел от 1 до N (включительно) каждое на новой строке.*/


void ShowCube(int num)
{
    for (int i = 1; i <= num; i++)
    {
        System.Console.WriteLine(Math.Pow(i, 3));
    }
    
}
//ShowCube(5);