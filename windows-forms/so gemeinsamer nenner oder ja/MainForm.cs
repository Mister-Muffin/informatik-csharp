/*
 * Created by SharpDevelop.
 * User: User
 * Date: 30.09.2021
 * Time: 14:49
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace so_gemeinsamer_nenner_oder_ja {
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form {
        public MainForm() {
            InitializeComponent();
        }

        //rekursiver Teil

        private int ichbineinerekursivefunktionmittollenfunktionen(int i, int j) {
            int diff;
            if (i > j) diff = i - j;
            else diff = j - i;
            if (diff == j) {
                label1.Text = diff.ToString();
                return diff;
            }
            ichbineinerekursivefunktionmittollenfunktionen(j, diff);
            return 1;
        }

        void Button1Click(object sender, EventArgs e) {
            ichbineinerekursivefunktionmittollenfunktionen(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
        }

        //absoluter Teil

        private int a(int i, int j) {
            List<int> teiler_a = new List<int>();
            List<int> teiler_b = new List<int>();

            for (int a = 1; a < i; a++) {
                if (i % a == 0) teiler_a.Add(a);
            }

            for (int b = 1; b < j; b++) {
                if (j % b == 0) teiler_b.Add(b);
            }
            teiler_a.Reverse();
            foreach (var element in teiler_a) {
                if (teiler_b.Contains(element)) return element;
            }
            return -1;

        }

        void Button2Click(object sender, EventArgs e) {
            label1.Text = a(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text)).ToString();
        }
    }
}
