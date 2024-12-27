namespace RandomNameSelector
{
    public partial class RandomForm : Form
    {
        private const string SessionFilePath = "session.json";


        public RandomForm()
        {
            InitializeComponent();

            listBoxNames.DragEnter += listBoxNames_DragEnter;
            listBoxNames.DragDrop += listBoxNames_DragDrop;
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

       
        private void buttonMove_Click(object sender, EventArgs e)
        {
            if (listBoxUsedNames.Items.Count > 0)
            {
                foreach (var item in listBoxUsedNames.Items)
                {
                    listBoxNames.Items.Add(item);
                }

                listBoxUsedNames.Items.Clear();
            }
            else
            {
                MessageBox.Show("The 'Used Names' list is already empty.",
                                "No Names to Move",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void listBoxNames_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

                if (files.All(file => file.EndsWith(".txt", StringComparison.OrdinalIgnoreCase)))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBoxNames_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);

            foreach (string file in files)
            {
                if (file.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(file);

                        foreach (string line in lines)
                        {
                            if (!string.IsNullOrWhiteSpace(line))
                            {
                                listBoxNames.Items.Add(line.Trim());
                            }
                        }

                        MessageBox.Show($"Names from {Path.GetFileName(file)} have been added!",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error reading file: {ex.Message}",
                                        "Error",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void SaveSession()
        {
            try
            {
                var sessionData = new
                {
                    Names = listBoxNames.Items.Cast<string>().ToList(),
                    UsedNames = listBoxUsedNames.Items.Cast<string>().ToList()
                };

                string json = System.Text.Json.JsonSerializer.Serialize(sessionData, new System.Text.Json.JsonSerializerOptions
                {
                    WriteIndented = true
                });

                File.WriteAllText(SessionFilePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save session: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadSession()
        {
            try
            {
                if (File.Exists(SessionFilePath))
                {
                    string json = File.ReadAllText(SessionFilePath);
                    var sessionData = System.Text.Json.JsonSerializer.Deserialize<SessionData>(json);

                    if (sessionData != null)
                    {
                        listBoxNames.Items.Clear();
                        foreach (var name in sessionData.Names)
                        {
                            listBoxNames.Items.Add(name);
                        }

                        listBoxUsedNames.Items.Clear();
                        foreach (var usedName in sessionData.UsedNames)
                        {
                            listBoxUsedNames.Items.Add(usedName);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load session: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private class SessionData
        {
            public List<string> Names { get; set; }
            public List<string> UsedNames { get; set; }
        }

        private void RandomNameSelectorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSession();
        }






    }
}
