using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace WpfAppHoofdstuk11
{
    class Bubble : Sphere
    {
        protected int radius = 60;

        public int Size
        {
            set { radius = value; UpdateEllipse(); }
        }

        public override void UpdateEllipse()
        {
            if (ellipse != null)
            {
                ellipse.Margin = new Thickness(xCoord, yCoord, 0, 0);
                ellipse.Width = 2 * radius;
                ellipse.Height = 2 * radius;
            }
        }

        public void MoveVertical(int amount)
        {
            yCoord += amount;
            UpdateEllipse();
        }
    }
}
