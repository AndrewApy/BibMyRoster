﻿namespace BibMyRoster
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.mcvyoSelectionButton = new System.Windows.Forms.Button();
            this.directAthleticsSelectionButton = new System.Windows.Forms.Button();
            this.outputFolderSelectionButton = new System.Windows.Forms.Button();
            this.mergeButton = new System.Windows.Forms.Button();
            this.mcvyoSelectionLabel = new System.Windows.Forms.Label();
            this.directAthleticsSelectionLabel = new System.Windows.Forms.Label();
            this.outptuFolderSelectionLabel = new System.Windows.Forms.Label();
            this.outptuFileNameTextBox = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(551, 329);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(543, 303);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(543, 303);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.mcvyoSelectionButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.directAthleticsSelectionButton, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.outputFolderSelectionButton, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.mergeButton, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.mcvyoSelectionLabel, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.directAthleticsSelectionLabel, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.outptuFolderSelectionLabel, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.outptuFileNameTextBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(531, 291);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // mcvyoSelectionButton
            // 
            this.mcvyoSelectionButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mcvyoSelectionButton.Location = new System.Drawing.Point(3, 24);
            this.mcvyoSelectionButton.Name = "mcvyoSelectionButton";
            this.mcvyoSelectionButton.Size = new System.Drawing.Size(259, 23);
            this.mcvyoSelectionButton.TabIndex = 0;
            this.mcvyoSelectionButton.Text = "Select mcvyo csv export";
            this.mcvyoSelectionButton.UseVisualStyleBackColor = true;
            // 
            // directAthleticsSelectionButton
            // 
            this.directAthleticsSelectionButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.directAthleticsSelectionButton.Location = new System.Drawing.Point(3, 96);
            this.directAthleticsSelectionButton.Name = "directAthleticsSelectionButton";
            this.directAthleticsSelectionButton.Size = new System.Drawing.Size(259, 23);
            this.directAthleticsSelectionButton.TabIndex = 1;
            this.directAthleticsSelectionButton.Text = "Select DirectAthleticsButton";
            this.directAthleticsSelectionButton.UseVisualStyleBackColor = true;
            // 
            // outputFolderSelectionButton
            // 
            this.outputFolderSelectionButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outputFolderSelectionButton.Location = new System.Drawing.Point(3, 168);
            this.outputFolderSelectionButton.Name = "outputFolderSelectionButton";
            this.outputFolderSelectionButton.Size = new System.Drawing.Size(259, 23);
            this.outputFolderSelectionButton.TabIndex = 2;
            this.outputFolderSelectionButton.Text = "Select output folder";
            this.outputFolderSelectionButton.UseVisualStyleBackColor = true;
            // 
            // mergeButton
            // 
            this.mergeButton.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mergeButton.Location = new System.Drawing.Point(3, 242);
            this.mergeButton.Name = "mergeButton";
            this.mergeButton.Size = new System.Drawing.Size(259, 23);
            this.mergeButton.TabIndex = 3;
            this.mergeButton.Text = "Merge!";
            this.mergeButton.UseVisualStyleBackColor = true;
            // 
            // mcvyoSelectionLabel
            // 
            this.mcvyoSelectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.mcvyoSelectionLabel.AutoSize = true;
            this.mcvyoSelectionLabel.Location = new System.Drawing.Point(268, 29);
            this.mcvyoSelectionLabel.Name = "mcvyoSelectionLabel";
            this.mcvyoSelectionLabel.Size = new System.Drawing.Size(105, 13);
            this.mcvyoSelectionLabel.TabIndex = 4;
            this.mcvyoSelectionLabel.Text = "You have selected...";
            // 
            // directAthleticsSelectionLabel
            // 
            this.directAthleticsSelectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.directAthleticsSelectionLabel.AutoSize = true;
            this.directAthleticsSelectionLabel.Location = new System.Drawing.Point(268, 101);
            this.directAthleticsSelectionLabel.Name = "directAthleticsSelectionLabel";
            this.directAthleticsSelectionLabel.Size = new System.Drawing.Size(105, 13);
            this.directAthleticsSelectionLabel.TabIndex = 5;
            this.directAthleticsSelectionLabel.Text = "You have selected...";
            // 
            // outptuFolderSelectionLabel
            // 
            this.outptuFolderSelectionLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outptuFolderSelectionLabel.AutoSize = true;
            this.outptuFolderSelectionLabel.Location = new System.Drawing.Point(268, 173);
            this.outptuFolderSelectionLabel.Name = "outptuFolderSelectionLabel";
            this.outptuFolderSelectionLabel.Size = new System.Drawing.Size(105, 13);
            this.outptuFolderSelectionLabel.TabIndex = 6;
            this.outptuFolderSelectionLabel.Text = "You have selected...";
            // 
            // outptuFileNameTextBox
            // 
            this.outptuFileNameTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.outptuFileNameTextBox.Location = new System.Drawing.Point(268, 243);
            this.outptuFileNameTextBox.Name = "outptuFileNameTextBox";
            this.outptuFileNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.outptuFileNameTextBox.TabIndex = 7;
            this.outptuFileNameTextBox.Text = "Output file name...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button mcvyoSelectionButton;
        private System.Windows.Forms.Button directAthleticsSelectionButton;
        private System.Windows.Forms.Button outputFolderSelectionButton;
        private System.Windows.Forms.Button mergeButton;
        private System.Windows.Forms.Label mcvyoSelectionLabel;
        private System.Windows.Forms.Label directAthleticsSelectionLabel;
        private System.Windows.Forms.Label outptuFolderSelectionLabel;
        private System.Windows.Forms.TextBox outptuFileNameTextBox;
    }
}
