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
            listBox2 = new ListBox();
            listBoxNames = new ListBox();
            btnSelectedName = new Label();
            label1 = new Label();
            label2 = new Label();
            lblTitle = new Label();
            label3 = new Label();
            panel2 = new Panel();
            textBoxNameInput = new TextBox();
            buttonAddName = new Button();
            label4 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonAddName);
            panel1.Controls.Add(textBoxNameInput);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(listBoxNames);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 721);
            panel1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.None;
            listBox2.BackColor = SystemColors.Info;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(808, 213);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(200, 319);
            listBox2.TabIndex = 1;
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
            // btnSelectedName
            // 
            btnSelectedName.Anchor = AnchorStyles.None;
            btnSelectedName.AutoSize = true;
            btnSelectedName.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectedName.Location = new Point(91, 32);
            btnSelectedName.Name = "btnSelectedName";
            btnSelectedName.Size = new Size(44, 32);
            btnSelectedName.TabIndex = 2;
            btnSelectedName.Text = "``";
            btnSelectedName.TextAlign = ContentAlignment.MiddleCenter;
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
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Snap ITC", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(192, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(665, 63);
            lblTitle.TabIndex = 5;
            lblTitle.Text = "Random Name Selector";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(344, 199);
            label3.Name = "label3";
            label3.Size = new Size(337, 33);
            label3.TabIndex = 6;
            label3.Text = "The Choosen Name Is :";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.Silver;
            panel2.Controls.Add(btnSelectedName);
            panel2.Location = new Point(344, 283);
            panel2.Name = "panel2";
            panel2.Size = new Size(337, 100);
            panel2.TabIndex = 7;
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
            // buttonAddName
            // 
            buttonAddName.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAddName.Location = new Point(105, 605);
            buttonAddName.Name = "buttonAddName";
            buttonAddName.Size = new Size(91, 29);
            buttonAddName.TabIndex = 9;
            buttonAddName.Text = "Add Name";
            buttonAddName.UseVisualStyleBackColor = true;
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
            // RandomForm
            // 
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listBox2;
        private ListBox listBoxNames;
        private Label btnSelectedName;
        private Label lblTitle;
        private Label label2;
        private Label label1;
        private Label label3;
        private Panel panel2;
        private Button buttonAddName;
        private TextBox textBoxNameInput;
        private Label label4;
    }
}
