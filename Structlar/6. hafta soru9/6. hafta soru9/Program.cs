using System;

struct ComplexNumber
{
    public double Real;
    public double Imaginary;

    // Constructor
    public ComplexNumber(double real, double imaginary)
    {
        Real = real;
        Imaginary = imaginary;
    }

    // Toplama işlemi
    public static ComplexNumber Add(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
    }

    // Çıkarma işlemi
    public static ComplexNumber Subtract(ComplexNumber c1, ComplexNumber c2)
    {
        return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
    }

    // Karmaşık sayıyı "a + bi" formatında döndüren ToString metodu
    public override string ToString()
    {
        return $"{Real} + {Imaginary}i";
    }
}

class Program
{
    static void Main()
    {
        ComplexNumber complex1 = new ComplexNumber(4, 5);  // 4 + 5i
        ComplexNumber complex2 = new ComplexNumber(2, 3);  // 2 + 3i

        ComplexNumber sum = ComplexNumber.Add(complex1, complex2);
        ComplexNumber difference = ComplexNumber.Subtract(complex1, complex2);

        Console.WriteLine($"Toplam: {sum}");
        Console.WriteLine($"Fark: {difference}");
    }
}
