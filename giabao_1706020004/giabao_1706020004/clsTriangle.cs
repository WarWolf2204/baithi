/*
 * Created by SharpDevelop.
 * User: C1-D02
 * Date: 1/8/2019
 * Time: 9:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
namespace giabao_1706020004
{
	/// <summary>
	/// Description of clsTriangle.
	/// </summary>
	public class clsTriangle : clsHinh
	{
		public clsTriangle()
		{
		}
		public clsTriangle(clsPoint a, clsPoint b ,clsPoint c)
		{
			A1 = a;
			B1 = b;
			C1 = c;
		}
		public override void draw(Graphics g, Pen p)
		{
			g.Clear(Color.White);
			Point [] a = new Point[4];
			a[0] = new Point(A1.ix,A1.ix);
			a[1] = new Point(B1.ix,B1.iy);
			a[2] = new Point(C1.ix,C1.iy);
			a[3] = new Point(A1.ix,A1.iy);
			g.DrawLines(p,a);
		}
	}
}
