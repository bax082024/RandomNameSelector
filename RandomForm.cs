namespace RandomNameSelector
{
    public partial class RandomForm : Form
    {
        public RandomForm()
        {
            InitializeComponent();
        }

        private void buttonPickRandom_Click(object sender, EventArgs e)
        {
            // Check if there are names in the list
            if (listBoxNames.Items.Count == 0)
            {
                MessageBox.Show("No names available to pick!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        private void buttonAddName_Click(object sender, EventArgs e)
        {
            string newName = textBoxNameInput.Text.Trim();

            if (string.IsNullOrEmpty(newName))
            {
                MessageBox.Show("Name cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (listBoxNames.Items.Contains(newName))
            {
                MessageBox.Show("Name already exists in the list!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            listBoxNames.Items.Add(newName);
            textBoxNameInput.Clear();
        }
    }
}
