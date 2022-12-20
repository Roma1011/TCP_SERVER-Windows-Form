
namespace TCP_SERVER
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
			this.TbOutPutbox = new System.Windows.Forms.TextBox();
			this.TbIPAddres = new System.Windows.Forms.TextBox();
			this.TbPort = new System.Windows.Forms.TextBox();
			this.BtStartListening = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// TbOutPutbox
			// 
			this.TbOutPutbox.Location = new System.Drawing.Point(12, 12);
			this.TbOutPutbox.Multiline = true;
			this.TbOutPutbox.Name = "TbOutPutbox";
			this.TbOutPutbox.Size = new System.Drawing.Size(776, 391);
			this.TbOutPutbox.TabIndex = 0;
			// 
			// TbIPAddres
			// 
			this.TbIPAddres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TbIPAddres.ForeColor = System.Drawing.Color.Red;
			this.TbIPAddres.Location = new System.Drawing.Point(244, 409);
			this.TbIPAddres.Name = "TbIPAddres";
			this.TbIPAddres.Size = new System.Drawing.Size(165, 21);
			this.TbIPAddres.TabIndex = 1;
			this.TbIPAddres.Text = "192.168.1.75";
			this.TbIPAddres.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// TbPort
			// 
			this.TbPort.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TbPort.ForeColor = System.Drawing.Color.Red;
			this.TbPort.Location = new System.Drawing.Point(415, 409);
			this.TbPort.Name = "TbPort";
			this.TbPort.Size = new System.Drawing.Size(100, 21);
			this.TbPort.TabIndex = 2;
			this.TbPort.Text = "5555";
			this.TbPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TbPort.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
			// 
			// BtStartListening
			// 
			this.BtStartListening.Location = new System.Drawing.Point(587, 407);
			this.BtStartListening.Name = "BtStartListening";
			this.BtStartListening.Size = new System.Drawing.Size(117, 23);
			this.BtStartListening.TabIndex = 3;
			this.BtStartListening.Text = "Start";
			this.BtStartListening.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 438);
			this.Controls.Add(this.BtStartListening);
			this.Controls.Add(this.TbPort);
			this.Controls.Add(this.TbIPAddres);
			this.Controls.Add(this.TbOutPutbox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox TbOutPutbox;
		private System.Windows.Forms.TextBox TbIPAddres;
		private System.Windows.Forms.TextBox TbPort;
		private System.Windows.Forms.Button BtStartListening;
	}
}

