using System;
using System.Drawing;
using System.Globalization;
using System.Security;

namespace MathS
{
    public static class MathS
    {
        public enum InputFormat
        {
            Degrees = 0,
            Radians = 1,
            Gardians = 2
        }

        public enum InputFormat_Deduction
        {
            Deduction = 0,
            Float = 1
        }


        public static InputFormat InputFormat_FromName(string name)
        {
            return (name == "Degrees") ? InputFormat.Degrees : (name == "Radians") ? InputFormat.Radians : InputFormat.Gardians;
        }

        // -> Variables
        public const double P = 3.1415926535897931;
        public const double E = 2.7182818284590451;
        public const double G = 6.673848E-11;
        public const double C = 2.99792458E8;
        public const double H = 1.0545717297978387E-34;
        public static double I = Sqrt(-1);

        // -> +, -, *, /, ^, %
        /// <summary>
        /// Returns a specified number raised to the specified power.
        /// </summary>
        /// <param name="X">x is the variable down</param>
        /// <param name="Y">y is the variable up</param>
        /// <returns>The number x raised to the power y.</returns>
        public static double Pow(double X, double Y)
        {
            return Math.Pow(X, Y);
        }
        /// <summary>
        /// return the plus of two arguments
        /// </summary>
        /// <param name="X">x is variable one</param>
        /// <param name="Y">y is variable two</param>
        /// <returns>The number x plused to the y.</returns>
        public static double Plus(double X, double Y)
        {
            return X + Y;
        }
        /// <summary>
        /// return the minuse of two arguments
        /// </summary>
        /// <param name="X">x is variable one</param>
        /// <param name="Y">y is variable two</param>
        /// <returns>The number x minused to the y.</returns>
        public static double Minuse(double X, double Y)
        {
            return X - Y;
        }
        /// <summary>
        /// return the multiply of two arguments
        /// </summary>
        /// <param name="X">x is variable one</param>
        /// <param name="Y">y is variable two</param>
        /// <returns>The number x multiply to the y.</returns>
        public static double MultyPly(double X, double Y)
        {
            return X * Y;
        }
        /// <summary>
        /// return the division of two arguments
        /// </summary>
        /// <param name="X">x is variable one</param>
        /// <param name="Y">y is variable two</param>
        /// <returns>The number x division by y.</returns>
        public static double Division(double X, double Y)
        {
            return X / Y;
        }
        /// <summary>
        /// return the moludo operation finds the remainder of division 'x' by 'y'
        /// </summary>
        /// <param name="X">x is variable one</param>
        /// <param name="Y">y is variable two</param>
        /// <returns>The number x moded to the y.</returns>
        public static double Mod(double X, double Y)
        {
            return X % Y;
        }
        // -> trangle
        /// <summary>
        /// trigonometric sine function
        /// </summary>
        /// <param name="X">the value for sine</param>
        /// <param name="mode">calculate mode. calculate degrees, radians or gradians</param>
        /// <returns>The sine of a. If a is equal to System.Double.NaN, System.Double.NegativeInfinity, or System.Double.PositiveInfinity, this method returns System.Double.NaN.</returns>
        public static double Sin(double X, InputFormat mode)
        {
            if (mode == InputFormat.Radians)
                return Math.Sin(X);
            else if (mode == InputFormat.Degrees)
                return Math.Sin(X * Math.PI / 180);
            else
                return Math.Sin(X * 200 / P);
        }
        /// <summary>
        /// trigonometric cosine function
        /// </summary>
        /// <param name="X">the value for cosine</param>
        /// <param name="mode">calculate mode. calculate degrees, radians or gradians</param>
        /// <returns>The cosine of d. If d is equal to System.Double.NaN, System.Double.NegativeInfinity, or System.Double.PositiveInfinity, this method returns System.Double.NaN.</returns>
        public static double Cos(double X, InputFormat mode)
        {
            if (mode == InputFormat.Radians)
                return Math.Cos(X);
            else if (mode == InputFormat.Degrees)
                return Math.Cos(X * Math.PI / 180);
            else
                return Math.Cos(X * 200 / P);
        }
        /// <summary>
        /// trigonometric tangent function
        /// </summary>
        /// <param name="X">the value for tangent</param>
        /// <param name="mode">calculate mode. calculate degrees, radians or gradians</param>
        /// <returns>The tangent of a. If a is equal to System.Double.NaN, System.Double.NegativeInfinity, or System.Double.PositiveInfinity, this method returns System.Double.NaN.</returns>
        public static double Tan(double X, InputFormat mode)
        {
            if (mode == InputFormat.Radians)
                return Math.Tan(X);
            else if (mode == InputFormat.Degrees)
                return Math.Tan(X * Math.PI / 180);
            else
                return Math.Tan(X * 200 / P);
        }
        /// <summary>
        /// trigonometric inverse sine function
        /// </summary>
        /// <param name="X">the value for inverse sine</param>
        /// <param name="mode">calculate mode. calculate degrees, radians or gradians</param>
        /// <returns> An angle, θ, measured in radians, such that -π/2 ≤θ≤π/2 -or- System.Double.NaN if d < -1 or d > 1 or d equals System.Double.NaN.</returns>
        public static double ASin(double X, InputFormat mode)
        {
            if (mode == InputFormat.Radians)
                return Math.Asin(X);
            else if (mode == InputFormat.Degrees)
                return Math.Asin(X * Math.PI / 180);
            else
                return Math.Asin(X * 200 / P);
        }
        /// <summary>
        /// trigonometric inverse cosine function
        /// </summary>
        /// <param name="X">the value for inverse cosine</param>
        /// <param name="mode">calculate mode. calculate degrees, radians or gradians</param>
        /// <returns> An angle, θ, measured in radians, such that 0 ≤θ≤π -or- System.Double.NaN if d < -1 or d > 1 or d equals System.Double.NaN.</returns>
        public static double ACos(double X, InputFormat mode)
        {
            if (mode == InputFormat.Radians)
                return Math.Acos(X);
            else if (mode == InputFormat.Degrees)
                return Math.Acos(X * Math.PI / 180);
            else
                return Math.Acos(X * 200 / P);
        }
        /// <summary>
        /// trigonometric inverse tangent function
        /// </summary>
        /// <param name="X">the value for inverse tangent</param>
        /// <param name="mode">calculate mode. calculate degrees, radians or gradians</param>
        /// <returns>An angle, θ, measured in radians, such that -π/2 ≤θ≤π/2. -or- System.Double.NaN if d equals System.Double.NaN, -π/2 rounded to double precision (-1.5707963267949) if d equals System.Double.NegativeInfinity, or π/2 rounded to double precision (1.5707963267949) if d equals System.Double.PositiveInfinity.</returns>
        public static double ATan(double X, InputFormat mode)
        {
            if (mode == InputFormat.Radians)
                return Math.Atan(X);
            else if (mode == InputFormat.Degrees)
                return Math.Atan(X * Math.PI / 180);
            else
                return Math.Atan(X * 200 / P);
        }
        public static double SinH(double X, InputFormat mode)
        {
            if (mode == InputFormat.Radians)
                return Math.Sinh(X);
            else if (mode == InputFormat.Degrees)
                return Math.Sinh(X * Math.PI / 180);
            else
                return Math.Sinh(X * 200 / P);
        }
        public static double CosH(double X, InputFormat mode)
        {
            if (mode == InputFormat.Radians)
                return Math.Cosh(X);
            else if (mode == InputFormat.Degrees)
                return Math.Cosh(X * Math.PI / 180);
            else
                return Math.Cosh(X * 200 / P);
        }
        public static double TanH(double X, InputFormat mode)
        {
            if (mode == InputFormat.Radians)
                return Math.Tanh(X);
            else if (mode == InputFormat.Degrees)
                return Math.Tanh(X * Math.PI / 180);
            else
                return Math.Tanh(X * 200 / P);
        }
        /// <summary>
        /// rounds a double value to the rearest integral value
        /// </summary>
        /// <param name="X">The x coordinate of a point.</param>
        /// <param name="Y">The y coordinate of a point.</param>
        /// <returns>An angle, θ, measured in radians, such that -π≤θ≤π, and tan(θ) = y / x, where (x, y) is a point in the Cartesian plane. Observe the following: For (x, y) in quadrant 1, 0 < θ < π/2. For (x, y) in quadrant 2, π/2 < θ≤π. For (x, y) in quadrant 3, -π < θ < -π/2. For (x, y) in quadrant 4, -π/2 < θ < 0. For points on the boundaries of the quadrants, the return value is the following: If y is 0 and x is not negative, θ = 0. If y is 0 and x is negative, θ = π. If y is positive and x is 0, θ = π/2. If y is negative and x is 0, θ = -π/2. If y is 0 and x is 0, θ = 0. If x or y is System.Double.NaN, or if x and y are either System.Double.PositiveInfinity or System.Double.NegativeInfinity, the method returns System.Double.NaN.</returns>
        public static double Atan2(double X, double Y)
        {
            return Math.Atan2(X, Y);
        }
        // -> Round
        /// <summary>
        /// rounds a double value to the rearest integral value
        /// </summary>
        /// <param name="X">A decimal number to be rounded.</param>
        /// <returns>The integer nearest a. If the fractional component of a is halfway between two integers, one of which is even and the other odd, then the even number is returned. Note that this method returns a System.Double instead of an integral type.</returns>
        public static double Round(double X)
        {
            return (X > 0.5) ? Convert.ToInt32(X) : Convert.ToInt32(X);
        }
        /// <summary>
        /// rounds a decimal value to the rearest integral value
        /// </summary>
        /// <param name="X">A decimal number to be rounded.</param>
        /// <returns>The integer nearest parameter d. If the fractional component of d is halfway between two integers, one of which is even and the other odd, the even number is returned. Note that this method returns a System.Decimal instead of an integral type.</returns>
        /// <exception cref="System.StackOverflowException">The result is outside the range of a System.Decimal.</exception>
        public static decimal Round(decimal X)
        {
            return (Convert.ToDouble(X) > 0.5) ? Convert.ToInt32(X) : Convert.ToInt32(X);
        }
        /// <summary>
        /// Rounds a double-precision floating-point value to the nearest integer. A parameter specifies how to round the value if it is midway between two numbers.
        /// </summary>
        /// <param name="X">A decimal number to be rounded.</param>
        /// <param name="midpointRounding">Specification for how to round value if it is midway between two other numbers.</param>
        /// <returns>The integer nearest value. If value is halfway between two integers, one of which is even and the other odd, then mode determines which of the two is returned.</returns>
        /// <exception cref="ArgumentException">mode is not a valid value of System.MidpointRounding.</exception>
        public static double Round(double X, MidpointRounding midpointRounding)
        {
            return Math.Round(X, midpointRounding);
        }
        /// <summary>
        ///Rounds a decimal value to the nearest integer. A parameter specifies how to round the value if it is midway between two numbers.
        /// </summary>
        /// <param name="X">A decimal number to be rounded.</param>
        /// <param name="midpointRounding">Specification for how to round X if it is midway between two other numbers.</param>
        /// <returns>The integer nearest d. If d is halfway between two numbers, one of which is even and the other odd, then mode determines which of the two is returned.</returns>
        /// <exception cref="ArgumentException">mode is not a valid value of System.MidpointRounding.</exception>
        public static decimal Round(decimal X, MidpointRounding midpointRounding)
        {
            return Math.Round(X, midpointRounding);
        }
        // -> sqrt = √
        /// <summary>
        /// Take input and calculate what number multiply to that number to result equals to X
        /// </summary>
        /// <param name="X">a double number</param>
        /// <returns>return a double number</returns>
        public static double Sqrt(double X)
        {
            return Math.Sqrt(X);
        }
        public static double Sqrt(double X, double Y)
        {
            return Pow(X, Division(1, Y));
        }
        /// <summary>
        /// Take input and calculate what number multiply to that number to result equals to X
        /// </summary>
        /// <param name="X">a double number</param>
        /// <returns>return a double number</returns>
        /// <exception cref="StackOverflowException">The System can't convert System.string to System.double</exception>
        public static string Sqrt(string X)
        {
            return Math.Sqrt(Convert.ToDouble(X)).ToString();
        }
        // -> Min
        public static double Min(double X, double Y)
        {
            return (X < Y) ? X : Y;
        }
        public static decimal Min(decimal X, decimal Y)
        {
            return (X < Y) ? X : Y;
        }
        public static int Min(int X, int Y)
        {
            return (X < Y) ? X : Y;
        }
        public static ulong Min(ulong X, ulong Y)
        {
            return (X < Y) ? X : Y;
        }
        public static float Min(float X, float Y)
        {
            return (X < Y) ? X : Y;
        }
        public static long Min(long X, long Y)
        {
            return (X < Y) ? X : Y;
        }
        public static short Min(short X, short Y)
        {
            return (X < Y) ? X : Y;
        }
        public static sbyte Min(sbyte X, sbyte Y)
        {
            return (X < Y) ? X : Y;
        }
        public static byte Min(byte X, byte Y)
        {
            return (X < Y) ? X : Y;
        }
        public static ushort Min(ushort X, ushort Y)
        {
            return (X < Y) ? X : Y;
        }
        public static string Min(string X, string Y)
        {
            return (Convert.ToDouble(X) < Convert.ToDouble(Y)) ? X : Y;
        }
        // -> Max
        public static double Max(double X, double Y)
        {
            return (X > Y) ? X : Y;
        }
        public static decimal Max(decimal X, decimal Y)
        {
            return (X > Y) ? X : Y;
        }
        public static int Max(int X, int Y)
        {
            return (X > Y) ? X : Y;
        }
        public static ulong Max(ulong X, ulong Y)
        {
            return (X > Y) ? X : Y;
        }
        public static float Max(float X, float Y)
        {
            return (X > Y) ? X : Y;
        }
        public static long Max(long X, long Y)
        {
            return (X > Y) ? X : Y;
        }
        public static short Max(short X, short Y)
        {
            return (X > Y) ? X : Y;
        }
        public static sbyte Max(sbyte X, sbyte Y)
        {
            return (X > Y) ? X : Y;
        }
        public static byte Max(byte X, byte Y)
        {
            return (X > Y) ? X : Y;
        }
        public static ushort Max(ushort X, ushort Y)
        {
            return (X > Y) ? X : Y;
        }
        public static string Max(string X, string Y)
        {
            return (Convert.ToDouble(X) > Convert.ToDouble(Y)) ? X : Y;
        }
        // -> celling
        /// <summary>
        /// Returns the smallest integral value that is greater than or equal to the specified double-precision floating-point number.
        /// </summary>
        /// <param name="X"> A double-precision floating-point number.</param>
        /// <returns>  The smallest integral value that is greater than or equal to a. If a is equal to System.Double.NaN, System.Double.NegativeInfinity, or System.Double.PositiveInfinity, that value is returned. Note that this method returns a System.Double instead of an integral type.</returns>
        public static double Ceil(double X)
        {
            return Math.Ceiling(X);
        }
        /// <summary>
        /// Returns the smallest integral value that is greater than or equal to the specified decimal number.
        /// </summary>
        /// <param name="X">A decimal number.</param>
        /// <returns>The smallest integral value that is greater than or equal to d. Note that this method returns a System.Decimal instead of an integral type.</returns>
        public static decimal Ceil(decimal X)
        {
            return Convert.ToDecimal(Math.Ceiling(Convert.ToDouble(X)));
        }
        // -> Floor
        /// <summary>
        /// Returns the largest integer less than or equal to the specified double-precision floating-point number.
        /// </summary>
        /// <param name="X">A double-precision floating-point number.</param>
        /// <returns>The largest integer less than or equal to d. If d is equal to System.Double.NaN, System.Double.NegativeInfinity, or System.Double.PositiveInfinity, that value is returned.</returns>
        public static double Floor(double X)
        {
            return Math.Floor(X);
        }
        /// <summary>
        /// Returns the largest integer less than or equal to the specified decimal number.
        /// </summary>
        /// <param name="X"> A decimal number.</param>
        /// <returns>The largest integer less than or equal to d. Note that the method returns an integral value of type System.Math.</returns>
        public static decimal Floor(decimal X)
        {
            return Convert.ToDecimal(Math.Floor(Convert.ToDouble(X)));
        }
        // -> Abs
        public static decimal Abs(decimal directionue)
        {
            return Convert.ToDecimal(Math.Abs(directionue));
        }
        public static double Abs(double directionue)
        {
            return Math.Abs(directionue);
        }
        public static float Abs(float directionue)
        {
            return Math.Abs(directionue);
        }
        public static int Abs(int directionue)
        {
            return Convert.ToInt32(Math.Abs(directionue));
        }
        public static short Abs(short directionue)
        {
            return Math.Abs(directionue);
        }
        public static sbyte Abs(sbyte directionue)
        {
            return Math.Abs(directionue);
        }
        public static long Abs(long directionue)
        {
            return Math.Abs(directionue);
        }
        // -> ap, ne, !
        /// <summary>
        /// Copmare the input numbers
        /// </summary>
        /// <param name="X">A double number for input one</param>
        /// <param name="Y">A double number for input two</param>
        /// <returns>if the x equals to y return true else false</returns>
        public static double ap(double X, double Y)
        {
            return Convert.ToInt32(X == Y);
        }
        /// <summary>
        /// Copmare the input numbers
        /// </summary>
        /// <param name="X">A decimal number for input one</param>
        /// <param name="Y">A decimal number for input two</param>
        /// <returns>if the x equals to y return true else false</returns>
        /// <exception cref="ArgumentException">The inputs out of range</exception>
        public static decimal ap(decimal X, decimal Y)
        {
            return Convert.ToInt32(X == Y);
        }
        /// <summary>
        /// Copmare the input numbers
        /// </summary>
        /// <param name="X">A double number for input one</param>
        /// <param name="Y">A double number for input two</param>
        /// <returns>if the x not equals to y return true else false</returns>
        public static double ne(double X, double Y)
        {
            return Convert.ToInt32(X != Y);
        }
        /// <summary>
        /// Copmare the input numbers
        /// </summary>
        /// <param name="X">A decimal number for input one</param>
        /// <param name="Y">A decimal number for input two</param>
        /// <returns>if the x not equals to y return true else false</returns>
        /// <exception cref="ArgumentException">The inputs out of range</exception>
        public static decimal ne(decimal X, decimal Y)
        {
            return Convert.ToInt32(X != Y);
        }
        // -> Deduction
        // in float
        /// <summary>
        /// Caluclate the deduction on floting number
        /// </summary>
        /// <param name="numerator_number_1">first function from</param>
        /// <param name="numerator_number_2">The denominator of the first fraction</param>
        /// <param name="denominator_number_1">The second fraction form</param>
        /// <param name="denominator_number_2">The denominator of the second fraction</param>
        /// <returns>Return a double number</returns>
        public static double Deduction_Plus(double numerator_number_1, double numerator_number_2, double denominator_number_1, double denominator_number_2)
        {
            return (numerator_number_1 / denominator_number_1) + (numerator_number_2 / denominator_number_2);
        }
        /// <summary>
        /// Caluclate the deduction on floting number
        /// </summary>
        /// <param name="numerator_number_1">first function from</param>
        /// <param name="numerator_number_2">The denominator of the first fraction</param>
        /// <param name="denominator_number_1">The second fraction form</param>
        /// <param name="denominator_number_2">The denominator of the second fraction</param>
        /// <returns>Return a double number</returns>
        /// <exception cref="StackOverflowException">The System can't convert System.String to System.Double</exception>
        public static string Deduction_Plus(string numerator_number_1, string numerator_number_2, string denominator_number_1, string denominator_number_2)
        {
            return ((Convert.ToDouble(numerator_number_1) / Convert.ToDouble(denominator_number_1)) + (Convert.ToDouble(numerator_number_2) / Convert.ToDouble(denominator_number_2))).ToString();
        }
        /// <summary>
        /// Caluclate the deduction on floting number
        /// </summary>
        /// <param name="numerator_number_1">first function from</param>
        /// <param name="numerator_number_2">The denominator of the first fraction</param>
        /// <param name="denominator_number_1">The second fraction form</param>
        /// <param name="denominator_number_2">The denominator of the second fraction</param>
        /// <returns>Return a double number</returns>
        public static double Deduction_Minuse(double numerator_number_1, double numerator_number_2, double denominator_number_1, double denominator_number_2)
        {
            return (numerator_number_1 / denominator_number_1) - (numerator_number_2 / denominator_number_2);
        }
        /// <summary>
        /// Caluclate the deduction on floting number
        /// </summary>
        /// <param name="numerator_number_1">first function from</param>
        /// <param name="numerator_number_2">The denominator of the first fraction</param>
        /// <param name="denominator_number_1">The second fraction form</param>
        /// <param name="denominator_number_2">The denominator of the second fraction</param>
        /// <returns>Return a double number</returns>
        /// <exception cref="StackOverflowException">The System can't convert System.String to System.Double</exception>
        public static string Deduction_Minuse(string numerator_number_1, string numerator_number_2, string denominator_number_1, string denominator_number_2)
        {
                return ((Convert.ToDouble(numerator_number_1) / Convert.ToDouble(denominator_number_2)) - (Convert.ToDouble(numerator_number_2) / Convert.ToDouble(denominator_number_1))).ToString();
        }
        /// <summary>
        /// Caluclate the deduction on floting number
        /// </summary>
        /// <param name="numerator_number_1">first function from</param>
        /// <param name="numerator_number_2">The denominator of the first fraction</param>
        /// <param name="denominator_number_1">The second fraction form</param>
        /// <param name="denominator_number_2">The denominator of the second fraction</param>
        /// <returns>Return a double number</returns>
        public static double Deduction_MultiPly(double numerator_number_1, double numerator_number_2, double denominator_number_1, double denominator_number_2)
        {
            return (numerator_number_1 / denominator_number_1) * (numerator_number_2 / denominator_number_2);
        }
        /// <summary>
        /// Caluclate the deduction on floting number
        /// </summary>
        /// <param name="numerator_number_1">first function from</param>
        /// <param name="numerator_number_2">The denominator of the first fraction</param>
        /// <param name="denominator_number_1">The second fraction form</param>
        /// <param name="denominator_number_2">The denominator of the second fraction</param>
        /// <returns>Return a double number</returns>
        /// <exception cref="StackOverflowException">The System can't convert System.String to System.Double</exception>
        public static string Deduction_MultiPly(string numerator_number_1, string numerator_number_2, string denominator_number_1, string denominator_number_2)
        {
                return ((Convert.ToDouble(numerator_number_1) / Convert.ToDouble(denominator_number_1)) * (Convert.ToDouble(numerator_number_2) / Convert.ToDouble(denominator_number_2))).ToString();
        }
        /// <summary>
        /// Caluclate the deduction on floting number
        /// </summary>
        /// <param name="numerator_number_1">first function from</param>
        /// <param name="numerator_number_2">The denominator of the first fraction</param>
        /// <param name="denominator_number_1">The second fraction form</param>
        /// <param name="denominator_number_2">The denominator of the second fraction</param>
        /// <returns>Return a double number</returns>
        public static double Deduction_Division(double numerator_number_1, double numerator_number_2, double denominator_number_1, double denominator_number_2)
        {
            return ((numerator_number_1 / denominator_number_1) / (numerator_number_2 / denominator_number_2));
        }
        /// <summary>
        /// Caluclate the deduction on floting number
        /// </summary>
        /// <param name="numerator_number_1">first function from</param>
        /// <param name="numerator_number_2">The denominator of the first fraction</param>
        /// <param name="denominator_number_1">The second fraction form</param>
        /// <param name="denominator_number_2">The denominator of the second fraction</param>
        /// <returns>Return a double number</returns>
        /// <exception cref="StackOverflowException">The System can't convert System.String to System.Double</exception>
        public static string Deduction_Division(string numerator_number_1, string numerator_number_2, string denominator_number_1, string denominator_number_2)
        {
                return (((Convert.ToDouble(numerator_number_1) / Convert.ToDouble(denominator_number_1)) / (Convert.ToDouble(numerator_number_2) / Convert.ToDouble(denominator_number_2)))).ToString();
        }
        /// <summary>
        /// Caluclate the deduction on floting number
        /// </summary>
        /// <param name="numerator_number_1">first function from</param>
        /// <param name="numerator_number_2">The denominator of the first fraction</param>
        /// <param name="denominator_number_1">The second fraction form</param>
        /// <param name="denominator_number_2">The denominator of the second fraction</param>
        /// <returns>Return a double number</returns>
        public static double Deduction_mod(double numerator_number_1, double numerator_number_2, double denominator_number_1, double denominator_number_2)
        {
            return ((numerator_number_1 * denominator_number_2) % (numerator_number_2 * denominator_number_1)) / (denominator_number_1 * denominator_number_2);
        }
        /// <summary>
        /// Caluclate the deduction on floting number
        /// </summary>
        /// <param name="numerator_number_1">first function from</param>
        /// <param name="numerator_number_2">The denominator of the first fraction</param>
        /// <param name="denominator_number_1">The second fraction form</param>
        /// <param name="denominator_number_2">The denominator of the second fraction</param>
        /// <returns>Return a double number</returns>
        /// <exception cref="StackOverflowException">The System can't convert System.String to System.Double</exception>
        public static string Deduction_mod(string numerator_number_1, string numerator_number_2, string denominator_number_1, string denominator_number_2)
        {
                return (((Convert.ToDouble(numerator_number_1) * Convert.ToDouble(denominator_number_2)) % (Convert.ToDouble(numerator_number_2) * Convert.ToDouble(denominator_number_1))) / (Convert.ToDouble(denominator_number_1) * Convert.ToDouble(denominator_number_2))).ToString();
        }
        /// <summary>
        /// Caluclate the deduction on floting number
        /// </summary>
        /// <param name="numerator_number_1">first function from</param>
        /// <param name="numerator_number_2">The denominator of the first fraction</param>
        /// <param name="denominator_number_1">The second fraction form</param>
        /// <param name="denominator_number_2">The denominator of the second fraction</param>
        /// <returns>Return a double number</returns>
        public static double Deduction_pow(double numerator_number_1, double numerator_number_2, double denominator_number_1, double denominator_number_2)
        {
            return (Pow(numerator_number_1 * denominator_number_2, numerator_number_2 * denominator_number_1)) / (denominator_number_1 * denominator_number_2);
        }
        /// <summary>
        /// Caluclate the deduction on floting number
        /// </summary>
        /// <param name="numerator_number_1">first function from</param>
        /// <param name="numerator_number_2">The denominator of the first fraction</param>
        /// <param name="denominator_number_1">The second fraction form</param>
        /// <param name="denominator_number_2">The denominator of the second fraction</param>
        /// <returns>Return a double number</returns>
        /// <exception cref="StackOverflowException">The System can't convert System.String to System.Double</exception>
        public static string Deduction_pow(string numerator_number_1, string numerator_number_2, string denominator_number_1, string denominator_number_2)
        {
                return (Pow(Convert.ToDouble(numerator_number_1), Convert.ToDouble(denominator_number_2) * Convert.ToDouble(numerator_number_2) * Convert.ToDouble(denominator_number_1)) / (Convert.ToDouble(denominator_number_1) * Convert.ToDouble(denominator_number_2))).ToString();
        }
        // in deduction
        /// <summary>
        /// Caluclate the deduction on array floting
        /// </summary>
        /// <param name="x">first function from</param>
        /// <param name="y">The denominator of the first fraction</param>
        /// <param name="z">The second fraction form</param>
        /// <param name="a">The denominator of the second fraction</param>
        /// <returns>Return a array double number. the function return two varible in array. 1: The fraction form  - 2: The denominator of the fraction</returns>
        public static double[] Deduction_Plus_deduction(string x, string y, string z, string a)
        {
            try
            {
                if (y == a)
                {
                    double[] s = { Convert.ToDouble(x) + Convert.ToDouble(z), Convert.ToDouble(a) };
                    return SimplifyDeduction(s);
                }
                else
                {
                    double s = Convert.ToDouble(y) * Convert.ToDouble(a);
                    double[] f = { (s / Convert.ToDouble(y)) * Convert.ToDouble(x), (s / Convert.ToDouble(a)) * Convert.ToDouble(z) };
                    double[] d = { f[0] + f[1], s };
                    return SimplifyDeduction(d);
                }
            }
            catch
            {
                double[] e = { 0, 0 };
                return e;
            }
        }
        /// <summary>
        /// Caluclate the deduction on array floting
        /// </summary>
        /// <param name="x">first function from</param>
        /// <param name="y">The denominator of the first fraction</param>
        /// <param name="z">The second fraction form</param>
        /// <param name="a">The denominator of the second fraction</param>
        /// <returns>Return a array double number. the function return two varible in array. 1: The fraction form  - 2: The denominator of the fraction</returns>
        public static double[] Deduction_Minuse_deduction(string x, string y, string z, string a)
        {
            try
            {
                if (y == a)
                {
                    double[] s = { Convert.ToDouble(x) + Convert.ToDouble(z), Convert.ToDouble(a) };
                    return SimplifyDeduction(s);
                }
                else
                {
                    double s = Convert.ToDouble(y) * Convert.ToDouble(a);
                    double[] f = { (s / Convert.ToDouble(y)) * Convert.ToDouble(x), (s / Convert.ToDouble(a)) * Convert.ToDouble(z) };
                    double[] d = { f[0] - f[1], s };
                    return SimplifyDeduction(d);
                }
            }
            catch
            {
                double[] e = { 0, 0 };
                return e;
            }
        }
        /// <summary>
        /// Caluclate the deduction on array floting
        /// </summary>
        /// <param name="x">first function from</param>
        /// <param name="y">The denominator of the first fraction</param>
        /// <param name="z">The second fraction form</param>
        /// <param name="a">The denominator of the second fraction</param>
        /// <returns>Return a array double number. the function return two varible in array. 1: The fraction form  - 2: The denominator of the fraction</returns>
        public static double[] Deduction_MultiPly_deduction(string x, string y, string z, string a)
        {
            try
            {
                double[] s = { Convert.ToDouble(x) * Convert.ToDouble(z), Convert.ToDouble(y) * Convert.ToDouble(a) };
                return  SimplifyDeduction(s);
            }
            catch
            {
                double[] e = { 0, 0 };
                return e;
            }
        }
        /// <summary>
        /// Caluclate the deduction on array floting
        /// </summary>
        /// <param name="x">first function from</param>
        /// <param name="y">The denominator of the first fraction</param>
        /// <param name="z">The second fraction form</param>
        /// <param name="a">The denominator of the second fraction</param>
        /// <returns>Return a array double number. the function return two varible in array. 1: The fraction form  - 2: The denominator of the fraction</returns>
        public static double[] Deduction_Division_deduction(string x, string y, string z, string a)
        {
            try
            {
                double[] d = { Convert.ToDouble(x) * Convert.ToDouble(a), Convert.ToDouble(y) * Convert.ToDouble(z) };
                return SimplifyDeduction(d);
            }
            catch
            {
                double[] e = { 0, 0 };
                return e;
            }
        }
        // for simplify deduction
        private static double[] SimplifyDeduction(double[] input)
        {
            double[] YX = new double[2];
            YX[0] = input[0];
            YX[1] = input[1];
            while (!YX[0].ToString().Contains(".") || !YX[1].ToString().Contains("."))
            {
                int numbers = 100;
                for (int i = 100; i >= 2; i--)
                {
                    if (input[0] != input[1])
                    {
                    simpfilyagian:
                        if ((input[0] % i) == 0 && (input[1] % i) == 0)
                        {
                            double x = YX[0];
                            double y = YX[1];
                            YX[0] /= i;
                            YX[1] /= i;
                            if (YX[0].ToString().Contains(".") || YX[1].ToString().Contains("."))
                            {
                                YX[0] = x;
                                YX[1] = y;
                                goto StopThisscript;
                            }
                            goto simpfilyagian;
                        }
                        else
                        {
                            numbers--;
                            if (numbers < 2)
                                goto StopThisscript;
                        }
                    }
                    else
                    {
                        YX[0] = 1;
                        YX[1] = 1;
                        goto StopThisscript;
                    }
                }
            }
        StopThisscript:
            return YX;
        }
        // -> Comperison
        /// <summary>
        /// compare the input numbers
        /// </summary>
        /// <param name="N1">number one - a double number</param>
        /// <param name="N2">number two - a double number</param>
        /// <param name="N3">number three - a double number</param>
        /// <param name="ComperisonN2And3">if set value for number 2 and number 3 or 1 set this variable to true else false </param>
        /// <param name="ComperisonN1And3">if set value for number 1 and number 3 or 2 set this variable to true else false </param>
        /// <param name="ComperisonN1And2">if set value for number 1 and number 2 or 3 set this variable to true else false </param>
        /// <returns></returns>
        public static string Comperison(double N1, double N2, double N3, Boolean ComperisonN2And3, Boolean ComperisonN1And3, Boolean ComperisonN1And2)
        {
            try
            {
                if (ComperisonN1And2 == true)
                {
                    string N1_N2 = N1.ToString() + ((N1 > N2) ? " > " : (N1 < N2) ? " < " : " = ") + N2.ToString();
                    return N1_N2;
                }
                else if (ComperisonN2And3 == true)
                {
                    string N2_N3 = N2.ToString() + ((N2 > N3) ? " > " : (N2 < N3) ? " < " : " = ") + N3.ToString();
                    return N2_N3;
                }
                else if (ComperisonN1And3 == true)
                {
                    string N1_N3 = N1.ToString() + ((N1 > N3) ? " > " : (N1 < N3) ? " < " : " = ") + N3.ToString();
                    return N1_N3;
                }
                else
                {
                    string N1_N2 = N1.ToString() + ((N1 > N2) ? " > " : (N1 < N2) ? " < " : " = ") + N2.ToString();
                    string RESULT = ((N2 > N3) ? " > " : (N2 < N3) ? " < " : " = ") + N3.ToString();
                    return N1_N2 + " " + RESULT;
                }
            }
            catch
            {
                return "Dont have any input";
            }
        }
        /// <summary>
        /// this function convert a Bin ( binary ) to int ( integer ) 
        /// </summary>
        /// <param name="code">the code is write with 0 and 1</param>
        /// <returns>Return int value</returns>
        public static int ConvertBinToInt(string code)
        {
            int i = 0, m = 0;
            string s = code;
            while (i < s.Length)
            {
                if (s.Substring(i, 1).Equals("0"))
                    m = m * 2;
                else if (s.Substring(i, 1).Equals("1"))
                    m = m * 2 + 1;
                i++;
            }
            return m;
        }
        /// <summary>
        /// this function convert a Bin ( binary ) to int ( integer ) 
        /// </summary>
        /// <param name="code">the code is write with 0 and 1</param>
        /// <returns>Return int value</returns>
        public static int ConvertHexToInt(string code)
        {
            return Int32.Parse(code, NumberStyles.HexNumber);
        }
        /// <summary>
        /// Convert Int ( integer ) to Bin ( binary ) 
        /// </summary>
        /// <param name="number">A int number</param>
        /// <returns>return converted Int ( integer ) number to Bin ( binary ) number</returns>
        /// <exception cref="StackOverflowException">The System can't convert System.String to System.double</exception>
        /// <exception cref="ArgumentException">The value out of range</exception>
        public static string ConvertIntToBin(string number)
        {
                string answer = Convert.ToString(Convert.ToInt32(number), 2);
                return answer;
        }
        /// <summary>
        /// Convert Int ( integer ) to Hex ( hexidecimal ) 
        /// </summary>
        /// <param name="number">A int number</param>
        /// <returns>return converted Int ( integer ) number to Hex ( hexidecimal ) number</returns>
        /// <exception cref="StackOverflowException">The System can't convert System.String to System.double</exception>
        /// <exception cref="ArgumentException">The value out of range</exception>
        public static string ConvertIntToHex(string number)
        {
            try
            {
                return Convert.ToInt32(number).ToString("X");
            }
            catch
            {
                return "Can't be calculate ...";
            }
        }
        public static int Sgn(double value)
        {
            if (value > 0)
                return 1;
            else if (value == 0)
                return 0;
            else
                return -1;
        }
        /// <summary>
        /// give the double facterial of input number
        /// </summary>
        /// <param name="number">A int number for give double facterial</param>
        /// <returns>Return the double facterial of input</returns>
        /// <exception cref="ArgumentException">The input out of range</exception>
        public static int doubleFacterial(int number)
        {
            int ret = 1;
            string i = number.ToString().Substring(number.ToString().Length - 1);
            if (i.Equals("0") || i.Equals("2") || i.Equals("4") || i.Equals("6") || i.Equals("8"))
            {
                for (int f = 2; f <= number; f += 2)
                {
                    ret *= f;
                }
            }
            if (i.Equals("1") || i.Equals("3") || i.Equals("5") || i.Equals("7") || i.Equals("9"))
            {
                for (int f = 1; f <= number; f += 2)
                {
                    ret *= f;
                }
            }
            return ret;
        }
        /// <summary>
        /// give the double facterial of input number
        /// </summary>
        /// <param name="number">A int number for give double facterial</param>
        /// <returns>Return the double facterial of input</returns>
        /// <exception cref="ArgumentException">The input out of range</exception>
        public static int Facterial(int number)
        {
            int o = 1;
            for (int i = 2; i <= number; i++)
                o *= i;
            return o;
        }
        /// <summary>
        /// Give the mutiplication of start and end 
        /// </summary>
        /// <param name="multiplication">the number for give multiplication</param>
        /// <param name="start">the multiplication start from</param>
        /// <param name="end">the multiplication end to</param>
        /// <returns>Return of numtiplication number</returns>
        public static string Multiplication(int multiplication, int start, int end)
        {
            string output = "";
            for (int i = start; i <= end; i++)
            {
                output += " - " + (multiplication * i);
            }
            return output;
        }
        public struct Converts
        {
            public struct Tempeture
            {

