
using System; 
  
class Square { 
  
    // Main Method 
    static public void Main(String[] args) 
    { 
  
        String num = Console.ReadLine();
        try{
            Console.WriteLine(System.Math.Sqrt(Double.Parse(num)));
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
        return;
    } 
}