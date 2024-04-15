using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Choices
{
    public partial class Sorting : Form
    {
        public Sorting()
        {
            InitializeComponent();
        }

        Button[] buttons;

        private void Sorting_Load(object sender, EventArgs e)
        {
            string[] items = Data.getItems();
            buttons = new Button[items.Length];
            for(int i = 0; i <items.Length; i++)
            {
                buttons[i] = new Button();
                buttons[i].Text = items[i];
                buttons[i].SetBounds(20, (i + 1) * 50, 100, 30);
                Controls.Add(buttons[i]);
            }
        }
    }
}
