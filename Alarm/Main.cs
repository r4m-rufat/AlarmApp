using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Alarm
{
    public partial class Alarm : Form, OnClickedListener
    {
        
        private SoundPlayer soundPlayer;
        private CustomMessageBox custom_message;


        public Alarm()
        {
            InitializeComponent();

            // creating object
            custom_message = new CustomMessageBox(this);
            soundPlayer = new SoundPlayer(Properties.Resources.alarm_music);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            timer_for_clock.Start();
            String current_date = DateTime.Now.ToLongTimeString();
            tb_clock_time.Text = current_date;
            tb_alarm_time.Text = current_date;
            cb_sound.SelectedIndex = 0;
        }

        private void set_alarm_Click(object sender, EventArgs e)
        {
            timer_for_alarm.Start();
        }

        private void clock_time_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void stop_alarm_Click(object sender, EventArgs e)
        {
            timer_for_alarm.Stop();
        }

        private void tb_alarm_time_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer_for_clock_Tick(object sender, EventArgs e)
        {
            String current_date = DateTime.Now.ToLongTimeString();
            tb_clock_time.Text = current_date;
        }

      
        private void timer_for_alarm_Tick(object sender, EventArgs e)
        {
            if (tb_clock_time.Text == tb_alarm_time.Text)
            {
                soundPlayer.PlayLooping();
                custom_message.Show();

            }

        }

        /**
         * click cancel button and alarm becomes stop, sound should be off 
         */
        public void onClickCancel()
        {

            timer_for_alarm.Stop();

            soundPlayer.Stop();
          
        }

        /**
         * click snooze button and sound becomes off 
         */
        public void onClickSnooze()
        {
            // added 30 seconds(normally 5 minute) is for your checking program fastly
            String added_30Seconds = DateTime.Now.AddSeconds(30).ToLongTimeString();
            tb_alarm_time.Text = added_30Seconds;

            soundPlayer.Stop();

        }

        private void cb_sound_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cb_sound.SelectedIndex)
            {
                case 0: soundPlayer = new SoundPlayer(Properties.Resources.alarm_music); break;
                case 1: soundPlayer = new SoundPlayer(Properties.Resources.creepy); break;

            }
        }
    }
}
