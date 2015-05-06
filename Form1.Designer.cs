namespace Section3CC
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose( bool disposing )
		{
			if( disposing && ( components != null ) )
			{
				components.Dispose();
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.txtActorName = new System.Windows.Forms.TextBox();
			this.txtPosition = new System.Windows.Forms.TextBox();
			this.btnInsert = new System.Windows.Forms.Button();
			this.cboActor = new System.Windows.Forms.ComboBox();
			this.btnDelete = new System.Windows.Forms.Button();
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuRead = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuWrite = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.mnuMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(66, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Actor Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 68);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(47, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Position:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(13, 104);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(37, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Actors";
			// 
			// txtActorName
			// 
			this.txtActorName.Location = new System.Drawing.Point(95, 29);
			this.txtActorName.Name = "txtActorName";
			this.txtActorName.Size = new System.Drawing.Size(314, 20);
			this.txtActorName.TabIndex = 3;
			// 
			// txtPosition
			// 
			this.txtPosition.Location = new System.Drawing.Point(95, 60);
			this.txtPosition.Name = "txtPosition";
			this.txtPosition.Size = new System.Drawing.Size(40, 20);
			this.txtPosition.TabIndex = 4;
			// 
			// btnInsert
			// 
			this.btnInsert.Location = new System.Drawing.Point(466, 29);
			this.btnInsert.Name = "btnInsert";
			this.btnInsert.Size = new System.Drawing.Size(128, 23);
			this.btnInsert.TabIndex = 5;
			this.btnInsert.Text = "&Insert Into ArrayList";
			this.btnInsert.UseVisualStyleBackColor = true;
			this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
			// 
			// cboActor
			// 
			this.cboActor.FormattingEnabled = true;
			this.cboActor.Location = new System.Drawing.Point(95, 95);
			this.cboActor.Name = "cboActor";
			this.cboActor.Size = new System.Drawing.Size(314, 21);
			this.cboActor.TabIndex = 6;
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(466, 95);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(128, 23);
			this.btnDelete.TabIndex = 7;
			this.btnDelete.Text = "&Delete From ArrayList";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// mnuMain
			// 
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.mnuMain.Location = new System.Drawing.Point(0, 0);
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Size = new System.Drawing.Size(634, 24);
			this.mnuMain.TabIndex = 8;
			this.mnuMain.Text = "&File";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRead,
            this.mnuWrite,
            this.mnuExit});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// mnuRead
			// 
			this.mnuRead.Name = "mnuRead";
			this.mnuRead.Size = new System.Drawing.Size(154, 22);
			this.mnuRead.Text = "&Read Array List";
			this.mnuRead.Click += new System.EventHandler(this.mnuRead_Click);
			// 
			// mnuWrite
			// 
			this.mnuWrite.Name = "mnuWrite";
			this.mnuWrite.Size = new System.Drawing.Size(154, 22);
			this.mnuWrite.Text = "&Write Array List";
			this.mnuWrite.Click += new System.EventHandler(this.mnuWrite_Click);
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(154, 22);
			this.mnuExit.Text = "&Exit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(634, 396);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.cboActor);
			this.Controls.Add(this.btnInsert);
			this.Controls.Add(this.txtPosition);
			this.Controls.Add(this.txtActorName);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.mnuMain);
			this.MainMenuStrip = this.mnuMain;
			this.Name = "frmMain";
			this.Text = "Array Lists";
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtActorName;
		private System.Windows.Forms.TextBox txtPosition;
		private System.Windows.Forms.Button btnInsert;
		private System.Windows.Forms.ComboBox cboActor;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.MenuStrip mnuMain;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem mnuRead;
		private System.Windows.Forms.ToolStripMenuItem mnuWrite;
		private System.Windows.Forms.ToolStripMenuItem mnuExit;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

