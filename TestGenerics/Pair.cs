namespace TestGenerics
{
    internal class Pair<TFirst, TSecond>
    {
        private TFirst first;
        private TSecond second;

        public Pair(TFirst v1, TSecond v2)
        {
            this.first = v1;
            this.second = v2;
        }

        public TFirst First { get => first; set => first = value; }
        public TSecond Second { get => second; set => second = value; }

        public override string ToString()
        {
            return $"{First}, {Second}";
        }
    }

    internal class Pair<T> : Pair<T, T>
    {

        public Pair(T v1, T v2) : base(v1, v2)
        {
        }
    }

    internal class Pair : Pair<int>
    {
        public Pair(int v1, int v2) : base(v1, v2)
        {
        }
    }
}