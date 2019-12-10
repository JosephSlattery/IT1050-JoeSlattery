using System;




namespace Dog
{
    // publici is the scope of the method , the method is non-static since it isn't specified as static, double is the return type, and getArea is the method name, return height * width is teh method body.
    // Methods made by programmers hold properties that are hidden from other methods. While the defult method can be accessed by other parts of the program. We should make a method without remaking the method provided to us by VisualStudio.
    // static and non-static is a way that we can prevent objects from accessing parts of a method that we don't want them to. Non-static objects can only access non-static properties while static objects cannot.

    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Fido";

            // To do: uncomment the following lines of code to call the methods
            myDog.bark();
            myDog.doTrick("Fetch");
        }
         
        public string Name;
        public string doTrick;
    }
}
    public bark()
{
    Console.WriteLine("{0} is Barking...", name);
}
   
public trick()
{
    Console.WriteLine("{0} is so smart!  {0} is doing a(n) {1}", name, trickName);

}