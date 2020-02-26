using System;

class MainClass {
  public static void Main () {
    int i = 0;

    while (i < 5)
    {
      Console.WriteLine("One more time!");
      i++;
    }

    
    do 
    {
      Console.WriteLine("No more times!");
      i++;
    }
    while (i >= 5 && i < 20);

  }
}