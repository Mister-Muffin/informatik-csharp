/*
 * Created by SharpDevelop.
 * User: User
 * Date: 21.10.2021
 * Time: 12:17
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace ulam
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.textFieldN = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(260, 23);
			this.label1.TabIndex = 0;
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// textFieldN
			// 
			this.textFieldN.Location = new System.Drawing.Point(94, 44);
			this.textFieldN.Name = "textFieldN";
			this.textFieldN.Size = new System.Drawing.Size(100, 20);
			this.textFieldN.TabIndex = 1;
			this.textFieldN.TextChanged += new System.EventHandler(this.TextFieldNTextChanged);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 261);
			this.Controls.Add(this.textFieldN);
			this.Controls.Add(this.label1);
			this.Name = "MainForm";
			this.Text = "ulam";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textFieldN;
		private System.Windows.Forms.Label label1;
	}
}
