namespace test002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            headP("myเอง");

            while (true)
            {

                line("-", 40);
                double weight = 0.0;
                double hight = 0.0;
                Console.Write("ใส่น้ำหนัก: ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                //weight = Convert.ToDouble(Console.ReadLine());
                if (double.TryParse(Console.ReadLine(), out weight) == false)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("ใส่ส่วนสูง: ");
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                //hight = Convert.ToDouble(Console.ReadLine());
                if (!double.TryParse(Console.ReadLine(), out hight))
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }
                Console.ForegroundColor = ConsoleColor.White;
                line("-", 40);
                conm(weight, hight);
                line("-", 40);

                color("ถ้าไม่ต้องการทำรายการต่อให้พิมพ์ 'N' :", ConsoleColor.Red, ConsoleColor.Black);
                Console.ForegroundColor = ConsoleColor.Green;
                string yn_1 = Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.White;
                if (yn_1 == "N" | yn_1 == "n")
                {
                    break;
                }
           
            }

            static void line(string letter, int width)
            {

                string str = "";
                for (int i = 0; i < width; i++)
                {
                    str += letter;
                }
                Console.WriteLine(str);
            }

            static void headP(string nume_1)
            {
                Console.WriteLine("โปรแกรมคำนวนหาค่า BMI");
                line("*", 40);
                Console.WriteLine("ทำโดย"+nume_1);
            }

            static void conm(double weight , double hight)
            {
                double sum_1 = weight / Math.Pow(hight / 100, 2);
                string result = "";
                if (sum_1 < 18.5)
                {
                    result = "ผอม";
                }
                else if (sum_1 < 25)
                {
                    result = "ปกติ";
                }
                else if (sum_1 < 30)
                {
                    result = "อ้วน";
                }
                else
                {
                    result = "โรคอ้วน";
                }
                color("ค่าBMI = " + sum_1.ToString("F2"), ConsoleColor.Green, ConsoleColor.Black);
                color("ผลลัพธ์= " + result, ConsoleColor.Green, ConsoleColor.Black);
                
            }

            static void color(string text , ConsoleColor fg, ConsoleColor bg)
            {
                Console.ForegroundColor = fg;
                Console.BackgroundColor = bg;

                Console.WriteLine(text);

                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }

            





        }
    }
}

        //double sum_1 = weight / (height * height);
        /* if (sum_1 < 18.5)
         {
             Console.WriteLine("ผอม");
         }
         else if (sum_1 < 25)
         {
             Console.WriteLine("ปกติ");
         }
         else if (sum_1 < 30)
         {
             Console.WriteLine("อ้วน");
         }
         else
         {
             Console.WriteLine("อ้วนเกินไป");


         double sum_1 = weight /Math.Pow(hight/100 , 2);
         Console.Write("ค่าBMI: ");
         if (sum_1 < 18.5)
          {
              Console.WriteLine("ผอม");
          }
          else if (sum_1 < 25)
          {
              Console.WriteLine("ปกติ");
          }
          else if (sum_1 < 30)
          {
              Console.WriteLine("อ้วน");
          }
          else
          {
              Console.WriteLine("โรคอ้วน");
          }
         }*/

