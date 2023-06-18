namespace DesignPatterns;

// AbstractProductA
public abstract class Car
{
    protected abstract void Info();
    public void Interact(Engine engine)
    {
        Info();
        Console.WriteLine("Set Engine: ");
        engine.GetPower();
    }
}
    
// concrete Mercedes
public class Mercedes : Car
{
    protected override void Info()
    {
        Console.WriteLine("Mercedes");
    }
}

// ConcreteProductA1
public class Ford : Car
{
    protected override void Info()
    {
        Console.WriteLine("Ford");
    }
}

//ConcreteProductA2
public class Toyota : Car
{
    protected override void Info()
    {
        Console.WriteLine("Toyota");
    }
}

// AbstractProductB
public abstract class Engine
{
    public virtual void GetPower()
    {
    }
}

// concrete mercedes engine 
public class MercedesEngine : Engine
{
    public override void GetPower()
    {
        Console.WriteLine("Mercedes Engine");
    }
}

// ConcreteProductB1
public class FordEngine : Engine
{
    public override void GetPower()
    {
        Console.WriteLine("Ford Engine");
    }
}

//ConcreteProductB2
public class ToyotaEngine : Engine
{
    public override void GetPower()
    {
        Console.WriteLine("Toyota Engine");
    }
}

// AbstractFactory
public interface ICarFactory
{
    Car CreateCar();
    Engine CreateEngine();
}

// mercedes concrete factory
public class MercedesFactory : ICarFactory
{
    Car ICarFactory.CreateCar()
    {
        return new Mercedes();
    }

    Engine ICarFactory.CreateEngine()
    {
        return new MercedesEngine();
    }
}

// ConcreteFactory1
public class FordFactory : ICarFactory
{
    // from CarFactory
    Car ICarFactory.CreateCar()
    {
        return new Ford();
    }

    Engine ICarFactory.CreateEngine()
    {
        return new FordEngine();
    }
}

// ConcreteFactory2
public class ToyotaFactory : ICarFactory
{
    // from CarFactory
    Car ICarFactory.CreateCar()
    {
        return new Toyota();
    }

    Engine ICarFactory.CreateEngine()
    {
        return new ToyotaEngine();
    }
}

public class ClientFactory
{
    private readonly Car _car;
    private readonly Engine _engine;

    public ClientFactory(ICarFactory factory)
    {
        //Абстрагування процесів інстанціювання
        _car = factory.CreateCar();
        _engine = factory.CreateEngine();
    }

    public void Run()
    {
        _car.GetType();
        //Абстрагування варіантів використання
        _car.Interact(_engine);
    }
}