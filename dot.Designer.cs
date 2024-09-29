﻿/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/30/2024
 * Time: 1:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace dotControl
{
	partial class dot
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			this.SuspendLayout();
			// 
			// dot
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Black;
			this.Name = "dot";
			this.Size = new System.Drawing.Size(21, 22);
			this.Load += new System.EventHandler(this.DotLoad);
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.DotPaint);
			this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DotMouseDown);
			this.MouseEnter += new System.EventHandler(this.DotMouseEnter);
			this.MouseLeave += new System.EventHandler(this.DotMouseLeave);
			this.MouseHover += new System.EventHandler(this.DotMouseHover);
			this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DotMouseMove);
			this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DotMouseUp);
			this.ResumeLayout(false);

		}
	}
}
