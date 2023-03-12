/*
Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
["hello","2", "world", ":-)"] -> ["2", ":-)"]
["1234","1567","-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []
*/


// Entering strings from the keyboard and the formation of a new array

// 1. Declaring Variables
string[] arrString1;                                    // reference to an array of strings
int count;                                              // the current number of rows in the array
string s;
string[] temp;                                    // additional variable-reference - saves the old array of strings

// 2. Цикл ввода строк
Console.WriteLine("Enter strings:");

count = 0;                                              // reset the number of rows
arrString1 = new string[count];                         // allocate memory for 0 lines

do
{
    s = Console.ReadLine();                             // Enter string

    if (s != "")                                        // Checking if a string is empty
    {
        count++;                                        // if the string is not empty, then add the string to the array
        temp = new string[count];                 // pre-allocate memory for a new array with 1 more element

        for (int i = 0; i < temp.Length - 1; i++) // copy the old array to the new one
            temp[i] = arrString1[i];

        temp[count - 1] = s;                      // add last entered string to "arrString2" array

        arrString1 = temp;                         
    }
} while (s != "");


string[] arrString2 = new string[arrString1.Length];

void SecondArray(string[] arrString1, string[] arrString2)
{
    int count = 0;
    for (int i = 0; i < arrString1.Length; i++)
    {
        if (arrString1[i].Length <= 3)
        {
            arrString2[count] = arrString1[i];
            count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine();
}
SecondArray(arrString1, arrString2);
Console.WriteLine($"Array of strings less than or equal to 3 characters long:");
PrintArray(arrString2);