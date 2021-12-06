using System.Collections;
using System.Numerics;
using System.Text.RegularExpressions;

string[] inputData = System.IO.File.ReadAllLines(@"C:\Users\robin\OneDrive\Skrivbord\inputdataPusselNr3.txt");
string[] sampleData = new string[] { "001001111010", "110101111010", "101111001111", "110010000110", "010001001010" };






for (int i = 0; i < sampleData.Length; i++)
{

    if (sampleData[i].Substring(0,1) == "0")
    {
        Console.WriteLine("Negativt");
    }
    else if (sampleData[i].Substring(0,1) == "1")
    {
        Console.WriteLine("Positivt");
    }
        
        
}



