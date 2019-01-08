/*
 * Created by SharpDevelop.
 * User: C1-D02
 * Date: 1/8/2019
 * Time: 8:56 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
namespace giabao_1706020004
{
	/// <summary>
	/// Description of clsHinh.
	/// </summary>
	public class clsHinh
	{
		clsPoint A , B , C;
		public clsPoint A1
		{
			get
			{
				return A;
			}
			set
			{
				A.ix = value.ix;
				A.iy = value.iy;
			}
		}
		public clsPoint B1
		{
			get
			{
				return B;
			}
			set
			{
				B.ix = value.ix;
				B.iy = value.iy;
			}
		}
		public clsPoint C1
		{
			get
			{
				return C;
			}
			set
			{
				C.ix = value.ix;
				C.iy = value.iy;
			}
		}
		public clsHinh()
		{
			A = new clsPoint();
			B = new clsPoint();
			C = new clsPoint();
		}
		public clsHinh(clsPoint a, clsPoint b,clsPoint c)
		{
			A = a;
			B = b;
			C = c;
		}
		public virtual void draw(Graphics g , Pen p)
		{
			
		}
	}
}
