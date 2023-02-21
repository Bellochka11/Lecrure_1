// Вид 1 (не принимают не возвращают) Выведет слово текст
void Method1()
{
    Console.WriteLine("Текст");
}
Method1();

// Вид 2 (принимают не возвращают) Выведет слово текст сообщения 4 раза
void Method2(string msg, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method2("Текст сообщения", 4);
Method2(count: 5, msg: "Новый текст"); // Выведет "новый текст" 5 раз

// Вид 3 (не принимают, но  возвращают) выведет текущий год (2023)
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4 (принимают и возвращают) 10 Раз покажет z
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty; // пустая строка!!!!
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
 string text = Method4(10, "z");
 Console.WriteLine(text);