                public enum TempetureInput
                {
                    Fahrenheit = 0,
                    Kelvin = 1,
                    Celsius = 2
                }
                /// <summary>
                /// Convert Tempeture
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert celsius to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromCelsius(double d, TempetureInput to)
                {
                    if (to == TempetureInput.Celsius)
                        return d;
                    else if (to == TempetureInput.Fahrenheit)
                        return (d * 9 / 5) + 32;
                    else
                        return d + 273.15;
                }
                /// <summary>
                /// Convert Tempeture
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert fahrenheit to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromFahrenheit(double d, TempetureInput to)
                {
                    if (to == TempetureInput.Celsius)
                        return (d - 32) * 5 / 9;
                    else if (to == TempetureInput.Fahrenheit)
                        return d;
                    else
                        return (d - 32) * 5 / 9 + 273.15;
                }
                /// <summary>
                /// Convert Tempeture
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert kelvin to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromKelvin(double d, TempetureInput to)
                {
                    if (to == TempetureInput.Celsius)
                        return d - 273.15;
                    else if (to == TempetureInput.Fahrenheit)
                        return (d - 273.15) * 9 / 5 + 32;
                    else
                        return d;
                }
            }

            public struct Time
            {
                public enum TimeInput
                {
                    MilliSecond = 0,
                    Second = 1,
                    Minute = 2,
                    Hour = 3,
                    Day = 4
                }
                /// <summary>
                /// Convert Time
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert Milisecond to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromMilliSecond(double d, TimeInput to)
                {
                    if (to == TimeInput.MilliSecond)
                        return d;
                    else if (to == TimeInput.Second)
                        return d / 1E4;
                    else if (to == TimeInput.Minute)
                        return d / 6E4;
                    else if (to == TimeInput.Hour)
                        return d / 36E5;
                    else
                        return d / 864E5;
                }
                /// <summary>
                /// Convert Time
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert second to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromSecond(double d, TimeInput to)
                {
                    if (to == TimeInput.MilliSecond)
                        return d * 1E4;
                    else if (to == TimeInput.Second)
                        return d;
                    else if (to == TimeInput.Minute)
                        return d / 60;
                    else if (to == TimeInput.Hour)
                        return d / 36E2;
                    else
                        return d / 864E2;
                }
                /// <summary>
                /// Convert Time
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert minute to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromMinute(double d, TimeInput to)
                {
                    if (to == TimeInput.MilliSecond)
                        return d * 6E4;
                    else if (to == TimeInput.Second)
                        return d * 60;
                    else if (to == TimeInput.Minute)
                        return d;
                    else if (to == TimeInput.Hour)
                        return d / 60;
                    else
                        return d / 1440;
                }
                /// <summary>
                /// Convert Time
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert hour to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromHour(double d, TimeInput to)
                {
                    if (to == TimeInput.MilliSecond)
                        return d * 36E5;
                    else if (to == TimeInput.Second)
                        return d * 3600;
                    else if (to == TimeInput.Minute)
                        return d * 60;
                    else if (to == TimeInput.Hour)
                        return d;
                    else
                        return d / 24;
                }
                /// <summary>
                /// Convert Time
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert day to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromDay(double d, TimeInput to)
                {
                    if (to == TimeInput.MilliSecond)
                        return d * 864E5;
                    else if (to == TimeInput.Second)
                        return d * 864E2;
                    else if (to == TimeInput.Minute)
                        return d * 1440;
                    else if (to == TimeInput.Hour)
                        return d * 24;
                    else
                        return d;
                }
            }

