using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    class Program
    {
      public MasterMindParam param = new MasterMindParam(4, 1, 6, 10, "-", "+", false);

        static void Main(string[] args)
        {
            Console.Title = "Mastermind";
            Int32 option1 = DisplayMainMenu();
            Program pr = new Program();
            MainCall(option1,pr);
            Console.Read();



        }
        private static void MainCall(Int32 option,Program pr)
        {
             
            switch (option)
            {
                case 1:
                   pr.start(pr.param);
                    break;
                case 2:
                    pr.setting(pr.param,pr);
                   
                    Int32 option11 = DisplayMainMenu();
                   MainCall(option11,pr);
                    break;
            
                case 3:
                    Console.WriteLine("BYEEEEEEEEEEEEEEEEEEEEE!!!!!!!!!!!!!!!!!!!");
                    break;
                default:
                    Console.WriteLine("Invalid Input!!!!!!Re-Enter");
                    Console.ReadKey();
                    Console.Clear();
                    int option1 = DisplayMainMenu();
                    MainCall(option1,pr);
                   
                    break;
                    
            }
        }

        private static int DisplayMainMenu()
        {
            Console.WriteLine("\nSelect any option:");
            Console.WriteLine("1. Start MasterMind");
            Console.WriteLine("2. Setting MasterMind");
            Console.WriteLine("3. Exit");

            Int32 option = 0;
            try
            {
                option = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Some Error Occured");
            }
            return option;
        }

        void start(MasterMindParam param)
           {


            Console.WriteLine("Enter a {0} digit number, e.g. 123",param.NumberOfDigits);
            Console.WriteLine("each digit between the number {0} and {1}" ,param.RangeStarts,param.RangeEnds);
            Console.WriteLine("each digit must be unique");
            Console.WriteLine("you have {0} attempts to guess the number correctly",param.Attemps);
            Random rnd = new Random();
            //generate random digits
             int[] target = new int[param.NumberOfDigits];
          //  int[] target = { 1, 3};
              while (target.Distinct().Count() != param.NumberOfDigits)
             {
                 for (int x = 0; x < param.NumberOfDigits; x++)
                 {
                     target[x] = rnd.Next(param.RangeStarts, param.RangeEnds);
                 }
             } 

            while (param.Attemps > 0)
            {
                string userInput = Console.ReadLine();
                param.Attemps--;
                List<int> userNumber = userInput.Select(v => v - '0').ToList();
                int countCorrect = 0;
                int positionCorrect = 0;
                string oneresult = "";
             
                    //check if the input is param.NumberOfDigits by defaults (4) digits  
                    //else message for the user with the number of attemps remain
                    if (userNumber.Count == param.NumberOfDigits  )
                    {
                        //check if the input is in the range of {1,6}
                        if (userNumber.All(x => x >= param.RangeStarts && x <= param.RangeEnds))
                        {
                            //check if the array contain only distinct element
                            if (userNumber.Distinct<int>().Count() == userNumber.Count())
                            {
                                for (int c = 0; c < param.NumberOfDigits; c++)
                                {
                                    if (target[c] == userNumber[c])
                                    {
                                        if (c != 0)
                                        {
                                            positionCorrect++;
                                            oneresult = oneresult + " | " + param.CorrectPosition + userNumber[c];
                                        }
                                        else
                                        {
                                        positionCorrect++;
                                        oneresult = oneresult + " " + param.CorrectPosition + userNumber[c];
                                        }
                                    }
                                    else
                                    {
                                        if (target.Contains(userNumber[c]) && target[c] != userNumber[c])
                                        {
                                            if (c != 0)
                                            {
                                                countCorrect++;
                                                oneresult = oneresult + " |  " + param.CorrectWrongPosition + userNumber[c];
                                            }
                                            else
                                            {
                                                oneresult = oneresult + " " + param.CorrectWrongPosition + userNumber[c];
                                            }
                                        }
                                        else
                                        {
                                            if (!target.Contains(userNumber[c]) && target[c] != userNumber[c])
                                            {
                                                countCorrect++;
                                                if (c != 0)
                                                {
                                                    oneresult = oneresult + " |  ";
                                                }
                                                else
                                                {
                                                    oneresult = oneresult + "   ";
                                                }

                                            }
                                        }
                                    }



                                }
                             //display the result for the user
                             Console.WriteLine(oneresult.ToString());
                         //   Console.WriteLine((target[0]).ToString()+ (target[1]).ToString());

                            Console.WriteLine(positionCorrect.ToString());
                            if (positionCorrect==param.NumberOfDigits)
                             {
                               Console.WriteLine("All correct ");
                                Console.ReadKey();
                                Console.Clear();
                                break;  
                             }
                            if(param.Attemps==0)
                            {
                                 Console.WriteLine("Game Over ");
                                Console.ReadKey();
                                Console.Clear();
                                break;

                            }
                        }
                            else
                            {
                                Console.WriteLine("message 3)every digit must be unique");

                            }
                        }
                        else
                        {
                            Console.WriteLine("message 2)every digit must be between the number {0} and {1}", param.RangeStarts, param.RangeEnds);
                            Console.WriteLine("you must enter 4 digits you still have : " + (param.Attemps).ToString() + " attemps");

                        }
                    }
                    else
                    {
                        Console.WriteLine("message 1) you must enter {0} digits you still have {1} attemps ", param.NumberOfDigits, (param.Attemps).ToString());
                    }
              
            }
           
        }
         void setting(MasterMindParam paramm,Program pr)
        {
            Int32 result = 0;
            
            try
            {
               
                 
                    Console.WriteLine("Enter The lenght of the random generated answer ");
                    param.NumberOfDigits = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the number of attemps");
                    param.Attemps = int.Parse(Console.ReadLine());
                   
                    Console.WriteLine("updated successfully");
                Console.ReadKey();
                Console.Clear();
                    Int32 option1 = DisplayMainMenu();
                    MainCall(option1,pr);
                 
            }
            catch (Exception)
            {
                Console.WriteLine("Some Error Occured!! Please select right option");
                Console.WriteLine("-----------------------------------------------");
                Int32 option1 = DisplayMainMenu();
                MainCall(option1,pr);
            }
          
        }
        
    }
}
