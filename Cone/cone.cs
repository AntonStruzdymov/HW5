namespace HWLibrary2
{
    public class Cone
    {
        private double r;
        private double h;
        private double l;
        private double BA;
        private double SA;
        public Cone(double radius, double height)
        {
            r = radius;
            h = height;
        }

        public double BaseArea()
        {
            BA = Math.PI * r * r;
            return BA;
        }
        public double SurfaceArea()
        {
            l = Math.Sqrt(r*r + h*h);
            BA = Math.PI * r * r;
            SA = BA+ Math.PI * r*l;
            return SA;
        }
    }
}