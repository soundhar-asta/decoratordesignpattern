using System;

class Program
{
    static void Main(string[] args)
    {
        IComponent<string> component = new ConcreteComponent();
        component = new PlainDecorator(component);
        component = new UpperCaseDecorator(component);
        component = new ColorDecorator(component);

        Console.WriteLine(component.GetText());
    }
}