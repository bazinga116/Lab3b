using System;

class MainClass {
  public static void Main (string[] args) {
  int the;
   Console.WriteLine("Enter the salesperson name");
   string name = Console.ReadLine();
   Console.WriteLine("Enter the sales amount");
   string sales = Console.ReadLine();
   double commission = 200+(0.09*sales);
   Console.ReadLine();
   
   Console.WriteLine("Sales Commission for "+ name + " is " + commission );

   switch()
    {
      case "0-2999":
            
      {   
        Console.WriteLine("Performance is poor");
        break;
      }
      case "3000-4999":      
      {   
        Console.WriteLine("Performance is average");
        break;
      }
      case "5000-9999": 
            
      {   
        Console.WriteLine("Performance is good");
        break;
      }
      case "10000-14999":
      {
        Console.WriteLine("Performance is excellent");
        break;
      }
      case "15000-":
      {
        Console.WriteLine("Performance is outstanding");
        break;
      }
      default:
        Console.WriteLine("Unable to evaluate commission");
        break;
    }
    

 
  }
}
