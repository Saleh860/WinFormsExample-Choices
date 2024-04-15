using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choices
{
    internal class Data
    {
        private static string[] items;

        public static string[] getItems() { return items; }

        public static void setItems(System.Windows.Forms.ListBox.ObjectCollection inputItems)
        {
            items = new string[inputItems.Count];
            for(int i = 0; i < items.Length; i++)
            {
                items[i] = inputItems[i].ToString();
            }
        }
    }
}
