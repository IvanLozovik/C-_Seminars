// // Задача: Написать программу, которая из имеющегося массива строк 
// // формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// // Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// // выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// // лучше обойтись исключительно массивами.

    
// // Примеры:
// // [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// // [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// // [“Russia”, “Denmark”, “Kazan”] → []


string[] Massiv1 = {"Hello", "Russia", ":-)", "mk", "day", "-2yy", "1"};
int count = GetNumbers3(Massiv1);
string[] Massiv2 = FilteredArray(Massiv1, count);
Console.WriteLine("    Исходный массив: ");
Console.WriteLine(string.Join(" ", Massiv1));
Console.WriteLine("    Новый массив: ");
Console.WriteLine(string.Join(" ", Massiv2));


string[] FilteredArray(string[] Massiv, int count)
{
string[] Massiv2 = new string[count];
int j =0;
for (int i=0; i<Massiv1.Length; i++)
{
    if (Massiv1[i].Length<=3)
    {
        Massiv2[j]=Massiv1[i];
        j++;
    }
}
return Massiv2;
}

int GetNumbers3 (string[] Massiv)
{
int count = 0;
foreach (string s in Massiv)
{
    if (s.Length <= 3)
    {
        count+=1;
    }
}
return count;
}



