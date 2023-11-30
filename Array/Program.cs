
int numberOfElements;
int index = 0;

double sumOfNegativeElements = 0;
double minElement = double.MaxValue;
double maxElement = double.MinValue;
double indexOfMaxElement = 0;
double maxAbsElement = 0;
double sumOfIndexesOfPositiveElements = 0;
double numberOfIntegers = 0;

var randomGenerator = new Random();

Console.Write("Enter number of elements: ");

while(true)
{
    bool status = int.TryParse(Console.ReadLine(), out numberOfElements);
    if (numberOfElements <= 0) status = false;
    if (status) break;
    Console.Write("Incorrect input. Number of elements should be an integer > 0.\n" +
                  "Enter number of elements: ");
}

double[] randomNumbers = new double[numberOfElements];

Console.WriteLine($"Array of size `{numberOfElements}` filled with random double numbers: \n");
for (int i = 0; i < numberOfElements; i++)
{
    double randomNumber = randomGenerator.NextDouble() * 100 - 50;
    randomNumbers[i] = randomNumber;
    Console.Write($"{randomNumbers[i],9:F2} ");
}
Console.Write("\n\n");


foreach (double randomNumber in randomNumbers)
{
    if (randomNumber < 0) sumOfNegativeElements += randomNumber;
    if(randomNumber < minElement) minElement = randomNumber;
    if(randomNumber > maxElement)
    {
        maxElement = randomNumber;
        indexOfMaxElement = index;
    }
    if(Math.Abs(randomNumber) >  maxAbsElement) maxAbsElement = Math.Abs(randomNumber);
    if (randomNumber > 0) sumOfIndexesOfPositiveElements += index;
    if (randomNumber % 1 == 0) numberOfIntegers++;

    index++;
}

Console.WriteLine("Sum of negative elements is equal to: {0:F2}", sumOfNegativeElements);
Console.WriteLine("Minimal element is equal to: {0:F2}", minElement);
Console.WriteLine("Index of maximal element is equal to: {0}", indexOfMaxElement);
Console.WriteLine("Maximal absolute element is equal to: {0:F2}", maxAbsElement);
Console.WriteLine("Sum of indexes of positive elements: {0}", sumOfIndexesOfPositiveElements);
Console.WriteLine("Number of integer elements: {0}", numberOfIntegers);

