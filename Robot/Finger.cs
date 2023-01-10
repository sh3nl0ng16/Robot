namespace Robot
{
    internal class Finger
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Finger()
        {
        }

        internal void setPosition(int x, int y)
        {
            X = X + x;
            Y = Y + y;
        }
    }
}