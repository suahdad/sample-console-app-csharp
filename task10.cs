
using System; 
  
class Uppercase { 
    static private int factor(int input){
        if(input == 1) {return input;};
        return input*factor(input-1);
    }
    // Main Method 
    static public void Main(String[] args) 
    { 
  
        String num = Console.ReadLine();
        try{
            Console.WriteLine(factor(Int32.Parse(num)));
        }
        catch(Exception e){
            Console.WriteLine(e);
        }
        return;
    } 
}