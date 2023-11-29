using System;
using System.Windows.Forms;

namespace TestTask_KleverensSoft
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void Task1_Click(object sender, EventArgs e)
        {
            var FormTask = new FormTask1();
            FormTask.ShowDialog();
        }

        private void Task2_Click(object sender, EventArgs e)
        {
            var FormTask = new FormTask2();
            FormTask.ShowDialog();
        }

        private void Task3_Click(object sender, EventArgs e)
        {
            var FormTask = new FormTask3();
            FormTask.ShowDialog();
        }
    }
}
