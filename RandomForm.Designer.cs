﻿namespace RandomNameSelector
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
            label5 = new Label();
            listBoxSelectedNames = new ListBox();
            numericUpDownCount = new NumericUpDown();
            panel3 = new Panel();
            buttonPickRandom = new Button();
            buttonReset = new Button();
            buttonMove = new Button();
            label4 = new Label();
            buttonAddName = new Button();
            textBoxNameInput = new TextBox();
            label3 = new Label();
            lblTitle = new Label();
            label2 = new Label();
            label1 = new Label();
            listBoxUsedNames = new ListBox();
            listBoxNames = new ListBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(listBoxSelectedNames);
            panel1.Controls.Add(numericUpDownCount);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(buttonMove);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(buttonAddName);
            panel1.Controls.Add(textBoxNameInput);
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkOliveGreen;
            label5.Location = new Point(332, 662);
            label5.Name = "label5";
            label5.Size = new Size(172, 34);
            label5.TabIndex = 18;
            label5.Text = "How many names to pick :\r\n        (between 1 - 10)";
            // 
            // listBoxSelectedNames
            // 
            listBoxSelectedNames.Anchor = AnchorStyles.None;
            listBoxSelectedNames.BackColor = Color.DarkSlateGray;
            listBoxSelectedNames.Font = new Font("Stencil", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listBoxSelectedNames.ForeColor = Color.OrangeRed;
            listBoxSelectedNames.FormattingEnabled = true;
            listBoxSelectedNames.ItemHeight = 29;
            listBoxSelectedNames.Location = new Point(367, 283);
            listBoxSelectedNames.Name = "listBoxSelectedNames";
            listBoxSelectedNames.Size = new Size(276, 91);
            listBoxSelectedNames.TabIndex = 17;
            listBoxSelectedNames.TabStop = false;
            // 
            // numericUpDownCount
            // 
            numericUpDownCount.Location = new Point(511, 656);
            numericUpDownCount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownCount.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.Size = new Size(120, 23);
            numericUpDownCount.TabIndex = 16;
            numericUpDownCount.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.None;
            panel3.Controls.Add(buttonPickRandom);
            panel3.Controls.Add(buttonReset);
            panel3.Location = new Point(388, 405);
            panel3.Name = "panel3";
            panel3.Size = new Size(243, 156);
            panel3.TabIndex = 15;
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
            buttonPickRandom.Click += buttonStart_Click;
            // 
            // buttonReset
            // 
            buttonReset.Anchor = AnchorStyles.None;
            buttonReset.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReset.Location = new Point(3, 86);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(230, 70);
            buttonReset.TabIndex = 12;
            buttonReset.Text = "RESET";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
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
            // label4
            // 
            label4.Anchor = AnchorStyles.None;
            label4.AutoSize = true;
            label4.Font = new Font("Showcard Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkOliveGreen;
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
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Showcard Gothic", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Green;
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
            lblTitle.ForeColor = Color.Maroon;
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
            label2.ForeColor = Color.DarkOliveGreen;
            label2.Location = new Point(850, 179);
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
            label1.ForeColor = Color.DarkOliveGreen;
            label1.Location = new Point(114, 179);
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
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ListBox listBoxUsedNames;
        private ListBox listBoxNames;
        private Label lblTitle;
        private Label label2;
        private Label label1;
        private Label label3;
        private Button buttonAddName;
        private TextBox textBoxNameInput;
        private Label label4;
        private Button buttonReset;
        private Button buttonPickRandom;
        private Button buttonMove;
        private Panel panel3;
        private NumericUpDown numericUpDownCount;
        private ListBox listBoxSelectedNames;
        private Label label5;
    }
}
