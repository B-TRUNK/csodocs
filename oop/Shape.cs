namespace csodocs.oop
{
    public class Shape
    {
        // A few example members
        public int X { get; init; }
        public int Y { get; init; }
        public int Height { get; init; }
        public int Width { get; init; }

        // Virtual method
        public virtual void Draw()
        {
            Console.WriteLine("Performing base class drawing tasks");
        }
    }


}