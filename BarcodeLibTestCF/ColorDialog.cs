using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace BarcodeLibTestCF
{
    public partial class ColorDialog : Form
    {
        bool _anyColor=true;
        public bool AnyColor
        {
            get { return _anyColor; }
            set { _anyColor = value; }
        }

        Color _color = Color.Black;
        public Color @Color
        {
            get { return _color; }
            set { _color = value; }
        }

        class myColor
        {
            public Color _mColor;
            public string _name;
            public myColor(Color _c, string _n)
            {
                _mColor = _c;
                _name = _n;
            }
            public override string ToString()
            {
                return _name;
            }
        }
        myColor[] _colorset = new myColor[]{
            new myColor(Color.FromArgb(0,0,0), "Black"),
            new myColor(Color.FromArgb(255,0,0),"Red"),
            new myColor(Color.FromArgb(0,255,0),"Green"),
            new myColor(Color.FromArgb(0,0,255),"Blue"),
            new myColor(Color.FromArgb(128,128,128),"Grey"),
            new myColor(Color.FromArgb(255,255,255),"White"),
        };

        public ColorDialog()
        {
            InitializeComponent();
            foreach (myColor c in _colorset)
            {
                listBox1.Items.Add(c);
            }
            listBox1.SelectedIndex = 0;
        }

        private void mnuOK_Click(object sender, EventArgs e)
        {
            _color = ((myColor)listBox1.SelectedItem)._mColor;
            this.DialogResult = DialogResult.OK;
        }

        private void mnuCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}