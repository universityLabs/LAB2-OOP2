namespace DesignPatterns;

// "Component"
internal abstract class AbstractTree
{
    public abstract void DecorateRoom();
}

// "ConcreteComponent"
internal class Tree : AbstractTree
{
    public override void DecorateRoom()
    {
        Console.WriteLine("ROOM IS DECORATED BY ME !!!");
    }
}

// "Decorator"
internal abstract class Decorator : AbstractTree
{
    protected AbstractTree abstractTree;

    public void SetComponent(AbstractTree abstractTree)
    {
        this.abstractTree = abstractTree;
    }
    public override void DecorateRoom()
    {
        if (abstractTree != null)
        {
            abstractTree.DecorateRoom();
        }
    }
}
    
// "ConcreteDecorator" of tree
internal class Garland : Decorator
{
    private Color color;
    private bool isSwitchedOn;
    public override void DecorateRoom()
    {
        base.DecorateRoom();
        Status();
        Console.WriteLine("I AM GARLAND decoration of Tree!");
    }

    private void Status()
    {
        GetColor();
        SwitchOnGarland();
        Console.WriteLine("My color: " + color + ", am I switched? : " + isSwitchedOn);
    }

    private void GetColor()
    {
        Console.WriteLine("Enter color: ");
        var val = Console.ReadLine() ?? throw new InvalidOperationException();
        if (Enum.IsDefined(typeof(Color), val))
        {
            color = Enum.Parse<Color>(val);
        }
    }

    private void SwitchOnGarland()
    {
        isSwitchedOn = true;
    }
}

internal enum Color
{
    Black, Green, Blue, Yellow, White, Red, Purple
}