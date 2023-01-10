namespace Robot
{
    internal class Head
    {
        public Ear Ear { get; set; }
        public Hair Hair { get; set; }
        public Face Face { get; set; }
        public Neck Neck { get; set; }

        public Head(Ear ear, Hair hair,Face face, Neck neck )
        {

        }

        public Head()
        {
        }

        internal bool HasHead()
        {
            return true;
        }

        internal void HeadMove(string head)
        {
            
        }

        internal void SetPosition(int X, int Y)
        {
            
        }
    }
}