            public struct Angle
            {
                public enum AngleInput
                {
                    Degrees = 0,
                    Radians = 1,
                    Gradians = 2
                }
                /// <summary>
                /// Convert Angle
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert degress to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromDegrees(double d, AngleInput to)
                {
                    if (to == AngleInput.Degrees)
                        return d;
                    else if (to == AngleInput.Radians)
                        return d * P / 180;
                    else
                        return d* 200 / P;

                }
                /// <summary>
                /// Convert Angle
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert radians to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromRadians(double d, AngleInput to)
                {
                    if (to == AngleInput.Degrees)
                        return d * 200 / P;
                    else if (to == AngleInput.Radians)
                        return d;
                    else
                        return d * 200 / P;
                }
                /// <summary>
                /// Convert Angle
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert gradians to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromGradians(double d, AngleInput to)
                {
                    if (to == AngleInput.Degrees)
                        return d * 180 / 200;
                    else if (to == AngleInput.Radians)
                        return d * P / 200;
                    else
                        return d;
                }
            }

            public struct Mass
            {
                public enum MassInput
                {
                    MicroGram = 0,
                    MilliGram = 1,
                    Gram = 2,
                    KiloGram = 3,
                    Ton = 4
                }
                /// <summary>
                /// Convert Mass
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert microgram to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromMicroGram(double d, MassInput to)
                {
                    if (to == MassInput.MicroGram)
                        return d;
                    else if (to == MassInput.MilliGram)
                        return d / 1000;
                    else if (to == MassInput.Gram)
                        return d / 1E6;
                    else if (to == MassInput.KiloGram)
                        return d / 1E9;
                    else
                        return d / 1E12;
                }
                /// <summary>
                /// Convert Mass
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert milligram to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromMilliGram(double d, MassInput to)
                {
                    if (to == MassInput.MicroGram)
                        return d * 1000;
                    else if (to == MassInput.MilliGram)
                        return d;
                    else if (to == MassInput.Gram)
                        return d / 1000;
                    else if (to == MassInput.KiloGram)
                        return d / 1E6;
                    else
                        return d / 1E9;
                }
                /// <summary>
                /// Convert Mass
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert gram to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromGram(double d, MassInput to)
                {
                    if (to == MassInput.MicroGram)
                        return d * 1E6;
                    else if (to == MassInput.MilliGram)
                        return d * 1000;
                    else if (to == MassInput.Gram)
                        return d;
                    else if (to == MassInput.KiloGram)
                        return d / 1000;
                    else
                        return d / 1E6;
                }
                /// <summary>
                /// Convert Mass
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert kilogram to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromKiloGram(double d, MassInput to)
                {
                    if (to == MassInput.MicroGram)
                        return d * 1E9;
                    else if (to == MassInput.MilliGram)
                        return d * 1E6;
                    else if (to == MassInput.Gram)
                        return d * 1000;
                    else if (to == MassInput.KiloGram)
                        return d;
                    else
                        return d / 1000;
                }
                /// <summary>
                /// Convert Mass
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert ton to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromTon(double d, MassInput to)
                {
                    if (to == MassInput.MicroGram)
                        return d * 1E12;
                    else if (to == MassInput.MilliGram)
                        return d * 1E9;
                    else if (to == MassInput.Gram)
                        return d * 1E6;
                    else if (to == MassInput.KiloGram)
                        return d * 1000;
                    else
                        return d;
                }
            }

