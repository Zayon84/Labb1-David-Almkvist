// C# Labb1 – Hitta tal i sträng med tecken 
// David Almvkvist - Sep 2022


using System.Data.SqlTypes;

Console.WriteLine("Labb 1 - Hitta tal i sträng med tecken! \n");

string defaultStringForTest = "29535123p48723487597645723645";
long sumOfAllNumbers = 0;



// Loop all characters
ScanText(defaultStringForTest);
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
                Console.Write($"we add {currentNrString}: ");
                PrintCheckIfDigitResult(mainLoopsIndex);            //TODO: remove when done testing
                AddToSum(long.Parse(currentNrString));

                return;
            }
        }
        else
        {
            return;
        }
    }
}


bool CheckIfDigit(char charToTest)
{
    if (char.IsDigit(charToTest))
    {
        return true;
    }
    return false;
}

void PrintCheckIfDigitResult(int indexNr)                   //TODO: remove when done testing
{
    Console.WriteLine($"Index nr {indexNr}, Char = {defaultStringForTest[indexNr]} is a digit = {CheckIfDigit(defaultStringForTest[indexNr])}");

}

void AddToSum(long valueToAdd)
{
    sumOfAllNumbers += valueToAdd;
}