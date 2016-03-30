using System;
using System.Windows.Forms;
using System.IO;

namespace BuildScript
{
    public partial class mainForm : Form
    {
        string path = System.IO.Path.Combine(Environment.GetFolderPath(
               Environment.SpecialFolder.MyDoc‌​uments), "EKDSID.ini");

        public mainForm()
        {
            InitializeComponent();
            clockUpdateTimer = new Timer();
            clockUpdateTimer.Tick += new EventHandler(clockTimer_Elapsed);
            clockUpdateTimer.Interval = 100;
            clockUpdateTimer.Start();
            if (File.Exists(path))
            {
            }
            else
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("What's your nick, fellow EKDS dev?", "Name input", "Ermelber", -1, -1);
                using (StreamWriter writer = new StreamWriter(path))
                {
                    writer.Write(input.ToString());
                }
            }
            wb.Text += File.ReadAllLines(path)[0] + "!";
            build.Text = (File.ReadAllLines("data/data/boot/build.bin"))[0];
        }

        private void clockTimer_Elapsed(object sender, EventArgs e)
        {
            clock.Text = DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss")
                    + " UTC";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("data/data/boot/build.bin"))
            {
                writer.Write((Int32.Parse(build.Text) + 1).ToString());
            }
            using (StreamWriter anotherwriter = new StreamWriter("changelog.txt", true))
            {
                anotherwriter.Write(Environment.NewLine
                    + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss") 
                    + " UTC || build number " + (Int32.Parse(build.Text) + 1).ToString() 
                    + " || " + File.ReadAllLines(path)[0]  
                    + " || " + textAdded.Text);
            }
            build.Text = (Int32.Parse(build.Text) + 1).ToString();
            System.Diagnostics.Process.Start("ndstool_close.bat");
            if (closeAfterBuilding.Checked == true)
            {
                Application.Exit();
            }
        }
    }
}
