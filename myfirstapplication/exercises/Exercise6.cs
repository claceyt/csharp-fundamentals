using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace myfirstapplication.exercises
{
    internal class Exercise6
    {
        private int _showSize;
            private string _shoeType;
        public Exercise6(int showSize, string shoeType)
        {
            _showSize = showSize;
            _shoeType = shoeType;
        }

        public class ExerciseClass()
        {
            private int Integral
            {
                get { return Integral; }
                set { Intrgral = value; }
                
            }
        }
        public delegate void TryOn(string message);
        static void Main(string[] args)
        {
            TryOn testDelegate = new TryOn(DisplayMessage);
            testDelegate("Testing the TryOn Delegate");
            Public static void DisplayMessage(string message)
            {
                Console.WriteLine(message);
            }
        }






    }
}
