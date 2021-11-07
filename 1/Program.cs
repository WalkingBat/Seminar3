//Подсчитать количество натуральных чисел, не превосходящих заданного числа n, которые:
//делятся на k, но не на l
//делятся хотябы на k или на l
//не делятся на (k + l)

int Check (int a, int k, int l)
{
    int count = 0;
    int number = 1;
    while (number <= a)
    {
        if (number % k == 0 && number % l != 0) count++; //делятся на k и не делятся на l
        number++;
    }
    return count;
}
Console.WriteLine(Check(125, 4, 10));