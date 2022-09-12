// C# Labb1 – Hitta tal i sträng med tecken 
// David Almvkvist - Sep 2022


using System.Data.SqlTypes;

Console.WriteLine("Labb 1 - Hitta tal i sträng med tecken! \n");

Console.Write("Enter a string with numbers and laters");

string inputString = Console.ReadLine();
string defaultStringForTest = "29535123p48723487597645723645";


if (inputString == "")
{
    inputString = defaultStringForTest;
}

long sumOfAllNumbers = 0;



// Loop all characters
ScanText(inputString);
//check if its a number

// loop to find next same number

// Add to sum


// Convert to int




void ScanText(string stringToScan)
{
	Console.WriteLine("Our text: " + stringToScan + "\n");				//TODO: remove when done testing

	for (int i = 0; i < stringToScan.Length; i++)
	{
        if (CheckIfDigit(stringToScan[i]))
        {
            ScanNextChar(i, stringToScan);
        }
    }

    Console.WriteLine($"\nAnd the sum is: {sumOfAllNumbers}");
}


void ScanNextChar(int mainLoopsIndex,string stringToScan)
{
    string currentNrString = "";
    currentNrString += stringToScan[mainLoopsIndex];

    for (int j = mainLoopsIndex + 1; j < stringToScan.Length; j++)
    {
        if (CheckIfDigit(stringToScan[j]))
        {
            currentNrString += stringToScan[j];

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

bool CheckIfDigit(char charToTest)
{
    return (char.IsDigit(charToTest));
}

void AddToSum(long valueToAdd)
{
    sumOfAllNumbers += valueToAdd;
}