using System;

namespace ObjectCloneDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectCopyViaFieldCopy();
            //ObjectCopyViaFieldCopy2();
            Console.ReadKey();
        }
        /// <summary>
        /// 基于字段值拷贝的简单对象复制
        /// </summary>
        static void ObjectCopyViaFieldCopy()
        {
            MyClass obj = new MyClass();
            MyClass other = MyClass.CloneObject(obj);
            Console.WriteLine("原对象：{0},新对象：{1}", obj, other);
            Console.WriteLine(obj == other);
            Console.WriteLine(obj.Equals(other));
        }
        /// <summary>
        /// 基于字段值拷贝的组合对象复制
        /// </summary>
        static void ObjectCopyViaFieldCopy2()
        {
            ClassA obj = new ClassA();
            ClassA other = ClassA.CloneObject(obj);
            Console.WriteLine(obj == other);
            Console.WriteLine(obj.AValue == other.AValue);
            Console.WriteLine(obj.EmbedObject == other.EmbedObject);
            Console.WriteLine(obj.EmbedObject.BValue == obj.EmbedObject.BValue);

        }


    }
}
