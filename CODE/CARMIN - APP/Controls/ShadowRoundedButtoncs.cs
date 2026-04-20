using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using CARMIN___BLL.Helper;

namespace CARMIN___APP.Controls
{
 
        public class ShadowRoundedButton : UserControl
        {
            private string _buttonText = "Botón";
            private Color _fillColor = Color.FromArgb(232, 174, 183);
            private Color _textColor = Color.White;
            private Color _shadowColor = Color.FromArgb(45, 0, 0, 0);
            private int _borderRadius = 100;
            private int _shadowOffset = 4;
            private int _hoverLift = 2;
            private bool _isHovering = false;

        
            public ShadowRoundedButton()
            {
                DoubleBuffered = true;
                ResizeRedraw = true;
                Cursor = Cursors.Hand;

                PrivateFontCollection pfc = new PrivateFontCollection();

                /*
                string path = Path.Combine(Application.StartupPath, "Poppins-Regular.ttf");

                pfc.AddFontFile(path);

                Font poppins = new Font(pfc.Families[0], 12);

                Font = poppins;
                */
                
                Font = new Font("Segoe UI", 10F, FontStyle.Bold);

                Size = new Size(160, 48);

                BackColor = Color.Transparent;

                SetStyle(
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.UserPaint |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.SupportsTransparentBackColor,
                    true);
            }

            [Category("Appearance")]
            public override string Text
            {
                get => _buttonText;
                set
                {
                    _buttonText = value;
                    Invalidate();
                }
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
            public Color ButtonTextColor
            {
                get => _textColor;
                set
                {
                    _textColor = value;
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

            [Category("Behavior")]
            public int HoverLift
            {
                get => _hoverLift;
                set
                {
                    _hoverLift = Math.Max(0, value);
                    Invalidate();
                }
            }

            [Category("Appearance")]
            public ContentAlignment TextAlign { get; set; } = ContentAlignment.MiddleCenter;

            protected override void OnMouseEnter(EventArgs e)
            {
                base.OnMouseEnter(e);
                _isHovering = true;
                Invalidate();
            }

            protected override void OnMouseLeave(EventArgs e)
            {
                base.OnMouseLeave(e);
                _isHovering = false;
                Invalidate();
            }

            protected override void OnMouseDown(MouseEventArgs e)
            {
                base.OnMouseDown(e);
                Invalidate();
            }

            protected override void OnMouseUp(MouseEventArgs e)
            {
                base.OnMouseUp(e);
                Invalidate();
            }

            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);

                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                e.Graphics.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;

                int lift = _isHovering ? _hoverLift : 0;

                Rectangle shadowRect = new Rectangle(
                    _shadowOffset,
                    _shadowOffset - lift,
                    Width - _shadowOffset - 1,
                    Height - _shadowOffset - 1
                );

                Rectangle buttonRect = new Rectangle(
                    0,
                    -lift,
                    Width - _shadowOffset - 1,
                    Height - _shadowOffset - 1
                );

                if (buttonRect.Width <= 0 || buttonRect.Height <= 0)
                    return;

                using GraphicsPath shadowPath = GetRoundedPath(shadowRect, _borderRadius);
                using SolidBrush shadowBrush = new SolidBrush(_shadowColor);
                e.Graphics.FillPath(shadowBrush, shadowPath);

                Color currentFill = Enabled ? _fillColor : ControlPaint.Light(_fillColor, 0.3f);
                if (ClientRectangle.Contains(PointToClient(Cursor.Position)) && MouseButtons == MouseButtons.Left)
                {
                    currentFill = ControlPaint.Dark(currentFill, 0.08f);
                }

                using GraphicsPath buttonPath = GetRoundedPath(buttonRect, _borderRadius);
                using SolidBrush buttonBrush = new SolidBrush(currentFill);
                e.Graphics.FillPath(buttonBrush, buttonPath);

                using Pen borderPen = new Pen(ControlPaint.Dark(currentFill, 0.06f), 1);
                e.Graphics.DrawPath(borderPen, buttonPath);

                DrawButtonText(e.Graphics, buttonRect);
            }

            private void DrawButtonText(Graphics g, Rectangle rect)
            {
                TextFormatFlags flags = TextFormatFlags.EndEllipsis | TextFormatFlags.SingleLine;

                flags |= TextAlign switch
                {
                    ContentAlignment.TopLeft => TextFormatFlags.Left | TextFormatFlags.Top,
                    ContentAlignment.TopCenter => TextFormatFlags.HorizontalCenter | TextFormatFlags.Top,
                    ContentAlignment.TopRight => TextFormatFlags.Right | TextFormatFlags.Top,
                    ContentAlignment.MiddleLeft => TextFormatFlags.Left | TextFormatFlags.VerticalCenter,
                    ContentAlignment.MiddleCenter => TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter,
                    ContentAlignment.MiddleRight => TextFormatFlags.Right | TextFormatFlags.VerticalCenter,
                    ContentAlignment.BottomLeft => TextFormatFlags.Left | TextFormatFlags.Bottom,
                    ContentAlignment.BottomCenter => TextFormatFlags.HorizontalCenter | TextFormatFlags.Bottom,
                    ContentAlignment.BottomRight => TextFormatFlags.Right | TextFormatFlags.Bottom,
                    _ => TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter
                };

                Color drawColor = Enabled ? _textColor : SystemColors.GrayText;

                TextRenderer.DrawText(
                    g,
                    _buttonText,
                    Font,
                    rect,
                    drawColor,
                    flags
                );
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

            protected override void OnClick(EventArgs e)
            {
                base.OnClick(e);
            }

        }
}

