public class ConcreteComponent : IComponent<string>
{
    public string GetText()
    {
        return "This is a sample text";
    }
}