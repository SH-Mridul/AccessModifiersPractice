using DemoLib;

namespace AccessModifiersPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AccessDemo access = new AccessDemo();
            access.PublicMethod(); //here i can call only public method after creating object
        }
    }
}
