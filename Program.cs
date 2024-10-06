//1. 4x4 ölçülü matrixin elementlərinin cəmini tapın.

/*int[,] numbers =
{
    {1,2,3,4 },
    {5,6,7,8 },
    {9,10,11,12 },
    {13,14,15,16 }
};
int sum = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j<numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i,j];
    }
}
        Console.WriteLine(sum);*/

//2. Matrixin baş diaqonalındakı elementlərin cəmi

/*int[,] numbers =
{
    {1,2,3,4 },
    {5,6,7,8 },
    {9,10,11,12 },
    {13,14,15,16 }
};
int sum = 0;
for (int i = 0; i < numbers.GetLength(0); i++)
{
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        if (i==j)
        {
        sum = sum + numbers[i, j];

        }
    }
}
Console.WriteLine(sum);*/

//3. Matrixin baş diaqonal və ondan yuxarıdakı elementlərin cəmi

/*int[,] numbers =
{
    {1,2,3,4 },   // 0,0 //10
    {5,6,7,8 },   // 1,1  //21
    {9,10,11,12},  // 2,2  //23
    {13,14,15,16}   // 3,3  //16     // 70
};
int sum = 0;
for (int i = 0; i < 4; i++)
{
    for (int j = i; j < 4; j++)
    {
        sum += numbers[i, j];
    }
}
        Console.WriteLine(sum);*/

//4. Matrixin baş diaqonalından yuxarıda olan ədədlərin cəmindən aşağıda olan ədədlərin cəminin fərqi.

/*int[,] numbers =
{
    {1,2,3,4 },      // 1
    {5,6,7,8 },     // 11
    {9,10,11,12},  // 30
    {13,14,15,16} //58    //100               
};
int sum1 = 0;
int sum2 = 0;
for (int i = 0; i < 4; i++)
{
    for (int j = i; j < 4; j++)
    {
        sum1 += numbers[i, j];
    }
}
for (int i = 0; i < 4; i++)
{

    for (int j = 0;j<=i; j++ )
        {
            sum2 += numbers[i, j];
        }
}
    Console.WriteLine(sum1 -sum2);*/

