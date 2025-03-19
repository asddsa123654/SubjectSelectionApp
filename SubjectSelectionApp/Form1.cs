using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SubjectSelectionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // Додавання дисциплін до CheckedListBox
            checkedListBoxSubjects.Items.Add("Алгоритми");
            checkedListBoxSubjects.Items.Add("Бази даних");
            checkedListBoxSubjects.Items.Add("Програмування на C#");
            checkedListBoxSubjects.Items.Add("Програмування на Java");
            checkedListBoxSubjects.Items.Add("Математика");
            checkedListBoxSubjects.Items.Add("Мережі");
            checkedListBoxSubjects.Items.Add("Інженерія програмного забезпечення");
            checkedListBoxSubjects.Items.Add("Операційні системи");

            // Початково можна залишити все не вибраним, тому що CheckedListBox не вибрано по замовчуванню
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBoxSubjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
