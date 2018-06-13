namespace WindowsFormsApp1
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
			this.CounterLbl = new System.Windows.Forms.Label();
			this.CounterTxt = new System.Windows.Forms.TextBox();
			this.BtnIncrement = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// CounterLbl
			// 
			this.CounterLbl.AutoSize = true;
			this.CounterLbl.Location = new System.Drawing.Point(13, 45);
			this.CounterLbl.Name = "CounterLbl";
			this.CounterLbl.Size = new System.Drawing.Size(44, 13);
			this.CounterLbl.TabIndex = 0;
			this.CounterLbl.Text = "Counter";
			// 
			// CounterTxt
			// 
			this.CounterTxt.Location = new System.Drawing.Point(63, 42);
			this.CounterTxt.Name = "CounterTxt";
			this.CounterTxt.ReadOnly = true;
			this.CounterTxt.Size = new System.Drawing.Size(69, 20);
			this.CounterTxt.TabIndex = 1;
			// 
			// BtnIncrement
			// 
			this.BtnIncrement.Location = new System.Drawing.Point(138, 40);
			this.BtnIncrement.Name = "BtnIncrement";
			this.BtnIncrement.Size = new System.Drawing.Size(75, 23);
			this.BtnIncrement.TabIndex = 2;
			this.BtnIncrement.Text = "Increment";
			this.BtnIncrement.UseVisualStyleBackColor = true;
			this.BtnIncrement.Click += new System.EventHandler(this.BtnIncrement_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(249, 115);
			this.Controls.Add(this.BtnIncrement);
			this.Controls.Add(this.CounterTxt);
			this.Controls.Add(this.CounterLbl);
			this.Name = "Form1";
			this.Text = "Counter App";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label CounterLbl;
		private System.Windows.Forms.TextBox CounterTxt;
		private System.Windows.Forms.Button BtnIncrement;
	}
}

