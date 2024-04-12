using System; 
using System.IO; 
  
class sampleProgram4 { 
  
    // Main Method 
    static public void Main(String[] args) 
    { 
  
        String filePath = Console.ReadLine();
        try{
            File.Open(filePath,FileMode.Open);
        }catch{
            Console.WriteLine("File doesn't exist");
        }
        return;
    } 
}