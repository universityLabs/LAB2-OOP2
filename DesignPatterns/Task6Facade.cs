namespace DesignPatterns;

// 4 health sub systems
// facade -> doctor who analise 
internal class Eyes
{
    public void AnaliseEyes()
    {
        Console.WriteLine("Eyes OK!");
    }
}

internal class Lungs
{
    public void AnaliseLungs()
    {
        Console.WriteLine("Lungs OK!");
    }
}

internal class Heart
{
    public void AnaliseHeart()
    {
        Console.WriteLine("Heart OK!");
    }
}

internal class NeuralSystem
{
    public void AnaliseNeuralSystem()
    {
        Console.WriteLine("Neural system is ok...;)");
    }
}

internal class Doctor
{
    Eyes one;
    Lungs two;
    Heart three;
    NeuralSystem four;

    public Doctor()
    {
        one = new Eyes();
        two = new Lungs();
        three = new Heart();
        four = new NeuralSystem();
    }

    public void NoCardioStatistic()
    {
        Console.WriteLine("NoCardioStatistic() ---- ");
        one.AnaliseEyes();
        two.AnaliseLungs();;
        four.AnaliseNeuralSystem();
    }

    public void CardioStatistic()
    {
        Console.WriteLine("CardioStatistic() ---- ");
        three.AnaliseHeart();
    }
}