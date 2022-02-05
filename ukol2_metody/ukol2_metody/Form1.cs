using System;
using System.Windows.Forms;

namespace ukol2_metody
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public bool JePrvocislo(int number)
        {
            if (number <= 1) {
                return false;
            }
            if (number == 2) {
                return true;
            }
            if (number % 2 == 0) {
                return false;
            }
            for (int xd = 3; xd < number / 2; xd += 2)
            {
                if (number % xd == 0) {
                    return false; 
                }
            }
            return true;
        }
        public void Prepis(int[] array)
        {
            foreach (int lol in array) {
                if (JePrvocislo(lol)) { 
                    listBox1.Items.Add(lol); 
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try {
                listBox1.Items.Clear();
                int input = Int32.Parse(textBox1.Text);
                int[] array = new int[input];
                Random rnd = new Random();
                for (int i = 0; i < input; i++) {
                    array[i] = rnd.Next(2, 16);
                    listBox2.Items.Add(array[i]);
                }
                Prepis(array);
            } 
            catch {
                MessageBox.Show("Zadal jsi špatnou hodnotu! :)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show("Zadávej jen čísla! :)", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
        }
    }
}
