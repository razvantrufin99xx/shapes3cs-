/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/30/2024
 * Time: 1:11 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace dotControl
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private dotControl.dot dot1;
		private dotControl.dot dot2;
		private dotControl.dot dot3;
		private dotControl.dot dot4;
		private dotControl.dot dot5;
		private dotControl.dot dot6;
		private dotControl.dot dot7;
		private dotControl.dot dot8;
		
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
			this.dot1 = new dotControl.dot();
			this.dot2 = new dotControl.dot();
			this.dot3 = new dotControl.dot();
			this.dot4 = new dotControl.dot();
			this.dot5 = new dotControl.dot();
			this.dot6 = new dotControl.dot();
			this.dot7 = new dotControl.dot();
			this.dot8 = new dotControl.dot();
			this.SuspendLayout();
			// 
			// dot1
			// 
			this.dot1.BackColor = System.Drawing.Color.Black;
			this.dot1.Location = new System.Drawing.Point(103, 13);
			this.dot1.Name = "dot1";
			this.dot1.Size = new System.Drawing.Size(21, 22);
			this.dot1.TabIndex = 0;
			// 
			// dot2
			// 
			this.dot2.BackColor = System.Drawing.Color.Black;
			this.dot2.Location = new System.Drawing.Point(286, 12);
			this.dot2.Name = "dot2";
			this.dot2.Size = new System.Drawing.Size(21, 22);
			this.dot2.TabIndex = 1;
			// 
			// dot3
			// 
			this.dot3.BackColor = System.Drawing.Color.Black;
			this.dot3.Location = new System.Drawing.Point(460, 12);
			this.dot3.Name = "dot3";
			this.dot3.Size = new System.Drawing.Size(21, 22);
			this.dot3.TabIndex = 2;
			// 
			// dot4
			// 
			this.dot4.BackColor = System.Drawing.Color.Black;
			this.dot4.Location = new System.Drawing.Point(460, 106);
			this.dot4.Name = "dot4";
			this.dot4.Size = new System.Drawing.Size(21, 22);
			this.dot4.TabIndex = 3;
			// 
			// dot5
			// 
			this.dot5.BackColor = System.Drawing.Color.Black;
			this.dot5.Location = new System.Drawing.Point(460, 208);
			this.dot5.Name = "dot5";
			this.dot5.Size = new System.Drawing.Size(21, 22);
			this.dot5.TabIndex = 4;
			// 
			// dot6
			// 
			this.dot6.BackColor = System.Drawing.Color.Black;
			this.dot6.Location = new System.Drawing.Point(286, 208);
			this.dot6.Name = "dot6";
			this.dot6.Size = new System.Drawing.Size(21, 22);
			this.dot6.TabIndex = 5;
			// 
			// dot7
			// 
			this.dot7.BackColor = System.Drawing.Color.Black;
			this.dot7.Location = new System.Drawing.Point(103, 208);
			this.dot7.Name = "dot7";
			this.dot7.Size = new System.Drawing.Size(21, 22);
			this.dot7.TabIndex = 6;
			// 
			// dot8
			// 
			this.dot8.BackColor = System.Drawing.Color.Black;
			this.dot8.Location = new System.Drawing.Point(103, 106);
			this.dot8.Name = "dot8";
			this.dot8.Size = new System.Drawing.Size(21, 22);
			this.dot8.TabIndex = 7;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(948, 467);
			this.Controls.Add(this.dot8);
			this.Controls.Add(this.dot7);
			this.Controls.Add(this.dot6);
			this.Controls.Add(this.dot5);
			this.Controls.Add(this.dot4);
			this.Controls.Add(this.dot3);
			this.Controls.Add(this.dot2);
			this.Controls.Add(this.dot1);
			this.Name = "MainForm";
			this.Text = "dotControl";
			this.ResumeLayout(false);

		}
	}
}
