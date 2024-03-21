namespace Winforms.Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //create an instance of the NewInventoryItem form
            NewInventoryItem newItemForm = new NewInventoryItem();
            //show the form
            newItemForm.ShowDialog();
            RefreshItems();

        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            RefreshItems();
        }
        public void RefreshItems()
        {
            listBox1.Items.Clear();
            List<InventoryItem> items = InventoryDB.GetItems();
            foreach (InventoryItem item in items)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                List<InventoryItem> items = InventoryDB.GetItems();
                items.RemoveAt(listBox1.SelectedIndex);
                InventoryDB.SaveItems(items);
                RefreshItems();
            }
            
        }
    }
}
