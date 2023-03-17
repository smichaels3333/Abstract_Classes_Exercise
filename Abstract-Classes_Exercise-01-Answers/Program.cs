

// TODO: DONE - Create 3 concrete classes that inherit from the abstract Part class
// TODO: DONE - Implement the abstract class and add any extra functionality to your concrete class

// TODO: Instantiate all 3 concrete classes and give their members values 
using Abstract_Classes_Exercise_01_Answers;

var carpart1 = new CarPart(1, "Wheel Rim", 250.00m);
var truckPart1 = new TruckPart(2, "Wheel Rim", 350.00m);
var motorcyclePart = new MotorcyclePart(3, "Wheel Rim", 150.00m);

// TODO: Create a list of type Part and add the instances to the list
var partList = new List<Part>();
partList.Add(carpart1);
partList.Add(truckPart1);
partList.Add(motorcyclePart);

// TODO: Using a loop, execute each part's method Console.WriteLine() the result if the method isn't void
foreach (var part in partList)
{
	part.PrintPartInfo();
}

AddSpaces(1);

// Bonus: Call the PrintTotalPartCount() method
Part.PrintTotalPartCount();

void AddSpaces(int numberOfSpaces)
{
	while (numberOfSpaces > 0)
	{
		Console.WriteLine();
		numberOfSpaces--;
	}
}