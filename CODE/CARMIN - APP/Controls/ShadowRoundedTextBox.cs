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
        public class ShadowRoundedTextBox : UserControl
        {
            private readonly TextBox _textBox;

            private Color _fillColor = Color.White;
            private Color _borderColor = Color.FromArgb(220, 220, 220);
            private Color _focusBorderColor = Color.FromArgb(232, 174, 183);
            private Color _shadowColor = Color.FromArgb(25, 0, 0, 0);
            private Color _placeholderColor = Color.FromArgb(140, 140, 140);

            private int _borderRadius = 16;
            private int _shadowOffset = 3;
            private int _borderThickness = 1;

            private string _placeholderText = "Escribí aquí...";
            private bool _isPlaceholderActive = true;
            private bool _isFocused = false;

            public ShadowRoundedTextBox()
            {
                DoubleBuffered = true;
                ResizeRedraw = true;
                BackColor = Color.Transparent;
                Size = new Size(220, 46);

                SetStyle(
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.UserPaint |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.SupportsTransparentBackColor,
                    true);

                _textBox = new TextBox
                {
                    BorderStyle = BorderStyle.None,
                    BackColor = _fillColor,
                    ForeColor = _placeholderColor,
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point),
                    Location = new Point(14, 14),
                    Width = Width - 28,
                    Text = _placeholderText
                };

                _textBox.Enter += TextBox_Enter;
                _textBox.Leave += TextBox_Leave;
                _textBox.TextChanged += TextBox_TextChanged;
                _textBox.KeyDown += (s, e) => OnKeyDown(e);
                _textBox.KeyPress += (s, e) => OnKeyPress(e);
                _textBox.KeyUp += (s, e) => OnKeyUp(e);

                Controls.Add(_textBox);

                UpdateTextBoxBounds();
            }

            [Category("Appearance")]
            public override Font Font
            {
                get => base.Font;
                set
                {
                    base.Font = value;
                    if (_textBox != null)
                    {
                        _textBox.Font = value;
                        UpdateTextBoxBounds();
                        Invalidate();
                    }
                }
            }

            [Category("Appearance")]
            public override Color ForeColor
            {
                get => base.ForeColor;
                set
                {
                    base.ForeColor = value;
                    if (!_isPlaceholderActive)
                    {
                        _textBox.ForeColor = value;
                    }
                }
            }

            [Category("Appearance")]
            public Color FillColor
            {
                get => _fillColor;
                set
                {
                    _fillColor = value;
                    _textBox.BackColor = value;
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
            public Color FocusBorderColor
            {
                get => _focusBorderColor;
                set
                {
                    _focusBorderColor = value;
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
            public Color PlaceholderColor
            {
                get => _placeholderColor;
                set
                {
                    _placeholderColor = value;
                    if (_isPlaceholderActive)
                    {
                        _textBox.ForeColor = value;
                    }
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
                    UpdateTextBoxBounds();
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

            [Category("Behavior")]
            public string PlaceholderText
            {
                get => _placeholderText;
                set
                {
                    _placeholderText = value ?? string.Empty;

                    if (_isPlaceholderActive)
                    {
                        _textBox.Text = _placeholderText;
                        _textBox.ForeColor = _placeholderColor;
                    }

                    Invalidate();
                }
            }

            [Category("Behavior")]
            public override string Text
            {
                get => _isPlaceholderActive ? string.Empty : _textBox.Text;
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        SetPlaceholder();
                    }
                    else
                    {
                        _isPlaceholderActive = false;
                        _textBox.Text = value;
                        _textBox.ForeColor = ForeColor;
                    }

                    Invalidate();
                }
            }

            [Category("Behavior")]
            public bool UseSystemPasswordChar
            {
                get => _textBox.UseSystemPasswordChar;
                set
                {
                    _textBox.UseSystemPasswordChar = !_isPlaceholderActive && value;
                }
            }

            [Category("Behavior")]
            public bool Multiline
            {
                get => _textBox.Multiline;
                set
                {
                    _textBox.Multiline = value;
                    UpdateTextBoxBounds();
                    Invalidate();
                }
            }

            [Category("Behavior")]
            public HorizontalAlignment TextAlign
            {
                get => _textBox.TextAlign;
                set => _textBox.TextAlign = value;
            }

            [Category("Behavior")]
            public int MaxLength
            {
                get => _textBox.MaxLength;
                set => _textBox.MaxLength = value;
            }

            [Category("Behavior")]
            public new event EventHandler? TextChanged;

            [Category("Behavior")]
            public CharacterCasing CharacterCasing
            {
                get => _textBox.CharacterCasing;
                set => _textBox.CharacterCasing = value;
            }

            [Category("Behavior")]
            public ScrollBars ScrollBars
            {
                get => _textBox.ScrollBars;
                set => _textBox.ScrollBars = value;
            }

            [Browsable(false)]
            public TextBox InnerTextBox => _textBox;

            protected override void OnResize(EventArgs e)
            {
                base.OnResize(e);
                UpdateTextBoxBounds();
                Invalidate();
            }

            protected override void OnClick(EventArgs e)
            {
                base.OnClick(e);
                _textBox.Focus();
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

                Rectangle boxRect = new Rectangle(
                    0,
                    0,
                    Width - _shadowOffset - 1,
                    Height - _shadowOffset - 1
                );

                using GraphicsPath shadowPath = GetRoundedPath(shadowRect, _borderRadius);
                using SolidBrush shadowBrush = new SolidBrush(_shadowColor);
                e.Graphics.FillPath(shadowBrush, shadowPath);

                using GraphicsPath boxPath = GetRoundedPath(boxRect, _borderRadius);
                using SolidBrush fillBrush = new SolidBrush(_fillColor);
                e.Graphics.FillPath(fillBrush, boxPath);

                Color currentBorderColor = _isFocused ? _focusBorderColor : _borderColor;
                using Pen borderPen = new Pen(currentBorderColor, _borderThickness);
                e.Graphics.DrawPath(borderPen, boxPath);
            }

            private void UpdateTextBoxBounds()
            {
                if (_textBox == null) return;

                int leftPadding = 14;
                int rightPadding = 14;
                int topPadding = _textBox.Multiline ? 12 : Math.Max(10, (Height - _shadowOffset - _textBox.Font.Height) / 2 - 1);

                _textBox.Location = new Point(leftPadding, topPadding);
                _textBox.Width = Math.Max(50, Width - leftPadding - rightPadding - _shadowOffset);

                if (_textBox.Multiline)
                {
                    _textBox.Height = Math.Max(24, Height - topPadding - 12 - _shadowOffset);
                }
            }

            private void TextBox_Enter(object? sender, EventArgs e)
            {
                _isFocused = true;

                if (_isPlaceholderActive)
                {
                    _isPlaceholderActive = false;
                    _textBox.Text = string.Empty;
                    _textBox.ForeColor = ForeColor;

                    if (UseSystemPasswordChar)
                        _textBox.UseSystemPasswordChar = true;
                }

                Invalidate();
            }

            private void TextBox_Leave(object? sender, EventArgs e)
            {
                _isFocused = false;

                if (string.IsNullOrWhiteSpace(_textBox.Text))
                {
                    SetPlaceholder();
                }

                Invalidate();
            }

            private void TextBox_TextChanged(object? sender, EventArgs e)
            {
                if (!_isPlaceholderActive)
                {
                    TextChanged?.Invoke(this, e);
                }
            }

            private void SetPlaceholder()
            {
                _isPlaceholderActive = true;
                _textBox.UseSystemPasswordChar = false;
                _textBox.Text = _placeholderText;
                _textBox.ForeColor = _placeholderColor;
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
