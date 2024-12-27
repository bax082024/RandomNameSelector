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
            listBox1 = new ListBox();
            btnSelectedName = new Label();
            label1 = new Label();
            label2 = new Label();
            lblTitle = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(lblTitle);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSelectedName);
            panel1.Controls.Add(listBox2);
            panel1.Controls.Add(listBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1074, 721);
            panel1.TabIndex = 0;
            // 
            // listBox2
            // 
            listBox2.Anchor = AnchorStyles.None;
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(808, 213);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(200, 319);
            listBox2.TabIndex = 1;
            // 
            // listBox1
            // 
            listBox1.Anchor = AnchorStyles.None;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(48, 213);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(200, 319);
            listBox1.TabIndex = 0;
            // 
            // btnSelectedName
            // 
            btnSelectedName.Anchor = AnchorStyles.None;
            btnSelectedName.AutoSize = true;
            btnSelectedName.Font = new Font("Stencil", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSelectedName.Location = new Point(430, 448);
            btnSelectedName.Name = "btnSelectedName";
            btnSelectedName.Size = new Size(115, 32);
            btnSelectedName.TabIndex = 2;
            btnSelectedName.Text = "label1";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 148);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 3;
            label1.Text = "Add Names";
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
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listBox2;
        private ListBox listBox1;
        private Label btnSelectedName;
        private Label lblTitle;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}
