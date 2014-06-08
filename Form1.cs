using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HWStudents
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int count;
        static string name = "Adis";

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                List<Student> students = new List<Student>(); // List of students
                students.Add(new Student("asjo1525@aubih.edu.ba", "Adis", "Jugo"));
                students.Add(new Student("nmkn1527@aubih.edu.ba", "Nedim", "Kulašin"));
                students.Add(new Student("kmkc1643@aubih.edu.ba", "Kerim", "Krdžević"));
                students.Add(new Student("eknc1552@aubih.edu.ba", "Eldin", "Kasapović"));
                students.Add(new Student("uryl1552@aubih.edu.ba", "Umur", "Yuksel"));
                students.Add(new Student("inhr1555@aubih.edu.ba", "Irfan", "Hujdur"));

                students.Sort(); // student sort
                count = students.Count(); // counting of students and putting into static int variable

                foreach (Student s in students) // inputing students on listbox
                {
                    listBox1.Items.Add(s);
                }

                label1.Text = "Number of students: " + count; // ispis broja studenata
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}
