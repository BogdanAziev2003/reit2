using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reit2
{
    public partial class Form1 : Form
    {
        int[] monthDay = new int[12] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};  

        public Form1()
        {
            InitializeComponent();
        }



        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            string selectedState = comboBox1.SelectedItem.ToString();
            richTextBox1.Text = $"{richTextBox1.Text} {selectedState} - {monthDay[selectedIndex]}\n";
            textBox1.Text = Convert.ToString(selectedIndex + 1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = int.Parse(textBox1.Text) - 1;
            comboBox1.SelectedIndex = index;
        }
    }
}
