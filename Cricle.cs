namespace bai4_w07
{
    public class Circle : Resizeable
    {
        public double radius;
        public string color;
        public bool filled;

        public Circle()
        {
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }
        public Circle(double radius, string color, bool filled)
        {
            this.radius = radius;
            this.color = color;
            this.filled = filled;
        }
        public double getRadius()
        {
            return radius;
        }

        public void Resize(double percent)
        {
            radius = percent*radius;
        }

        public override string ToString()
        {
            return "Ban kinh hinh tron la: " + radius;
        }
    }
}
