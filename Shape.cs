using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns {
    public abstract class Shape {
        public int X { get; set; }
        public int Y { get; set; }

        public abstract Shape Clone();
    }

    public class Square : Shape {
        private int Side;

        public Square(int x, int y, int s) {
            X = x;
            Y = y;
            Side = s;
        }

        public override Shape Clone() {
            return new Square(X, Y, Side);
        }
    }

    public class Triangle : Shape {
        private int Base;
        private int Height;

        public Triangle(int x, int y, int b, int h) {
            X = x;
            Y = y;
            Base   = b;
            Height = h;
        }

        public override Shape Clone() {
            return new Triangle(X, Y, Base, Height);
        }
    }
}
