/*
 * Created by SharpDevelop.
 * User: Martin - Notebook
 * Date: 1.12.2012
 * Time: 16:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Piskvorky
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
			this.lab11 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.labhrac = new System.Windows.Forms.Label();
			this.lab12 = new System.Windows.Forms.Label();
			this.lab13 = new System.Windows.Forms.Label();
			this.lab23 = new System.Windows.Forms.Label();
			this.lab33 = new System.Windows.Forms.Label();
			this.lab22 = new System.Windows.Forms.Label();
			this.lab32 = new System.Windows.Forms.Label();
			this.lab31 = new System.Windows.Forms.Label();
			this.lab21 = new System.Windows.Forms.Label();
			this.labpodvod = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lab11
			// 
			this.lab11.BackColor = System.Drawing.Color.LightGray;
			this.lab11.Location = new System.Drawing.Point(22, 57);
			this.lab11.Name = "lab11";
			this.lab11.Size = new System.Drawing.Size(68, 57);
			this.lab11.TabIndex = 1;
			this.lab11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lab11.Click += new System.EventHandler(this.Lab11Click);
			// 
			// label3
			// 
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Location = new System.Drawing.Point(12, 9);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(78, 20);
			this.label3.TabIndex = 2;
			this.label3.Text = "Hraje hráč :";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// labhrac
			// 
			this.labhrac.BackColor = System.Drawing.SystemColors.Control;
			this.labhrac.Location = new System.Drawing.Point(80, 9);
			this.labhrac.Name = "labhrac";
			this.labhrac.Size = new System.Drawing.Size(56, 20);
			this.labhrac.TabIndex = 3;
			this.labhrac.Text = "1";
			this.labhrac.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lab12
			// 
			this.lab12.BackColor = System.Drawing.Color.LightGray;
			this.lab12.Location = new System.Drawing.Point(96, 57);
			this.lab12.Name = "lab12";
			this.lab12.Size = new System.Drawing.Size(68, 57);
			this.lab12.TabIndex = 4;
			this.lab12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lab12.Click += new System.EventHandler(this.Lab12Click);
			// 
			// lab13
			// 
			this.lab13.BackColor = System.Drawing.Color.LightGray;
			this.lab13.Location = new System.Drawing.Point(170, 57);
			this.lab13.Name = "lab13";
			this.lab13.Size = new System.Drawing.Size(68, 57);
			this.lab13.TabIndex = 5;
			this.lab13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lab13.Click += new System.EventHandler(this.Lab13Click);
			// 
			// lab23
			// 
			this.lab23.BackColor = System.Drawing.Color.LightGray;
			this.lab23.Location = new System.Drawing.Point(170, 123);
			this.lab23.Name = "lab23";
			this.lab23.Size = new System.Drawing.Size(68, 57);
			this.lab23.TabIndex = 6;
			this.lab23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lab23.Click += new System.EventHandler(this.Lab23Click);
			// 
			// lab33
			// 
			this.lab33.BackColor = System.Drawing.Color.LightGray;
			this.lab33.Location = new System.Drawing.Point(170, 189);
			this.lab33.Name = "lab33";
			this.lab33.Size = new System.Drawing.Size(68, 57);
			this.lab33.TabIndex = 7;
			this.lab33.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lab33.Click += new System.EventHandler(this.Lab33Click);
			// 
			// lab22
			// 
			this.lab22.BackColor = System.Drawing.Color.LightGray;
			this.lab22.Location = new System.Drawing.Point(96, 123);
			this.lab22.Name = "lab22";
			this.lab22.Size = new System.Drawing.Size(68, 57);
			this.lab22.TabIndex = 8;
			this.lab22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lab22.Click += new System.EventHandler(this.Lab22Click);
			// 
			// lab32
			// 
			this.lab32.BackColor = System.Drawing.Color.LightGray;
			this.lab32.Location = new System.Drawing.Point(96, 189);
			this.lab32.Name = "lab32";
			this.lab32.Size = new System.Drawing.Size(68, 57);
			this.lab32.TabIndex = 9;
			this.lab32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lab32.Click += new System.EventHandler(this.Lab32Click);
			// 
			// lab31
			// 
			this.lab31.BackColor = System.Drawing.Color.LightGray;
			this.lab31.Location = new System.Drawing.Point(22, 189);
			this.lab31.Name = "lab31";
			this.lab31.Size = new System.Drawing.Size(68, 57);
			this.lab31.TabIndex = 10;
			this.lab31.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lab31.Click += new System.EventHandler(this.Lab31Click);
			// 
			// lab21
			// 
			this.lab21.BackColor = System.Drawing.Color.LightGray;
			this.lab21.Location = new System.Drawing.Point(22, 123);
			this.lab21.Name = "lab21";
			this.lab21.Size = new System.Drawing.Size(68, 57);
			this.lab21.TabIndex = 11;
			this.lab21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.lab21.Click += new System.EventHandler(this.Lab21Click);
			// 
			// labpodvod
			// 
			this.labpodvod.Location = new System.Drawing.Point(23, 29);
			this.labpodvod.Name = "labpodvod";
			this.labpodvod.Size = new System.Drawing.Size(214, 19);
			this.labpodvod.TabIndex = 12;
			this.labpodvod.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(196, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(47, 23);
			this.button1.TabIndex = 13;
			this.button1.Text = "Credits";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(0, 260);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(255, 80);
			this.pictureBox1.TabIndex = 14;
			this.pictureBox1.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(255, 340);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.labpodvod);
			this.Controls.Add(this.lab21);
			this.Controls.Add(this.lab31);
			this.Controls.Add(this.lab32);
			this.Controls.Add(this.lab22);
			this.Controls.Add(this.lab33);
			this.Controls.Add(this.lab23);
			this.Controls.Add(this.lab13);
			this.Controls.Add(this.lab12);
			this.Controls.Add(this.labhrac);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.lab11);
			this.Name = "MainForm";
			this.Text = "Piskvorky";
			this.TransparencyKey = System.Drawing.Color.White;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label labpodvod;
		private System.Windows.Forms.Label lab11;
		private System.Windows.Forms.Label lab12;
		private System.Windows.Forms.Label lab13;
		private System.Windows.Forms.Label lab23;
		private System.Windows.Forms.Label lab33;
		private System.Windows.Forms.Label lab22;
		private System.Windows.Forms.Label lab32;
		private System.Windows.Forms.Label lab31;
		private System.Windows.Forms.Label lab21;
		private System.Windows.Forms.Label labhrac;
		private System.Windows.Forms.Label label3;
	}
}
