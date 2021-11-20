namespace FurnishingEx
{
    public class Stool : Chair
    {
        

        public Stool(double price) : base("black", price, 20)
        {
            SetCount = 4;
        }
        

        

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
