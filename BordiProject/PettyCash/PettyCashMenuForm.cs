using System;
using System.Windows.Forms;

namespace BordiProject.PettyCash
{
    public partial class PettyCashMenuForm : Form
    {
        public void openForm(Form x)
        {
            x.ShowDialog();
            this.Show();
        }

        public PettyCashMenuForm()
        {
            InitializeComponent();
        }

        private void attendanceLabel_Click(object sender, EventArgs e)
        {
            openForm(new PettyCashInsertForm());
        }

        private void customerLabel_Click(object sender, EventArgs e)
        {
            openForm(new PettyCashHistoryForm());
        }
    }
}
