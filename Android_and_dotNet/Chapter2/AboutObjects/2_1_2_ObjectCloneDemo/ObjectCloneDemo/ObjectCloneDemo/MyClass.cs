
namespace ObjectCloneDemo
{
    class MyClass
    {
        private int MyClassValue = 100;
        public override string ToString()
        {
            return "MyClassValue:" + MyClassValue;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || obj is MyClass == false)
            {
                return false;
            }
            return MyClassValue == (obj as MyClass).MyClassValue;
        }
        public override int GetHashCode()
        {
            return MyClassValue;
        }

        public static MyClass CloneObject(MyClass obj)
        {
            MyClass newObj = new MyClass();
            newObj.MyClassValue = obj.MyClassValue;		//字段复制
            return newObj;
        }

    }
}
