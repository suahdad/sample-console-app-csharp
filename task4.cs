
using System; 
  
class sampleProgram4 { 
  
    // Main Method 
    static public void Main(String[] args) 
    { 
  
        String inputString = Console.ReadLine();
        try{
            int input = Int32.Parse(inputString);
        }catch{
            Console.WriteLine("Input cannot be parsed to Int");
        }
        return;
    } 
}