using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GetFileVersionInfo
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void ButtonRun_Click(object sender, EventArgs e)
		{
			try
			{
				Cursor.Current = Cursors.WaitCursor;
				//Clear Link label and reset text back to default
				LabelResults_Link.Links.Clear();
				LabelResults_Link.ResetText();

				string fileinfo = Utility.GetFileVersionInformation(
					Utility.GetTargetPathsFromFile(Constants.FILE_CONTAINING_TARGET_PATHS),
					Utility.GetTargetFileExtensions(',', TextBox_TargetFileExtensions.Text),
					CheckedListBox_DesiredFileAttributes.CheckedItems);

				//Capture file information and output data to file.
				File.WriteAllText(Constants.FILENAME_FOR_OUTPUT, fileinfo);

				Cursor.Current = Cursors.Default;
				//Display link to file to user.
				LabelResults_Link.Text = Constants.FILENAME_FOR_OUTPUT;
				LabelResults_Link.Visible = true;
				LabelResults_Link.Links.Add(0, LabelResults_Link.Text.Length, Constants.FILENAME_FOR_OUTPUT);
			}
			catch (Exception)
			{
				throw;
			}
		}

		private void LabelResults_Link_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(@".\" + Constants.FILENAME_FOR_OUTPUT);
		}
	}
}
