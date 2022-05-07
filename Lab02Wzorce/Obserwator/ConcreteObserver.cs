namespace Lab02Wzorce.Obserwator
{
    internal class ConcreteObserver : Observer
    {
        private string name;
        private string observerState;
        private ObservedSubject subject;
        // Constructor
        public ConcreteObserver(
            ObservedSubject subject, string name)
        {
            this.subject = subject;
            this.name = name;
        }
        public override void update()
        {
            Console.WriteLine("Observer {0} is updated.");
        }
        // Gets or sets subject
        public ObservedSubject Subject
        {
            get { return subject; }
            set { subject = value; }
        }
    }
}
