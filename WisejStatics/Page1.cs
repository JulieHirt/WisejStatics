using System;
using Wisej.Web;

namespace WisejStatics
{
    public partial class Page1 : Page
    {
        public static int timesClicked = 0;

        public static event EventHandler DisplayTimesClicked;
        public Page1()
        {
            InitializeComponent();
            DisplayTimesClicked += DisplayTimesClicked_Handler;
        }

        private void DisplayTimesClicked_Handler(object sender, EventArgs e)
        {
            Application.Update(this, () =>
            {
                button1.Text = "Times Clicked: " + timesClicked.ToString();
            });
        }


        private void button1_Click(object sender, EventArgs e)
        {
            timesClicked++;
            DisplayTimesClicked?.Invoke(null, EventArgs.Empty);
        }

        private void Page1_Load(object sender, EventArgs e)
        {
            button1.Text = "Times Clicked: " + timesClicked.ToString();
        }
    }
}
