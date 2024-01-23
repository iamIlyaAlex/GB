using static System.Console;
// Строки !!!
// Строка - последовательный набор символов, который используется для представления текста.
// Строка в C# - массив символов типа char.
// Для работы со строками в C# используется специальный символ - String, кратко str.
// ВАЖНО: У Строки нет возможности изменять элементы существующей строки, а также невозможности увеличивать и укорачивать строку.

string GetLettersFromStr(string s);
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
    string str = ReadLine();
    string letters = GetLettersFromStr(str);
    WriteLine(letters);
}