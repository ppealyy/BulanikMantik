using System;
using System.Collections.Generic;

namespace BulanikMantik.Models
{
    public class FuzzySet
    {
        public string Name { get; set; }
        public List<double> Points { get; set; }
        public string Type { get; set; }

        public FuzzySet(string name, string type, List<double> points)
        {
            Name = name;
            Type = type;
            Points = points;
        }

        public double GetMembership(double x)
        {
            if (Type == "triangle")
            {
                double a = Points[0], b = Points[1], c = Points[2];
                if (x <= a || x >= c) return 0;
                else if (x == b) return 1;
                else if (x < b) return (x - a) / (b - a);
                else return (c - x) / (c - b);
            }
            else // trapezoid
            {
                double a = Points[0], b = Points[1], c = Points[2], d = Points[3];
                if (x <= a || x >= d) return 0;
                else if (x >= b && x <= c) return 1;
                else if (x < b) return (x - a) / (b - a);
                else return (d - x) / (d - c);
            }
        }
    }
}
