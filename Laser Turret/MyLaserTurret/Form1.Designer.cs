namespace MyLaserTurret
{
	partial class main
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.port = new System.IO.Ports.SerialPort(this.components);
            this.labelConnectionStatus = new System.Windows.Forms.Label();
            this.groupBoxTurretSpeeds = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonMouseControlOn = new System.Windows.Forms.Button();
            this.hScrollBarSpeed = new System.Windows.Forms.HScrollBar();
            this.timer50ms = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxTurretSpeeds.SuspendLayout();
            this.SuspendLayout();
            // 
            // port
            // 
            this.port.PortName = "COM3";
            // 
            // labelConnectionStatus
            // 
            this.labelConnectionStatus.AutoSize = true;
            this.labelConnectionStatus.Location = new System.Drawing.Point(12, 9);
            this.labelConnectionStatus.Name = "labelConnectionStatus";
            this.labelConnectionStatus.Size = new System.Drawing.Size(96, 13);
            this.labelConnectionStatus.TabIndex = 0;
            this.labelConnectionStatus.Text = "[connectionStatus]";
            // 
            // groupBoxTurretSpeeds
            // 
            this.groupBoxTurretSpeeds.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxTurretSpeeds.Controls.Add(this.label7);
            this.groupBoxTurretSpeeds.Controls.Add(this.buttonMouseControlOn);
            this.groupBoxTurretSpeeds.Controls.Add(this.hScrollBarSpeed);
            this.groupBoxTurretSpeeds.Location = new System.Drawing.Point(1032, 577);
            this.groupBoxTurretSpeeds.Name = "groupBoxTurretSpeeds";
            this.groupBoxTurretSpeeds.Size = new System.Drawing.Size(265, 104);
            this.groupBoxTurretSpeeds.TabIndex = 12;
            this.groupBoxTurretSpeeds.TabStop = false;
            this.groupBoxTurretSpeeds.Text = "TurretSpeed";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(114, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Speed";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonMouseControlOn
            // 
            this.buttonMouseControlOn.Location = new System.Drawing.Point(61, 67);
            this.buttonMouseControlOn.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMouseControlOn.Name = "buttonMouseControlOn";
            this.buttonMouseControlOn.Size = new System.Drawing.Size(146, 28);
            this.buttonMouseControlOn.TabIndex = 12;
            this.buttonMouseControlOn.Text = "Mouse Control On";
            this.buttonMouseControlOn.UseVisualStyleBackColor = true;
            // 
            // hScrollBarSpeed
            // 
            this.hScrollBarSpeed.Location = new System.Drawing.Point(11, 35);
            this.hScrollBarSpeed.Name = "hScrollBarSpeed";
            this.hScrollBarSpeed.Size = new System.Drawing.Size(243, 22);
            this.hScrollBarSpeed.TabIndex = 7;
            // 
            // timer50ms
            // 
            this.timer50ms.Enabled = true;
            this.timer50ms.Interval = 50;
            this.timer50ms.Tick += new System.EventHandler(this.timer50ms_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 693);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBoxTurretSpeeds);
            this.Controls.Add(this.labelConnectionStatus);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Laser Turret - Mouse Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.main_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.main_KeyUp);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.groupBoxTurretSpeeds.ResumeLayout(false);
            this.groupBoxTurretSpeeds.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.IO.Ports.SerialPort port;
        private System.Windows.Forms.Label labelConnectionStatus;
        private System.Windows.Forms.GroupBox groupBoxTurretSpeeds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonMouseControlOn;
        private System.Windows.Forms.HScrollBar hScrollBarSpeed;
        private System.Windows.Forms.Timer timer50ms;
        private System.Windows.Forms.Label label1;
    }
}

