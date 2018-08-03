using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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

        public class Strings
        {
            public static string mcvyoFilePath = string.Empty;
            public static string directAthleticsFilePath = string.Empty;
            public static string outputFolderPath = string.Empty;
            public static string outputName = "BibMyRosterOutput";
        }

        // mcvyo selection button logic
        private void mcvyoSelectionButton_Click(object sender, EventArgs e)
        {
            DialogResult mcvyo = mcvyoFileDialog.ShowDialog(); // open the dialog when the button is clicked
            if (mcvyo == DialogResult.OK) // if the selected path is legit
            {
                Strings.mcvyoFilePath = mcvyoFileDialog.FileName; // record the path
                mcvyoSelectionLabel.Text = mcvyoFileDialog.FileName; // set the label to the right display the name of the path chosen
            }
        }

        // DirectAthletics file selection button logic
        private void directAthleticsSelectionButton_Click(object sender, EventArgs e)
        {
            DialogResult directathletics = directAthleticsFileDialog.ShowDialog();
            if (directathletics == DialogResult.OK)
            {
                Strings.directAthleticsFilePath = directAthleticsFileDialog.FileName;
                directAthleticsSelectionLabel.Text = directAthleticsFileDialog.FileName;
            }
        }

        // output folder selection button logic
        private void outputFolderSelectionButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog outputFolder = new FolderBrowserDialog();
            if (outputFolder.ShowDialog() == DialogResult.OK)
            {
                Strings.outputFolderPath = outputFolder.SelectedPath;
                outputFolderSelectionLabel.Text = outputFolder.SelectedPath;
            }
        }

        // output file name text box logic
        private void outputFileNameTextBox_TextChanged(object sender, EventArgs e)
        {
            Strings.outputName = outputFileNameTextBox.Text;
        }
        
        // merge button logic
        private void mergeButton_Click(object sender, EventArgs e)
        {
            REngine engine;

            //init the R engine            
            REngine.SetEnvironmentVariables();
            engine = REngine.GetInstance();
            engine.Initialize();

            Strings.mcvyoFilePath = Strings.mcvyoFilePath.Replace('\\', '/'); //make the path string readable by R
            engine.Evaluate(System.String.Format("FromMissionValley <- read.csv('{0}', FALSE)", Strings.mcvyoFilePath));
            Strings.directAthleticsFilePath = Strings.directAthleticsFilePath.Replace('\\', '/'); //make the path string readable by R
            engine.Evaluate(System.String.Format("FromDirectAthletics <- read.csv2('{0}', FALSE, \";\", \"\")", Strings.directAthleticsFilePath));

            //do all the calculations stuff
            engine.Evaluate("names(FromMissionValley) <- c(\"bib\", \"last\", \"first\")");
            engine.Evaluate("names(FromDirectAthletics) <- c(\"V1\", \"last\", \"first\")");
            engine.Evaluate("FMVsplit <- FromMissionValley[, c(1, 2, 3)]");
            engine.Evaluate("FDAsplit <- FromDirectAthletics[c(2:nrow(FromDirectAthletics)),]");
            engine.Evaluate("merged <- merge(FDAsplit, FMVsplit, by = c(\"last\", \"first\"))");
            engine.Evaluate("rearranged <- merged[, c(3, 1, 2, 4:22, 24)]");

            //output
            Strings.outputFolderPath = Strings.outputFolderPath.Replace('\\', '/'); //make the path string readable by R
            engine.Evaluate(System.String.Format("write.table(rearranged, file='{0}/{1}.txt', quote=FALSE, row.names=FALSE, na=\"\", col.names=FALSE, sep=\";\")", Strings.outputFolderPath, Strings.outputName));

            //clean up
            engine.Dispose();

            //success dialogue
            mergeButton.Text = "Success!";
        }

    }
}
