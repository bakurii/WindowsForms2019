using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _15file//Se toimii!!
{
    public partial class Form1 : Form
    {
        private String EditorFileName = "Untitled";

        private void SetFormTitleText()
        {
            // Tiedoston nimi formiin. 
            FileInfo fileinfo = new FileInfo(EditorFileName);
            Text = fileinfo.Name + " - Editor";
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReadFile()
        {
            try
            {
                // Luodaan StreamReader objekti ja luetaan tiedosto. 
                using (StreamReader Reader = new StreamReader(EditorFileName))
                {
                    // Luku 
                    richTextBox1.Clear();
                    richTextBox1.Text = Reader.ReadToEnd();
                }
            }

            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Open File",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void SaveFile()
        {
            try
            {
                // Luodaan SteramWriter objekti ja kirjoitetaan teksti tiedostoon. 
                using (StreamWriter StrWriter = new StreamWriter(EditorFileName))
                {
                    // Kirjoitus 
                    StrWriter.Write(richTextBox1.Text);
                }
            }

            catch (IOException ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Save File",
                                 MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)//File Exit
        {
            Environment.Exit(0);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)//File New
        {
            EditorFileName = "Untitled";
            richTextBox1.Clear();
            SetFormTitleText();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)//File open
        {
            // Luodaan standardi avausdialogiobjekti ja alustetaan se. 
            OpenFileDialog OpenFileDlg = new OpenFileDialog();
            OpenFileDlg.Title = "Open";
            OpenFileDlg.ShowReadOnly = true;
            OpenFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*";

            // Avataan windowsin standardi avausdialogi. 
            if (OpenFileDlg.ShowDialog() == DialogResult.OK)
            {
                // Talletetaan tiedoston nimi ja polku lukemista varten. 
                EditorFileName = OpenFileDlg.FileName;

                // Luetaan tiedosotn sisältö ja tuodaan se näytölle. 
                ReadFile();
                SetFormTitleText();

            }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)//File Save
        {
            if (EditorFileName == "Untitled")
            {
                SaveAsToolStripMenuItem_Click(sender, e);
            }

            else
            {
                SaveFile();
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)//File Save as...
        {
            // Luodaan standardi talletusdialogiobjekti ja alustetaan se. 
            SaveFileDialog SaveFileDlg = new SaveFileDialog();
            SaveFileDlg.Filter = "Text documents (*.txt)|*.txt|All files|*.*";

            // Avataan windowsin standardi talletusdialogi. 
            if (SaveFileDlg.ShowDialog() == DialogResult.OK)
            {
                // Talletetaan tiedoston nimi ja polku talletusta varten. 
                EditorFileName = SaveFileDlg.FileName;
                SaveFile();
                SetFormTitleText();
            }
        }
    }
}
