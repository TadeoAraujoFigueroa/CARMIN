using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___APP.Helpers
{

    public static class RoundedPanelHelper
        {
        public static GraphicsPath CreateRoundedPath(
                Rectangle rect,
                int radius)
            {
                GraphicsPath path = new GraphicsPath();

                int diameter = radius * 2;

                if (diameter > rect.Width)
                    diameter = rect.Width;

                if (diameter > rect.Height)
                    diameter = rect.Height;

                Rectangle arc = new Rectangle(
                    rect.X,
                    rect.Y,
                    diameter,
                    diameter);

                // Superior izquierda
                path.AddArc(arc, 180, 90);

                // Superior derecha
                arc.X = rect.Right - diameter;
                path.AddArc(arc, 270, 90);

                // Inferior derecha
                arc.Y = rect.Bottom - diameter;
                path.AddArc(arc, 0, 90);

                // Inferior izquierda
                arc.X = rect.Left;
                path.AddArc(arc, 90, 90);

                path.CloseFigure();

                return path;
            }
        }
    }

