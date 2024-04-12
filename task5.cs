
using System; 
using System.Collections.Generic;
  
class sampleProgram4 { 
  
    // Main Method 
    static public void Main(String[] args) 
    { 
  
        String inputString = Console.ReadLine();
        try{

            List<String> intArray = new List();
            String[] strArray = inputString.Split(',');
            Console.WriteLine(String.join(intArray,"."));
        }catch{
            Console.WriteLine("Input cannot be parsed to Int");
        }
        return;
    } 
}