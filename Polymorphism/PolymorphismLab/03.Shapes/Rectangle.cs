using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    public class Rectangle : Shape
    {
        private double height;
        private double width;

        public double Height
        {
            get => this.height;
            private set
            {
                {
                    if (value > 0)
                    {
                        this.height = value;
                    }
                }
            }
        }
        public double Width
        {
            get => this.width;
            private set
            {
                {
                    if (value > 0)
                    {
                        this.width = value;
                    }
                }
            }
        }

        public Rectangle(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }
        public override double CalculateArea()
        {
            return this.Width * this.Height;
        }

        public override double CalculatePerimeter()
        {
            return this.Width * 2 + this.Height * 2;
        }

        public override string Draw()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(DrawLine(this.Width, '*', '*'));
            for (int i = 1; i < this.Height - 1; ++i)
                sb.Append(DrawLine(this.Width, '*', ' '));
            sb.Append(DrawLine(this.Width, '*', '*'));
            return sb.ToString();
            
        }
        private string DrawLine(double width, char end, char mid)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(end);
            for (int i = 1; i < width - 1; ++i)
                sb.Append(mid);
            sb.AppendLine(end.ToString());
            return sb.ToString();
        }
    }
}

