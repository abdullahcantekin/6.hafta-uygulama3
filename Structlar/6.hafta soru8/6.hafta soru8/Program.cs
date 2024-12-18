using System;

struct Time
{
    public int Hour;
    public int Minute;

    // Constructor
    public Time(int hour, int minute)
    {
        Hour = (hour >= 0 && hour < 24) ? hour : 0;
        Minute = (minute >= 0 && minute < 60) ? minute : 0;
    }

    // Toplam dakika değerini döndüren metot
    public int GetTotalMinutes()
    {
        return Hour * 60 + Minute;
    }

    // İki zaman arasındaki farkı dakika olarak hesaplayan metot
    public static int DifferenceInMinutes(Time t1, Time t2)
    {
        return Math.Abs(t1.GetTotalMinutes() - t2.GetTotalMinutes());
    }
}

class Program
{
    static void Main()
    {
        Time time1 = new Time(12, 45);  // 12:45
        Time time2 = new Time(14, 30);  // 14:30

        Console.WriteLine($"Toplam Dakika (Time1): {time1.GetTotalMinutes()}");
        Console.WriteLine($"Zamanlar Arasındaki Fark: {Time.DifferenceInMinutes(time1, time2)} dakika");
    }
}

