
using System; 
  
class sampleProgram4 { 
  
    // Main Method 
    static public void Main(String[] args) 
    { 
  
        String num = Console.ReadLine();
        String denom = Console.ReadLine();
        try{
            Double input = Double.Parse(num);
            Double input2 = Double.Parse(denom);
            Console.WriteLine(input/input2);
        }
        catch(DivideByZeroException){
            Console.WriteLine("Division of {0} by zero.", input2);
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
        return;
    } 
}