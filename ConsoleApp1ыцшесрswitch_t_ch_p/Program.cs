//Console.WriteLine("условноя констр if_elseif_else");
//Console.WriteLine("введите значени2е");
//int num1 = Convert.ToInt32(Console.ReadLine());

//if (num1 > 0)
//{
//    Console.WriteLine($"{num1} больше ноля!");
//}
//else if (num1 > 100)
//{
//    Console.WriteLine("больше сотни");
//}
//else if (num1 == 0)
//{
//    Console.WriteLine($"{num1} равно нулю!");
//}
//else
//{
//    Console.WriteLine($"{num1} меньше нуля !!!№!№!№!");
//}



//Console.WriteLine("время дня");
//int hour = Convert.ToInt32(Console.ReadLine());

//if (hour >= 6 && hour <= 12)
//{
//    Console.WriteLine("доброе утро!");
//}
//else if (hour > 12 && hour <= 18)
//{
//    Console.WriteLine("добрый день!");
//}
//else if (hour > 18 && hour <= 23)
//{
//    Console.WriteLine("добрый вечер");
//}
//else if (hour >= 23 && hour <= 6)
//{
//    {
//        Console.WriteLine("доброй ночи");


//        else
//            Console.WriteLine("введите время");
//    }


Console.WriteLine("начало игры выберете один из пунктов!");
Console.WriteLine("1. начало игры");
Metod1();
Console.WriteLine("2. загрузить игру");
Metod1();
Console.WriteLine("3. выход из игры!");
Metod1();
string game = Console.ReadLine();

switch (game)
{
    case "1":
                    Console.WriteLine("вход в игру!"); Metod3();
        break;
    case "2":
        Console.WriteLine("загрузили игру!"); Metod2();
        break;
    case "3":
        Console.WriteLine("выход!"); Metod4();
        break;
}



void Metod1()
{
    Console.WriteLine("-----________--------");
}

void Metod2()
{
    Console.WriteLine("ваш возраст : 13");
}

void Metod3()
{
    Console.WriteLine("ваш возраст оперделяется подождите вечность _-_-_-_-_");
}
void Metod4()
{
    Console.WriteLine("вы покинули игру, закройте окно");
}