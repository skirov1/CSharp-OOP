using System;
using System.Collections.Generic;
using System.Text;

namespace _01.ClassBoxData
{
    public class Box
    {
        private double length;
        private double width;
        private double height;

        public double Length
        {
            get => this.length;
            private set
            {
                if (value > 0)
                {
                    this.length = value;
                }
                else
                {
                    Console.WriteLine("Length cannot be zero or negative.");
                    Environment.Exit(0);
                }
            }
        }
        public double Width
        {
            get => this.width;
            private set
            {
                if (value > 0)
                {
                    this.width = value;
                }
                else
                {
                    Console.WriteLine("Width cannot be zero or negative.");
                    Environment.Exit(0);
                }
            }
        }
        public double Height
        {
            get => this.height;
            private set
            {
                if (value > 0)
                {
                    this.height = value;
                }
                else
                {
                    Console.WriteLine("Height cannot be zero or negative.");
                    Environment.Exit(0);
                }
            }
        }
        public Box(double length, double height, double width)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public double SurfaceArea()
        {
            return 2 * (this.Length * this.Width) + 2 * (this.Length * this.Height) + 2 * (this.Width * this.Height);
        }
        public double LateralSurfaceArea()
        {
            return 2 * (this.Length * this.Height) + 2 * (this.Width * this.Height);
        }
        public double Volume()
        {
            return this.Length * this.Height * this.Width;
        }

    }
}
