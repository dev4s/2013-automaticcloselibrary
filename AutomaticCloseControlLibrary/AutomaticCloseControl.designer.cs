namespace AutomaticCloseControlLibrary
{
	partial class AutomaticCloseControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.labelTime = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.timerClose = new System.Windows.Forms.Timer(this.components);
			this.timerUpdateLabel = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.Location = new System.Drawing.Point(162, 0);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(49, 13);
			this.labelTime.TabIndex = 0;
			this.labelTime.Text = "00:00:00";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(1, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(155, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Program zostanie zamknięty za:";
			// 
			// timerClose
			// 
			this.timerClose.Tick += new System.EventHandler(this.TimerCloseTick);
			// 
			// timerUpdateLabel
			// 
			this.timerUpdateLabel.Interval = 1000;
			this.timerUpdateLabel.Tick += new System.EventHandler(this.TimerUpdateLabelTick);
			// 
			// AutomaticCloseControl
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.label2);
			this.Controls.Add(this.labelTime);
			this.Name = "AutomaticCloseControl";
			this.Size = new System.Drawing.Size(212, 14);
			this.Load += new System.EventHandler(this.AutomaticCloseControlLoad);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timerClose;
		private System.Windows.Forms.Timer timerUpdateLabel;
	}
}
