using System;


namespace oops_concepts{
    public class ParentClass:BaseClass {
        

        public void sayHello(){
            Console.WriteLine("Hello");
        }

    }

    public class BaseClass {
        public int a =10;
        public void test(){
            Console.WriteLine("Method from base class");
        }
    }
}