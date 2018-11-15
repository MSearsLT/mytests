using System;  

class Program  
{  
    static void Main()  
    {  
#if DebugConfig  
        Console.WriteLine("WE ARE IN THE DEBUG CONFIGURATION");  
#endif  

        Console.WriteLine("Demo program for understanding how MSBuld works. Thanks for playing!");
        Console.WriteLine("I've added this great feature!");
        Console.WriteLine("I've made an update to the new feature");   
        Console.Read();
    }  
}  