namespace BibMyRoster
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mcvyoSelectionButton = new System.Windows.Forms.Button();
            this.directAthleticsSelectionButton = new System.Windows.Forms.Button();
            this.outputFolderSelectionButton = new System.Windows.Forms.Button();
            this.mcvyoSelectionLabel = new System.Windows.Forms.Label();
            this.directAthleticsSelectionLabel = new System.Windows.Forms.Label();
            this.outputFolderSelectionLabel = new System.Windows.Forms.Label();
            this.mergeButton = new System.Windows.Forms.Button();
            this.outputFileNameTextBox = new System.Windows.Forms.TextBox();
            this.outputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.mcvyoFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.directAthleticsFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tabControl.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(340, 189);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(332, 163);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Bib No. Assignment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(332, 163);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "mcvyo and DirectAthletics Merge";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mcvyoSelectionButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.directAthleticsSelectionButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputFolderSelectionButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mcvyoSelectionLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.directAthleticsSelectionLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputFolderSelectionLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.mergeButton, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.outputFileNameTextBox, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 151);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mcvyoSelectionButton
            // 
            this.mcvyoSelectionButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mcvyoSelectionButton.Location = new System.Drawing.Point(3, 7);
            this.mcvyoSelectionButton.Name = "mcvyoSelectionButton";
            this.mcvyoSelectionButton.Size = new System.Drawing.Size(154, 23);
            this.mcvyoSelectionButton.TabIndex = 0;
            this.mcvyoSelectionButton.Text = "Select mcvyo csv export";
            this.mcvyoSelectionButton.UseVisualStyleBackColor = true;
            this.mcvyoSelectionButton.Click += new System.EventHandler(this.mcvyoSelectionButton_Click);
            // 
            // directAthleticsSelectionButton
            // 
            this.directAthleticsSelectionButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.directAthleticsSelectionButton.Location = new System.Drawing.Point(3, 44);
            this.directAthleticsSelectionButton.Name = "directAthleticsSelectionButton";
            this.directAthleticsSelectionButton.Size = new System.Drawing.Size(154, 23);
            this.directAthleticsSelectionButton.TabIndex = 1;
            this.directAthleticsSelectionButton.Text = "Select DirectAthletics export";
            this.directAthleticsSelectionButton.UseVisualStyleBackColor = true;
            this.directAthleticsSelectionButton.Click += new System.EventHandler(this.directAthleticsSelectionButton_Click);
            // 
            // outputFolderSelectionButton
            // 
            this.outputFolderSelectionButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outputFolderSelectionButton.Location = new System.Drawing.Point(3, 81);
            this.outputFolderSelectionButton.Name = "outputFolderSelectionButton";
            this.outputFolderSelectionButton.Size = new System.Drawing.Size(154, 23);
            this.outputFolderSelectionButton.TabIndex = 2;
            this.outputFolderSelectionButton.Text = "Select output folder";
            this.outputFolderSelectionButton.UseVisualStyleBackColor = true;
            this.outputFolderSelectionButton.Click += new System.EventHandler(this.outputFolderSelectionButton_Click);
            // 
            // mcvyoSelectionLabel
            // 
            this.mcvyoSelectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mcvyoSelectionLabel.AutoSize = true;
            this.mcvyoSelectionLabel.Location = new System.Drawing.Point(163, 12);
            this.mcvyoSelectionLabel.Name = "mcvyoSelectionLabel";
            this.mcvyoSelectionLabel.Size = new System.Drawing.Size(105, 13);
            this.mcvyoSelectionLabel.TabIndex = 4;
            this.mcvyoSelectionLabel.Text = "You have selected...";
            // 
            // directAthleticsSelectionLabel
            // 
            this.directAthleticsSelectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.directAthleticsSelectionLabel.AutoSize = true;
            this.directAthleticsSelectionLabel.Location = new System.Drawing.Point(163, 49);
            this.directAthleticsSelectionLabel.Name = "directAthleticsSelectionLabel";
            this.directAthleticsSelectionLabel.Size = new System.Drawing.Size(105, 13);
            this.directAthleticsSelectionLabel.TabIndex = 5;
            this.directAthleticsSelectionLabel.Text = "You have selected...";
            // 
            // outputFolderSelectionLabel
            // 
            this.outputFolderSelectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outputFolderSelectionLabel.AutoSize = true;
            this.outputFolderSelectionLabel.Location = new System.Drawing.Point(163, 86);
            this.outputFolderSelectionLabel.Name = "outputFolderSelectionLabel";
            this.outputFolderSelectionLabel.Size = new System.Drawing.Size(105, 13);
            this.outputFolderSelectionLabel.TabIndex = 6;
            this.outputFolderSelectionLabel.Text = "You have selected...";
            // 
            // mergeButton
            // 
            this.mergeButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mergeButton.Location = new System.Drawing.Point(163, 119);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(154, 23);
            this.mergeButton.TabIndex = 3;
            this.mergeButton.Text = "Merge!";
            this.mergeButton.UseVisualStyleBackColor = true;
            this.mergeButton.Click += new System.EventHandler(this.mergeButton_Click);
            // 
            // outputFileNameTextBox
            // 
            this.outputFileNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outputFileNameTextBox.Location = new System.Drawing.Point(3, 121);
            this.outputFileNameTextBox.Name = "outputFileNameTextBox";
            this.outputFileNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.outputFileNameTextBox.TabIndex = 7;
            this.outputFileNameTextBox.Text = "Output file name...";
            // 
            // mcvyoFileDialog
            // 
            this.mcvyoFileDialog.FileName = "openFileDialog1";
            // 
            // directAthleticsFileDialog
            // 
            this.directAthleticsFileDialog.FileName = "openFileDialog2";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 214);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(381, 253);
            this.Name = "MainScreen";
            this.Text = "BibMyRoster by Andrew Apy";
            this.tabControl.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button mcvyoSelectionButton;
        private System.Windows.Forms.Button directAthleticsSelectionButton;
        private System.Windows.Forms.Button outputFolderSelectionButton;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Label mcvyoSelectionLabel;
        private System.Windows.Forms.Label directAthleticsSelectionLabel;
        private System.Windows.Forms.Label outputFolderSelectionLabel;
        private System.Windows.Forms.TextBox outputFileNameTextBox;
        private System.Windows.Forms.FolderBrowserDialog outputFolderBrowserDialog;
        private System.Windows.Forms.OpenFileDialog mcvyoFileDialog;
        private System.Windows.Forms.OpenFileDialog directAthleticsFileDialog;
    }
}

