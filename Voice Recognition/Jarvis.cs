using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Voice_Recognition
{
    public partial class Jarvis : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine();
        public Jarvis()
        {
            InitializeComponent();
        }

        private void B_active_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Multiple);
            B_disable.Enabled = true;
            B_active.Enabled = false;
        }

        private void Jarvis_Load(object sender, EventArgs e)
        {
            Choices commands = new Choices();
            commands.Add(new string[] {"say hello","say my name","open","steam","open ads" });
            GrammarBuilder gBuilder = new GrammarBuilder();
            gBuilder.Append(commands);
            Grammar grammar = new Grammar(gBuilder);

            recEngine.LoadGrammarAsync(grammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += RecEngine_SpeechRecognized;



        }

        private void RecEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            switch (e.Result.Text)
            {
                case "say hello":
                    MessageBox.Show("Hello Karna.How are you today?");
                    break;
                case "say my name":
                    richTextBox1.Text += "\nKarna";
                    break;
                case "open":
                    System.Diagnostics.Process.Start("https://www.youtube.com/");
                    break;
                case "steam":
                    System.Diagnostics.Process.Start(@"C:\Program Files (x86)\Steam\steam.exe");
                    break;
                    
            }
        }

        private void B_disable_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            B_disable.Enabled = false; 
            B_active.Enabled = true;
        }

        private void B_settings_Click(object sender, EventArgs e)
        {
            Settings formSettings = new Settings();

            formSettings.Show();

            //formSettings.Close();
        }

        private void B_commands_Click(object sender, EventArgs e)
        {
            commands formSettings = new commands();

            formSettings.Show();
        }
    }
}
