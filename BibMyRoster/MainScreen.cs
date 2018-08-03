using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RDotNet;

namespace BibMyRoster
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
        }

        // mcvyo selection button logic
        private void mcvyoSelectionButton_Click(object sender, EventArgs e)
        {
            DialogResult mcvyo = mcvyoFileDialog.ShowDialog();
            if (mcvyo == DialogResult.OK)
            {
                string mcvyoFilePath = mcvyoFileDialog.FileName;
                mcvyoSelectionLabel.Text = mcvyoFileDialog.FileName;
            }
        }

        // DirectAthletics file selection button logic
        private void directAthleticsSelectionButton_Click(object sender, EventArgs e)
        {
            DialogResult directathletics = directAthleticsFileDialog.ShowDialog();
            if (directathletics == DialogResult.OK)
            {
                string directAthleticsFilePathy = directAthleticsFileDialog.FileName;
                directAthleticsSelectionLabel.Text = directAthleticsFileDialog.FileName;
            }
        }

        // output folder selection button logic
        private void outputFolderSelectionButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog outputFolder = new FolderBrowserDialog();
            if (outputFolder.ShowDialog() == DialogResult.OK)
            {
                string outputFolderPath = outputFolder.SelectedPath;
                outputFolderSelectionLabel.Text = outputFolder.SelectedPath;
            }
        }

        private void outputFileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            string outputName = outputFileNameTextBox.Text;
        }
    }
}
