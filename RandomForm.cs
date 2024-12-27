namespace RandomNameSelector
{
    public partial class RandomForm : Form
    {
        private const string SessionFilePath = "session.json";

        public RandomForm()
        {
            InitializeComponent();

            // Attach events
            this.FormClosing += RandomNameSelectorForm_FormClosing;
            this.Load += RandomNameSelectorForm_Load;
            listBoxNames.DragEnter += listBoxNames_DragEnter;
            listBoxNames.DragDrop += listBoxNames_DragDrop;

            this.Paint += RandomForm_Paint;
            this.BackColor = Color.White;
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            int numberOfNamesToPick = (int)numericUpDownCount.Value;

            if (listBoxNames.Items.Count == 0)
            {
                MessageBox.Show("No names available to pick from!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numberOfNamesToPick > listBoxNames.Items.Count)
            {
                MessageBox.Show($"There are not enough names in the list. Only {listBoxNames.Items.Count} names available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Random random = new Random();
            listBoxSelectedNames.Items.Clear();

            for (int i = 0; i < numberOfNamesToPick; i++)
            {
                int randomIndex = random.Next(listBoxNames.Items.Count);
                string pickedName = listBoxNames.Items[randomIndex].ToString();

                listBoxSelectedNames.Items.Add(pickedName);
                listBoxUsedNames.Items.Add(pickedName);
                listBoxNames.Items.RemoveAt(randomIndex);
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

        private void buttonReset_Click(object sender, EventArgs e)
        {
            listBoxNames.Items.Clear();
            listBoxUsedNames.Items.Clear();
            listBoxSelectedNames.Items.Clear();
            textBoxNameInput.Clear();
        }

        private void buttonMove_Click(object sender, EventArgs e)
        {
            foreach (var item in listBoxUsedNames.Items)
            {
                if (!listBoxNames.Items.Contains(item))
                {
                    listBoxNames.Items.Add(item);
                }
            }
            listBoxUsedNames.Items.Clear();
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
                            string trimmedLine = line.Trim();
                            if (!string.IsNullOrWhiteSpace(trimmedLine) && !listBoxNames.Items.Contains(trimmedLine))
                            {
                                listBoxNames.Items.Add(trimmedLine);
                            }
                        }

                        MessageBox.Show($"Names from {Path.GetFileName(file)} have been added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error reading file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        listBoxUsedNames.Items.Clear();

                        foreach (var name in sessionData.Names)
                        {
                            listBoxNames.Items.Add(name);
                        }
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

        private void RandomNameSelectorForm_Load(object sender, EventArgs e)
        {
            LoadSession();
        }

        

        private void RandomForm_Paint(object sender, PaintEventArgs e)
        {
            Color startColor = Color.LightBlue;
            Color endColor = Color.DarkBlue;

            using (var gradientBrush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle,
                startColor, 
                endColor, 
                System.Drawing.Drawing2D.LinearGradientMode.Vertical 
            ))
            {
                e.Graphics.FillRectangle(gradientBrush, this.ClientRectangle);
            }
        }

    }
}
