namespace Lab02Wzorce.Strategia
{
    class Context
    {
        private IStrategy _strategy;
        public Context() { }

        public Context(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void setStrategy(IStrategy strategy)
        {
            this._strategy = strategy;
        }

        public void execute()
        {
            Console.WriteLine("Context: executing");
            this._strategy.execute();
        }
    }
}
