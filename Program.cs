using System;

namespace Cs_3_ex1
{
    class Program
    {
        class person
        {
            private int age;
            private string name, city, phoennum;
            public void test()                                  //1. 클래스 매개변수 호출해보기
            {
                Console.WriteLine("test");
            }
            public person()
            {
                age = 0;
                phoennum = "000-0000-0000";
                name = "무명";
                city = "서울";
            }
            public person(int age, string phoennum, string name, string city)
            {
                this.age = age;
                this.phoennum = phoennum;
                this.name = name;
                this.city = city;
            }
            public void show()
            {
                Console.WriteLine("이름 : {2}\n지역 : {3}\n나이 : {0}\n전화번호 : {1}", age, phoennum, name, city);
            }

        }

        static void Main(string[] args)
        {
            person per = new person();
            per.test();
            per.show();
            person per2 = new person(28, "010-22221-1603", "이동준", "안동시");
            per2.show();
        }
    }
}