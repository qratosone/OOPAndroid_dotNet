
namespace ObjectCloneDemo
{
    class ClassB
    {
        public int BValue = 200;
    }
    class ClassA
    {
        public int AValue = 100;
        public ClassB EmbedObject;    //ClassA包容一个ClassB的对象
        public ClassA()
        {
            EmbedObject = new ClassB();		//创建被包容对象
        }
        public static ClassA CloneObject(ClassA obj)
        {
            ClassA newObj = new ClassA();
            newObj.AValue = obj.AValue;		//字段复制
            newObj.EmbedObject = obj.EmbedObject;	//引用复制
            return obj;
        }

    }
}
