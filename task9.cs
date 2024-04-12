
using System; 
  
class Uppercase { 
  
    // Main Method 
    static public void Main(String[] args) 
    { 
  
        String num = Console.ReadLine();
        try{
            Console.WriteLine(num.ToUpper());
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
        return;
    } 
}