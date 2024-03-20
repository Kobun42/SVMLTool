using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace MOTDGen
{
    public partial class Main : Form
    {

        int st00pidm0nkey = 28282028;

        public Main()
        {
            InitializeComponent();
        }

        public void generateMOTD(int style, String header, String message)
        {
            if (style == 2)
            {
                MessageBox.Show("New style is currently unavailable. Your style choice has been overridden to 'Classic' style.", "Warning"); // waiting for more pcaps of this era
                style = 1;
            } else if (style > 2 || style < 1)
            {
                MessageBox.Show("Style selected is invalid. Your style choice has been overridden to 'Classic' style.", "Warning"); // or at least an ISE server based on 1.35? pls?...
                style = 1;
            }

            if (st00pidm0nkey == 28102010 && style == 2) // Style must be new for this easter egg, in other words it's not happenin' yet.
            {
                System.Diagnostics.Process.Start("http://cb-sc.com/doomstuff/lazure3000.mp3"); // what does this have to do with anything? nothing! now get out.
                st00pidm0nkey++;
            }

            String MOTDClassic = $"<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n<SVML>\r\n    <RECTANGLE class=\"CHIP_FACE\" name=\"backPanel\" x=\"292\" y=\"140\" width=\"708\" height=\"440\"/>\r\n    <RECTANGLE class=\"CHIP_RECESS\" name=\"backPanel\" x=\"300\" y=\"148\" width=\"692\" height=\"384\" fillColor=\"#FFFFFFFF\"/>\r\n\r\n    <TEXT name=\"text\" x=\"640\" y=\"171\" width=\"636\" height=\"26\" fontSize=\"26\" align=\"center\" textColor=\"#cc000000\">{header}</TEXT>\r\n\r\n    <TEXTAREA class=\"TEXTAREA1\" name=\"message\" x=\"308\" y=\"204\" width=\"664\" height=\"320\"\r\n\t\tfontSize=\"22\" lineSpacing=\"22\" linesVisible=\"14\"\r\n\t\treadonly=\"true\" selectable=\"false\" blinkCursor=\"false\"\r\n\t\ttextColor=\"#CC000000\" highlightTextColor=\"#FF000000\"\r\n\t\tleftPadValue=\"8\" topPadValue=\"8\" \r\n        defaultTextEntry=\"1\" defaultTextScroll=\"1\">{message}</TEXTAREA>\r\n    \r\n    <TEXT name=\"legend\" x=\"984\" y=\"548\" width=\"652\" height=\"18\" fontSize=\"18\" align=\"right\" textColor=\"#CCFFFFFF\">[CROSS] Continue</TEXT>\r\n    <QUICKLINK name=\"refresh\" button=\"SV_PAD_X\" linkOption=\"NORMAL\" href=\"../home/homeEnterWorld.jsp\"/>\r\n</SVML>\r\n";
            // this redundant POS code above called MOTDClassic will be revamped whenever 1.35 MOTD format is found

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "PlayStation Home SVML Files (*.svml)|*.svml|PlayStation Home JSP Files (*.jsp)|*.jsp|PSMultiServer MOTD XML Files (*.xml)|*.xml";
                sfd.FilterIndex = 2;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, MOTDClassic);
                }
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
           About about = new About();
            about.Show(); // create and show about window
        }

        private void classicMOTD_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void naviMOTD_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            int currentStyle = 0;
            if (classicMOTD.Checked && !naviMOTD.Checked)
            {
                currentStyle = 1; // Assume classic style (currently the only style)
            } else
            {
                currentStyle = 2; // Assume new if otherwise
            }
            generateMOTD(currentStyle, this.headerTextbox.Text, this.messageTextbox.Text);
        }

        private void linksToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pSMultiServerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please note that I am not affiliated with the creator of MultiServer. I just think it's a neat tool.", "Warning");
            System.Diagnostics.Process.Start("https://github.com/GitHubProUser67/PSMultiServer");
        }

        private void sVMLToolGithubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Kobun42/SVMLTool");
        }

        private void homeLaboratoryDiscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to enter the Home Laboratory discord? \n\nThis server may NOT help you with problems for this tool. \nIf you are confused or having problems with this tool, please contact Kobun42 instead. \n\nIf you are otherwise interested in PlayStation Home online, feel free to join.", "Warning", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                System.Diagnostics.Process.Start("https://discord.gg/KRVpknsgG4");
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if ((bool)Properties.Settings.Default["FirstBoot"] == true)
            {
                // We don't want it happening twice!
                Properties.Settings.Default["FirstBoot"] = false;
                Properties.Settings.Default.Save();
                // Warn the user that the tool will only work for SVO reliant versions of Home
                MessageBox.Show("Please read the following before use of this tool:\n\nThis tool will NOT work on Home clients v1.70 or higher.\nThis is because they are not reliant on the SVO server and thus will not read files output by this program.\n\nPlease do not message me about the program 'not working' on these newer Home clients as this tool is intended for older versions of Home. \n\nFor best results, use on clients v1.32 or lower. \nThank you for using this tool. This notice will not appear again.", "First-run Reminder", MessageBoxButtons.OK);
            }
        }
    }
}