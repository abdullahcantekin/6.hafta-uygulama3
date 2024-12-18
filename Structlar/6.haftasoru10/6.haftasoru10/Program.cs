using System;

struct GPSLocation
{
    public double Latitude;
    public double Longitude;

    // Constructor
    public GPSLocation(double latitude, double longitude)
    {
        Latitude = latitude;
        Longitude = longitude;
    }

    // Haversine formülünü kullanarak iki GPS konumu arasındaki mesafeyi hesaplayan metot
    public static double GetDistance(GPSLocation loc1, GPSLocation loc2)
    {
        const double R = 6371;  // Dünya'nın yarıçapı (km)

        // Koordinatları radyan cinsinden hesapla
        double lat1Rad = ToRadians(loc1.Latitude);
        double lon1Rad = ToRadians(loc1.Longitude);
        double lat2Rad = ToRadians(loc2.Latitude);
        double lon2Rad = ToRadians(loc2.Longitude);

        // Farklar
        double dLat = lat2Rad - lat1Rad;
        double dLon = lon2Rad - lon1Rad;

        // Haversine formülü
        double a = Math.Sin(dLat / 2) * Math.Sin(dLat / 2) +
                   Math.Cos(lat1Rad) * Math.Cos(lat2Rad) *
                   Math.Sin(dLon / 2) * Math.Sin(dLon / 2);
        double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

        // Mesafeyi döndür
        return R * c;
    }

    // Dereceyi radiana çeviren yardımcı metot
    private static double ToRadians(double degree)
    {
        return degree * (Math.PI / 180);
    }
}

class Program
{
    static void Main()
    {
        GPSLocation loc1 = new GPSLocation(40.748817, -73.985428);  // New York
        GPSLocation loc2 = new GPSLocation(34.052235, -118.243683); // Los Angeles

        double distance = GPSLocation.GetDistance(loc1, loc2);
        Console.WriteLine($"Mesafe: {distance} km");
    }
}
