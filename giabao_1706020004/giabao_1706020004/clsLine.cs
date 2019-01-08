/*
 * Created by SharpDevelop.
 * User: C1-D02
 * Date: 1/8/2019
 * Time: 8:49 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
namespace giabao_1706020004
{
	/// <summary>
	/// Description of clsLine.
	/// </summary>
	public class clsLine : clsHinh
	{
		
		public clsLine()
		{
			
		}
		public clsLine(clsPoint a , clsPoint b)
		{
			A1 = a;
			B1 = b;
		}
		public override void draw(Graphics g, Pen p)
		{
			g.DrawLine(p,A1.ix,A1.iy,B1.ix,B1.iy);
		}
	}
}
