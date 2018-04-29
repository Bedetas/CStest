using System;

namespace DeepCopy
{
    class Myclass
    {
        public int MyField1;
        public int MyField2;

        public Myclass DeepCopy()
        {
            Myclass newCopy = new Myclass();//인스턴스 메소드 생성
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("얕은 복사(Shallow Copy)");

            Myclass Shallow = new Myclass();//인스턴스 메소드 호출 방법
            Shallow.MyField1 = 10;
            Shallow.MyField2 = 20;

            Myclass targetS = Shallow;//새로운 메소드를 만듦
            targetS.MyField2 = 30;

            Console.WriteLine("{0},{1}", Shallow.MyField1, Shallow.MyField2);
            Console.WriteLine("{0},{1}", targetS.MyField1,targetS.MyField2);

            Console.WriteLine();

            Console.WriteLine("깊은 복사(Deep Copy)");

            Myclass Deep = new Myclass(); //Deep이란 Myclass의 인스턴스 메소드를 만들어서
            Deep.MyField1 = 10;
            Deep.MyField2 = 20;

            Myclass targetD = Deep.DeepCopy();// Myclass 의 Deep 인스턴스를 갖고와서 따로 메모리에 저장 후 값을 호출함.
            targetD.MyField2 = 30;

            Console.WriteLine("{0},{1}", Deep.MyField1,Deep.MyField2);
            Console.WriteLine("{0},{1}",targetD.MyField1,targetD.MyField2);

        }
    }
}
