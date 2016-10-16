using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace SortArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MyThread obj = new MyThread();
            obj.createArr = CreateIntArray;
            obj.showArr = ShowArray;
            Thread th = new Thread(obj.SortArray);
            th.Start();
            Console.ReadKey();
        }
        static int[] CreateIntArray()
        {
            int[] arr = new int[10];
            Random ran = new Random();
            for (int  i = 0;  i< 10; i++)
            {
                arr[i] = ran.Next(1, 100);
            }
            return arr;
        }
        static void ShowArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine();
        }
    }
    public delegate int[] CreateIntArrayDelegate();
    public delegate void ShowArrayDelegate(int[] arr);
    class MyThread
    {
        public CreateIntArrayDelegate createArr;
        public ShowArrayDelegate showArr;
        public void SortArray()
        {
            int[] arr = createArr();
            Console.WriteLine("Original Array: ");
            showArr(arr);
            Array.Sort(arr);
            Console.WriteLine("After Sorting: ");
            showArr(arr);
        }
    }
}
