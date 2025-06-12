using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizAppWinForms;

namespace ConsoleApp2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStartQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new QuizForm();
            form.FormClosed += (s, args) => this.Close();
            form.Show();
        }

        private void btnAddQuestion_Click(object sender, EventArgs e)
        {
            this.Hide();
            var addForm = new AddQuestion();
            addForm.FormClosed += (s, args) => this.Close();
            addForm.Show();
        }

    }
}
