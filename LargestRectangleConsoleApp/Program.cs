using System;

namespace LargestRectangleConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int numRectangles = 10;
            Random random = new Random();
            Rectangle[] rectangles = new Rectangle[numRectangles];

            // Generate random rectangles
            for (int i = 0; i < numRectangles; i++)
            {
                rectangles[i] = new Rectangle
                {
                    Width = random.Next(1, 101),  // Width between 1 and 100
                    Height = random.Next(1, 101)  // Height between 1 and 100
                };

                Console.WriteLine(rectangles[i]);
            }

            // Find the largest rectangle
            Rectangle largestRectangle = FindLargestRectangle(rectangles);
            Console.WriteLine($"\nLargest Rectangle: {largestRectangle}");
        }

        static Rectangle FindLargestRectangle(Rectangle[] rectangles)
        {
            Rectangle largest = rectangles[0];

            foreach (var rectangle in rectangles)
            {
                if (rectangle.Area > largest.Area ||
                    (rectangle.Area == largest.Area && rectangle.Height > largest.Height))
                {
                    largest = rectangle;
                }
            }

            return largest;
        }
    }
}
