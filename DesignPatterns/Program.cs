using System.Text;
using DesignPatterns;

// task1
Console.WriteLine("START OF TASK 1:");
ICarFactory carFactory = new ToyotaFactory();
var client1 = new ClientFactory(carFactory);
client1.Run();

carFactory = new FordFactory();
var client2 = new ClientFactory(carFactory);
client2.Run();

carFactory = new MercedesFactory();
var client3 = new ClientFactory(carFactory);
client3.Run();
Console.WriteLine("END OF TASK 1:");
Console.WriteLine();

// task2
Console.WriteLine("START OF TASK 2:");
var waiter = new Waiter();
PizzaBuilder hawaiianPizzaBuilder = new HawaiianPizzaBuilder();
PizzaBuilder spicyPizzaBuilder = new SpicyPizzaBuilder();
PizzaBuilder margaritaPizzaBuilder = new MargaritaPizzaBuilder();

waiter.SetPizzaBuilder(margaritaPizzaBuilder);
waiter.ConstructPizza();

var pizza = waiter.GetPizza();
pizza.Info();
Console.WriteLine("END OF TASK 2:");
Console.WriteLine();

// task3
Console.WriteLine("START OF TASK 3:");
Console.OutputEncoding = Encoding.UTF8;
var m = new ConcreteMediator();
var c1 = new ConcreteColleague1(m);
var c2 = new ConcreteColleague2(m);
var c3 = new ConcreteColleague3(m);

m.Colleague1 = c1;
m.Colleague2 = c2;
m.Colleague3 = c3;

m.Send("How are you?", c1);
m.Send("Fine, thanks", c2);
m.Send("Hello!", c3);
Console.WriteLine("END OF TASK 3:");             
Console.WriteLine();


// task4
Console.WriteLine("START OF TASK 4:");
var t = new Tree();
var d1 = new Garland();
var d2 = new Garland();
var d3 = new Garland();

// Link decorators
d1.SetComponent(t);
d2.SetComponent(d1);
d3.SetComponent(d2);

d3.DecorateRoom();
Console.WriteLine("END OF TASK 4:");             
Console.WriteLine();

//task5
Console.WriteLine("START OF TASK 5:");
Console.OutputEncoding = Encoding.UTF8;
IFigure figure = new Rectangle(10, 20);
var clonedFigure = figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();

figure = new Circle(15);
clonedFigure = figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();

figure = new Triangle(3, 4, 5);
clonedFigure = figure.Clone();
figure.GetInfo();
clonedFigure.GetInfo();

Console.WriteLine("END OF TASK 5:");             
Console.WriteLine();

//task6
Console.WriteLine("START OF TASK 6:");
Console.WriteLine("FACADE:");

var facade = new Doctor();
facade.NoCardioStatistic();
facade.CardioStatistic();

Console.WriteLine();
Console.WriteLine("ADAPTER:");

var newUniversity = new NewUniversity();
Freshman.GetCode(newUniversity);
var oldUniversity = new OldUniversity();
var adapter = new Adapter(oldUniversity);
Freshman.GetCode(adapter);       

Console.WriteLine("END OF TASK 6:");             
Console.WriteLine("END OF HOMEWORK!");