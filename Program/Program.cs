using System;
    public class Store_Class
    {
        public string Name;
        public string Owner;
        public double Number;
        public double Value;
        public static double[] exchange(double input){
            float box=0;
            double[] database={0,0,0,0,0,0,0,0,0,0,0};
            double d = (input%1)*100;
            if (input<= 0 || (d != 50 && d != 25 && d!=0 && d!=75))
                Console.WriteLine("Input Error");
            else
            {
                //Console.WriteLine("1000 : {0}",(int)(input/1000));
                database[0]=(int)(input/1000);
                box=(int)(input%1000);
                //Console.WriteLine("500 : {0}",(int)(box/500));
                database[1]=(int)(box/500);
                box=(int)(input%500);
                //Console.WriteLine("100 : {0}",(int)(box/100));
                database[2]=(int)(box/100);
                box=(int)(input%100);
                //Console.WriteLine("50 : {0}",(int)(box/50));
                database[3]=(int)(box/50);
                box=(int)(input%50);
                //Console.WriteLine("20 : {0}",(int)(box/20));
                database[4]=(int)(box/20);
                box=(int)(input%20);
                //Console.WriteLine("10 : {0}",(int)(box/10));
                database[5]=(int)(box/10);
                box=(int)(input%10);
                //Console.WriteLine("5 : {0}",(int)(box/5));
                database[6]=(int)(box/5);
                box=(int)(input%5);
                //Console.WriteLine("2 : {0}",(int)(box/2));
                database[7]=(int)(box/2);
                box=(int)(input%2);
                //Console.WriteLine("1 : {0}",(int)(box/1));
                database[8]=(int)(box/1);
                //Console.WriteLine(".50 : {0}",(int)(d/50));
                database[9]=(int)(d/50);
                d=d%50;
                database[10]=(int)(d/25);
                //Console.WriteLine(".25 : {0}",(int)(d/25));
            }
            Print_exchange(database);
            return database;
     
        }

        public static void Print_exchange(double[] d){
            Console.WriteLine("1000 : "+d[0]);
            Console.WriteLine("500 : "+d[1]);
            Console.WriteLine("100 : "+d[2]);
            Console.WriteLine("50 : "+d[3]);
            Console.WriteLine("20 : "+d[4]);
            Console.WriteLine("10 : "+d[5]);
            Console.WriteLine("5 : "+d[6]);
            Console.WriteLine("2 : "+d[7]);
            Console.WriteLine("1 : "+d[8]);
            Console.WriteLine(".50 : "+d[9]);
            Console.WriteLine(".25 : "+d[10]);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Store_Class s1 = new Store_Class();
            Console.WriteLine("--------------  1.1 --------------------");
            Console.Write("Please input Name : ");
            s1.Name = Console.ReadLine();
            Console.Write("Please input Number : ");
            s1.Number = double.Parse(Console.ReadLine());
            Console.Write("Please input Owner Name : ");
            s1.Owner = Console.ReadLine();
            Console.Write("Please input Registerd Value : ");
            s1.Value = double.Parse(Console.ReadLine());


            Console.WriteLine("-----------Shop Information--------------");
            Console.WriteLine("Name : "+s1.Name);
            Console.WriteLine("Number : " + s1.Number);
            Console.WriteLine("Owner name : " + s1.Owner);
            Console.WriteLine("Registered Value : " + s1.Value);


            Console.WriteLine("--------------  1.2 --------------------");
            Console.Write("Please input money : ");
            double Money = double.Parse(Console.ReadLine());
            Store_Class.exchange(Money);
            //s1.exchange(double.Parse(Console.ReadLine()));
        }
    }
