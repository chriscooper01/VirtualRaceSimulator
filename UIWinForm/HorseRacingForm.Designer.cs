namespace UIWinForm
{
    partial class HorseRacingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.HorsesList = new System.Windows.Forms.ListBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameText = new System.Windows.Forms.TextBox();
            this.NumeratorTextBox = new System.Windows.Forms.TextBox();
            this.NumeratorLabel = new System.Windows.Forms.Label();
            this.DenominatorText = new System.Windows.Forms.TextBox();
            this.DenominatorLabel = new System.Windows.Forms.Label();
            this.AddHorseButton = new System.Windows.Forms.Button();
            this.RaceButton = new System.Windows.Forms.Button();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.ClearAllButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HorsesList
            // 
            this.HorsesList.FormattingEnabled = true;
            this.HorsesList.Location = new System.Drawing.Point(25, 146);
            this.HorsesList.Name = "HorsesList";
            this.HorsesList.Size = new System.Drawing.Size(580, 160);
            this.HorsesList.TabIndex = 0;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(22, 27);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(38, 13);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // NameText
            // 
            this.NameText.Location = new System.Drawing.Point(116, 24);
            this.NameText.Name = "NameText";
            this.NameText.Size = new System.Drawing.Size(489, 20);
            this.NameText.TabIndex = 2;
            this.NameText.TextChanged += new System.EventHandler(this.NameText_TextChanged);
            // 
            // NumeratorTextBox
            // 
            this.NumeratorTextBox.Location = new System.Drawing.Point(116, 50);
            this.NumeratorTextBox.Name = "NumeratorTextBox";
            this.NumeratorTextBox.Size = new System.Drawing.Size(67, 20);
            this.NumeratorTextBox.TabIndex = 4;
            this.NumeratorTextBox.TextChanged += new System.EventHandler(this.OddsText_TextChanged);
            // 
            // NumeratorLabel
            // 
            this.NumeratorLabel.AutoSize = true;
            this.NumeratorLabel.Location = new System.Drawing.Point(22, 53);
            this.NumeratorLabel.Name = "NumeratorLabel";
            this.NumeratorLabel.Size = new System.Drawing.Size(59, 13);
            this.NumeratorLabel.TabIndex = 3;
            this.NumeratorLabel.Text = "Numerator:";
            // 
            // DenominatorText
            // 
            this.DenominatorText.Location = new System.Drawing.Point(116, 76);
            this.DenominatorText.Name = "DenominatorText";
            this.DenominatorText.Size = new System.Drawing.Size(67, 20);
            this.DenominatorText.TabIndex = 6;
            this.DenominatorText.TextChanged += new System.EventHandler(this.OddsText_TextChanged);
            // 
            // DenominatorLabel
            // 
            this.DenominatorLabel.AutoSize = true;
            this.DenominatorLabel.Location = new System.Drawing.Point(22, 79);
            this.DenominatorLabel.Name = "DenominatorLabel";
            this.DenominatorLabel.Size = new System.Drawing.Size(70, 13);
            this.DenominatorLabel.TabIndex = 5;
            this.DenominatorLabel.Text = "Denominator:";
            // 
            // AddHorseButton
            // 
            this.AddHorseButton.Enabled = false;
            this.AddHorseButton.Location = new System.Drawing.Point(530, 102);
            this.AddHorseButton.Name = "AddHorseButton";
            this.AddHorseButton.Size = new System.Drawing.Size(75, 23);
            this.AddHorseButton.TabIndex = 7;
            this.AddHorseButton.Text = "Add Horse";
            this.AddHorseButton.UseVisualStyleBackColor = true;
            this.AddHorseButton.Click += new System.EventHandler(this.AddHorseButton_Click);
            // 
            // RaceButton
            // 
            this.RaceButton.Enabled = false;
            this.RaceButton.Location = new System.Drawing.Point(25, 312);
            this.RaceButton.Name = "RaceButton";
            this.RaceButton.Size = new System.Drawing.Size(580, 23);
            this.RaceButton.TabIndex = 8;
            this.RaceButton.Text = "Race";
            this.RaceButton.UseVisualStyleBackColor = true;
            this.RaceButton.Click += new System.EventHandler(this.RaceButton_Click);
            // 
            // MessageLabel
            // 
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.Location = new System.Drawing.Point(22, 339);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(35, 13);
            this.MessageLabel.TabIndex = 9;
            this.MessageLabel.Text = "label1";
            // 
            // ClearAllButton
            // 
            this.ClearAllButton.Enabled = false;
            this.ClearAllButton.Location = new System.Drawing.Point(530, 339);
            this.ClearAllButton.Name = "ClearAllButton";
            this.ClearAllButton.Size = new System.Drawing.Size(75, 23);
            this.ClearAllButton.TabIndex = 10;
            this.ClearAllButton.Text = "Clean Slate";
            this.ClearAllButton.UseVisualStyleBackColor = true;
            this.ClearAllButton.Click += new System.EventHandler(this.ClearAllButton_Click);
            // 
            // HorseRacingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 363);
            this.Controls.Add(this.ClearAllButton);
            this.Controls.Add(this.MessageLabel);
            this.Controls.Add(this.RaceButton);
            this.Controls.Add(this.AddHorseButton);
            this.Controls.Add(this.DenominatorText);
            this.Controls.Add(this.DenominatorLabel);
            this.Controls.Add(this.NumeratorTextBox);
            this.Controls.Add(this.NumeratorLabel);
            this.Controls.Add(this.NameText);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.HorsesList);
            this.Name = "HorseRacingForm";
            this.Text = "Horse racing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox HorsesList;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameText;
        private System.Windows.Forms.TextBox NumeratorTextBox;
        private System.Windows.Forms.Label NumeratorLabel;
        private System.Windows.Forms.TextBox DenominatorText;
        private System.Windows.Forms.Label DenominatorLabel;
        private System.Windows.Forms.Button AddHorseButton;
        private System.Windows.Forms.Button RaceButton;
        private System.Windows.Forms.Label MessageLabel;
        private System.Windows.Forms.Button ClearAllButton;
    }
}

