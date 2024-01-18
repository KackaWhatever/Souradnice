using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Souřadnice;

namespace Souřadnice
{
    public class Coord : IEquatable<Coord>, IComparable<Coord>
    {
        public Coord(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public bool Equals(Coord other)
        {
            if (other == null) 
                return false;
            return true;
        }
        /*
        public static bool operator >(Coord operator1, Coord operator2)
        {
            return operator1.CompareTo(operator2) > 0;
        }

        public int CompareTo(Coord other)
        {
            if (other == null) return 1;
            return X.CompareTo(other.X);
        }*/
    }
}
