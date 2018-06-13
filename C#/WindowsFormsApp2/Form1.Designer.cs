namespace WindowsFormsApp2
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
			this.LblName = new System.Windows.Forms.Label();
			this.TbxName = new System.Windows.Forms.TextBox();
			this.BtnSayHello = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// LblName
			// 
			this.LblName.AutoSize = true;
			this.LblName.Location = new System.Drawing.Point(22, 48);
			this.LblName.Name = "LblName";
			this.LblName.Size = new System.Drawing.Size(83, 13);
			this.LblName.TabIndex = 0;
			this.LblName.Text = "Input your name";
			// 
			// TbxName
			// 
			this.TbxName.Location = new System.Drawing.Point(111, 45);
			this.TbxName.Name = "TbxName";
			this.TbxName.Size = new System.Drawing.Size(100, 20);
			this.TbxName.TabIndex = 1;
			// 
			// BtnSayHello
			// 
			this.BtnSayHello.Location = new System.Drawing.Point(217, 43);
			this.BtnSayHello.Name = "BtnSayHello";
			this.BtnSayHello.Size = new System.Drawing.Size(75, 23);
			this.BtnSayHello.TabIndex = 2;
			this.BtnSayHello.Text = "Say Hello";
			this.BtnSayHello.UseVisualStyleBackColor = true;
			this.BtnSayHello.Click += new System.EventHandler(this.BtnSayHello_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(318, 110);
			this.Controls.Add(this.BtnSayHello);
			this.Controls.Add(this.TbxName);
			this.Controls.Add(this.LblName);
			this.Name = "Form1";
			this.Text = "Hello App";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label LblName;
		private System.Windows.Forms.TextBox TbxName;
		private System.Windows.Forms.Button BtnSayHello;
	}
}

