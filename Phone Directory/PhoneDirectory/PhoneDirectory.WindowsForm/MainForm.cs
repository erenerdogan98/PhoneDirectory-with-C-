using PhoneDirectory.BLL;
using PhoneDirectory.Entities;
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
    public partial class MainForm : Form
    {
        BusinessLogicLayer BLL; // 1.
        public MainForm()
        {
            InitializeComponent();
            BLL = new BusinessLogicLayer(); //2.
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_newregister_Click(object sender, EventArgs e)
        {
            // we sampled BLL like we did before user control in class level. and call that under the initializecomponent
            int result = BLL.Newregistration(Guid.NewGuid(), txt_name.Text, txt_surname.Text, txt_phonenoI.Text, txt_phonenoII.Text,
                 txt_phonenoIII.Text, txt_adress.Text, txt_emailadress.Text, txt_website.Text, txt_explanation.Text);
            // and now we check result ? 
            if (result >= 0)
            {
                MessageBox.Show("Your registration has been successfully added.");
                Fill();
            }
            else if (result == -100)
            {
                MessageBox.Show("Please fill in the required fields which Name, Surname and Phone Number", "Missing Parameter Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Error occurred while adding registration!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Fill()
        {
            // we add references entities to Windows form 
            List<DirectoryRegistration> MyDirectoryRegistration = BLL.DirectoryRegistrationList();
            if (MyDirectoryRegistration != null && MyDirectoryRegistration.Count >= 0)
            {
                lst_list.DataSource = MyDirectoryRegistration;
                // we call this method (Fill) under to successfully registration -- and onLoad
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Fill();
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (lst_list.SelectedItem != null)
            {
                Guid ID = ((DirectoryRegistration)lst_list.SelectedItem).ID; // this method will work on ID
                int result = BLL.UpdateRegistration(ID, txt_name.Text, txt_surname.Text, txt_phonenoI.Text, txt_phonenoII.Text,
                     txt_phonenoIII.Text, txt_adress.Text, txt_emailadress.Text, txt_website.Text, txt_explanation.Text);
                if (result >= 0)
                {
                    MessageBox.Show("Your registration has been successfully updated.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Fill(); // we call this method to update listbox
                }
                else if (result == -100)
                {
                    MessageBox.Show("Please fill in the required fields which Name, Surname and Phone Number", "Missing Parameter Error!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {
                    MessageBox.Show("Error occurred while adding registration!!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            Guid ID = ((DirectoryRegistration)lst_list.SelectedItem).ID;
            int result = BLL.RemoveRegistration(ID);
            if (result >= 0)
            {
                MessageBox.Show("Your remove performed.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Fill(); // if it works , listbox will fill
            }
            else
            {
                MessageBox.Show("Your remove could not be performed", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_xmlexport_Click(object sender, EventArgs e)
        {
            int result = BLL.ExportXML(); // we defined methot in BLL and now we just call
            if (result > 0)
            {
                lbl_event.Text = "Event : XML export completed!";
            }
            else
            {
                lbl_event.Text = "Event : ERROR";
                    
            }
        }

        private void btn_CSV_Click(object sender, EventArgs e)
        {
            int result = BLL.ExportCSV();
            if (result > 0)
            {
                lbl_event.Text = "Event : CSV export completed!";
            }
            else
            {
                lbl_event.Text = "Event : ERROR";

            }
        }

        private void btn_Json_Click(object sender, EventArgs e)
        {
            int result = BLL.ExportJson();
            if (result > 0)
            {
                lbl_event.Text = "Event : Json export completed!";
            }
            else
            {
                lbl_event.Text = "Event : ERROR";

            }
        }

        private void lst_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
