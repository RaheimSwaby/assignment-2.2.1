namespace assignment_2._2._1
{
    namespace Assignment_2_2_1
    {
        public abstract class Shape
        {
            public abstract double calcArea();
            public int ID { get; set; }
            public string Name { get; set; }
            public string Color { get; set; }
        }

        public class Circle : Shape
        {
            public double radius { get; set; }

            public Circle(double radius)
            {
                this.radius = radius;
            }

            public override double calcArea()
            {
                return Math.PI * radius * radius;
            }
        }

        public class Square : Shape
        {
            public double side { get; set; }

            public Square(double side)
            {
                this.side = side;
            }

            public override double calcArea()
            {
                return side * side;
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Choose a shape:\n1. Circle\n2. Square");
                int choice = Convert.ToInt32(Console.ReadLine());

                Shape shape;

                if (choice == 1)
                {
                    Console.WriteLine("Enter the radius:");
                    double radius = Convert.ToDouble(Console.ReadLine());
                    Circle circle = new Circle(radius);
                    shape = circle;
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the side length:");
                    double side = Convert.ToDouble(Console.ReadLine());
                    Square square = new Square(side);
                    shape = square;
                }
                else
                {
                    Console.WriteLine("Invalid choice.");
                    return;
                }

                Console.WriteLine("Enter shape ID:");
                shape.ID = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name of the shape:");
                shape.Name = Console.ReadLine();
                Console.WriteLine("Enter the color of your shape:");
                shape.Color = Console.ReadLine();

                Console.WriteLine($"The area of the {shape.Name} is: {shape.calcArea():F2}");
                Console.WriteLine($"Shape ID: {shape.ID}, Name: {shape.Name}, Color: {shape.Color}");
            }
        }
    }
}