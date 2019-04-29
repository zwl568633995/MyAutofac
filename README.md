# MyAutofac
模仿Autofac写一个IOC容器
常规操作Autofac几步曲：
1.创建ContainerBuilder()
2.注册数据类型RegisterTyper<T>()
3.创建IContainer,ContainerBuilder.Builder()
4.解析IContainer.Resolve<T>()
  
于是模仿Autofac乎，采用最常规的.NET技术栈（泛型，反射以及委托）来手写一个Autofac,当然和Autofac相比，九牛一毛，权当学习下Autofac原理，以便提升自己的代码水平  
  
