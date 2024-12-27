namespace RandomNameSelector
{
    partial class RandomForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonMove = new Button();
            buttonReset = new Button();
            buttonPickRandom = new Button();
            label4 = new Label();
            buttonAddName = new Button();
            textBoxNameInput = new TextBox();
            panel2 = new Panel();
            labelRandomName = new Label();
            label3 = new Label();
            lblTitle = new Label();
            label2 = new Label();
            label1 = new Label();
            listBoxUsedNames = new ListBox();
            listBoxNames = new ListBox();
            btnSettings = new Button();
            panel3 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(buttonMove);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonAddName);
            panel1.Controls.Add(textBoxNameInput);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listBoxUsedNames);
            panel1.Controls.Add(listBoxNames);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 721);
            panel1.TabIndex = 0;
            // 
            // buttonMove
            // 
            buttonMove.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonMove.Location = new Point(854, 551);
            buttonMove.Name = "buttonMove";
            buttonMove.Size = new Size(113, 38);
            buttonMove.TabIndex = 13;
            buttonMove.Text = "<<<   Move";
            buttonMove.TextAlign = ContentAlignment.MiddleLeft;
            buttonMove.UseVisualStyleBackColor = true;
            buttonMove.Click += buttonMove_Click;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = AnchorStyles.None;
            buttonReset.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.Location = new Point(0, 173);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(230, 70);
            buttonReset.TabIndex = 12;
            buttonReset.Text = "RESET";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonPickRandom
            // 
            buttonPickRandom.Anchor = AnchorStyles.None;
            buttonPickRandom.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonPickRandom.Location = new Point(3, 3);
            buttonPickRandom.Name = "buttonPickRandom";
            buttonPickRandom.Size = new Size(230, 70);
            buttonPickRandom.TabIndex = 11;
            buttonPickRandom.Text = "START";
            buttonPickRandom.UseVisualStyleBackColor = true;
            buttonPickRandom.Click += buttonPickRandom_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(105, 544);
            label4.Name = "label4";
            label4.Size = new Size(91, 17);
            label4.TabIndex = 10;
            label4.Text = "Add Name :";
            // 
            // buttonAddName
            // 
            buttonAddName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddName.Location = new Point(105, 605);
            buttonAddName.Name = "buttonAddName";
            buttonAddName.Size = new Size(91, 29);
            buttonAddName.TabIndex = 9;
            buttonAddName.Text = "Add Name";
            buttonAddName.UseVisualStyleBackColor = true;
            buttonAddName.Click += buttonAddName_Click;
            // 
            // textBoxNameInput
            // 
            textBoxNameInput.BackColor = Color.Silver;
            textBoxNameInput.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxNameInput.Location = new Point(48, 564);
            textBoxNameInput.Name = "textBoxNameInput";
            textBoxNameInput.Size = new Size(200, 25);
            textBoxNameInput.TabIndex = 8;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(labelRandomName);
            panel2.Location = new Point(344, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 100);
            panel2.TabIndex = 7;
            // 
            // labelRandomName
            // 
            labelRandomName.Anchor = AnchorStyles.None;
            labelRandomName.AutoSize = true;
            labelRandomName.Font = new Font("Stencil", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelRandomName.Location = new Point(60, 32);
            labelRandomName.Name = "labelRandomName";
            labelRandomName.Size = new Size(227, 34);
            labelRandomName.TabIndex = 2;
            labelRandomName.Text = "Random Name";
            labelRandomName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(332, 189);
            label3.Name = "label3";
            label3.Size = new Size(367, 36);
            label3.TabIndex = 6;
            label3.Text = "The Choosen Name Is :";
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Snap ITC", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(88, 22);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(879, 82);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Random Name Selector";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.None;
            label2.AutoSize = true;
            label2.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(850, 148);
            label2.Name = "label2";
            label2.Size = new Size(117, 20);
            label2.TabIndex = 4;
            label2.Text = "Used Names";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(111, 148);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 3;
            label1.Text = "Names";
            // 
            // listBoxUsedNames
            // 
            listBoxUsedNames.Anchor = AnchorStyles.None;
            listBoxUsedNames.BackColor = SystemColors.Info;
            listBoxUsedNames.FormattingEnabled = true;
            listBoxUsedNames.ItemHeight = 15;
            listBoxUsedNames.Location = new Point(808, 213);
            listBoxUsedNames.Name = "listBoxUsedNames";
            listBoxUsedNames.Size = new Size(200, 319);
            listBoxUsedNames.TabIndex = 1;
            // 
            // listBoxNames
            // 
            listBoxNames.AllowDrop = true;
            listBoxNames.Anchor = AnchorStyles.None;
            listBoxNames.BackColor = SystemColors.Info;
            listBoxNames.FormattingEnabled = true;
            listBoxNames.ItemHeight = 15;
            listBoxNames.Location = new Point(48, 213);
            listBoxNames.Name = "listBoxNames";
            listBoxNames.Size = new Size(200, 319);
            listBoxNames.TabIndex = 0;
            // 
            // btnSettings
            // 
            btnSettings.Anchor = AnchorStyles.None;
            btnSettings.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSettings.Location = new Point(3, 87);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(230, 70);
            btnSettings.TabIndex = 14;
            btnSettings.Text = "SETTINGS";
            btnSettings.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(buttonPickRandom);
            panel3.Controls.Add(btnSettings);
            panel3.Controls.Add(buttonReset);
            panel3.Location = new Point(388, 405);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 251);
            panel3.TabIndex = 15;
            // 
            // RandomForm
            // 
            AcceptButton = buttonAddName;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SlateGray;
            ClientSize = new Size(1074, 721);
            Controls.Add(panel1);
            Name = "RandomForm";
            Text = "Random Name Selector";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listBoxUsedNames;
        private ListBox listBoxNames;
        private Label labelRandomName;
        private Label lblTitle;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private Button buttonAddName;
        private TextBox textBoxNameInput;
        private Label label4;
        private Button buttonReset;
        private Button buttonPickRandom;
        private Button buttonMove;
        private Panel panel3;
        private Button btnSettings;
    }
}
