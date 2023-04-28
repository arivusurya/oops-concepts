namespace oops_concepts
{
    public class ConstructorClass:interfaceTypes
    {
       public ConstructorClass(){
            Console.WriteLine("Hello world!");
       }

       public ConstructorClass(String name){
            Console.WriteLine($"hello {name}");
       }

       public void Saygreetings(){
        Console.WriteLine($"Hello world!");
       }
    }
}