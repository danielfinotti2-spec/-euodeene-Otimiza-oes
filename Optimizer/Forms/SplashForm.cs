using System.Windows.Forms;

namespace Optimizer
{
    public sealed partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
            OptionsHelper.ApplyTheme(this);

            this.DoubleBuffered = true;
            CheckForIllegalCrossThreadCalls = false;

            LoadingStatus.Font = FontHelper.Poppins15;
            LoadingStatus.Visible = false;

            pictureBox2.BackColor = OptionsHelper.CurrentOptions.Theme;
        }

        public void SetLoadingStatus(string status)
        {
            LoadingStatus.Text = status;

            if (status == "inspecting hardware")
                pictureBox2.Image = Properties.Resources.splashHardware;
            else if (status == "checking for requirements")
                pictureBox2.Image = Properties.Resources.splashRequirements;
        }
    }
}
