
using System; 
  
class sampleProgram { 
  
    // Main Method 
    static public void Main(String[] args) 
    { 
  
        String inputString = Console.ReadLine();
        int input = Int32.Parse(inputString);
        if(input < 0 || input > 1000) Console.WriteLine(new Exception("Invalid Input"));
        return;
    } 
}