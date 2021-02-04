using System;

namespace TypesOfConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rectangle rectangle = new Rectangle();

            //rectangle.Draw();

            //Rectangle rectangle2 = new Rectangle(56, 12);

            //rectangle2.Draw();

            //RectangleCopy rectangleCopy = new RectangleCopy(rectangle.Width, rectangle.Height);

            //rectangleCopy.Draw();

            //RectangleCopy rectangleCopy2 = new RectangleCopy(rectangle2);

            //rectangleCopy2.Draw();

            //Shapes.DrawRectangle();

            //Shapes.DrawRectangle(34, 56);

            Shape rectangleShape = new RectangleShape();

            DrawShape(rectangleShape);

            Shape rectangleShape2 = new RectangleShape(54,100);

            DrawShape(rectangleShape2);

            //Shape circleShape = new CircleShape();

            //DrawShape(circleShape);

            //Shape circleShape2 = new CircleShape(35);

            //DrawShape(circleShape2);

            Shape copyRectangleShape = new RectangleShapeCopy(rectangleShape.Width,rectangleShape.Height);

            DrawShape(copyRectangleShape);

            Shape copyRectangleShape2 = new RectangleShapeCopy(rectangleShape2);


            DrawShape(copyRectangleShape2);



            Console.ReadKey();

        }

        public static void DrawShape(Shape shape)
        {
            shape.Draw();
        }
    }

    public class RectangleShapeCopy:Shape
    {

        const string ShapeNameAppend = "Copy: ";

        public RectangleShapeCopy(int width, int height):base(width,height)
        {
            ModifyShapeName();
        }
        public RectangleShapeCopy(Shape rectangle):base(rectangle)
        {
            ModifyShapeName();
        }

        private void ModifyShapeName()
        {
            ShapeName = ShapeNameAppend + ShapeName;
        }

        public override void Draw()
        {
            Console.WriteLine($"Shape, '{ShapeName}', with width, {Width}, height, {Height}");
        }

    }

    public class RectangleCopy
    {
        public int Width;
        public int Height;
        const string ShapeName = "RectangleCopy";

        public RectangleCopy(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public RectangleCopy(Rectangle rectangle)
        {
            Width = rectangle.Width;
            Height = rectangle.Height;

        }
        public void Draw()
        {
            Console.WriteLine($"Shape, '{ShapeName}', with width, {Width}, height, {Height}");

        }

    }

    public abstract class Shape
    {
        protected string ShapeName;
        public int Width;
        public int Height;
        public int Radius;

        public Shape(int radius)
        {
            Radius = radius;
            ShapeName = "Circle";
        }

        public Shape(int width, int height)
        {
            Width = width;
            Height = height;

            ShapeName = "Rectangle";
        }

        public Shape(Shape shape)
        {
            this.Radius = shape.Radius;
            this.Width = shape.Width;
            this.Height = shape.Height;
            this.ShapeName = shape.ShapeName;

        }

        public abstract void Draw();

    }

    public class CircleShape:Shape
    {
        public CircleShape():this(10)
        {

        }
        public CircleShape(int radius):base(radius)
        {

        }
        public override void Draw()
        {
            Console.WriteLine($"Shape, '{ShapeName}', with radius, {Radius}");
        }

    }

    public class RectangleShape:Shape
    {
        public RectangleShape():this(20,10)
        {

        }

        public RectangleShape(int width, int height):base(width,height)
        {

        }

        public override void Draw()
        {
            Console.WriteLine($"Shape, '{ShapeName}', with width, {Width}, Height, {Height}");
        }

    }

    public class Rectangle
    {
        public int Width;
        public int Height;
        const string ShapeName = "Rectangle";

        public Rectangle():this(20,10)
        {

        }

        public Rectangle(int width, int height)
        {
            Width = width;
            Height = height;
        }

        public void Draw()
        {
            Console.WriteLine($"Shape, '{ShapeName}', with width, {Width}, Height, {Height}");

        }

    }

    public class Shapes
    {
        public static int Width = 20;
        public static int Height = 10;

        public const string DateTimeFormat = "dddd, dd MMMM yyyy HH:mm:ss";

        private static readonly string TimeStamp;

        //private Shapes()
        //{

        //}



        static Shapes()
        {
            TimeStamp = DateTime.Now.ToString(DateTimeFormat);
        }

        private static void OutputRectangleDetails()
        {
            Console.WriteLine($"Shape, 'Rectangle', with width, {Width}, Height, {Height}");
            System.Threading.Thread.Sleep(1200);

            Console.WriteLine($"Static constructor called {TimeStamp}, OutputRectangleDetails called, {DateTime.Now.ToString(DateTimeFormat)}");

        }
        public static void DrawRectangle()
        {
            OutputRectangleDetails();

        }
        public static void DrawRectangle(int width, int height)
        {
            Width = width;
            Height = height;

            OutputRectangleDetails();

        }

    }

}
