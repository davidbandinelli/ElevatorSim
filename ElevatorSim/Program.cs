using System;
using System.Threading;

namespace OOP
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Elevator el = new Elevator(5);
            el.GoToFloor(3);
            Console.WriteLine(String.Format("Current Floor={0}", el.CurrentFloor));
        }
    }
   
}
