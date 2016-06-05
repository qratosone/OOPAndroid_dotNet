using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
namespace Thread_Using
{
    class ThreadHelper
    {
        public int x;
        public int y;
        public int return_value;
    }
    class Program
    {
        static void show_func(object p) //必须是static函数并且使用object作为参数
        {
            int num = Convert.ToInt32(p);
            Console.WriteLine("显示{0}", num);
        }
        static int plus_func(int a,int b)
        {
            return a + b;
        }
        static void show_func_2(object argu)
        {
            int x = (argu as ThreadHelper).x;
            int y = (argu as ThreadHelper).y;
            int result = x + y;
            (argu as ThreadHelper).return_value = result;
        }
        static void Main(string[] args)
        {
            //使用无返回值单一参数的委托
            Thread no_return = new Thread(new ParameterizedThreadStart(show_func));
            Console.WriteLine("启动show_func");
            no_return.Start(10);
            Console.ReadKey();
            //对于多参数，有返回值的函数
            var argu = new ThreadHelper();//定义一个线程参数辅助类
            argu.x = 23;
            argu.y = 33;
            Thread complex_func = new Thread(new ParameterizedThreadStart(show_func_2));
            complex_func.Start(argu);
            complex_func.Join();
            int thread_result = argu.return_value;
            Console.WriteLine(thread_result.ToString());
            Console.ReadKey();//使用辅助对象作为参数——这是一个比较通用的方法

        }
    }
}
