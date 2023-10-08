// Дан текст 
//все пробелы заменить на черточки, 
//маленькие буквы к на большие К
//А большие с на маленькие С




string text = "Прошло семь лет после 12-го года. "
            + "Взволнованное историческое море Европы улеглось в свои берега. "
            + "Оно казалось затихшим; но таинственные силы," 
            + "двигающие человечество, продолжали свое действие.";

//string s = "qwerty"
//            012345
// s[3] // r

string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;
    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}
string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'с', 'С');
Console.WriteLine(newText);