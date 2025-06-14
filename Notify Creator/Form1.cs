
using System.Windows.Forms;



namespace Notify_Creator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {

            if (comboBox2.SelectedIndex == 0)
            {
                notifyIcon1.Icon = SystemIcons.Application;
            }
            else if (comboBox2.SelectedIndex == 1)
            {
                notifyIcon1.Icon = SystemIcons.Information;
            }
            else if (comboBox2.SelectedIndex == 2)
            {
                notifyIcon1.Icon = SystemIcons.Error;
            }
            else if (comboBox2.SelectedIndex == 3)
            {
                notifyIcon1.Icon = SystemIcons.Warning;
            }
            else if (comboBox2.SelectedIndex == 4)
            {
                using (OpenFileDialog openfiledialog = new OpenFileDialog())
                {
                    openfiledialog.Filter = "icon files (*.ico)|*.ico|png files (*.png)|*.png|all files (*.*)|*.*";
                    if (openfiledialog.ShowDialog() == DialogResult.OK)
                    {
                        string selectedfile = openfiledialog.FileName;
                        try
                        {
                            if (System.IO.Path.GetExtension(selectedfile).ToLower() == ".ico")
                            {
                                if (System.IO.Path.GetExtension(selectedfile).ToLower() == ".ico")
                                {
                                    notifyIcon1.Icon = new System.Drawing.Icon(selectedfile);
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            {
                                MessageBox.Show($"failed! {ex.Message}");
                            }
                        }

                    }
                }
            }
            if (comboBox1.SelectedIndex == 0)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                notifyIcon1.BalloonTipIcon = ToolTipIcon.None;
            }


            notifyIcon1.Visible = true;
            notifyIcon1.Text = textBox2.Text;  // tray icon tooltip text
            notifyIcon1.BalloonTipTitle = textBox1.Text;
            notifyIcon1.BalloonTipText = textBox2.Text;

            if (notifyIcon1.BalloonTipTitle == "" || notifyIcon1.BalloonTipText == "")
            {
                MessageBox.Show("Textbox can't be empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (notifyIcon1.Icon == null)
            {
                notifyIcon1.Icon = SystemIcons.Application;
            }
            else
            {
                notifyIcon1.ShowBalloonTip(3000);
            }


        }


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
