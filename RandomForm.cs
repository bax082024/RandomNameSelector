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
            if (listBoxNames.Items.Count == 0)
            {
                MessageBox.Show("No names available to pick!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random random = new Random();
            int randomIndex = random.Next(listBoxNames.Items.Count);

            string randomName = listBoxNames.Items[randomIndex].ToString();

            labelRandomName.Text = randomName;

            // Move the name to "Used Names"
            listBoxUsedNames.Items.Add(randomName);
            listBoxNames.Items.RemoveAt(randomIndex);
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listBoxNames.Items.Clear();
            listBoxUsedNames.Items.Clear();

            labelRandomName.Text = "Random Name";

            textBoxNameInput.Clear();
        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            // Check if the Used Names list has any items
            if (listBoxUsedNames.Items.Count > 0)
            {
                // Loop through all items in the Used Names list
                foreach (var item in listBoxUsedNames.Items)
                {
                    // Add each item back to the Names list
                    listBoxNames.Items.Add(item);
                }

                // Clear the Used Names list after moving all names
                listBoxUsedNames.Items.Clear();
            }
            else
            {
                // Show a message if the Used Names list is already empty
                MessageBox.Show("The 'Used Names' list is already empty.",
                                "No Names to Move",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

    }
}
