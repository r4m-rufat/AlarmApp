using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alarm
{
    public partial class CustomMessageBox : Form
    {

        // variables
        public bool snooze_activation = false;
        private OnClickedListener listener;

        public CustomMessageBox(OnClickedListener listener)
        {
            InitializeComponent();
            this.listener = listener;
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            listener.onClickCancel();
            this.Hide();
        }

        // when clicked snooze button snooze become active and custom MessageBox is hide
        private void btn_snooze_Click(object sender, EventArgs e)
        {

            snooze_activation = true;
            listener.onClickSnooze();
            this.Hide();
            
        }

    }

    public interface OnClickedListener
    {
        void onClickCancel();

        void onClickSnooze();

    }


}
