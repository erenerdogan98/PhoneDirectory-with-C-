using PhoneDirectory.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneDirectory.WindowsForm
{
    public partial class Form1 : Form
    {
        BusinessLogicLayer BLL = new BusinessLogicLayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void txt_username_Enter(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.YellowGreen; // we did unboxing and we know which type we used (sender)
        }

        private void txt_username_Leave(object sender, EventArgs e)
        {
            TextBox T = (TextBox)sender;
            T.BackColor = Color.White;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            // we call usercontrol method which we defined in BLL so therefore , we add reference BLL and we call this to Class level , first
            int result = BLL.UserControl(txt_username.Text, txt_pass.Text); // UserControl method turn int 
            if (result > 0)
            {
                // if result > 0 , it should open new form then ---
                MainForm form = new MainForm();
                form.Show();
            }
            else if (result == -100)
            {
                MessageBox.Show("Please fill in the blanks completely", "Missing Parameter Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Wrong User!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
    
}
