
namespace Azzeton.Shared
{
    /// <summary>
    /// Value conversion
    /// </summary>
    public class Converter
    {
        /// <summary>
        /// Converts an interger value to hex equivalent
        /// </summary>
        /// <param name="number">integer value</param>
        /// <returns>hex representation</returns>
        public static string ToHexadecimal(int number)
        {
            return number.ToString("X");
        }
        /// <summary>
        /// Convert a hex value to integer
        /// </summary>
        /// <param name="hex">hex value as a string</param>
        /// <returns>integer representation</returns>
        public static int  ToDecimal(string hex)
        {
            return int.Parse(hex, System.Globalization.NumberStyles.HexNumber);
        }
    }
}
