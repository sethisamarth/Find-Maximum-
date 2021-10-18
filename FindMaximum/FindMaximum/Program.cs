using System;

namespace FindMaximum
{
    class Program
    {
        public float FindMaximumFloat(float first, float second, float third)
        {
            if (first.CompareTo(second) > 0 && first.CompareTo(third) > 0)
            {
                return first;
            }
            else if (second.CompareTo(first) > 0 && second.CompareTo(third) > 0)
            {
                return second;
            }
            else if (third.CompareTo(second) > 0 && third.CompareTo(first) > 0)
            {
                return third;
            }
            else
            {
                Console.WriteLine("All three having same number");
                return -1;
            }
        }





        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine("Maximum value is : " + obj.FindMaximumFloat(89.2f, 25.43f, 155.85f));

            Console.ReadLine();
        }
    }
}
