namespace DesignPatterns;

// university to adapt
internal class OldUniversity
{
    public string MatchCodename()
    {
        return "KNU";
    }
}
// interface of new university
internal interface INewUniversity
{
    string MatchCodename();
}

// concrete new University
internal class NewUniversity : INewUniversity
{
    public string MatchCodename()
    {
        return "new brand KNU";
    }
}
// Адаптер назовні виглядає як новий КНУ фле це робиться шляхом наслідування прийнятного у 
// системі інтерфейсу
internal class Adapter : INewUniversity
{
    private readonly OldUniversity _adaptee;
    public Adapter(OldUniversity adaptee)
    {
        _adaptee = adaptee;
    }

    // magic
    public string MatchCodename()
    {
        return _adaptee.MatchCodename();
    }
}

internal static class Freshman
{
    // freshmen that understand only new KNU
    public static void GetCode(INewUniversity university)
    {
        Console.WriteLine(university.MatchCodename());
    }
}