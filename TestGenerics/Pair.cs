namespace TestGenerics
{
    internal class Pair<T>
    {
        private T first;
        private T second;

        public Pair(T v1, T v2)
        {
            this.first = v1;
            this.second = v2;
        }

        public T First { get => first; set => first = value; }
        public T Second { get => second; set => second = value; }
    }

    internal class Pair : Pair<int>
    {
        public Pair(int v1, int v2) : base(v1, v2)
        {
        }
    }
}