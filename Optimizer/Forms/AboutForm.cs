using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Optimizer
{
    public sealed partial class AboutForm : Form
    {
        // Modified by @euodeene on 2026-10-12 for this custom edition.
        public AboutForm()
        {
            InitializeComponent();
            OptionsHelper.ApplyTheme(this);
            pictureBox1.BackColor = OptionsHelper.CurrentOptions.Theme;
        }

        private void About_Load(object sender, EventArgs e)
        {
            t1.Interval = 50;
            t1.Start();
        }

        private void t1_Tick(object sender, EventArgs e)
        {
            const string title = "Optimizer";
            if (l1.Text.Length < title.Length)
            {
                l1.Text = title.Substring(0, l1.Text.Length + 1);
            }
            else
            {
                t1.Stop();
            }
        }

        private void l2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/danielfinotti2-spec");
        }

        private void l3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://www.instagram.com/euodeene/");
        }

        private void l4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://discord.gg/am9s4fqRHw");
        }

        private void l5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://x.com/euodeene");
        }
    }
}
