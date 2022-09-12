// C# Labb1 – Hitta tal i sträng med tecken 
// David Almvkvist - Sep 2022

Console.WriteLine("Labb 1 - Hitta tal i sträng med tecken! \n");

Console.Write("Enter a string with numbers and latters: ");
string inputString = Console.ReadLine();

string defaultStringForTest = "29535123p48723487597645723645";
long sumOfAllNumbers = 0;

ReplaceStringIfEmptyWithDefault();

ScanText(inputString);

void ScanText(string stringToScan)
{
    Console.WriteLine();

    for (int i = 0; i < stringToScan.Length; i++)
	{
        if (char.IsDigit(stringToScan[i]))
        {
            ScanNextChar(i, stringToScan);
        }
    }

    Console.WriteLine($"\nAnd the sum is: {sumOfAllNumbers}");
}


void ScanNextChar(int mainLoopsIndex,string stringToScan)
{
    string currentNrString = "";
    addDigit(stringToScan[mainLoopsIndex]);

    for (int j = mainLoopsIndex + 1; j < stringToScan.Length; j++)
    {
        if (char.IsDigit(stringToScan[j]))
        {
            addDigit(stringToScan[j]);

            if (stringToScan[j] == stringToScan[mainLoopsIndex])
            {
                AddToSum(long.Parse(currentNrString));
                PrintStringInColors(mainLoopsIndex, j);
                return;
            }
        }
        else
        {
            return;
        }
    }

    void addDigit(char digit)
    {
        currentNrString += digit;
    }
}

void PrintStringInColors(int startColorIndex, int endColorIndex)
{
    for (int i = 0; i < inputString.Length; i++)                   // TODO: Change when done with test String
    {
        if (i >= startColorIndex && i <= endColorIndex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
        }
        else
        {
            resetForeGroundColor();
        }
        Console.Write(inputString[i]);
    }
    resetForeGroundColor();
    Console.WriteLine();

    void resetForeGroundColor()
    {
        Console.ForegroundColor = ConsoleColor.White;
    }
}

void ReplaceStringIfEmptyWithDefault()
{
    if (string.IsNullOrWhiteSpace(inputString))
    {
        Console.WriteLine($"No text entered! Using default string: {defaultStringForTest}");
        inputString = defaultStringForTest;
    }
}

bool CheckIfDigit(char charToTest)
{
    return (char.IsDigit(charToTest));
}

void AddToSum(long valueToAdd)
{
    sumOfAllNumbers += valueToAdd;
}