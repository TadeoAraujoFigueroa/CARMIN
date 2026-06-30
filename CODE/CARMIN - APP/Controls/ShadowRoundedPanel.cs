using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARMIN___APP.Controls
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;

    namespace CARMIN.UI.Controls
    {
        public class ShadowRoundedPanel : Panel
        {
            private Color _fillColor = Color.White;
            private Color _borderColor = Color.FromArgb(230, 230, 230);
            private Color _shadowColor = Color.FromArgb(18, 0, 0, 0);
            private Color _titleColor = Color.FromArgb(60, 60, 60);

            private int _borderRadius = 20;
            private int _shadowOffset = 4;
            private int _borderThickness = 1;

            private string _title = string.Empty;
            private Font _titleFont = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            private int _titlePaddingLeft = 18;
            private int _titlePaddingTop = 14;
            private int _contentTopPadding = 42;

            public ShadowRoundedPanel()
            {
                DoubleBuffered = true;
                ResizeRedraw = true;
                BackColor = Color.FromArgb(243, 238, 224);

                SetStyle(
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.UserPaint |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.OptimizedDoubleBuffer, 
                    true);

                Padding = new Padding(18, _contentTopPadding, 18, 18);
                Size = new Size(260, 180);
            }

            [Category("Appearance")]
            public Color FillColor
            {
                get => _fillColor;
                set
                {
                    _fillColor = value;
                    Invalidate();
                }
            }

            [Category("Appearance")]
            public Color BorderColor
            {
                get => _borderColor;
                set
                {
                    _borderColor = value;
                    Invalidate();
                }
            }

            [Category("Appearance")]
            public Color ShadowColor
            {
                get => _shadowColor;
                set
                {
                    _shadowColor = value;
                    Invalidate();
                }
            }

            [Category("Appearance")]
            public Color TitleColor
            {
                get => _titleColor;
                set
                {
                    _titleColor = value;
                    Invalidate();
                }
            }

            [Category("Appearance")]
            public int BorderRadius
            {
                get => _borderRadius;
                set
                {
                    _borderRadius = Math.Max(1, value);
                    Invalidate();
                }
            }

            [Category("Appearance")]
            public int ShadowOffset
            {
                get => _shadowOffset;
                set
                {
                    _shadowOffset = Math.Max(0, value);
                    Invalidate();
                }
            }

            [Category("Appearance")]
            public int BorderThickness
            {
                get => _borderThickness;
                set
                {
                    _borderThickness = Math.Max(1, value);
                    Invalidate();
                }
            }

            [Category("Appearance")]
            public string Title
            {
                get => _title;
                set
                {
                    _title = value ?? string.Empty;
                    Invalidate();
                }
            }

            [Category("Appearance")]
            public Font TitleFont
            {
                get => _titleFont;
                set
                {
                    _titleFont = value ?? new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
                    Invalidate();
                }
            }

            [Category("Layout")]
            public int TitlePaddingLeft
            {
                get => _titlePaddingLeft;
                set
                {
                    _titlePaddingLeft = Math.Max(0, value);
                    Invalidate();
                }
            }

            [Category("Layout")]
            public int TitlePaddingTop
            {
                get => _titlePaddingTop;
                set
                {
                    _titlePaddingTop = Math.Max(0, value);
                    Invalidate();
                }
            }

            [Category("Layout")]
            public int ContentTopPadding
            {
                get => _contentTopPadding;
                set
                {
                    _contentTopPadding = Math.Max(0, value);
                    Padding = new Padding(Padding.Left, _contentTopPadding, Padding.Right, Padding.Bottom);
                    Invalidate();
                }
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

                Rectangle shadowRect = new Rectangle(
                    _shadowOffset,
                    _shadowOffset,
                    Width - _shadowOffset - 1,
                    Height - _shadowOffset - 1
                );

                Rectangle panelRect = new Rectangle(
                    0,
                    0,
                    Width - _shadowOffset - 1,
                    Height - _shadowOffset - 1
                );

                if (panelRect.Width <= 0 || panelRect.Height <= 0)
                    return;

                /*using (GraphicsPath shadowPath = GetRoundedPath(shadowRect, _borderRadius))
                using (SolidBrush shadowBrush = new SolidBrush(_shadowColor))
                {
                    e.Graphics.FillPath(shadowBrush, shadowPath);
                }
                */
                using (GraphicsPath panelPath = GetRoundedPath(panelRect, _borderRadius))
                using (SolidBrush fillBrush = new SolidBrush(_fillColor))
                using (Pen borderPen = new Pen(_borderColor, _borderThickness))
                {
                    e.Graphics.FillPath(fillBrush, panelPath);
                    e.Graphics.DrawPath(borderPen, panelPath);
                }

                if (!string.IsNullOrWhiteSpace(_title))
                {
                    Rectangle titleRect = new Rectangle(
                        _titlePaddingLeft,
                        _titlePaddingTop,
                        panelRect.Width - (_titlePaddingLeft * 2),
                        _titleFont.Height + 6
                    );

                    TextRenderer.DrawText(
                        e.Graphics,
                        _title,
                        _titleFont,
                        titleRect,
                        _titleColor,
                        TextFormatFlags.Left | TextFormatFlags.VerticalCenter | TextFormatFlags.EndEllipsis
                    );
                }
            }

            protected override void OnResize(EventArgs eventargs)
            {
                base.OnResize(eventargs);
                Invalidate();
            }

            private static GraphicsPath GetRoundedPath(Rectangle rect, int radius)
            {
                GraphicsPath path = new GraphicsPath();

                int diameter = radius * 2;
                if (diameter > rect.Width) diameter = rect.Width;
                if (diameter > rect.Height) diameter = rect.Height;

                Rectangle arc = new Rectangle(rect.Location, new Size(diameter, diameter));

                path.AddArc(arc, 180, 90);
                arc.X = rect.Right - diameter;
                path.AddArc(arc, 270, 90);
                arc.Y = rect.Bottom - diameter;
                path.AddArc(arc, 0, 90);
                arc.X = rect.Left;
                path.AddArc(arc, 90, 90);

                path.CloseFigure();
                return path;
            }
        }
    }
}
