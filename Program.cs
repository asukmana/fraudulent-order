// See https://aka.ms/new-console-template for more information
// array exercise from https://www.freecodecamp.org/learn/foundational-c-sharp-with-microsoft/create-and-run-simple-c-sharp-console-applications/store-and-iterate-through-sequences-of-data-using-arrays-and-the-foreach-statement-in-c-sharp

string[] fraudulentOrderIDs = new string[8];

fraudulentOrderIDs[0] = "B123";
fraudulentOrderIDs[1] = "C234";
fraudulentOrderIDs[2] = "A345";
fraudulentOrderIDs[3] = "C15";
fraudulentOrderIDs[4] = "B177";
fraudulentOrderIDs[5] = "G3003";
fraudulentOrderIDs[6] = "C235";
fraudulentOrderIDs[7] = "B179";

foreach (string fraudulentOrderID in fraudulentOrderIDs)
{
    if (fraudulentOrderID.StartsWith('B'))
    {
        Console.WriteLine(fraudulentOrderID);
    }
}