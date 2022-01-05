using System;

namespace ConsoleApp6
{
    public class A
    {

        public string name;
        //4 A의 생성자가 인스턴스를 생성
        // 이름을 강제한다
        public A()
        {
            //안녕
            name = "한빈";
        }
    }

    public class B
    {
        //2생성자가 B의 인스턴스를 생성

        //3 A의 객체 a12를 생성
        public A a12 = new A();
      
    }

    public class Program
    {
       
        public static void Main(string[] args)
        {
            //1 B 클래스의 인스턴스 b를 생성
            B b = new B();

            //6 생성된 b인스턴스 안에 생성된 A클래스의 인스턴스인 a12의 이름 속성을 가져온다
           Console.WriteLine( b.a12.name);
            
           

        }
    }
}
