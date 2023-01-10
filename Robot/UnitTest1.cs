using System.Numerics;
using System.Xml.Schema;

namespace Robot
{
    [TestClass]
    public class Robot
    {
        [TestMethod]
        public void Robotest()
        {
            var ear = new Ear();
            var hair = new Hair();
            var face = new Face();
            var neck = new Neck();
            var head = new Head(ear, hair, face, neck);

            Assert.IsTrue(head.HasHead());

            head.SetPosition(20, 30);
            Assert.
        }
        [TestMethod]
        public void MoveHandtest()
        {
            var finger1 = new Finger();
            var finger2 = new Finger();
            var hand = new Hand();
            hand.AddFinger(finger1);
            hand.AddFinger(finger2);
            hand.SetPosition(10, 20);

            Assert.AreEqual(hand.GetFingers().Count, 2);

            hand.Move(20, 40);
            Assert.AreEqual(hand.X, 20);
            Assert.AreEqual(hand.Y, 40);
            var firstFinger = hand.GetFingers().FirstOrDefault();
            Assert.AreEqual(firstFinger.X, 20);
            Assert.AreEqual(firstFinger.Y, 40);

            hand.Move(5, 5);
            Assert.AreEqual(firstFinger.X, 25);
            Assert.AreEqual(firstFinger.Y, 45);
        }
        

    }
}