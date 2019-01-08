/*
 * Created by SharpDevelop.
 * User: C1-D02
 * Date: 1/8/2019
 * Time: 8:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace giabao_1706020004
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.ts = new System.Windows.Forms.ToolStrip();
			this.tsline = new System.Windows.Forms.ToolStripButton();
			this.tsrectagle = new System.Windows.Forms.ToolStripButton();
			this.tsdiamond = new System.Windows.Forms.ToolStripButton();
			this.pbshow = new System.Windows.Forms.PictureBox();
			this.ts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbshow)).BeginInit();
			this.SuspendLayout();
			// 
			// ts
			// 
			this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
									this.tsline,
									this.tsrectagle,
									this.tsdiamond});
			this.ts.Location = new System.Drawing.Point(0, 0);
			this.ts.Name = "ts";
			this.ts.Size = new System.Drawing.Size(658, 25);
			this.ts.TabIndex = 0;
			// 
			// tsline
			// 
			this.tsline.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
			this.tsline.Image = ((System.Drawing.Image)(resources.GetObject("tsline.Image")));
			this.tsline.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsline.Name = "tsline";
			this.tsline.Size = new System.Drawing.Size(50, 22);
			this.tsline.Text = "line";
			this.tsline.Click += new System.EventHandler(this.TslineClick);
			// 
			// tsrectagle
			// 
			this.tsrectagle.Image = ((System.Drawing.Image)(resources.GetObject("tsrectagle.Image")));
			this.tsrectagle.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsrectagle.Name = "tsrectagle";
			this.tsrectagle.Size = new System.Drawing.Size(67, 22);
			this.tsrectagle.Text = "triangle";
			this.tsrectagle.Click += new System.EventHandler(this.TsrectagleClick);
			// 
			// tsdiamond
			// 
			this.tsdiamond.CheckOnClick = true;
			this.tsdiamond.Image = ((System.Drawing.Image)(resources.GetObject("tsdiamond.Image")));
			this.tsdiamond.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsdiamond.Name = "tsdiamond";
			this.tsdiamond.Size = new System.Drawing.Size(75, 22);
			this.tsdiamond.Text = "diamond";
			// 
			// pbshow
			// 
			this.pbshow.BackColor = System.Drawing.Color.White;
			this.pbshow.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pbshow.Location = new System.Drawing.Point(0, 25);
			this.pbshow.Name = "pbshow";
			this.pbshow.Size = new System.Drawing.Size(658, 290);
			this.pbshow.TabIndex = 1;
			this.pbshow.TabStop = false;
			this.pbshow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PbshowMouseDown);
			this.pbshow.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PbshowMouseMove);
			this.pbshow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PbshowMouseUp);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(658, 315);
			this.Controls.Add(this.pbshow);
			this.Controls.Add(this.ts);
			this.Name = "MainForm";
			this.Text = "giabao_1706020004";
			this.ts.ResumeLayout(false);
			this.ts.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pbshow)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.PictureBox pbshow;
		private System.Windows.Forms.ToolStripButton tsdiamond;
		private System.Windows.Forms.ToolStripButton tsrectagle;
		private System.Windows.Forms.ToolStripButton tsline;
		private System.Windows.Forms.ToolStrip ts;
	}
}
