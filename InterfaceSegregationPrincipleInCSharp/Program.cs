namespace InterfaceSegregationPrincipleInCSharp
{
    /// <summary>
    /// The Interface Segregation Principle (ISP) is one of the SOLID principles,
    /// and it suggests that a class should not be forced to i
    /// mplement interfaces it does not use. Instead of having a single, 
    /// large interface, it's better to have several small,
    /// specific interfaces. Here's an example in C# to illustrate ISP:
    /// </summary>
    /// 


    // Interface with both drawing and resizing methods
    //interface IShape
    //{
    //    void Draw();
    //    void Resize(int width, int height);
    //}
    public interface IDraw
    {
        void Draw();
    }
    public interface IResizeable
    {
        void Resize(int width, int height);
    }
    public interface IShape : IDraw, IResizeable
    {

    }
    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine($"Draw {typeof(Circle)}");
        }

        public void Resize(int width, int height)
        {
            Console.WriteLine($"Width: {width} , Height: {height}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();
            circle.Draw();
            circle.Resize(5, 5);

        }
    }
}