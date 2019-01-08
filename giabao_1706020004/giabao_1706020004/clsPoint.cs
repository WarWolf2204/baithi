/*
 * Created by SharpDevelop.
 * User: C1-D02
 * Date: 1/8/2019
 * Time: 8:43 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace giabao_1706020004
{
	/// <summary>
	/// Description of clsPoint.
	/// </summary>
	public class clsPoint
	{
		int x,y;
		public clsPoint()
		{
			x = 0;
			y = 0;
		}
		public clsPoint(int ix,int iy)
		{
			x = ix;
			y = iy;
		}
		public int ix
		{
			get
			{
				return x;
			}
			set
			{
				x = value;
			}
		}
		public int iy
		{
			get
			{
				return y;
			}
			set
			{
				y = value;
			}
		}
	}
}
