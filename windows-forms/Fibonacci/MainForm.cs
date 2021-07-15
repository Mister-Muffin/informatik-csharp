/*
 * Created by SharpDevelop.
 * User: User
 * Date: 15.07.2021
 * Time: 20:41
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace Fibonacci
{
    public partial class MainForm : Form
    {
        DataTable table = new DataTable();
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();
            //#

            table.Columns.Add("𝑛", typeof(int));
            table.Columns.Add("\x192\x2099", typeof(int));

        }

        private int Fib(int number)
        {
            if (number <= 2)
            {
                return 1;
            }
            else
            {
                return Fib(number - 1) + Fib(number - 2);
            }
        }

        void TextBox1TextChanged(object sender, EventArgs e)
        {
            try
            {
                table.Clear();
                label1.Text = "Ergebnis: " + Fib(Convert.ToInt32(textBox1.Text)).ToString();

                for (int i = 1; i <= Convert.ToInt32(textBox1.Text); i++)
                {
                    table.Rows.Add(i, Fib(i));
                }
                dataGridView1.DataSource = table;

            }
            catch (Exception) { }
        }
    }
}
