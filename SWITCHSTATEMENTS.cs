class mainClass 
{
  public static void Main (string[] args)
    {
    
      Random Generator = new Random(); //It generates new numbers , works as if it is an object
    
      int num01 = Generator.Next(1, 35);
      int num02 = Generator.Next(1, 6);
      
       Console.WriteLine("What is" + num01 " times " + num02 "?");
       
       int answer = Convert.ToInt32 (Console.ReadLine());
       
       if(answer == num01 / num02) {
        Console.WriteLine("Good job! You are welcome!");
         int responseIndex = Generator.Next(1, 4);
         switch(responseIndex){
             case 1:
             Console.WriteLine("I am proud of you!");
             break;
           case 2:
             Console.WriteLine("Well done, man");
             break;
             
             default:
             Console.WriteLine("Attabooooy!!!!!!");
             break;
      }else {
        int diff Math.Abs (answer - (num01 * num02));
           if (diff == 1){
            Console.WriteLine("Gosh that was close")
           }else if (diff <= 10){
            Console.WriteLine("You can definitely do better!")
           }else{
            Console.WriteLine("You are not even close....")
           }
         }
        Console.WriteLine("Come on! it is a simple math!!!")
      }
      
      Console.ReadKey();
    {
}
    
//Homework 
    
    
    
    
