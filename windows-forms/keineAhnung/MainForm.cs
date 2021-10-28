/*
 * Created by SharpDevelop.
 * User: User
 * Date: 28.10.2021
 * Time: 18:34
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace keineAhnung {
    /// <summary>
    /// Description of MainForm.
    /// </summary>
    public partial class MainForm : Form {
        DataTable table = new DataTable();
        public MainForm() {
            //
            // The InitializeComponent() call is required for Windows Forms designer support.
            //
            InitializeComponent();

            table.Columns.Add("1", typeof(String));
            table.Columns.Add("2", typeof(String));

            //
            // TODO: Add constructor code after the InitializeComponent() call.
            //
        }

        void TextBox1TextChanged(object sender, EventArgs e) {
            try {
                var input = textBox1.Text.ToString();
                List<String> list = new List<String>();

                string[] subs = input.Split(' ');
                table.Rows.Clear();

                foreach (var sub in subs) {
                    list.Add(sub);
                    table.Rows.Add(sub, "");
                }

                dataGridView1.DataSource = table;
            } catch (Exception) { }
        }
    }
}
