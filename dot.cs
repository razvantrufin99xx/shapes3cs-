/*
 * Created by SharpDevelop.
 * User: razvan
 * Date: 9/30/2024
 * Time: 1:12 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace dotControl
{
	/// <summary>
	/// Description of dot.
	/// </summary>
	public partial class dot : UserControl
	{
		public dot()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		public Graphics g;
		public Color linecolor = Color.Red;
		public int ismousedown = 0;
		public int ccc = 0;
		public int cx = 0;
		public int cy = 0;
		void DotLoad(object sender, EventArgs e)
		{
			g  = this.CreateGraphics();
		}
		void DotPaint(object sender, PaintEventArgs e)
		{
			g.DrawLine(new Pen(linecolor),1,1,Width,Height);
		}
		void DotMouseDown(object sender, MouseEventArgs e)
		{
			linecolor = Color.Blue;
			g.DrawLine(new Pen(linecolor),1,1,Width,1);
			cx = e.X;
			cy = e.Y;
			ismousedown = 1;
		}
		
		void DotMouseHover(object sender, EventArgs e)
		{
			this.BorderStyle = BorderStyle.FixedSingle;
		}
		void DotMouseLeave(object sender, EventArgs e)
		{
			this.BorderStyle = BorderStyle.None;
		}
		void DotMouseMove(object sender, MouseEventArgs e)
		{
			if(ismousedown==1)
						{
							this.Left += e.X -cx ;
							this.Top += e.Y - cy;
							
							
						}
		}
		void DotMouseEnter(object sender, EventArgs e)
		{
			this.BorderStyle = BorderStyle.FixedSingle;
		}
		void DotMouseUp(object sender, MouseEventArgs e)
		{
			linecolor = Color.Red;
			g.DrawLine(new Pen(linecolor),1,1,Width,1);
			ismousedown = 0;
		}
		
		
	}
}
