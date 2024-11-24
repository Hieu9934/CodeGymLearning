Console.Write("Input your positive integer with at most 3 digits: ");
string input = Console.ReadLine();
bool isInteger = int.TryParse(input, out int result);

// Check if input is a positive integer with at most 3 digits
if (!isInteger || (isInteger && (result < 0 || result >= 1000)))
{
    Console.WriteLine("Out of ability!");
} else
{
    string inputPronunciation = "";
    if (result == 0)
    {
        inputPronunciation += "Zero";
    }
    else
    {
        // Get the 3 digits
        int lastDigit = result % 10;
        int middleDigit = result % 100 / 10;
        int firstDigit = result / 100;

        // Pronounce the first digit
        switch (firstDigit)
        {
            case 1:
                inputPronunciation += "one hundred and ";
                break;
            case 2:
                inputPronunciation += "two hundreds and ";
                break;
            case 3:
                inputPronunciation += "three hundreds and ";
                break;
            case 4:
                inputPronunciation += "four hundreds and ";
                break;
            case 5:
                inputPronunciation += "five hundreds and ";
                break;
            case 6:
                inputPronunciation += "six hundreds and ";
                break;
            case 7:
                inputPronunciation += "seven hundreds and ";
                break;
            case 8:
                inputPronunciation += "eight hundreds and ";
                break;
            case 9:
                inputPronunciation += "nine hundreds and ";
                break;
        }

        // Pronounce number from 10 to 19
        int lastTwoDigits = middleDigit * 10 + lastDigit;
        switch (lastTwoDigits)
        {
            case 10:
                inputPronunciation += "ten";
                break;
            case 11:
                inputPronunciation += "eleven";
                break;
            case 12:
                inputPronunciation += "twelve";
                break;
            case 13:
                inputPronunciation += "thirteen";
                break;
            case 14:
                inputPronunciation += "fourteen";
                break;
            case 15:
                inputPronunciation += "fifteen";
                break;
            case 16:
                inputPronunciation += "sixteen";
                break;
            case 17:
                inputPronunciation += "seventeen";
                break;
            case 18:
                inputPronunciation += "eighteen";
                break;
            case 19:
                inputPronunciation += "nineteen";
                break;
            default:
                // Pronounce the middle digit
                switch (middleDigit)
                {
                    case 2:
                        inputPronunciation += "twenty ";
                        break;
                    case 3:
                        inputPronunciation += "thirty ";
                        break;
                    case 4:
                        inputPronunciation += "fourty ";
                        break;
                    case 5:
                        inputPronunciation += "fifty ";
                        break;
                    case 6:
                        inputPronunciation += "sixty ";
                        break;
                    case 7:
                        inputPronunciation += "seventy ";
                        break;
                    case 8:
                        inputPronunciation += "eighty ";
                        break;
                    case 9:
                        inputPronunciation += "ninety ";
                        break;
                }

                // Pronounce the last digit
                switch (lastDigit)
                {
                    case 1:
                        inputPronunciation += "one";
                        break;
                    case 2:
                        inputPronunciation += "two";
                        break;
                    case 3:
                        inputPronunciation += "three";
                        break;
                    case 4:
                        inputPronunciation += "four";
                        break;
                    case 5:
                        inputPronunciation += "five";
                        break;
                    case 6:
                        inputPronunciation += "six";
                        break;
                    case 7:
                        inputPronunciation += "seven";
                        break;
                    case 8:
                        inputPronunciation += "eight";
                        break;
                    case 9:
                        inputPronunciation += "nine";
                        break;
                }
                break;
        }
    }
    Console.WriteLine(inputPronunciation);
}