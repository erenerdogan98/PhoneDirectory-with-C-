using CsvHelper;
using PhoneDirectory.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhoneDirectory.BLL
{
    public class BusinessLogicLayer
    {
        PhoneDirectory.Core.DatabaseLogicLayer DLL; // we should call this and before we referenced 
        public BusinessLogicLayer()
        {
            DLL = new Core.DatabaseLogicLayer(); // we should   exemplify in constructive method
        }

        #region Methods
        public int Newregistration(Guid ID, string Name, string Surname, string PhoneNumberI, string PhoneNumberII, string PhoneNumberIII,
            string Adress, string EmailAdress, string WebSite, string Explanation)
        {
            int result = 0;
            if (ID != Guid.Empty && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Surname)
                && !string.IsNullOrEmpty(PhoneNumberI)) // Data must be entered for these parameters.
            {
                // we references entities 
                DirectoryRegistration Registration = new DirectoryRegistration();
                Registration.ID = ID;
                Registration.Name = Name;
                Registration.Surname = Surname;
                Registration.PhoneNumberI = PhoneNumberI;
                Registration.PhoneNumberII = PhoneNumberII;
                Registration.PhoneNumberIII = PhoneNumberIII;
                Registration.Adress = Adress;
                Registration.EmailAdress = EmailAdress;
                Registration.WebSite = WebSite;
                Registration.Explanation = Explanation;

                result = DLL.Newregistration(Registration); // if our values is correct , we send this to DLL
            }
            else { result = -100; } // missing parameter error
            return result;
        }
        public int UserControl(string UserName, string Password) // we take fragmented datas
        {
            int result = 0;
            if (!string.IsNullOrEmpty(UserName) && !string.IsNullOrEmpty(Password))
            {
                User user = new User(); // first we exemplify this by new 
                user.UserName = UserName;
                user.Password = Password;
                // We enter our values, which come as parameters, into our method.  
                result = DLL.UserControl(user);
            }
            else
            {
                result = -100;
            }
            return result;
        }
        public int UpdateRegistration(Guid ID, string Name, string Surname, string PhoneNumberI, string PhoneNumberII, string PhoneNumberIII,
            string Adress, string EmailAdress, string WebSite, string Explanation)
        {
            int result = 0;
            if (ID != Guid.Empty && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Surname) && !string.IsNullOrEmpty(PhoneNumberI))
            {
                DirectoryRegistration Registration = new DirectoryRegistration();
                Registration.ID = ID;
                Registration.Name = Name;
                Registration.Surname = Surname;
                Registration.PhoneNumberI = PhoneNumberI;
                Registration.PhoneNumberII = PhoneNumberII;
                Registration.PhoneNumberIII = PhoneNumberIII;
                Registration.Adress = Adress;
                Registration.EmailAdress = EmailAdress;
                Registration.WebSite = WebSite;
                Registration.Explanation = Explanation;

                result = DLL.UpdateRegistration(Registration); // we send result to >> DLL
            }
            else { result = -100; }
            return result;
        }
        public int RemoveRegistration(Guid ID)
        {
            return DLL.RemoveRegistration(ID);
        }
        public List<DirectoryRegistration> DirectoryRegistrationList() => DLL.DirectoryRegistrationList(); // from DLL 




        #endregion
        #region export data
        public int ExportXML() // we have already done a method in DLL DirectoryRegistrationList() , so no need to do new one in DLL
        {
            int result = 0;
            try
            {
                List<DirectoryRegistration> registrations = DLL.DirectoryRegistrationList();

                XDocument XDoc = new XDocument(new XDeclaration("1.0.0.1", "UTF-8", "yes"), new XElement("DirectoryRegistrations", registrations.Select(
                    I => new XElement("Registration", new XElement("ID", I.ID), new XElement("Name", I.Name), new XElement("Surname", I.Surname),
                    new XElement("PhoneNumberI", I.PhoneNumberI), new XElement("PhoneNumberII", I.PhoneNumberII), new XElement("PhoneNumberIII", I.PhoneNumberIII),
                    new XElement("Adress", I.Adress), new XElement("EmailAdress", I.EmailAdress), new XElement("WebSite", I.WebSite), new XElement("Explanation",
                    I.Explanation.Replace(" ", " "))))));

                XDoc.Save(@"c:\PhoneDirectoryDB\ExportDataXML.xml");
                result = 1; // dont forget !!
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }
        public int ExportCSV()
        {
            int result = 0;
            try
            {
                List<DirectoryRegistration> registrations = DLL.DirectoryRegistrationList();
                StreamWriter SW = new StreamWriter(@"c:\PhoneDirectoryDB\ExportDataCSV.csv");
                CsvWriter csvWriter = new CsvWriter(SW,CultureInfo.CurrentCulture);
                csvWriter.WriteHeader(typeof(DirectoryRegistration));
                foreach (var item in registrations)
                {
                    csvWriter.WriteRecord<DirectoryRegistration>(item);
                }
                SW.Dispose();
                result = 1;
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }
        public int ExportJson()
        {
            int result = 0;
            try
            {
                List<DirectoryRegistration> registrations = DLL.DirectoryRegistrationList(); // we add managenugdet Newtons..
                string JsonText = Newtonsoft.Json.JsonConvert.SerializeObject(registrations);
                File.WriteAllText(@"c:\PhoneDirectoryDB\ExportDataJSON.json",JsonText);
                result = 1;
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }
        #endregion
    }
}
