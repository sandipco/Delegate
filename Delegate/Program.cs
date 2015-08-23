using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Delegate
{
    class Program
    {
        static void Main(string[] args)
        {
            book _book = new book();
            _book.Name = "The Jungle Book";
            _book.NameChanged = new NameChangedDelegate(nameChangedNotification);
            _book.Name = "Robinson Crusoe";
            Console.ReadLine();
        }
        static void nameChangedNotification(string oldValue, string NewValue)
        {
            Console.WriteLine("Name changed from {0} to {1}", oldValue, NewValue);
        }
    }
}
