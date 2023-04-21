using System.IO.Pipes;
using System.Transactions;

namespace Dz8_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ch;
            do
            {
                Console.Write("Enter task (1 - 3): ");
                ch = int.Parse(Console.ReadLine());
                switch (ch) 
                {
                    case 1:
                        Vector vec1 = new Vector();
                        Vector vec2 = new Vector();
                        double num, X, Y, Z;
                        Console.Write("Vector 1:\nX: ");
                        X = int.Parse(Console.ReadLine());
                        Console.Write("Y: ");
                        Y = int.Parse(Console.ReadLine());
                        Console.Write("Z: ");
                        Z = int.Parse(Console.ReadLine());
                        vec1.x = X;
                        vec1.y = Y;
                        vec1.z = Z;
                        Console.Write("\nVector 2:\nX: ");
                        X = int.Parse(Console.ReadLine());
                        Console.Write("Y: ");
                        Y = int.Parse(Console.ReadLine());
                        Console.Write("Z: ");
                        Z = int.Parse(Console.ReadLine());
                        vec2.x = X;
                        vec2.y = Y;
                        vec2.z = Z;
                        Console.WriteLine($"\nVector 1: {vec1.x}; {vec1.y}; {vec1.z}");
                        Console.WriteLine($"Vector 2: {vec2.x}; {vec2.y}; {vec2.z}");
                        Console.Write("\nEnter num: ");
                        num = int.Parse(Console.ReadLine());
                        Vector rez = vec1 * num;
                        Console.WriteLine($"\nMultiply vector 1 on number: {rez.x}; {rez.y}; {rez.z}");
                        rez = vec1 + vec2;
                        Console.WriteLine($"\nAdd vectors: {rez.x}; {rez.y}; {rez.z}");
                        rez = vec1 - vec2;
                        Console.WriteLine($"\nSubtract vectors: {rez.x}; {rez.y}; {rez.z}");
                        break;
                    case 2:
                        int Num;
                        Console.Write("\nEnter number to convert: ");
                        Num = int.Parse(Console.ReadLine());
                        Number number = new Number(Num);
                        Console.Write($"\nConvert number to binary: {number.Binary()}");
                        Console.Write($"\nConvert number to octal: {number.Octal()}");
                        Console.Write($"\nConvert number to hexadecimal: {number.Hexadecimal()}");
                        break;
                    case 3:
                        int R, G, B;
                        RGB color = new RGB();
                        Console.Write("\nEnter red value: ");
                        R = int.Parse(Console.ReadLine());
                        Console.Write("Enter green value: ");
                        G = int.Parse(Console.ReadLine());
                        Console.Write("Enter blue value: ");
                        B = int.Parse(Console.ReadLine());
                        color.R = R;
                        color.G = G;
                        color.B = B;
                        Console.WriteLine($"\nRGB value: {color.R}, {color.G}, {color.B}");
                        string hex = color.HEX();
                        Console.WriteLine($"RGB color ({color.R}, {color.G}, {color.B}) in HEX format: {hex}");
                        color.HSL(out double h, out double s, out double l);
                        Console.WriteLine($"RGB color ({color.R}, {color.G}, {color.B}) in HSL format: H={h:F2}, S={s:F2}, L={l:F2}");
                        color.CMYK(out double c, out double m, out double y, out double k);
                        Console.WriteLine($"RGB color ({color.R}, {color.G}, {color.B}) in CMYK format: C={c:F2}, M={m:F2}, Y={y:F2}, K={k:F2}");
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;
                }
            } while (ch < 1 || ch > 3);
        }
    }
}