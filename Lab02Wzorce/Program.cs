using Lab02Wzorce.Strategia;


//Strategia
var context = new Context();

Console.WriteLine("Client: Strategy is set.");
context.setStrategy(new ConcreteStrategy());
context.execute();

