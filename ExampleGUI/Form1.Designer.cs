﻿namespace Comms
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnCon = new System.Windows.Forms.Button();
			this.txtIP = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.lblRedStatus = new System.Windows.Forms.Label();
			this.lblGreenStatus = new System.Windows.Forms.Label();
			this.btnToggleRed = new System.Windows.Forms.Button();
			this.btnToggleGreen = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lblPosRight = new System.Windows.Forms.Label();
			this.lblPosLeft = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.reading_accelX = new System.Windows.Forms.TextBox();
			this.reading_accelY = new System.Windows.Forms.TextBox();
			this.reading_accelZ = new System.Windows.Forms.TextBox();
			this.reading_tilt = new System.Windows.Forms.TextBox();
			this.label_accelerometer = new System.Windows.Forms.Label();
			this.status_accelerometer = new System.Windows.Forms.Label();
			this.status_connection = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.status_conn = new System.Windows.Forms.Label();
			this.status_position = new System.Windows.Forms.Label();
			this.status_leds = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.reading_pitch = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnCon);
			this.groupBox1.Controls.Add(this.txtIP);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(24, 23);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
			this.groupBox1.Size = new System.Drawing.Size(342, 244);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Communications";
			// 
			// btnCon
			// 
			this.btnCon.Location = new System.Drawing.Point(96, 154);
			this.btnCon.Margin = new System.Windows.Forms.Padding(6);
			this.btnCon.Name = "btnCon";
			this.btnCon.Size = new System.Drawing.Size(150, 44);
			this.btnCon.TabIndex = 2;
			this.btnCon.Text = "Connect";
			this.btnCon.UseVisualStyleBackColor = true;
			this.btnCon.Click += new System.EventHandler(this.btnCon_Click);
			// 
			// txtIP
			// 
			this.txtIP.Location = new System.Drawing.Point(96, 58);
			this.txtIP.Margin = new System.Windows.Forms.Padding(6);
			this.txtIP.Name = "txtIP";
			this.txtIP.Size = new System.Drawing.Size(192, 31);
			this.txtIP.TabIndex = 1;
			this.txtIP.Text = "10.215.2.35";
			this.txtIP.TextChanged += new System.EventHandler(this.txtIP_TextChanged);
			this.txtIP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIP_KeyPress);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(32, 63);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "IP";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.lblRedStatus);
			this.groupBox2.Controls.Add(this.lblGreenStatus);
			this.groupBox2.Controls.Add(this.btnToggleRed);
			this.groupBox2.Controls.Add(this.btnToggleGreen);
			this.groupBox2.Location = new System.Drawing.Point(378, 23);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(6);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(6);
			this.groupBox2.Size = new System.Drawing.Size(590, 244);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "LEDs and buttons";
			// 
			// lblRedStatus
			// 
			this.lblRedStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblRedStatus.Location = new System.Drawing.Point(332, 133);
			this.lblRedStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblRedStatus.Name = "lblRedStatus";
			this.lblRedStatus.Size = new System.Drawing.Size(198, 33);
			this.lblRedStatus.TabIndex = 1;
			this.lblRedStatus.Text = "Red Status";
			this.lblRedStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblGreenStatus
			// 
			this.lblGreenStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblGreenStatus.Location = new System.Drawing.Point(332, 77);
			this.lblGreenStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblGreenStatus.Name = "lblGreenStatus";
			this.lblGreenStatus.Size = new System.Drawing.Size(198, 33);
			this.lblGreenStatus.TabIndex = 1;
			this.lblGreenStatus.Text = "Green Status";
			this.lblGreenStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// btnToggleRed
			// 
			this.btnToggleRed.Location = new System.Drawing.Point(42, 129);
			this.btnToggleRed.Margin = new System.Windows.Forms.Padding(6);
			this.btnToggleRed.Name = "btnToggleRed";
			this.btnToggleRed.Size = new System.Drawing.Size(216, 44);
			this.btnToggleRed.TabIndex = 0;
			this.btnToggleRed.Text = "Toggle Red";
			this.btnToggleRed.UseVisualStyleBackColor = true;
			this.btnToggleRed.Click += new System.EventHandler(this.btnToggleRed_Click);
			// 
			// btnToggleGreen
			// 
			this.btnToggleGreen.Location = new System.Drawing.Point(42, 73);
			this.btnToggleGreen.Margin = new System.Windows.Forms.Padding(6);
			this.btnToggleGreen.Name = "btnToggleGreen";
			this.btnToggleGreen.Size = new System.Drawing.Size(216, 44);
			this.btnToggleGreen.TabIndex = 0;
			this.btnToggleGreen.Text = "Toggle Green";
			this.btnToggleGreen.UseVisualStyleBackColor = true;
			this.btnToggleGreen.Click += new System.EventHandler(this.btnToggleGreen_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(416, 82);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(172, 25);
			this.label3.TabIndex = 1;
			this.label3.Text = "Starboard Track:";
			// 
			// lblPosRight
			// 
			this.lblPosRight.AutoSize = true;
			this.lblPosRight.Location = new System.Drawing.Point(600, 82);
			this.lblPosRight.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblPosRight.Name = "lblPosRight";
			this.lblPosRight.Size = new System.Drawing.Size(24, 25);
			this.lblPosRight.TabIndex = 0;
			this.lblPosRight.Text = "0";
			// 
			// lblPosLeft
			// 
			this.lblPosLeft.AutoSize = true;
			this.lblPosLeft.Location = new System.Drawing.Point(601, 47);
			this.lblPosLeft.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.lblPosLeft.Name = "lblPosLeft";
			this.lblPosLeft.Size = new System.Drawing.Size(24, 25);
			this.lblPosLeft.TabIndex = 0;
			this.lblPosLeft.Text = "0";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(472, 47);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 25);
			this.label2.TabIndex = 0;
			this.label2.Text = "Port Track:";
			// 
			// reading_accelX
			// 
			this.reading_accelX.Location = new System.Drawing.Point(174, 41);
			this.reading_accelX.Margin = new System.Windows.Forms.Padding(6);
			this.reading_accelX.Name = "reading_accelX";
			this.reading_accelX.Size = new System.Drawing.Size(196, 31);
			this.reading_accelX.TabIndex = 3;
			this.reading_accelX.Text = "-";
			// 
			// reading_accelY
			// 
			this.reading_accelY.Location = new System.Drawing.Point(174, 91);
			this.reading_accelY.Margin = new System.Windows.Forms.Padding(6);
			this.reading_accelY.Name = "reading_accelY";
			this.reading_accelY.Size = new System.Drawing.Size(196, 31);
			this.reading_accelY.TabIndex = 4;
			this.reading_accelY.Text = "-";
			// 
			// reading_accelZ
			// 
			this.reading_accelZ.Location = new System.Drawing.Point(174, 141);
			this.reading_accelZ.Margin = new System.Windows.Forms.Padding(6);
			this.reading_accelZ.Name = "reading_accelZ";
			this.reading_accelZ.Size = new System.Drawing.Size(196, 31);
			this.reading_accelZ.TabIndex = 5;
			this.reading_accelZ.Text = "-";
			// 
			// reading_tilt
			// 
			this.reading_tilt.Location = new System.Drawing.Point(174, 187);
			this.reading_tilt.Margin = new System.Windows.Forms.Padding(6);
			this.reading_tilt.Name = "reading_tilt";
			this.reading_tilt.Size = new System.Drawing.Size(196, 31);
			this.reading_tilt.TabIndex = 6;
			this.reading_tilt.Text = "-";
			// 
			// label_accelerometer
			// 
			this.label_accelerometer.AutoSize = true;
			this.label_accelerometer.Location = new System.Drawing.Point(30, 81);
			this.label_accelerometer.Name = "label_accelerometer";
			this.label_accelerometer.Size = new System.Drawing.Size(150, 25);
			this.label_accelerometer.TabIndex = 8;
			this.label_accelerometer.Text = "Accelerometer";
			// 
			// status_accelerometer
			// 
			this.status_accelerometer.AutoSize = true;
			this.status_accelerometer.Location = new System.Drawing.Point(211, 81);
			this.status_accelerometer.Name = "status_accelerometer";
			this.status_accelerometer.Size = new System.Drawing.Size(19, 25);
			this.status_accelerometer.TabIndex = 9;
			this.status_accelerometer.Text = "-";
			// 
			// status_connection
			// 
			this.status_connection.AutoSize = true;
			this.status_connection.Location = new System.Drawing.Point(30, 83);
			this.status_connection.Name = "status_connection";
			this.status_connection.Size = new System.Drawing.Size(0, 25);
			this.status_connection.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(30, 36);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 25);
			this.label4.TabIndex = 11;
			this.label4.Text = "Connection";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(30, 127);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 25);
			this.label5.TabIndex = 12;
			this.label5.Text = "Position";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(30, 175);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(64, 25);
			this.label6.TabIndex = 13;
			this.label6.Text = "LEDs";
			// 
			// status_conn
			// 
			this.status_conn.AutoSize = true;
			this.status_conn.Location = new System.Drawing.Point(211, 36);
			this.status_conn.Name = "status_conn";
			this.status_conn.Size = new System.Drawing.Size(19, 25);
			this.status_conn.TabIndex = 14;
			this.status_conn.Text = "-";
			// 
			// status_position
			// 
			this.status_position.AutoSize = true;
			this.status_position.Location = new System.Drawing.Point(211, 127);
			this.status_position.Name = "status_position";
			this.status_position.Size = new System.Drawing.Size(19, 25);
			this.status_position.TabIndex = 15;
			this.status_position.Text = "-";
			// 
			// status_leds
			// 
			this.status_leds.AutoSize = true;
			this.status_leds.Location = new System.Drawing.Point(211, 175);
			this.status_leds.Name = "status_leds";
			this.status_leds.Size = new System.Drawing.Size(19, 25);
			this.status_leds.TabIndex = 16;
			this.status_leds.Text = "-";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(20, 44);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(145, 25);
			this.label7.TabIndex = 17;
			this.label7.Text = "AccelerationX";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(20, 141);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(144, 25);
			this.label8.TabIndex = 18;
			this.label8.Text = "AccelerationZ";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(20, 91);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(146, 25);
			this.label9.TabIndex = 19;
			this.label9.Text = "AccelerationY";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(123, 187);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(41, 25);
			this.label10.TabIndex = 20;
			this.label10.Text = "Tilt";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(104, 231);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(60, 25);
			this.label11.TabIndex = 21;
			this.label11.Text = "Pitch";
			// 
			// reading_pitch
			// 
			this.reading_pitch.Location = new System.Drawing.Point(174, 231);
			this.reading_pitch.Margin = new System.Windows.Forms.Padding(6);
			this.reading_pitch.Name = "reading_pitch";
			this.reading_pitch.Size = new System.Drawing.Size(196, 31);
			this.reading_pitch.TabIndex = 22;
			this.reading_pitch.Text = "-";
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label_accelerometer);
			this.groupBox3.Controls.Add(this.status_accelerometer);
			this.groupBox3.Controls.Add(this.status_connection);
			this.groupBox3.Controls.Add(this.label5);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.status_conn);
			this.groupBox3.Controls.Add(this.status_position);
			this.groupBox3.Controls.Add(this.status_leds);
			this.groupBox3.Location = new System.Drawing.Point(987, 23);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(394, 244);
			this.groupBox3.TabIndex = 23;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Status";
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.reading_accelY);
			this.groupBox4.Controls.Add(this.reading_accelX);
			this.groupBox4.Controls.Add(this.label3);
			this.groupBox4.Controls.Add(this.reading_accelZ);
			this.groupBox4.Controls.Add(this.reading_pitch);
			this.groupBox4.Controls.Add(this.reading_tilt);
			this.groupBox4.Controls.Add(this.lblPosRight);
			this.groupBox4.Controls.Add(this.label7);
			this.groupBox4.Controls.Add(this.label11);
			this.groupBox4.Controls.Add(this.label8);
			this.groupBox4.Controls.Add(this.lblPosLeft);
			this.groupBox4.Controls.Add(this.label9);
			this.groupBox4.Controls.Add(this.label10);
			this.groupBox4.Controls.Add(this.label2);
			this.groupBox4.Location = new System.Drawing.Point(24, 286);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(678, 364);
			this.groupBox4.TabIndex = 24;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Readings";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1404, 746);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.KeyPreview = true;
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "Form1";
			this.Text = "2nd Year Challenge - Example";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
			this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCon;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRedStatus;
        private System.Windows.Forms.Label lblGreenStatus;
        private System.Windows.Forms.Button btnToggleRed;
        private System.Windows.Forms.Button btnToggleGreen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPosRight;
        private System.Windows.Forms.Label lblPosLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox reading_accelX;
        private System.Windows.Forms.TextBox reading_accelY;
        private System.Windows.Forms.TextBox reading_accelZ;
        private System.Windows.Forms.TextBox reading_tilt;
		private System.Windows.Forms.Label label_accelerometer;
		private System.Windows.Forms.Label status_accelerometer;
		private System.Windows.Forms.Label status_connection;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label status_conn;
		private System.Windows.Forms.Label status_position;
		private System.Windows.Forms.Label status_leds;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox reading_pitch;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
	}
}

