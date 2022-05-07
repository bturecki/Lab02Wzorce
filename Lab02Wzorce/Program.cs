using Lab02Wzorce.Obserwator;
using Lab02Wzorce.Strategia;
using Lab02Wzorce.Iterator;


//Strategia
var context = new Context();
Console.WriteLine("/////////////////////// Strategia ///////////////////////");
Console.WriteLine("Client: Strategy is set.");
context.setStrategy(new ConcreteStrategy());
context.execute();

//Iterator
Console.WriteLine("/////////////////////// Iterator ///////////////////////");
ConcreteAggregate a = new ConcreteAggregate();
a[0] = "Item A";
a[1] = "Item B";
a[2] = "Item C";
a[3] = "Item D";
Iterator i = a.iterator();
Console.WriteLine("Iterating over collection:");
var item = i.next();
while (item != null)
{
    Console.WriteLine(item);
    item = i.next();
}
Console.WriteLine("Done iterating.");

//Obserwator
Console.WriteLine("/////////////////////// Obserwator ///////////////////////");
var observedSubject = new ObservedSubject();
observedSubject.addObserver(new ConcreteObserver(observedSubject, "A"));
observedSubject.addObserver(new ConcreteObserver(observedSubject, "B"));
observedSubject.addObserver(new ConcreteObserver(observedSubject, "C"));
observedSubject.notifyAll();