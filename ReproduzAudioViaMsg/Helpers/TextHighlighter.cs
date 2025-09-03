using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReproduzAudioViaMsg.Helpers
{
    public class TextHighlighter
    {
        #region Properties

        private readonly Control _textControl;
        private readonly Color _originalBackColor;
        private readonly Color _originalForeColor;
        private bool _highlightActive = false;

        #endregion

        #region Constructors

        public TextHighlighter(Control textControl)
        {
            _textControl = textControl;
            _originalBackColor = _textControl.BackColor;
            _originalForeColor = _textControl.ForeColor;

            if (_textControl is RichTextBox richTextBox)
            {
                richTextBox.DetectUrls = false;
            }
        }

        #endregion

        public void ApplyHighlight(int position, int length)
        {
            if (_textControl is RichTextBox richTextBox)
            {
                richTextBox.Select(position, length);
                richTextBox.SelectionBackColor = Color.LightBlue;
                richTextBox.SelectionColor = Color.DarkBlue;
                richTextBox.Select(richTextBox.Text.Length, 0);
            }
            else if (_textControl is TextBox textBox)
            {
                textBox.Select(position, length);
                textBox.BackColor = Color.LightBlue;
            }

            _highlightActive = true;
        }

        public void RemoveHighlight()
        {
            if (!_highlightActive)
                return;

            if (_textControl is RichTextBox richTextBox)
            {
                richTextBox.SelectAll();
                richTextBox.SelectionBackColor = _originalBackColor;
                richTextBox.SelectionColor = _originalForeColor;
                richTextBox.Select(richTextBox.Text.Length, 0);
            }
            else if (_textControl is TextBox textBox)
            {
                textBox.BackColor = _originalBackColor;
                textBox.ForeColor = _originalForeColor;
            }

            _highlightActive = false;
        }

        public void ScrollToPosition(int position)
        {
            if (_textControl is RichTextBox richTextBox)
            {
                richTextBox.Select(position, 0);
                richTextBox.ScrollToCaret();
            }
            else if (_textControl is TextBox textBox && textBox.Multiline)
            {
                textBox.Select(position, 0);
                textBox.ScrollToCaret();
            }
        }
    }
}
