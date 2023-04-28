namespace oops_concepts
{
    public class ConstructorClass
    {
       public ConstructorClass(){
            Console.WriteLine("Hello world!");
       }

       public ConstructorClass(String name){
            Console.WriteLine($"hello {name}");
       }
    }
}