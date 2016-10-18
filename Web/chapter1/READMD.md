### 对于本次作业的说明

解决方案`HW01.sln`一共包括两个部分：服务器`HTTPServer`和客户端`Client`

前者建立之后会对`HttpPost`进行监听——`Client`运行的时候，首先输入一个IP地址，然后与服务器建立连接。

两者都定义了一个类`Binary`，可以将两个整数封装在类中。

运行的时候`Client`会读取两个数字的输入，建立一个`Binary`类的对象，然后将其使用JSON发送给服务器。

服务器在收到JSON之后，将其反序列化得到类，执行加法运算，并将结果以`message`的形式发送给客户端。

### 部署方法

服务器基于ASP.net Core，在Windows下可以直接使用IIS进行部署。