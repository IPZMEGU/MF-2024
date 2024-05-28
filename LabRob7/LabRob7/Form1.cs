using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabRob7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Студент, прийшовши на екзамен з філософії, побачив тему на дошці: \"Чому?\" Сам-на-сам з собою він довго думав, а потім написав: \"Чому б і ні?\"");
        }
    }
}
