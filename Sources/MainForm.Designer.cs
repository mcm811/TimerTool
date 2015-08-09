/*
 * Created by SharpDevelop.
 * User: Tebjan Halm
 * Date: 21.01.2014
 * Time: 16:55
 * 
 * 
 */
namespace TimerTool
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
                trayIcon.Dispose();
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.MaxLabel = new System.Windows.Forms.Label();
            this.MinLabel = new System.Windows.Forms.Label();
            this.CurrentLabel = new System.Windows.Forms.Label();
            this.ModifyGroupBox = new System.Windows.Forms.GroupBox();
            this.UnsetTimer = new System.Windows.Forms.Button();
            this.SetTimerButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.InfoGroupBox.SuspendLayout();
            this.ModifyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1Tick);
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.Controls.Add(this.MaxLabel);
            this.InfoGroupBox.Controls.Add(this.MinLabel);
            this.InfoGroupBox.Controls.Add(this.CurrentLabel);
            this.InfoGroupBox.Location = new System.Drawing.Point(14, 11);
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.Size = new System.Drawing.Size(205, 78);
            this.InfoGroupBox.TabIndex = 1;
            this.InfoGroupBox.TabStop = false;
            this.InfoGroupBox.Text = "Timer Info";
            // 
            // MaxLabel
            // 
            this.MaxLabel.Location = new System.Drawing.Point(7, 57);
            this.MaxLabel.Name = "MaxLabel";
            this.MaxLabel.Size = new System.Drawing.Size(117, 18);
            this.MaxLabel.TabIndex = 3;
            this.MaxLabel.Text = "Max: 0.5 ms";
            // 
            // MinLabel
            // 
            this.MinLabel.Location = new System.Drawing.Point(7, 42);
            this.MinLabel.Name = "MinLabel";
            this.MinLabel.Size = new System.Drawing.Size(117, 14);
            this.MinLabel.TabIndex = 2;
            this.MinLabel.Text = "Min: 15.6 ms";
            // 
            // CurrentLabel
            // 
            this.CurrentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CurrentLabel.Location = new System.Drawing.Point(7, 21);
            this.CurrentLabel.Name = "CurrentLabel";
            this.CurrentLabel.Size = new System.Drawing.Size(156, 17);
            this.CurrentLabel.TabIndex = 1;
            this.CurrentLabel.Text = "Current: 1 ms";
            // 
            // ModifyGroupBox
            // 
            this.ModifyGroupBox.Controls.Add(this.UnsetTimer);
            this.ModifyGroupBox.Controls.Add(this.SetTimerButton);
            this.ModifyGroupBox.Controls.Add(this.label2);
            this.ModifyGroupBox.Controls.Add(this.numericUpDown2);
            this.ModifyGroupBox.Location = new System.Drawing.Point(14, 95);
            this.ModifyGroupBox.Name = "ModifyGroupBox";
            this.ModifyGroupBox.Size = new System.Drawing.Size(205, 82);
            this.ModifyGroupBox.TabIndex = 2;
            this.ModifyGroupBox.TabStop = false;
            this.ModifyGroupBox.Text = "Modify Timer";
            // 
            // UnsetTimer
            // 
            this.UnsetTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnsetTimer.Location = new System.Drawing.Point(107, 47);
            this.UnsetTimer.Name = "UnsetTimer";
            this.UnsetTimer.Size = new System.Drawing.Size(90, 28);
            this.UnsetTimer.TabIndex = 7;
            this.UnsetTimer.Text = "Unset Timer";
            this.UnsetTimer.UseVisualStyleBackColor = true;
            this.UnsetTimer.Click += new System.EventHandler(this.UnsetTimerClick);
            // 
            // SetTimerButton
            // 
            this.SetTimerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SetTimerButton.Location = new System.Drawing.Point(7, 47);
            this.SetTimerButton.Name = "SetTimerButton";
            this.SetTimerButton.Size = new System.Drawing.Size(93, 28);
            this.SetTimerButton.TabIndex = 6;
            this.SetTimerButton.Text = "Set Timer";
            this.SetTimerButton.UseVisualStyleBackColor = true;
            this.SetTimerButton.Click += new System.EventHandler(this.SetTimerButtonClick);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(80, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "ms";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.DecimalPlaces = 1;
            this.numericUpDown2.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown2.Location = new System.Drawing.Point(7, 23);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(66, 21);
            this.numericUpDown2.TabIndex = 4;
            this.numericUpDown2.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "TimerTool";
            this.trayIcon.Visible = true;
            this.trayIcon.DoubleClick += new System.EventHandler(this.OnShow);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 189);
            this.Controls.Add(this.ModifyGroupBox);
            this.Controls.Add(this.InfoGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TimerTool";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainFormLoad);
            this.InfoGroupBox.ResumeLayout(false);
            this.ModifyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

		}
		private System.Windows.Forms.Button UnsetTimer;
		private System.Windows.Forms.NumericUpDown numericUpDown2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button SetTimerButton;
		private System.Windows.Forms.Label MinLabel;
		private System.Windows.Forms.Label MaxLabel;
		private System.Windows.Forms.GroupBox ModifyGroupBox;
		private System.Windows.Forms.GroupBox InfoGroupBox;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Label CurrentLabel;
        private System.Windows.Forms.NotifyIcon trayIcon;
    }
}
