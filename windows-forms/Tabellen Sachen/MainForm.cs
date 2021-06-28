/*
 * Created by SharpDevelop.
 * User: User
 * Date: 28.06.2021
 * Time: 14:39
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Tabellen_Sachen
{
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form
    {
        Random rnd = new Random();
        public MainForm()
        {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        void DataGrid1Navigate(object sender, NavigateEventArgs ne)
        {

        }

        void Start(int count)
        {

            DataTable table = new DataTable();

            table.Columns.Add("Anzahl Jungen", typeof(int));
            table.Columns.Add("Anzahl Mädchen", typeof(int));
            table.Columns.Add("Sachen", typeof(float));

            int[] arr = new int[count + 1];

            for (int i = 0; i < 100000; i++)
            {
                int v = generateFamily(count);
                arr[v]++;

            }
            for (int i = 0; i < arr.Length; i++)
            {
                table.Rows.Add(i, 0, (double)arr[i]);
            }

            dataGridView1.DataSource = table;

            button1.Enabled = true;
        }

        int generateFamily(int children)
        {
            int boys = 0;
            //var rnnnnnn = rnd.NextDouble().ToString();
            for (int i = 0; i < children; i++)
            {

                if (rnd.NextDouble() < 0.514)
                {
                    boys++;
                }
            }

            return boys;

        }


        void TextBox1TextChanged(object sender, EventArgs e)
        {
            dataGridView1.Visible = textBox1.Text.Length > 0;

            try
            {
                Start(Clamp(Convert.ToInt32(textBox1.Text), 10, 1));
            }
            catch (Exception ignored) { }
        }

        public static T Clamp<T>(T value, T max, T min)
            where T : System.IComparable<T>
        {
            T result = value;
            if (value.CompareTo(max) > 0)
                result = max;
            if (value.CompareTo(min) < 0)
                result = min;
            return result;
        }


        void Button1Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            try
            {
                Start(Clamp(Convert.ToInt32(textBox1.Text), 10, 1));
            }
            catch (Exception ignored) { }
        }
    }

}

/*
Antworten Fragen 1-3
1: Nein!
2:
            table.Columns.Add("Anzahl Jungen", typeof(int));
            table.Columns.Add("Anzahl Mädchen", typeof(int));
            table.Columns.Add("Sachen", typeof(float)); 

            for (int i = 0; i < 10; i++)
            {
                table.Rows.Add(i, 0, (double)arr[i]);
            }

3: table.Rows[].SetField(int columnIndex, T vieldValue)
4: Der Program von oben si wissen bescheid
5: Reis!
*/