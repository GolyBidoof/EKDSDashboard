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
            string[] motivatingTextsHeader = { "Hola", "Hiya", "Sup", "Aloha", "<yawn> oh hey", "Nice to see you" };
            string[] motivatingTextsFooter = { "what you're up to today?", "so what change is it today?", "keep doing awesomeness!", "been a while.", "like the ol' good days, huh?", "what you're doing looks interesting..." };
            Random randomisedNumber = new Random();
            wb.Text = motivatingTextsHeader[randomisedNumber.Next(6)] + " " + File.ReadAllLines(path)[0] + ", " + motivatingTextsFooter[randomisedNumber.Next(6)];
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
            if (wiFiBox.Enabled==true) { System.Diagnostics.Process.Start("ndstool_close_wifi.bat");
            } else { System.Diagnostics.Process.Start("ndstool_close.bat");
            }
            if (closeAfterBuilding.Checked == true)
            {
                Application.Exit();
            }
        }
    }
}
