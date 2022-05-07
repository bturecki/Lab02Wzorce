namespace Lab02Wzorce.Iterator
{
    internal class ConcreteIterator : Iterator
    {
        ConcreteAggregate aggregate;
        int current = 0;
        // Constructor
        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override bool hasNext()
        {
            return current < aggregate.Count - 1;
        }

        public override object next()
        {
            object ret = null;
            if (current < aggregate.Count - 1)
            {
                ret = aggregate[++current];
            }
            return ret;
        }
    }
}
