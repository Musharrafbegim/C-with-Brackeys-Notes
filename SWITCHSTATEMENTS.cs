class mainClass 
{
  public static void Main (string[] args)
    {
    
      Random Generator = new Random(); //It generates new numbers , works as if it is an object
    
      int num01 = Generator.Next(1, 35);
      int num02 = Generator.Next(1, 6);
      
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
