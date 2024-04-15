namespace bai4_w07
{
    public class Rectangle : Resizeable
    {
        public double weight;
        public double height;


        public Rectangle()
        {
            weight = 0;
            height = 0;
        }

        public Rectangle(double weight, double height)
        {
            this.weight = weight;
            this.height = height;
        }

        public void Resize(double percent)
        {
            weight=weight*percent;
            height=height*percent;
        }

        public override string ToString()
        {
            return "Kich thuoc hinh chu nhat la: " + weight + "x" + height;
        }
    }
}

