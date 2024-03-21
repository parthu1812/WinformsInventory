using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Winforms.Inventory
{
    public partial class NewInventoryItem : Form
    {
        public NewInventoryItem()
        {
            InitializeComponent();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //add items from text box to the list
            InventoryItem item = new InventoryItem
            {
                ItemNo = Convert.ToInt32(itemTxt.Text),
                Description = descTxt.Text,
                Price = Convert.ToDecimal(priceTxt.Text)
            };

            List<InventoryItem> items = InventoryDB.GetItems();
            items.Add(item);
            InventoryDB.SaveItems(items);
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
