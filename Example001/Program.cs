/*Для решения данного домашнего задания вам необходимо воспользоваться сервисом автоматической проверки написанного кода.
Для того, чтобы успешно выполнить задание, необходимо перейти по каждой из представленных ссылок и решить все предложенные задачи. Будьте внимательны, количество попыток отправки кода на проверку ограничено! Вам дано 5 попыток на каждую задачу.
Прикреплять полученные решения не требуется. Итоговая оценка домашнего задания появится автоматически на платформе после решения всех задач. Полученная оценка не повлияет на получение итогового документа об обучении.
*/

static bool IsPalindrome(int number)
{
    bool result = false;
    int[] array = new int[5];
    int numTemp = number;
    int div = 10000;
    if (number < 100000 & number > 9999)
    {
        for (int i = 0; i < 5; i++)
            {
                array[i] = numTemp / div;
                numTemp = numTemp % div;
                div = div / 10;
            }    
        if (array[0] == array[4] & array[1] == array[3])
            {
                result = true;
            }
        return result;
    }
    else
    {
        LenNum();
        return result;
    }

}
static void LenNum()
{
    System.Console.WriteLine("Число не пятизначное");
}

/*
int num = 1331;

bool res = IsPalindrome(num);
System.Console.WriteLine(res);
*/

