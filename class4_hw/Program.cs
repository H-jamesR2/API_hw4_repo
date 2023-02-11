using System;
using System.Threading;
/* 
    Create a console app with a class that has an interface and push it to a git repo!
    Send me the link to the repository when done. 
    your class should have at least one interface and
        three different types of properties.
        // read-write, read-only, write-only
    the interface (and therefore, your class) should have at least three out of these four things:
    instance methods, properties, events, indexers.
    Make sure you have an instance of this class in main!

*/
namespace MyConsoleApplication
{
    /*
    // instance methods
    public interface MyDate
    {
        // Properties:
        string Month { get; set; }
        int X { get; set;  }
        int Y { get; set; }
    } */

    public interface IOrderingService
    {
        // Properties: 3-diff
        string Name { get; set; }
        int NumberOfOrders { get; }
        int CustomerNumber { set; }
        /*
        // Define delegate
        delegate void PackageEnrouteEventHandler(object source, EventArgs args);
        // Declare event
        event PackageEnrouteEventHandler PackageEnroute;

        void PrepareOrder(Order order); */

        // Indexers:
        string this[int index]
        {
            get; set;
        }
    }

    /*public class Script : MyScript
    {
 
    }*/
    /*
    class Date : MyDate
    {
        public Date(String month, int x, int y)
        {
            Month = month;
            X = x;
            Y = y;
        }
        public string Month { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
    } */

    // Events
    public class Order
    {
        public string Item;
    }
    public class PackageOrderingService : IOrderingService
    {
        //input1 = name, #ofOrders = default in class,
        //input2 = customerNumber;
        public static int customerNumber;

        private string _name;
        public string Name  // read-write instance property
        {
            get => _name;
            set => _name = value;
        }

        private int _numberOfOrders = 100;
        public int NumberOfOrders  // read-only instance property
        {
            get => _numberOfOrders;
        }

        private int _CustomerNumber;
        public int CustomerNumber
        {
            set => _CustomerNumber = value;
        }

        // constructor
        //public PackageOrderingService => _numberOfOrders = 100;

        //
        /*
        // Define delegate
        public delegate void PackageEnrouteEventHandler(object source, EventArgs args);
        // Declare event
        public event PackageEnrouteEventHandler PackageEnroute;

        public void PrepareOrder(Order order)
        {
            Console.WriteLine($"Preparing your package '{order.Item}', please wait...");
            Thread.Sleep(5000);

            OnPackageEnroute();
        }
        protected virtual void OnPackageEnroute()
        {
            if (PackageEnroute != null)
                PackageEnroute(this, null);
        } */


        private string[] arr = new string[100];
        public string this[int index]   // indexer declaration
        {
            // The arr object will throw IndexOutOfRange exception.
            get => arr[index];
            set => arr[index] = value;
        }

    }

    public class AppService
    {
        public void OnPackageEnroute(object source, EventArgs eventArgs)
        {
            Console.WriteLine("AppService: your package is enroute..");
        }
    }

    //Indexer
    /*
    public class SampleCollection<T>
    {
        private T[] arr = new T[100];
        // this refers to curr instance of class..
        public T this[int i]
        {
            get { return arr[i]; }
            set { arr[i] = value; }
        }
    } */

    class Program
    {
        /*
        static void PrintDateForDelivery(MyDate date)
        {
            Console.WriteLine($"{date.Month} {date.X}, {date.Y}.");//, date.Month, date.X, date.Y);
        } */
        static void Main(string[] args)
        {
            IOrderingService orderInfo = new PackageOrderingService();
            orderInfo.Name = "John Doe";
            orderInfo.CustomerNumber = 123;
            var numOrders = orderInfo.NumberOfOrders;
            Console.WriteLine(orderInfo.Name, 123, numOrders);

            //var stringCollection = IOrderingService.SampleCollection<string>;
            orderInfo[0] = "End Message. Encrypt and Send";
            Console.WriteLine(orderInfo[0]);

            /*
            var order = new Order { Item = "Vitamin Supplements 50mg" };
            //var orderingService = new PackageOrderingService();
            var appService = new AppService();
            orderInfo.PackageEnroute += appService.OnPackageEnroute;
            orderInfo.PrepareOrder(order);
            Console.ReadKey(); */

            /*MyDate d = new Date("February", 1, 2023);
            Console.Write("Shipment will be delivered by ");
            PrintDateForDelivery(d); */

            /*
            var stringCollection = new SampleCollection<string>();
            stringCollection[0] = "End Message.";
            Console.WriteLine(stringCollection[0]); */
        }
    }
}

