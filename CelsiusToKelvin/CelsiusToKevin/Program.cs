using System;
using System.Data;
namespace CelsiusToKevin
{
    public class CelsiusToKevin
    {
        public static void Main()
        {
            const string MSG_INPUT = "Enter temperature in Celsius: ";
            const string MSG_RESULT = "Temperature in Kelvin: ";

            double celsius, kelvin;

            Console.WriteLine(MSG_INPUT);
            celsius = Convert.ToDouble(Console.ReadLine());
            kelvin = celsius + 273.15;

            Console.WriteLine(MSG_RESULT + kelvin);
        }

    }
}




/*
 * 
// PRECONDITION: The user is prompted to input a temperature in Celsius.
ALGORITHM CelsiusToKelvin
    CONSTANTS
        MSG_INPUT <- "Enter temperature in Celsius:"
        MSG_RESULT <- "Temperature in Kelvin:"
    VARIABLES
        celsius, kelvin: REAL
    BEGIN
        WRITE MSG_INPUT
        READ celsius
        kelvin <- celsius + 273.15
        WRITE MSG_RESULT, kelvin
END
// POSTCONDITION: 'kelvin' contains the converted temperature, and it is // displayed.

 */