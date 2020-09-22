using System;

namespace Stopwatch
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datetime = new DateTime();
            Stopwatch st = new Stopwatch();
            int[] arr = new int[10];

            st.InputArray(ref arr);
            Console.WriteLine(st.Start());
            st.SortArray(ref arr);
            st.ShowArray(arr);

            Console.WriteLine(st.End());
            Console.WriteLine(st.GetElapsedTime());
        }
    }
}
