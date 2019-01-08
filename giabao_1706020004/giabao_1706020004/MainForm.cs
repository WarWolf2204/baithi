/*
 * Created by SharpDevelop.
 * User: C1-D02
 * Date: 1/8/2019
 * Time: 8:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace giabao_1706020004
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		clsLine line;
		clsTriangle tri;
		Graphics g;
		Pen p;
		clsPoint A = new clsPoint();
		clsPoint B = new clsPoint();
		clsPoint C = new clsPoint();
		List<clsHinh> list = new List<clsHinh>();
		bool Drawtriangle = false;
		bool DrawLine = false;
		bool isDrawing = false;
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			g = pbshow.CreateGraphics();
			p = new Pen(Color.Black);
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void TslineClick(object sender, EventArgs e)
		{
			DrawLine = true;
			Drawtriangle = false;
		}

		
		void PbshowMouseUp(object sender, MouseEventArgs e)
		{
			isDrawing = false;
			B.ix = e.X;
			B.iy = e.Y;
			if(DrawLine == true)
			{
				line = new clsLine(A,B);
				list.Add(line);
				foreach(var item in list)
				{
					item.draw(g,p);
				}
			}
			if(Drawtriangle == true)
			{
				tri = new clsTriangle(A,B,C);
				list.Add(tri);
				foreach(var item in list)
				{
					item.draw(g,new Pen(Color.White));
				}
				
					Point [] a = new Point[4];
					a[0] = new Point(A.ix,A.ix);
					a[1] = new Point(B.ix,B.iy);
					a[2] = new Point(C.ix,C.iy);
					a[3] = new Point(A.ix,A.ix);
					g.DrawLines(p,a);
			}
		}
		void PbshowMouseMove(object sender, MouseEventArgs e)
		{
			if(isDrawing == true)
			{
				if(DrawLine == true)
				{
					g.DrawLine(new Pen(Color.White),A.ix,A.iy,B.ix,B.iy);
					B.ix = e.X;
					B.iy = e.Y;
					foreach(var item in list)
					{
						item.draw(g,p);
					}
					g.DrawLine(p,A.ix,A.iy,B.ix,B.iy);
				}
			}
			if(isDrawing == true)
			{
				if(Drawtriangle == true)
				{
					Point [] a = new Point[4];
					a[0] = new Point(A.ix,A.ix);
					a[1] = new Point(B.ix,B.iy);
					a[2] = new Point(C.ix,C.iy);
					a[3] = new Point(A.ix,A.ix);
					g.DrawLines(new Pen(Color.White),a);
					B.ix = e.X;
					B.iy = e.Y;
					foreach(var item in list)
					{
						item.draw(g,p);
					}
					a[0] = new Point(A.ix,A.ix);
					a[1] = new Point(B.ix,B.iy);
					a[2] = new Point(C.ix,C.iy);
					a[3] = new Point(A.ix,A.ix);
					g.DrawLines(p,a);
				}
			}
		}
		
		void PbshowMouseDown(object sender, MouseEventArgs e)
		{
		if(DrawLine == true)
			{
				isDrawing = true;
				A.ix = e.X;
				A.iy = e.Y;
			}
		if(Drawtriangle == true)
			{
				isDrawing = true;
				A.ix = e.X;
				A.iy = e.Y;

			}			
		}
		
		void TsrectagleClick(object sender, EventArgs e)
		{
			DrawLine = false;
			Drawtriangle = true;
		}
	}
}
