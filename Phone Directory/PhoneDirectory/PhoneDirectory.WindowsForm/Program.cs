using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneDirectory.WindowsForm
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool LC = LicanceControl();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Application.Run(new Form1()); we will copy this in if bloc
            if (LC)
            {
                Application.Run(new Form1());
            }
            else
            {
                Application.Run(new LicanceKey()); // if it is wrong , user will have Licance Key screen
            }
        }
        static bool LicanceControl() // we will call this metot in main 
        {
            RegistryKey RK = Registry.CurrentUser.OpenSubKey("DirectoryRegistration");
            if (RK != null)
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

                string HardDiscSerialNoSTR = RK.GetValue("HardDiscSerialNumber").ToString();
                string MacAdressSTR = RK.GetValue("MacAddress").ToString();

                if(HardDiscSerialNoSTR == HardDiscSerialNumber && MacAdressSTR == MacAddress)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
            }
            else
            {
                return false;
            }           
        }
    }
}
