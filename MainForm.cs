/*
 * Created by SharpDevelop.
 * User: Martin - Notebook
 * Date: 1.12.2012
 * Time: 16:06
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Piskvorky
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		
		
		
		void Lab11Click(object sender, EventArgs e)
		{
			if (lab11.Text !="") {
				labpodvod.Text="Hráč "+labhrac.Text+" se pokusil o podvod.";
				switch (labhrac.Text) {
					case "1":
						labhrac.Text="2";
						break;
					case "2":
						labhrac.Text="1";
						break;
					default:
						break;
				}
			}
			else
			{
				if (labhrac.Text == "1") {
						lab11.Text="O";
						labhrac.Text="2";
				
				} 
				else  {
						lab11.Text="X";
						labhrac.Text="1";
				
				}
			}
			if (((lab11.Text == "O")&&(lab12.Text == "O")&&(lab13.Text == "O"))||
			    ((lab21.Text == "O")&&(lab22.Text == "O")&&(lab23.Text == "O"))||
			    ((lab31.Text == "O")&&(lab32.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab21.Text == "O")&&(lab31.Text == "O"))||
			    ((lab12.Text == "O")&&(lab22.Text == "O")&&(lab32.Text == "O"))||
			    ((lab13.Text == "O")&&(lab23.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab22.Text == "O")&&(lab33.Text == "O"))||
			    ((lab13.Text == "O")&&(lab22.Text == "O")&&(lab31.Text == "O"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 1 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}
			if (((lab11.Text == "X")&&(lab12.Text == "X")&&(lab13.Text == "X"))||
			    ((lab21.Text == "X")&&(lab22.Text == "X")&&(lab23.Text == "X"))||
			    ((lab31.Text == "X")&&(lab32.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab21.Text == "X")&&(lab31.Text == "X"))||
			    ((lab12.Text == "X")&&(lab22.Text == "X")&&(lab32.Text == "X"))||
			    ((lab13.Text == "X")&&(lab23.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab22.Text == "X")&&(lab33.Text == "X"))||
			    ((lab13.Text == "X")&&(lab22.Text == "X")&&(lab31.Text == "X"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 2 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}
			if ((lab11.Text!=""&&
				lab12.Text!=""&&
							lab13.Text!=""&&
							lab21.Text!=""&&
							lab22.Text!=""&&
							lab23.Text!=""&&
							lab31.Text!=""&&
							lab32.Text!=""&&
							lab33.Text!="")) { 
				DialogResult remiza =
				MessageBox.Show("Remíza! Chcete to zkusit znovu?","",MessageBoxButtons.YesNo);
				if (remiza == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (remiza == DialogResult.No) {
					Application.Exit();
				}
			}
		}
		
		void Lab12Click(object sender, EventArgs e)
		{
			if (lab12.Text !="") {
				labpodvod.Text="Hráč "+labhrac.Text+" se pokusil o podvod.";
				switch (labhrac.Text) {
					case "1":
						labhrac.Text="2";
						break;
					case "2":
						labhrac.Text="1";
						break;
					default:
						break;
				}
			}
			else
			{
				if (labhrac.Text == "1") {
						lab12.Text="O";
						labhrac.Text="2";
				
				} 
				else  {
						lab12.Text="X";
						labhrac.Text="1";
				
				}
			}
			if (((lab11.Text == "O")&&(lab12.Text == "O")&&(lab13.Text == "O"))||
			    ((lab21.Text == "O")&&(lab22.Text == "O")&&(lab23.Text == "O"))||
			    ((lab31.Text == "O")&&(lab32.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab21.Text == "O")&&(lab31.Text == "O"))||
			    ((lab12.Text == "O")&&(lab22.Text == "O")&&(lab32.Text == "O"))||
			    ((lab13.Text == "O")&&(lab23.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab22.Text == "O")&&(lab33.Text == "O"))||
			    ((lab13.Text == "O")&&(lab22.Text == "O")&&(lab31.Text == "O"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 1 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}
			if (((lab11.Text == "X")&&(lab12.Text == "X")&&(lab13.Text == "X"))||
			    ((lab21.Text == "X")&&(lab22.Text == "X")&&(lab23.Text == "X"))||
			    ((lab31.Text == "X")&&(lab32.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab21.Text == "X")&&(lab31.Text == "X"))||
			    ((lab12.Text == "X")&&(lab22.Text == "X")&&(lab32.Text == "X"))||
			    ((lab13.Text == "X")&&(lab23.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab22.Text == "X")&&(lab33.Text == "X"))||
			    ((lab13.Text == "X")&&(lab22.Text == "X")&&(lab31.Text == "X"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 2 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}
			if ((lab11.Text!=""&&
				lab12.Text!=""&&
							lab13.Text!=""&&
							lab21.Text!=""&&
							lab22.Text!=""&&
							lab23.Text!=""&&
							lab31.Text!=""&&
							lab32.Text!=""&&
							lab33.Text!="")) { 
				DialogResult remiza =
				MessageBox.Show("Remíza! Chcete to zkusit znovu?","",MessageBoxButtons.YesNo);
				if (remiza == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (remiza == DialogResult.No) {
					Application.Exit();
				}
			}			
		}
		
		void Lab13Click(object sender, EventArgs e)
		{
			if (lab13.Text !="") {
				labpodvod.Text="Hráč "+labhrac.Text+" se pokusil o podvod.";
				switch (labhrac.Text) {
					case "1":
						labhrac.Text="2";
						break;
					case "2":
						labhrac.Text="1";
						break;
					default:
						break;
				}
			}
			else
			{
				if (labhrac.Text == "1") {
						lab13.Text="O";
						labhrac.Text="2";
				
				} 
				else  {
						lab13.Text="X";
						labhrac.Text="1";
				
				}
			}			
			if (((lab11.Text == "O")&&(lab12.Text == "O")&&(lab13.Text == "O"))||
			    ((lab21.Text == "O")&&(lab22.Text == "O")&&(lab23.Text == "O"))||
			    ((lab31.Text == "O")&&(lab32.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab21.Text == "O")&&(lab31.Text == "O"))||
			    ((lab12.Text == "O")&&(lab22.Text == "O")&&(lab32.Text == "O"))||
			    ((lab13.Text == "O")&&(lab23.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab22.Text == "O")&&(lab33.Text == "O"))||
			    ((lab13.Text == "O")&&(lab22.Text == "O")&&(lab31.Text == "O"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 1 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}
			if (((lab11.Text == "X")&&(lab12.Text == "X")&&(lab13.Text == "X"))||
			    ((lab21.Text == "X")&&(lab22.Text == "X")&&(lab23.Text == "X"))||
			    ((lab31.Text == "X")&&(lab32.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab21.Text == "X")&&(lab31.Text == "X"))||
			    ((lab12.Text == "X")&&(lab22.Text == "X")&&(lab32.Text == "X"))||
			    ((lab13.Text == "X")&&(lab23.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab22.Text == "X")&&(lab33.Text == "X"))||
			    ((lab13.Text == "X")&&(lab22.Text == "X")&&(lab31.Text == "X"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 2 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}	
			if ((lab11.Text!=""&&
				lab12.Text!=""&&
							lab13.Text!=""&&
							lab21.Text!=""&&
							lab22.Text!=""&&
							lab23.Text!=""&&
							lab31.Text!=""&&
							lab32.Text!=""&&
							lab33.Text!="")) { 
				DialogResult remiza =
				MessageBox.Show("Remíza! Chcete to zkusit znovu?","",MessageBoxButtons.YesNo);
				if (remiza == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (remiza == DialogResult.No) {
					Application.Exit();
				}
			}			
		}
		
		void Lab21Click(object sender, EventArgs e)
		{
			if (lab21.Text !="") {
				labpodvod.Text="Hráč "+labhrac.Text+" se pokusil o podvod.";
				switch (labhrac.Text) {
					case "1":
						labhrac.Text="2";
						break;
					case "2":
						labhrac.Text="1";
						break;
					default:
						break;
				}
			}
			else
			{
				if (labhrac.Text == "1") {
						lab21.Text="O";
						labhrac.Text="2";
				
				} 
				else {
						lab21.Text="X";
						labhrac.Text="1";
				
				}
			}
			if (((lab11.Text == "O")&&(lab12.Text == "O")&&(lab13.Text == "O"))||
			    ((lab21.Text == "O")&&(lab22.Text == "O")&&(lab23.Text == "O"))||
			    ((lab31.Text == "O")&&(lab32.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab21.Text == "O")&&(lab31.Text == "O"))||
			    ((lab12.Text == "O")&&(lab22.Text == "O")&&(lab32.Text == "O"))||
			    ((lab13.Text == "O")&&(lab23.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab22.Text == "O")&&(lab33.Text == "O"))||
			    ((lab13.Text == "O")&&(lab22.Text == "O")&&(lab31.Text == "O"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 1 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}
			if (((lab11.Text == "X")&&(lab12.Text == "X")&&(lab13.Text == "X"))||
			    ((lab21.Text == "X")&&(lab22.Text == "X")&&(lab23.Text == "X"))||
			    ((lab31.Text == "X")&&(lab32.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab21.Text == "X")&&(lab31.Text == "X"))||
			    ((lab12.Text == "X")&&(lab22.Text == "X")&&(lab32.Text == "X"))||
			    ((lab13.Text == "X")&&(lab23.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab22.Text == "X")&&(lab33.Text == "X"))||
			    ((lab13.Text == "X")&&(lab22.Text == "X")&&(lab31.Text == "X"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 2 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}
						if ((lab11.Text!=""&&
				lab12.Text!=""&&
							lab13.Text!=""&&
							lab21.Text!=""&&
							lab22.Text!=""&&
							lab23.Text!=""&&
							lab31.Text!=""&&
							lab32.Text!=""&&
							lab33.Text!="")) { 
				DialogResult remiza =
				MessageBox.Show("Remíza! Chcete to zkusit znovu?","",MessageBoxButtons.YesNo);
				if (remiza == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (remiza == DialogResult.No) {
					Application.Exit();
				}
			}
		}
				
		void Lab22Click(object sender, EventArgs e)
		{
			if (lab22.Text !="") {
				labpodvod.Text="Hráč "+labhrac.Text+" se pokusil o podvod.";
				switch (labhrac.Text) {
					case "1":
						labhrac.Text="2";
						break;
					case "2":
						labhrac.Text="1";
						break;
					default:
						break;
				}
			}
			else
			{
				if (labhrac.Text == "1") {
						lab22.Text="O";
						labhrac.Text="2";
				
				} 
				else  {
						lab22.Text="X";
						labhrac.Text="1";
				
				}
			}
			if (((lab11.Text == "O")&&(lab12.Text == "O")&&(lab13.Text == "O"))||
			    ((lab21.Text == "O")&&(lab22.Text == "O")&&(lab23.Text == "O"))||
			    ((lab31.Text == "O")&&(lab32.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab21.Text == "O")&&(lab31.Text == "O"))||
			    ((lab12.Text == "O")&&(lab22.Text == "O")&&(lab32.Text == "O"))||
			    ((lab13.Text == "O")&&(lab23.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab22.Text == "O")&&(lab33.Text == "O"))||
			    ((lab13.Text == "O")&&(lab22.Text == "O")&&(lab31.Text == "O"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 1 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}
			if (((lab11.Text == "X")&&(lab12.Text == "X")&&(lab13.Text == "X"))||
			    ((lab21.Text == "X")&&(lab22.Text == "X")&&(lab23.Text == "X"))||
			    ((lab31.Text == "X")&&(lab32.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab21.Text == "X")&&(lab31.Text == "X"))||
			    ((lab12.Text == "X")&&(lab22.Text == "X")&&(lab32.Text == "X"))||
			    ((lab13.Text == "X")&&(lab23.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab22.Text == "X")&&(lab33.Text == "X"))||
			    ((lab13.Text == "X")&&(lab22.Text == "X")&&(lab31.Text == "X"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 2 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}	
			if ((lab11.Text!=""&&
				lab12.Text!=""&&
							lab13.Text!=""&&
							lab21.Text!=""&&
							lab22.Text!=""&&
							lab23.Text!=""&&
							lab31.Text!=""&&
							lab32.Text!=""&&
							lab33.Text!="")) { 
				DialogResult remiza =
				MessageBox.Show("Remíza! Chcete to zkusit znovu?","",MessageBoxButtons.YesNo);
				if (remiza == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (remiza == DialogResult.No) {
					Application.Exit();
				}
			}			
		}
		
		void Lab33Click(object sender, EventArgs e)
		{
			if (lab33.Text !="") {
				labpodvod.Text="Hráč "+labhrac.Text+" se pokusil o podvod.";
				switch (labhrac.Text) {
					case "1":
						labhrac.Text="2";
						break;
					case "2":
						labhrac.Text="1";
						break;
					default:
						break;
				}
			}
			else
			{
				if (labhrac.Text == "1") {
						lab33.Text="O";
						labhrac.Text="2";
				
				} 
				else  {
						lab33.Text="X";
						labhrac.Text="1";
				
				}
			}
			if (((lab11.Text == "O")&&(lab12.Text == "O")&&(lab13.Text == "O"))||
			    ((lab21.Text == "O")&&(lab22.Text == "O")&&(lab23.Text == "O"))||
			    ((lab31.Text == "O")&&(lab32.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab21.Text == "O")&&(lab31.Text == "O"))||
			    ((lab12.Text == "O")&&(lab22.Text == "O")&&(lab32.Text == "O"))||
			    ((lab13.Text == "O")&&(lab23.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab22.Text == "O")&&(lab33.Text == "O"))||
			    ((lab13.Text == "O")&&(lab22.Text == "O")&&(lab31.Text == "O"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 1 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}
			if (((lab11.Text == "X")&&(lab12.Text == "X")&&(lab13.Text == "X"))||
			    ((lab21.Text == "X")&&(lab22.Text == "X")&&(lab23.Text == "X"))||
			    ((lab31.Text == "X")&&(lab32.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab21.Text == "X")&&(lab31.Text == "X"))||
			    ((lab12.Text == "X")&&(lab22.Text == "X")&&(lab32.Text == "X"))||
			    ((lab13.Text == "X")&&(lab23.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab22.Text == "X")&&(lab33.Text == "X"))||
			    ((lab13.Text == "X")&&(lab22.Text == "X")&&(lab31.Text == "X"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 2 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}
						if ((lab11.Text!=""&&
				lab12.Text!=""&&
							lab13.Text!=""&&
							lab21.Text!=""&&
							lab22.Text!=""&&
							lab23.Text!=""&&
							lab31.Text!=""&&
							lab32.Text!=""&&
							lab33.Text!="")) { 
				DialogResult remiza =
				MessageBox.Show("Remíza! Chcete to zkusit znovu?","",MessageBoxButtons.YesNo);
				if (remiza == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (remiza == DialogResult.No) {
					Application.Exit();
				}
			}
		}
		
		void Lab23Click(object sender, EventArgs e)
		{
			if (lab23.Text !="") {
				labpodvod.Text="Hráč "+labhrac.Text+" se pokusil o podvod.";
				switch (labhrac.Text) {
					case "1":
						labhrac.Text="2";
						break;
					case "2":
						labhrac.Text="1";
						break;
					default:
						break;
				}
			}
			else
			{
				if (labhrac.Text == "1") {
						lab23.Text="O";
						labhrac.Text="2";
				
				} 
				else  {
						lab23.Text="X";
						labhrac.Text="1";
				
				}
			}
			if (((lab11.Text == "O")&&(lab12.Text == "O")&&(lab13.Text == "O"))||
			    ((lab21.Text == "O")&&(lab22.Text == "O")&&(lab23.Text == "O"))||
			    ((lab31.Text == "O")&&(lab32.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab21.Text == "O")&&(lab31.Text == "O"))||
			    ((lab12.Text == "O")&&(lab22.Text == "O")&&(lab32.Text == "O"))||
			    ((lab13.Text == "O")&&(lab23.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab22.Text == "O")&&(lab33.Text == "O"))||
			    ((lab13.Text == "O")&&(lab22.Text == "O")&&(lab31.Text == "O"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 1 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}
			if (((lab11.Text == "X")&&(lab12.Text == "X")&&(lab13.Text == "X"))||
			    ((lab21.Text == "X")&&(lab22.Text == "X")&&(lab23.Text == "X"))||
			    ((lab31.Text == "X")&&(lab32.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab21.Text == "X")&&(lab31.Text == "X"))||
			    ((lab12.Text == "X")&&(lab22.Text == "X")&&(lab32.Text == "X"))||
			    ((lab13.Text == "X")&&(lab23.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab22.Text == "X")&&(lab33.Text == "X"))||
			    ((lab13.Text == "X")&&(lab22.Text == "X")&&(lab31.Text == "X"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 2 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}
						if ((lab11.Text!=""&&
				lab12.Text!=""&&
							lab13.Text!=""&&
							lab21.Text!=""&&
							lab22.Text!=""&&
							lab23.Text!=""&&
							lab31.Text!=""&&
							lab32.Text!=""&&
							lab33.Text!="")) { 
				DialogResult remiza =
				MessageBox.Show("Remíza! Chcete to zkusit znovu?","",MessageBoxButtons.YesNo);
				if (remiza == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (remiza == DialogResult.No) {
					Application.Exit();
				}
			}
		}
		
		void Lab31Click(object sender, EventArgs e)
		{
			if (lab31.Text !="") {
				labpodvod.Text="Hráč "+labhrac.Text+" se pokusil o podvod.";
				switch (labhrac.Text) {
					case "1":
						labhrac.Text="2";
						break;
					case "2":
						labhrac.Text="1";
						break;
					default:
						break;
				}
			}
			else
			{
				if (labhrac.Text == "1") {
						lab31.Text="O";
						labhrac.Text="2";
				
				} 
				else  {
						lab31.Text="X";
						labhrac.Text="1";
				
				}
			}
			if (((lab11.Text == "O")&&(lab12.Text == "O")&&(lab13.Text == "O"))||
			    ((lab21.Text == "O")&&(lab22.Text == "O")&&(lab23.Text == "O"))||
			    ((lab31.Text == "O")&&(lab32.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab21.Text == "O")&&(lab31.Text == "O"))||
			    ((lab12.Text == "O")&&(lab22.Text == "O")&&(lab32.Text == "O"))||
			    ((lab13.Text == "O")&&(lab23.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab22.Text == "O")&&(lab33.Text == "O"))||
			    ((lab13.Text == "O")&&(lab22.Text == "O")&&(lab31.Text == "O"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 1 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}
			if (((lab11.Text == "X")&&(lab12.Text == "X")&&(lab13.Text == "X"))||
			    ((lab21.Text == "X")&&(lab22.Text == "X")&&(lab23.Text == "X"))||
			    ((lab31.Text == "X")&&(lab32.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab21.Text == "X")&&(lab31.Text == "X"))||
			    ((lab12.Text == "X")&&(lab22.Text == "X")&&(lab32.Text == "X"))||
			    ((lab13.Text == "X")&&(lab23.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab22.Text == "X")&&(lab33.Text == "X"))||
			    ((lab13.Text == "X")&&(lab22.Text == "X")&&(lab31.Text == "X"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 2 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}
						if ((lab11.Text!=""&&
				lab12.Text!=""&&
							lab13.Text!=""&&
							lab21.Text!=""&&
							lab22.Text!=""&&
							lab23.Text!=""&&
							lab31.Text!=""&&
							lab32.Text!=""&&
							lab33.Text!="")) { 
				DialogResult remiza =
				MessageBox.Show("Remíza! Chcete to zkusit znovu?","",MessageBoxButtons.YesNo);
				if (remiza == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (remiza == DialogResult.No) {
					Application.Exit();
				}
			}
		}
		
		void Lab32Click(object sender, EventArgs e)
		{
			if (lab32.Text !="") {
				labpodvod.Text="Hráč "+labhrac.Text+" se pokusil o podvod.";
				switch (labhrac.Text) {
					case "1":
						labhrac.Text="2";
						break;
					case "2":
						labhrac.Text="1";
						break;
					default:
						break;
				}
			}
			else
			{
				if (labhrac.Text == "1") {
						lab32.Text="O";
						labhrac.Text="2";
				
				} 
				else {
						lab32.Text="X";
						labhrac.Text="1";
				
				}
			}
			if (((lab11.Text == "O")&&(lab12.Text == "O")&&(lab13.Text == "O"))||
			    ((lab21.Text == "O")&&(lab22.Text == "O")&&(lab23.Text == "O"))||
			    ((lab31.Text == "O")&&(lab32.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab21.Text == "O")&&(lab31.Text == "O"))||
			    ((lab12.Text == "O")&&(lab22.Text == "O")&&(lab32.Text == "O"))||
			    ((lab13.Text == "O")&&(lab23.Text == "O")&&(lab33.Text == "O"))||
			    ((lab11.Text == "O")&&(lab22.Text == "O")&&(lab33.Text == "O"))||
			    ((lab13.Text == "O")&&(lab22.Text == "O")&&(lab31.Text == "O"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 1 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}
			if (((lab11.Text == "X")&&(lab12.Text == "X")&&(lab13.Text == "X"))||
			    ((lab21.Text == "X")&&(lab22.Text == "X")&&(lab23.Text == "X"))||
			    ((lab31.Text == "X")&&(lab32.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab21.Text == "X")&&(lab31.Text == "X"))||
			    ((lab12.Text == "X")&&(lab22.Text == "X")&&(lab32.Text == "X"))||
			    ((lab13.Text == "X")&&(lab23.Text == "X")&&(lab33.Text == "X"))||
			    ((lab11.Text == "X")&&(lab22.Text == "X")&&(lab33.Text == "X"))||
			    ((lab13.Text == "X")&&(lab22.Text == "X")&&(lab31.Text == "X"))) {
				DialogResult vyhra =	
				MessageBox.Show("Hráč 2 vyhrál. Chcete hrát znovu?","",MessageBoxButtons.YesNo);
				if (vyhra == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (vyhra == DialogResult.No) {
					Application.Exit();
				}
					}	
			if ((lab11.Text!=""&&
				lab12.Text!=""&&
							lab13.Text!=""&&
							lab21.Text!=""&&
							lab22.Text!=""&&
							lab23.Text!=""&&
							lab31.Text!=""&&
							lab32.Text!=""&&
							lab33.Text!="")) { 
				DialogResult remiza =
				MessageBox.Show("Remíza! Chcete to zkusit znovu?","",MessageBoxButtons.YesNo);
				if (remiza == DialogResult.Yes) {
							lab11.Text="";
							lab12.Text="";
							lab13.Text="";
							lab21.Text="";
							lab22.Text="";
							lab23.Text="";
							lab31.Text="";
							lab32.Text="";
							lab33.Text="";
							labhrac.Text="1";
				}
				if (remiza == DialogResult.No) {
					Application.Exit();
				}
			}			
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			MessageBox.Show("Shorty (Martin Václavík) - Autor\nWindy (Tomáš Cizler) - Rádce\nAmina (Tereza Zítková) - Tester");
		}
	}
}
