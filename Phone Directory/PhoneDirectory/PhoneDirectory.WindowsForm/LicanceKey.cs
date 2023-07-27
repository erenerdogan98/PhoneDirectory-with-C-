using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneDirectory.WindowsForm
{
    public partial class LicanceKey : Form
    {
        public LicanceKey()
        {
            InitializeComponent();
        }

        private void btn_licance_Click(object sender, EventArgs e)
        {
            if(txt_licancekey.Text == "8f0c5670‑4e56‑4892‑b06d‑91c085d7004f")
            {
                string HardDiscSerialNumber = string.Empty;
                string MacAddress = string.Empty;
                string driver = "C";
                ManagementObject DiscNo = new ManagementObject("Win32_LogicalDisk.DeviceID=\"" + driver + ":\""); // we added system.management refereance
                DiscNo.Get();

                HardDiscSerialNumber = DiscNo["VolumeSerialNumber"].ToString();

                ManagementClass MacAdress = new ManagementClass("Win32_NetworkAdapterConfiguration");
                ManagementObjectCollection NetworkAdapterList = MacAdress.GetInstances();
                foreach (ManagementObject item in NetworkAdapterList)
                {
                    if ((bool)item["IPEnabled"])
                    {
                        MacAddress = item["MacAddress"].ToString();
                    }
                }
                if (!string.IsNullOrEmpty(HardDiscSerialNumber)&& !string.IsNullOrEmpty(MacAddress))
                {
                    RegistryKey Key = Registry.CurrentUser.CreateSubKey("DirectoryRegistration",true);
                    Key.SetValue("HardDiscSerialNumber", HardDiscSerialNumber);
                    Key.SetValue("MacAddress", MacAddress);

                    MessageBox.Show("Your licensing process is complete. Please close and open the application.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Licance key is wrong!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
