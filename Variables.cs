//Method/Function consists of :

public static void Main (string[] args) 
{
  Concole.WriteLine("Hello, I am a computer. I am sent from the future ha-ha"); //Calling the function
  Console.ReadKey(); //This is to show the string on the console and close it when any key is pressed on the keyboard.
}

//It is called when the program starts. 


//Variables 
//Multiplication

public static void Main (string[] args) 
{
  int num01; 
  int num02;
  
  Console.Write("Type a number to be multiplied: ");
  num01 = Convert.int32 (console.ReadLine());
  Console.Write("Type your second number: ");
  num02 = Convert.int32 (console.ReadLine());
  Console.Write("The result is: " + num01 * num02);
  console.readKey();
}


//Divide Program
public static void Main (string[] args) 
{
  Start:
    int num01; 
    int num02;
  
  Console.Write("Type a number to be divided: ");
  num01 = Convert.int32 (console.ReadLine());
  Console.Write("Type your second number: ");
  num02 = Convert.int32 (console.ReadLine());
  Console.Write(num01 + " divided by " + num02 " is " + num01 / num02);
  Console.readKey();
  Console.WriteLine();
  goto.Start;
}

//int num01; num01 = 20; int - is the data type, float - decimal, double is just like double, bool is a boolean (True, False), string is a text, char is used for a single character.