            public struct Speed
            {
                public enum SpeedInput
                {
                    MilesPerHour = 0,
                    FootPerSecond = 1,
                    metrePerSecond = 2,
                    KilometrePerHour = 3,
                    Knot = 4
                }
                /// <summary>
                /// Convert Speed
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert 'miles per hour' to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromMilesPerHour(double d, SpeedInput to)
                {
                    if (to == SpeedInput.MilesPerHour)
                        return d;
                    else if (to == SpeedInput.FootPerSecond)
                        return d * 1.46667;
                    else if (to == SpeedInput.metrePerSecond)
                        return d / 2.237;
                    else if (to == SpeedInput.KilometrePerHour)
                        return d * 1.60934;
                    else
                        return d / 1.151;
                }
                /// <summary>
                /// Convert Speed
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert 'foot per second' to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromFootPerSecond(double d, SpeedInput to)
                {
                    if (to == SpeedInput.MilesPerHour)
                        return d / 1.467;
                    else if (to == SpeedInput.FootPerSecond)
                        return d;
                    else if (to == SpeedInput.metrePerSecond)
                        return d / 3.281;
                    else if (to == SpeedInput.KilometrePerHour)
                        return d * 1.09728;
                    else
                        return d / 1.688;
                }
                /// <summary>
                /// Convert Speed
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert 'metre per second' to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromMetrePerSecond(double d, SpeedInput to)
                {
                    if (to == SpeedInput.MilesPerHour)
                        return d / 2.237;
                    else if (to == SpeedInput.FootPerSecond)
                        return d * 3.28084;
                    else if (to == SpeedInput.metrePerSecond)
                        return d;
                    else if (to == SpeedInput.KilometrePerHour)
                        return d * 3.6;
                    else
                        return d * 1.94384;
                }
                /// <summary>
                /// Convert Speed
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert 'kilometre per hour' to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromKilometrePerHour(double d, SpeedInput to)
                {
                    if (to == SpeedInput.MilesPerHour)
                        return d / 1.609;
                    else if (to == SpeedInput.FootPerSecond)
                        return d / 1.097;
                    else if (to == SpeedInput.metrePerSecond)
                        return d / 3.6;
                    else if (to == SpeedInput.KilometrePerHour)
                        return d;
                    else
                        return d / 1.852;
                }
                /// <summary>
                /// Convert Speed
                /// </summary>
                /// <param name="d">number to convert</param>
                /// <param name="to">Convert 'knot' to ...</param>
                /// <returns>Return a Convert</returns>
                public static double FromKnot(double d, SpeedInput to)
                {
                    if (to == SpeedInput.MilesPerHour)
                        return d * 1.15078;
                    else if (to == SpeedInput.FootPerSecond)
                        return d * 1.68781;
                    else if (to == SpeedInput.metrePerSecond)
                        return d / 1.944;
                    else if (to == SpeedInput.KilometrePerHour)
                        return d * 1.852;
                    else
                        return d;
                }
            }
        }
    }
}