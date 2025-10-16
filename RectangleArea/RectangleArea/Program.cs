using System;
namespace RectangleArea
{
    public class RectangleArea
    {
        public static void Main()
        {
            const string MSG_INPUT_WIDTH = "Enter the width of the rectangle: ";
            const string MSG_INPUT_HEIGHT = "Enter the height of the rectangle: ";
            const string MSG_RESULT = "The area of the rectangle is: ";

            double width, height, area;
            Console.WriteLine(MSG_INPUT_WIDTH);
            width = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(MSG_INPUT_HEIGHT);
            height = Convert.ToDouble(Console.ReadLine());
            area = width * height;
            Console.WriteLine(MSG_RESULT + area);

        }
    }
}
/*
 * // PRECONDITION: The user is prompted to input the width and height of a // rectangle.
ALGORITHM RectangleArea
    CONSTANTS
        MSG_INPUT_WIDTH <- "Enter the width of the rectangle:"
        MSG_INPUT_HEIGHT <- "Enter the height of the rectangle:"
        MSG_RESULT <- "The area of the rectangle is:"
    VARIABLES
        width, height, area: REAL
    BEGIN
        WRITE MSG_INPUT_WIDTH
        READ width
        WRITE MSG_INPUT_HEIGHT
        READ height
        area <- width * height
        WRITE MSG_RESULT, area
END
// POSTCONDITION: 'area' contains the product of 'width' and 'height', 
// and it is displayed.
 */