/*
 * Created by SharpDevelop.
 * User: mr_lio_64
 * Date: 12/7/2016
 * Time: 12:02 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace pixelSitter
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		
		public MainForm()
		{
			
			Bitmap bitt =new Bitmap((double)777,(double)777,System.Drawing.Imaging.PixelFormat.Format16bppArgb1555);
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
	
		}
	}
}
