using System;

class Program {
  public static void Main (string[] args) {
    int counter = 1;
    int totalSpeed = 0;
    
    while (counter < 8) {
      Console.WriteLine("Enter the distance covered by Car #" + counter);
      int distance = Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Enter the time taken by Car #" + counter);
      int time = Convert.ToInt32(Console.ReadLine());
      
      int speed = distance / time;
      Console.WriteLine("The speed of this car is " + speed + " miles per hour");
      
      totalSpeed = totalSpeed + speed;
      counter++;
    }
    
    int averageSpeed = totalSpeed / 7;
    Console.WriteLine("The average speed of the cars is " + averageSpeed);
  }
}