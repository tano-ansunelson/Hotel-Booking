using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel_Booking.Services;

public static class Icons
{

    private static readonly Dictionary<string, Image> Cache = new();

    public static Image? Get(string name)
    {
        if (Cache.TryGetValue(name, out var cached)) return cached;

        string path = Path.Combine(AppContext.BaseDirectory, "Assets", "Icons", name + ".png");

        if (!File.Exists(path)) return null;

        using var temp = Image.FromFile(path);
        var image = new Bitmap(temp);
        Cache[name] = image;

        return image;
    }
}

