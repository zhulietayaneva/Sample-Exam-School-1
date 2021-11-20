namespace FurnishingEx
{
    public class Table : Furniture
    {
        public string Kind { get; set; }

        public Table(string kind, double price) : base("Table", price, 1, 0)
        {
            this.Kind = kind;
        }

        public override double Cost(int count)
        {
            return 
        }


        public override string GetColor()
        {
            return "white";
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
