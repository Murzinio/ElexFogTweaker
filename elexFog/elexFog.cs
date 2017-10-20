using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace elexFog
{
    public partial class elexFog : Form
    {
        FileIO m_file = new FileIO();

        public elexFog()
        {
            InitializeComponent();
            this.comboBoxAction.SelectedIndex = 0;
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            FogType action = FogType.Default;

            switch(comboBoxAction.SelectedIndex)
            {
                case 0:
                    action = FogType.Removed;
                    break;

                case 1:
                    action = FogType.Adjusted;
                    break;

                default:
                    action = FogType.Default;
                    break;
            }

            m_file.modifyFog(action);
            m_file.saveConfig();

            MessageBox.Show("Applied!", "Applied", MessageBoxButtons.OK);
        }

        private void comboBoxAction_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(comboBoxAction.SelectedIndex)
            {
                case 0:
                    pictureBoxComparision.Image = Image.FromFile("comparisions/removed.jpg");
                    pictureBoxComparision.Location = new Point(labelAfter.Location.X - 350, pictureBoxComparision.Location.Y);

                    labelBefore.Visible = true;
                    labelAfter.Visible = true;
                    break;

                case 1:
                    pictureBoxComparision.Image = Image.FromFile("comparisions/adjusted.jpg");
                    pictureBoxComparision.Location = new Point(labelAfter.Location.X - 350, pictureBoxComparision.Location.Y);

                    labelBefore.Visible = true;
                    labelAfter.Visible = true;
                    break;

                default:
                    pictureBoxComparision.Image = Image.FromFile("comparisions/default.jpg");
                    pictureBoxComparision.Location = new Point(labelAfter.Location.X - 175, pictureBoxComparision.Location.Y);

                    labelBefore.Visible = false;
                    labelAfter.Visible = false;
                    break;
            }

            pictureBoxComparision.Size = pictureBoxComparision.Image.Size;
        }

        private void buttonPath_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                var result = m_file.setPathIfValid(dialog.SelectedPath);
                if (!result)
                {
                    MessageBox.Show("Invalid path!", "Eror", MessageBoxButtons.OK);
                }
                else
                {
                    comboBoxAction.Enabled = true;
                    buttonApply.Enabled = true;
                    textBoxPath.Text = dialog.SelectedPath;
                    m_file.readConfig();
                }
            }
        }

        private void linkLabelAuthor_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Murzinio");
        }
    }
}
