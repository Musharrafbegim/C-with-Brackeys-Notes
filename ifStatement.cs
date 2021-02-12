class mainClass 
{
  public static void Main (string[] args)
    {
      Console.WriteLine("How old are you?");
      int age = Convert.ToInt32(Console.ReadLine());
      
      if(age < 18) {
        Console.WriteLine("That is too bad. You will have to wait a couple of years, dear.");
      }else if (age == 18) {
        Console.WriteLine("Good! You are good to go!!")
      }else {
        Console.WriteLine("You are welcome!")
      }
      
      Console.ReadKey();
    }
}

//Here we are using if statements to check if the user is okay to use a program or not. We can use else if if we want to check another condition.

//Homework Challenge
class mainClass 
{
  public static void Main (string[] args)
    {
      int num01 = 4;
      int num02 = 2;
      
       Console.WriteLine("What is" + num01 " divided by " + num02 " ? ");
       
       int answer = Convert.ToInt32 (Console.ReadLine());
       
       if(answer == num01 / num02) {
        Console.WriteLine("Good job! You are welcome!");
      }else {
        Console.WriteLine("Come on! it is a simple math!!!")
      }
      
      Console.ReadKey();
    {
}
