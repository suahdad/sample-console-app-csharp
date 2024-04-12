
using System; 
using System.Globalization;
  
class sampleProgram4 { 
  
    // Main Method 
    static public void Main(String[] args) 
    { 
  
        String date = Console.ReadLine();
        try{
            Console.WriteLine(DateTime.ParseExact(date,"dd/MM/yyyy",CultureInfo.InvariantCulture));
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
        return;
    } 
}