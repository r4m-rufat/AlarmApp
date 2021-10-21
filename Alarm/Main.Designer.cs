
namespace Alarm
{
    partial class Alarm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.set_alarm = new System.Windows.Forms.Button();
            this.tb_clock_time = new System.Windows.Forms.TextBox();
            this.stop_alarm = new System.Windows.Forms.Button();
            this.tb_alarm_time = new System.Windows.Forms.TextBox();
            this.timer_for_clock = new System.Windows.Forms.Timer(this.components);
            this.timer_for_alarm = new System.Windows.Forms.Timer(this.components);
            this.cb_sound = new System.Windows.Forms.ComboBox();
            this.label_current_time = new System.Windows.Forms.Label();
            this.lb_alarm_time = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // set_alarm
            // 
            this.set_alarm.BackColor = System.Drawing.SystemColors.Highlight;
            this.set_alarm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.set_alarm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.set_alarm.Location = new System.Drawing.Point(583, 601);
            this.set_alarm.Name = "set_alarm";
            this.set_alarm.Size = new System.Drawing.Size(113, 40);
            this.set_alarm.TabIndex = 0;
            this.set_alarm.Text = "Set Alarm ";
            this.set_alarm.UseVisualStyleBackColor = false;
            this.set_alarm.Click += new System.EventHandler(this.set_alarm_Click);
            // 
            // tb_clock_time
            // 
            this.tb_clock_time.Enabled = false;
            this.tb_clock_time.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_clock_time.Location = new System.Drawing.Point(571, 28);
            this.tb_clock_time.Name = "tb_clock_time";
            this.tb_clock_time.ReadOnly = true;
            this.tb_clock_time.Size = new System.Drawing.Size(125, 30);
            this.tb_clock_time.TabIndex = 2;
            this.tb_clock_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_clock_time.TextChanged += new System.EventHandler(this.clock_time_TextChanged);
            // 
            // stop_alarm
            // 
            this.stop_alarm.BackColor = System.Drawing.Color.Red;
            this.stop_alarm.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stop_alarm.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stop_alarm.Location = new System.Drawing.Point(12, 601);
            this.stop_alarm.Name = "stop_alarm";
            this.stop_alarm.Size = new System.Drawing.Size(113, 40);
            this.stop_alarm.TabIndex = 3;
            this.stop_alarm.Text = "Stop Alarm";
            this.stop_alarm.UseVisualStyleBackColor = false;
            this.stop_alarm.Click += new System.EventHandler(this.stop_alarm_Click);
            // 
            // tb_alarm_time
            // 
            this.tb_alarm_time.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tb_alarm_time.Location = new System.Drawing.Point(571, 83);
            this.tb_alarm_time.Name = "tb_alarm_time";
            this.tb_alarm_time.Size = new System.Drawing.Size(125, 30);
            this.tb_alarm_time.TabIndex = 4;
            this.tb_alarm_time.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tb_alarm_time.TextChanged += new System.EventHandler(this.tb_alarm_time_TextChanged);
            // 
            // timer_for_clock
            // 
            this.timer_for_clock.Interval = 1000;
            this.timer_for_clock.Tag = "";
            this.timer_for_clock.Tick += new System.EventHandler(this.timer_for_clock_Tick);
            // 
            // timer_for_alarm
            // 
            this.timer_for_alarm.Interval = 1000;
            this.timer_for_alarm.Tick += new System.EventHandler(this.timer_for_alarm_Tick);
            // 
            // cb_sound
            // 
            this.cb_sound.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cb_sound.FormattingEnabled = true;
            this.cb_sound.Items.AddRange(new object[] {
            "Alarm",
            "Creepy"});
            this.cb_sound.Location = new System.Drawing.Point(571, 141);
            this.cb_sound.Name = "cb_sound";
            this.cb_sound.Size = new System.Drawing.Size(125, 31);
            this.cb_sound.TabIndex = 5;
            this.cb_sound.SelectedIndexChanged += new System.EventHandler(this.cb_sound_SelectedIndexChanged);
            // 
            // label_current_time
            // 
            this.label_current_time.AutoSize = true;
            this.label_current_time.BackColor = System.Drawing.Color.Transparent;
            this.label_current_time.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_current_time.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label_current_time.Location = new System.Drawing.Point(408, 33);
            this.label_current_time.Name = "label_current_time";
            this.label_current_time.Size = new System.Drawing.Size(157, 25);
            this.label_current_time.TabIndex = 6;
            this.label_current_time.Text = "Current time: ";
            // 
            // lb_alarm_time
            // 
            this.lb_alarm_time.AutoSize = true;
            this.lb_alarm_time.BackColor = System.Drawing.Color.Transparent;
            this.lb_alarm_time.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_alarm_time.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lb_alarm_time.Location = new System.Drawing.Point(408, 88);
            this.lb_alarm_time.Name = "lb_alarm_time";
            this.lb_alarm_time.Size = new System.Drawing.Size(137, 25);
            this.lb_alarm_time.TabIndex = 7;
            this.lb_alarm_time.Text = "Alarm time: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(408, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sound: ";
            // 
            // Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::Alarm.Properties.Resources.alarm_icon;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(708, 653);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_alarm_time);
            this.Controls.Add(this.label_current_time);
            this.Controls.Add(this.cb_sound);
            this.Controls.Add(this.tb_alarm_time);
            this.Controls.Add(this.stop_alarm);
            this.Controls.Add(this.tb_clock_time);
            this.Controls.Add(this.set_alarm);
            this.DoubleBuffered = true;
            this.Name = "Alarm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alarm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button set_alarm;
        private System.Windows.Forms.TextBox tb_clock_time;
        private System.Windows.Forms.Button stop_alarm;
        public System.Windows.Forms.TextBox tb_alarm_time;
        private System.Windows.Forms.Timer timer_for_clock;
        private System.Windows.Forms.Timer timer_for_alarm;
        private System.Windows.Forms.ComboBox cb_sound;
        private System.Windows.Forms.Label label_current_time;
        private System.Windows.Forms.Label lb_alarm_time;
        private System.Windows.Forms.Label label2;
    }
}

