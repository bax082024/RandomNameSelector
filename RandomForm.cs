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

        }

        private void buttonAddName_Click(object sender, EventArgs e)
        {
            string newName = textBoxNameInput.Text.Trim();

            // Check for empty input or duplicate names
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

            // Add name to the list
            listBoxNames.Items.Add(newName);
            textBoxNameInput.Clear();
        }
    }
}
