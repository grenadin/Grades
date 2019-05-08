using System;


namespace Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            #region A1
            //GradeBook g1 = new GradeBook();
            //GradeBook g2 = g1;

            //g1.Name = "Harirak";
            //Console.WriteLine($" g2 = {g2.Name}");
            //g2.Name = "toon";
            //g1 = new GradeBook();//g1 have a new allocate. it's not point to previous box.

            //Console.WriteLine($" g1 = {g1.Name}");
            #endregion


            #region previous code

            GradeBook book = new GradeBook();

            book.NameChanged += OnNameChanged;
            book.NameChanged += OnToon;
            



            book.Name = "Harirak";


            book.AddGrade(91);
            book.AddGrade(89.5f);
            book.AddGrade(35);
            book.AddGrade(41);
            Console.WriteLine("hi");
            book.Name = "Somtavil";








            GradeStatistics stats = book.ComputeStatistics();

            Console.WriteLine($"Show Highest Grade {stats.HighestGrade}");
            Console.WriteLine($"Show Lowest Grade {stats.LowestGrade}");
            Console.WriteLine($"Show Average Grade {stats.AverageGrade}");

            Console.ReadLine();

            book.Name = "hi Gradebook";
            GradeBook book2 = new GradeBook();


            Logger aa = new Logger();
            Writer oo = new Writer(aa.M);



            Writer write = new Writer(new Logger().WriteMessage);// new Logger().WriteMessage = Logger logger = new Logger();
                                                                 //                             Writer write = new Writer(logger.WriteMessage);
            write("hi");



            Writer write1 = new Writer(new Logger().M);

            write1("hi");

            write = new Writer(new Logger2().WriteMessageOfLogger2);
            write("call from logger2");
            book.Name = "Toon";
            #endregion




        }


            static void OnNameChanged(object sender, NameChangedEventArgs args)
            {
                Console.WriteLine($"Gradebook is Changing name from " +
                    $"{args.ExistingName}" +
                    $" to {args.NewName}");
            }


        static void OnToon(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Toon Events"+
                $"{args.ExistingName}" +
                $" to {args.NewName}");
        }



    }





        class Logger
        {
            public void WriteMessage(string message)
            {
                Console.WriteLine(message);
                Console.ReadLine();
            }

            public event Writer De;

            public void M(string message)
            {
                Console.WriteLine(message);
                Console.WriteLine("oh");
                Console.ReadLine();
            }
        }

        class Logger2
        {
            public void WriteMessageOfLogger2(string message)
            {
                Console.WriteLine(message);
                Console.WriteLine($"Logger 2 Run");

                Console.ReadLine();
            }
        }

        public delegate void Writer(string message); //Declare Delegate Type by insert delegate type infront of Method that use Delegate.
                                                     //Because when Call Method for create Specific instance that reference Method
                                                     //Not Reference Box of Heap.
    
}
