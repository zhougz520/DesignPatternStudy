using Facade.Facade;

class Program
{
    static void Main(string[] args)
    {
        FacadeBase facade = new FacadeBase();

        facade.MethodA();
        facade.MethodB();
    }
}