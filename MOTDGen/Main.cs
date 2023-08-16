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
                MessageBox.Show("New style is currently unavailable. Your style choice has been overridden to 'Classic' style.");
                style = 1;
            } else if (style > 2 || style < 1)
            {
                MessageBox.Show("Style selected is invalid. Your style choice has been overridden to 'Classic' style.");
                style = 1;
            }
            //MessageBox.Show("Not done yet!");

            /*MessageBox.Show("Header is " + header + ".");

            MessageBox.Show("Text is " + message);*/

            /*if (st00pidm0nkey == 28102010)
            {
                MessageBox.Show("OKAY, YOU DIDN'T JUST TALK TO MY FACE THAT WAY, DID YOU? \n\nNO. \n\nDON'T YOU FUH-UCKING IGNORE ME YOU LITTLE F-----. \nYOU DON'T TALK SHIT TO MY FACE AND JUST WALK AWAY. \nFUCK YOU, YOU TAKE TO YOUR F----- ASS AND GET OUT. \nNAUT, YOU DON'T START SHIT WITH ME, YOU GOT THAT? \nI WASN'T EVEN TALKING TO YOUR F----- ASS BEFORE YOU DECIDED TO START SHIT WITH ME. \n\nSO WHY DON'T YOU SHOVE A DICK UP YOUR ASS AND GO THE FUCK AWAY, YOU STUPID TROLLS?");
                st00pidm0nkey++;
            }*/

            String MOTDClassic = $"<?xml version=\"1.0\" encoding=\"UTF-8\"?>\r\n<SVML>\r\n    <RECTANGLE class=\"CHIP_FACE\" name=\"backPanel\" x=\"292\" y=\"140\" width=\"708\" height=\"440\"/>\r\n    <RECTANGLE class=\"CHIP_RECESS\" name=\"backPanel\" x=\"300\" y=\"148\" width=\"692\" height=\"384\" fillColor=\"#FFFFFFFF\"/>\r\n\r\n    <TEXT name=\"text\" x=\"640\" y=\"171\" width=\"636\" height=\"26\" fontSize=\"26\" align=\"center\" textColor=\"#cc000000\">{header}</TEXT>\r\n\r\n    <TEXTAREA class=\"TEXTAREA1\" name=\"message\" x=\"308\" y=\"204\" width=\"664\" height=\"320\"\r\n\t\tfontSize=\"22\" lineSpacing=\"22\" linesVisible=\"14\"\r\n\t\treadonly=\"true\" selectable=\"false\" blinkCursor=\"false\"\r\n\t\ttextColor=\"#CC000000\" highlightTextColor=\"#FF000000\"\r\n\t\tleftPadValue=\"8\" topPadValue=\"8\" \r\n        defaultTextEntry=\"1\" defaultTextScroll=\"1\">{message}</TEXTAREA>\r\n    \r\n    <TEXT name=\"legend\" x=\"984\" y=\"548\" width=\"652\" height=\"18\" fontSize=\"18\" align=\"right\" textColor=\"#CCFFFFFF\">[CROSS] Continue</TEXT>\r\n    <QUICKLINK name=\"refresh\" button=\"SV_PAD_X\" linkOption=\"NORMAL\" href=\"../home/homeEnterWorld.jsp\"/>\r\n</SVML>\r\n";

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "PlayStation Home SVML Files (*.svml)|*.svml|PSMultiServer MOTD XML Files (*.xml)|*.xml";
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
            about.Show();
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
                currentStyle = 1;
            } else
            {
                currentStyle = 2; // Assume new if otherwise
            }
            generateMOTD(currentStyle, this.headerTextbox.Text, this.messageTextbox.Text);
        }
    }
}
