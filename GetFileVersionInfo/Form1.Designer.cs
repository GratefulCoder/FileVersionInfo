namespace GetFileVersionInfo
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.ButtonRun = new System.Windows.Forms.Button();
			this.TextBox_TargetFileExtensions = new System.Windows.Forms.TextBox();
			this.label_TextBox_TargetFileExtensions = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LableResults = new System.Windows.Forms.Label();
			this.LabelResults_Link = new System.Windows.Forms.LinkLabel();
			this.CheckedListBox_DesiredFileAttributes = new System.Windows.Forms.CheckedListBox();
			this.label_checkedListBox_DesiredFileAttributes = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// ButtonRun
			// 
			this.ButtonRun.Location = new System.Drawing.Point(224, 374);
			this.ButtonRun.Name = "ButtonRun";
			this.ButtonRun.Size = new System.Drawing.Size(176, 23);
			this.ButtonRun.TabIndex = 1;
			this.ButtonRun.Text = "Run";
			this.ButtonRun.UseVisualStyleBackColor = true;
			this.ButtonRun.Click += new System.EventHandler(this.ButtonRun_Click);
			// 
			// TextBox_TargetFileExtensions
			// 
			this.TextBox_TargetFileExtensions.Location = new System.Drawing.Point(33, 72);
			this.TextBox_TargetFileExtensions.Name = "TextBox_TargetFileExtensions";
			this.TextBox_TargetFileExtensions.Size = new System.Drawing.Size(432, 20);
			this.TextBox_TargetFileExtensions.TabIndex = 0;
			this.TextBox_TargetFileExtensions.Text = ".dll, .exe, .ver";
			// 
			// label_TextBox_TargetFileExtensions
			// 
			this.label_TextBox_TargetFileExtensions.AutoSize = true;
			this.label_TextBox_TargetFileExtensions.Location = new System.Drawing.Point(30, 95);
			this.label_TextBox_TargetFileExtensions.Name = "label_TextBox_TargetFileExtensions";
			this.label_TextBox_TargetFileExtensions.Size = new System.Drawing.Size(212, 13);
			this.label_TextBox_TargetFileExtensions.TabIndex = 3;
			this.label_TextBox_TargetFileExtensions.Text = "Comma delimited list of target file extensions";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(30, 13);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(447, 45);
			this.label2.TabIndex = 5;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// LableResults
			// 
			this.LableResults.AutoSize = true;
			this.LableResults.Location = new System.Drawing.Point(221, 417);
			this.LableResults.Name = "LableResults";
			this.LableResults.Size = new System.Drawing.Size(67, 13);
			this.LableResults.TabIndex = 6;
			this.LableResults.Text = "Results File: ";
			// 
			// LabelResults_Link
			// 
			this.LabelResults_Link.AutoSize = true;
			this.LabelResults_Link.Location = new System.Drawing.Point(285, 417);
			this.LabelResults_Link.Name = "LabelResults_Link";
			this.LabelResults_Link.Size = new System.Drawing.Size(94, 13);
			this.LabelResults_Link.TabIndex = 2;
			this.LabelResults_Link.TabStop = true;
			this.LabelResults_Link.Text = "LabelResults_Link";
			this.LabelResults_Link.Visible = false;
			this.LabelResults_Link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LabelResults_Link_LinkClicked);
			// 
			// CheckedListBox_DesiredFileAttributes
			// 
			this.CheckedListBox_DesiredFileAttributes.CheckOnClick = true;
			this.CheckedListBox_DesiredFileAttributes.FormattingEnabled = true;
			this.CheckedListBox_DesiredFileAttributes.Items.AddRange(new object[] {
            "Filename",
            "Version Number (Major.Minor.Build.Private)",
            "LastModified",
            "Full Path"});
			this.CheckedListBox_DesiredFileAttributes.Location = new System.Drawing.Point(33, 135);
			this.CheckedListBox_DesiredFileAttributes.Name = "CheckedListBox_DesiredFileAttributes";
			this.CheckedListBox_DesiredFileAttributes.Size = new System.Drawing.Size(389, 139);
			this.CheckedListBox_DesiredFileAttributes.TabIndex = 7;
			// 
			// label_checkedListBox_DesiredFileAttributes
			// 
			this.label_checkedListBox_DesiredFileAttributes.AutoSize = true;
			this.label_checkedListBox_DesiredFileAttributes.Location = new System.Drawing.Point(33, 281);
			this.label_checkedListBox_DesiredFileAttributes.Name = "label_checkedListBox_DesiredFileAttributes";
			this.label_checkedListBox_DesiredFileAttributes.Size = new System.Drawing.Size(290, 13);
			this.label_checkedListBox_DesiredFileAttributes.TabIndex = 8;
			this.label_checkedListBox_DesiredFileAttributes.Text = "Check the boxes of attributes you want to collect info about.";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(653, 439);
			this.Controls.Add(this.label_checkedListBox_DesiredFileAttributes);
			this.Controls.Add(this.CheckedListBox_DesiredFileAttributes);
			this.Controls.Add(this.LabelResults_Link);
			this.Controls.Add(this.LableResults);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label_TextBox_TargetFileExtensions);
			this.Controls.Add(this.TextBox_TargetFileExtensions);
			this.Controls.Add(this.ButtonRun);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button ButtonRun;
		private System.Windows.Forms.TextBox TextBox_TargetFileExtensions;
		private System.Windows.Forms.Label label_TextBox_TargetFileExtensions;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label LableResults;
		private System.Windows.Forms.LinkLabel LabelResults_Link;
		private System.Windows.Forms.CheckedListBox CheckedListBox_DesiredFileAttributes;
		private System.Windows.Forms.Label label_checkedListBox_DesiredFileAttributes;
	}
}

