using System;
using System.Windows.Forms;
using System.IO;
using LibErmiiKart.Discord;
using LibErmiiKart.Encryption;


namespace BuildScript
{
    public partial class mainForm : Form
    {
        readonly static string path = System.IO.Path.Combine(Environment.GetFolderPath(
               Environment.SpecialFolder.MyDoc‌​uments), "EKDSID.ini");
        private Motivator motivator;

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
            motivator = new Motivator(path);
            wb.Text = motivator.getMessage();
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
            using (StreamWriter anotherwriter = new StreamWriter("scripts/changelog.txt", true))
            {
                anotherwriter.Write(Environment.NewLine
                    + DateTime.UtcNow.ToString("dd/MM/yyyy HH:mm:ss")
                    + " UTC || build number " + (Int32.Parse(build.Text) + 1).ToString()
                    + " || " + File.ReadAllLines(path)[0]
                    + " || " + textAdded.Text);
            }
            build.Text = (Int32.Parse(build.Text) + 1).ToString();
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo
            {
                WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal,
                FileName = "cmd.exe",
                RedirectStandardInput = true,
                UseShellExecute = false
            };
            process.StartInfo = info;
            process.Start();
            process.StandardInput.WriteLine("cd scripts");
            if (wiFiBox.Enabled) {
                process.StandardInput.WriteLine("ndstool_close_wifi.bat");
            } else {
                process.StandardInput.WriteLine("ndstool_close.bat");
            }
            process.WaitForExit();
            if (discordBox.Checked)
            {
                string stringToBeSentToDiscord = ":warning: Hey guys, **" + File.ReadAllLines(path)[0] + "** just commited a new Ermii Kart DS build **#" + (build.Text).ToString() + "**!\nThe changes are as follows: " + textAdded.Text + "\n";
                string[] emojiArray = new string[] { ":smile:", ":smiley:", ":grinning:", ":blush:", ":relaxed:", ":wink:", ":heart_eyes:", ":kissing_heart:", ":kissing_closed_eyes:", ":kissing:", ":kissing_smiling_eyes:", ":stuck_out_tongue_winking_eye:", ":stuck_out_tongue_closed_eyes:", ":stuck_out_tongue:", ":flushed:", ":grin:", ":pensive:", ":relieved:", ":unamused:", ":disappointed:", ":persevere:", ":cry:", ":joy:", ":sob:", ":sleepy:", ":disappointed_relieved:", ":cold_sweat:", ":sweat_smile:", ":sweat:", ":weary:", ":tired_face:", ":fearful:", ":scream:", ":angry:", ":rage:", ":triumph:", ":confounded:", ":laughing:", ":yum:", ":mask:", ":sunglasses:", ":sleeping:", ":dizzy_face:", ":astonished:", ":worried:", ":frowning:", ":anguished:", ":smiling_imp:", ":imp:", ":open_mouth:", ":grimacing:", ":neutral_face:", ":confused:", ":hushed:", ":no_mouth:", ":innocent:", ":smirk:", ":expressionless:", ":man_with_gua_pi_mao:", ":man_with_turban:", ":cop:", ":construction_worker:", ":guardsman:", ":baby:", ":boy:", ":girl:", ":man:", ":woman:", ":older_man:", ":older_woman:", ":person_with_blond_hair:", ":angel:", ":princess:", ":japanese_ogre:", ":japanese_goblin:", ":skull:", ":alien:", ":poop:", ":man_with_turban:", ":man_with_turban::skin-tone-1:", ":man_with_turban::skin-tone-2:", ":man_with_turban::skin-tone-3:", ":man_with_turban::skin-tone-4:", ":man_with_turban::skin-tone-5:" };
                Random emojiRND = new Random();
                stringToBeSentToDiscord += emojiArray[emojiRND.Next(emojiArray.Length)];
                Classes.InteractWithDiscord.Interact(stringToBeSentToDiscord);
            }
            byte[] ekds_rom = File.ReadAllBytes("scripts/output_unenc (AltWfc).nds");
            File.Create("output.nds").Close();
            File.WriteAllBytes("output.nds", EKRomEncryptor.EncryptRom(ekds_rom));
            if (closeAfterBuilding.Checked)
            {
                Application.Exit();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void botRTF_Click(object sender, EventArgs e)
        {
            Classes.InteractWithDiscord.Interact(botTextBox.Text);
        }
    }
}
