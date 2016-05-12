using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Chap4_1_Thread
{
    public class MyClass
    {
        public static void StaticMethod()
        {
            Console.WriteLine("线程{0}执行MyClass.StaticMethod", Thread.CurrentThread.ManagedThreadId);
        }
        public void InstanceMethod()
        {
            Console.WriteLine("线程{0}执行MyClass.InstanceMethod", Thread.CurrentThread.ManagedThreadId);
        }
    }
    class Program
    {
        static void ThreadAMethod()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("辅助线程正在执行:" + i.ToString());
                Thread.Sleep(200);
            }
            Console.WriteLine("辅助线程执行结束");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("main thread ID:{0}", Thread.CurrentThread.ManagedThreadId);
            MyClass obj = new MyClass();
            Thread th1 = new Thread(new ThreadStart(MyClass.StaticMethod));
            Thread th2 = new Thread(new ThreadStart(obj.InstanceMethod));
            //ThreadStart是一个委托
            Thread th3 = new Thread(MyClass.StaticMethod);
            //简化写法
            th1.Start();
            th2.Start();
            th3.Start();
            //用Start方法开始执行线程
            Console.WriteLine("主线程{0}任务执行完毕，敲任意键退出", Thread.CurrentThread.ManagedThreadId);
            Console.ReadKey();
            //以下为线程的睡眠
            Thread sleeper = new Thread(()=>{
                for (int i = 0; i <10; i++)
                {
                    Thread.Sleep(100);
                    Console.WriteLine("第{0}次睡眠", i);
                }
            });
            sleeper.Start();
            Console.WriteLine("睡眠结束");//注意主线程和sleeper是并行运行的
            Console.ReadKey();
            //使用join方法让主线程等待子线程
            Console.WriteLine("join方法演示");
            Thread waiting = new Thread(ThreadAMethod);
            waiting.Start();
            waiting.Join();
            Console.WriteLine("主线程结束");
            Console.ReadKey();
            //线程状态

            Console.WriteLine("显示线程状态");
            Thread status = new Thread(() =>
            {
                Console.WriteLine(Thread.CurrentThread.ThreadState);
            });
            Console.WriteLine(status.ThreadState);
            status.Start();
            status.Join();
            Console.WriteLine(status.ThreadState);
            Console.ReadKey();
        }
    }
}
