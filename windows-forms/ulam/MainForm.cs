/*
 * Created by SharpDevelop.
 * User: User
 * Date: 21.10.2021
 * Time: 12:17
 *
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ulam {
    public partial class MainForm : Form {

        int counter = 0;

        public MainForm() { InitializeComponent(); }

        private int ulam(int n) {
            if (n == 1) {
                label1.Text = "Bei " + n.ToString() + " angekommen. counter: " + counter.ToString();
                return n;
            }

            counter++; //

            if (n > 1 && n % 2 == 0) {
                return n = ulam(n / 2);
            }
            if (n > 1 && n % 2 != 0) {
                return n = ulam(3 * n + 1);
            }
            label1.Text = n.ToString() + "counter: " + counter.ToString();
            return -1;
        }

        void TextFieldNTextChanged(object sender, EventArgs e) {
            textFieldN.Text = a(textFieldN.Text);
            //
            counter = 0;
            try {
                ulam(Convert.ToInt32(textFieldN.Text));
            } catch (System.Exception) {
                label1.Text = "Exception";
            }
        }
        //---------------------------------------------------------
        private string a(string text) {
            try {
                if (text.Contains("+")) {
                    text = text.Remove(text.IndexOf("+"), 1);
                    text = (Convert.ToInt32(text) + 1).ToString();
                    return text;
                }
                if (text.Contains("-")) {
                    text = text.Remove(text.IndexOf("-"), 1);
                    text = (Convert.ToInt32(text) - 1).ToString();
                    return text;
                }
                return text;
            } catch (Exception) { return text; }
        }
    }
}
