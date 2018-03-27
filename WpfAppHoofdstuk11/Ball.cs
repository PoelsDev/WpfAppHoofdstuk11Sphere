using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace WpfAppHoofdstuk11
{
    class Ball : Sphere
    {
        public override void UpdateEllipse()
        {
            if (ellipse != null)
            {
                ellipse.Margin = new Thickness(xCoord, yCoord, 0, 0);               
            }
        }

        public void MoveRight(int amount)
        {
            xCoord = xCoord + amount;
            UpdateEllipse();
        }

        public void MoveLeft(int amount)
        {
            xCoord = xCoord - amount;
            UpdateEllipse();
        }
    }
}
