namespace Robot
{
    internal class Hand
    {
        private List<Finger> _fingers = new List<Finger>();

        public Hand()
        {
        }

        public int X { get; private set; }
        public int Y { get; private set; }


        internal void AddFinger(Finger finger)
        {
            _fingers.Add(finger);
        }

        internal List<Finger> GetFingers()
        {
            return _fingers;

        }

        internal void Move(int x, int y)
        {
            this.X = x;
            this.Y = y;
            MoveFingers(this._fingers);
           
        }

        private void MoveFingers(List<Finger> fingers)
        {
            foreach (var item in fingers)
            {
                item.setPosition(this.X, this.Y);
            }
        }

        internal void SetPosition(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}