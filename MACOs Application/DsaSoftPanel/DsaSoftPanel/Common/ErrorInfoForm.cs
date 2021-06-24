using System.Windows.Forms;

namespace DsaSoftPanel.Common
{
    public partial class ErrorInfoForm : Form
    {
        public ErrorInfoForm(string title, string message)
        {
            InitializeComponent();
            this.label_title.Text = title;
            this.label_message.Text = message;
        }

        private void button_OK_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
