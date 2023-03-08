using System;
using static System.Console;

Clear();
string[] originalArray = GetArrayFromUser();
OutputMessage(originalArray, "Пользователь создал следующий массив:");
string[] lessOrEqualArray = GetLessOrEqualArray(originalArray);
OutputMessage(lessOrEqualArray, "Из массива были выбранны строки длиной меньше либо равно трем:");


string[] GetArrayFromUser(){
    string arrayLenStr = UserPrompt("Введите размер массива: ");
    int arrayLen = int.Parse(arrayLenStr);
    string[] userArray = GetArrayFromInput(arrayLen);
    return userArray;
}

string UserPrompt(string message){
    Write(message);
    string userInput = ReadLine();
    return userInput;
}

string[] GetArrayFromInput(int arrayLength){
    string[] array = new string[arrayLength];
    for (int i = 0; i < arrayLength; i++) {
        array[i] = UserPrompt("Введите строку: ");
    }
    return array;
}

string[] GetLessOrEqualArray(string[] fullArray) {
    string[] lessOrEqual = new string[fullArray.Length];
    int j = 0;
    for (int i = 0; i < fullArray.Length; i++)
    {
        if (fullArray[i].Length <= 3) {
            lessOrEqual[j] = fullArray[i];
            j++;
        }
    }
    return lessOrEqual;
}

void OutputMessage(string[] array, string message){
    WriteLine(message);
    PrintArray(array);
    WriteLine();
}

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        if (inArray[i] != "")
        {
            Write($"\"{inArray[i]}\" ");
        }
    }
}
