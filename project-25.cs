string? readResult;
bool validEntry = false;
int numericValue = 0;
bool validNumber = false;

System.Console.WriteLine("Enter a string containing at least three characters:");
do
{
    readResult = Console.ReadLine();
    if (readResult != null)
    {
        if (readResult.Length >= 3)
        {
            validEntry = true;
        }
        else
        {
            System.Console.WriteLine("Your input is invalid, please try again.");
        }
    }

} while (validEntry == false);

validNumber = int.TryParse(readResult, out numericValue);
if (validNumber == true)
{
    System.Console.WriteLine($"Try Parse method is working correctly {numericValue}");
}
