//Thread[] threads = new Thread[5];

//var sync = new object();

//for (int i = 0; i < 5; i++)
//{
//    threads[i] = new Thread(() =>
//    {
//        Counter.count++;
//    });

//    threads[i] = new Thread(() =>
//    {
//        for (int j = 0; j < 1000000; j++)
//        {
//            //Counter.count++;



//            #region Way1 Interlocked
//            //Interlocked class dan istifade ederek incriment etmek
//            //menfi ceheti nedir - yalniz bir deyiwen ucun gunceleme ede bilersen
//            //Interlocked.Increment(ref Counter.count);
//            #endregion


//            #region Way2 Monitor
//            //Monitor.Enter(sync);

//            //try
//            //{
//            //    Counter.count++;
//            //}
//            //finally
//            //{
//            //    Monitor.Exit(sync);
//            //}
//            #endregion


//            #region Way3 Lock
//            lock (sync)
//            {
//                Counter.count++;
//            }
//            #endregion

//        }
//    });

//}

//for (int i = 0; i < 5; i++) threads[i].Start();
//for (int i = 0; i < 5; i++) threads[i].Join();


//Console.WriteLine($"Count: {Counter.count}");

//static class Counter
//{
//    public static int count = 0;
//}



//President p1 = President.GetInstance();
//President p2 = President.GetInstance();
//President p3 = President.GetInstance();


//Console.WriteLine(p1.GetHashCode());
//Console.WriteLine(p2.GetHashCode());


//Console.WriteLine(p1);
//Console.WriteLine(p2);
//Console.WriteLine(p3);


//class President
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public int Height { get; set; }

//    private President() { }

//    private static President _instance;
//    private static object _lock = new object();


//    public static President GetInstance()
//    {
//        if (_instance == null)
//        {
//            lock (_lock)
//            {
//                if (_instance == null)
//                {
//                    _instance = new President { Name = "Presindent", Surname = "Presidentzade", Height = 195 };
//                }
//            }
//        }



//        return _instance;
//    }

//    public override string ToString()
//    => $"Name:{Name}\nSurname:{Surname}\nHeight:{Height}\n";


//}



//using System;
//using System.Threading;

//class Program
//{
//    static void Main(string[] args)
//    {
//        Thread[] threads = new Thread[10];

//        for (int i = 0; i < 10; i++)
//        {
//            threads[i] = new Thread(() =>
//            {
//                President p = President.GetInstance();
//                Console.WriteLine($"Instance HashCode: {p.GetHashCode()}");
//            });
//            threads[i].Start();
//        }

//        for (int i = 0; i < 10; i++)
//        {
//            threads[i].Join();
//        }
//    }
//}

//class President
//{
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public int Height { get; set; }

//    private President() { }

//    private static President _instance;

//    public static President GetInstance()
//    {
//        if (_instance == null)
//        {
//            _instance = new President { Name = "President", Surname = "Presidentzade", Height = 195 };
//        }
//        return _instance;
//    }

//    public override string ToString()
//    => $"Name: {Name}, Surname: {Surname}, Height: {Height}";
//}



//var object1 = new object();
//var object2 = new object();



//void ObliviousFunction()
//{
//    lock (object1)
//    {
//        Console.WriteLine("critical 1_0");
//        Thread.Sleep(500); // wait for the blind to lead

//        lock (object2)
//        {
//            Console.WriteLine("critical 1");
//        }
//    }
//}


//void BlindFunction()
//{
//    lock (object2)
//    {
//        Console.WriteLine("critical 2_0");
//        Thread.Sleep(500); // wait for oblivion

//        lock (object1)
//        {
//            Console.WriteLine("critical 2");
//        }
//    }
//}




//new Thread(ObliviousFunction).Start();
//new Thread(BlindFunction).Start();