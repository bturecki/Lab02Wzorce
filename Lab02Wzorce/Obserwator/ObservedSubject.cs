namespace Lab02Wzorce.Obserwator
{
    internal class ObservedSubject
    {
        private List<Observer> observers = new List<Observer>();

        private string subjectState;
        // Gets or sets subject state
        public string SubjectState
        {
            get { return subjectState; }
            set { subjectState = value; }
        }
        public void notifyAll()
        {
            foreach (Observer o in observers)
            {
                o.update();
            }
        }
        public void notifyObserver(Observer o)
        {
            o.update();
        }
        public void removeObserver(Observer o)
        {
            observers.Remove(o);
        }
        public void addObserver(Observer observer)
        {
            observers.Add(observer);
        }
    }
}
