using PhoneDirectory.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneDirectory.Core
{
    public class DatabaseLogicLayer
    {
        List<DirectoryRegistration> registrations;
        public DatabaseLogicLayer()
        {
            registrations = new List<DirectoryRegistration>(); // we For the method to work, we exemplify it here
            DatabaseControl();
        }
        #region MainMethods
        private void DatabaseControl()
        {
            // we check for Folder
            bool FolderControl = Directory.Exists(@"c:\PhoneDirectoryDB\");

            if (!FolderControl)
            {
                Directory.CreateDirectory(@"c:\PhoneDirectoryDB\");

                User Demo = new User(); // we add references entity to .core
                Demo.ID = Guid.NewGuid();
                Demo.UserName = "Demo";
                Demo.Password = "Demo";

                string JsonUserText = Newtonsoft.Json.JsonConvert.SerializeObject(Demo);
                File.WriteAllText(@"c:\PhoneDirectoryDB\user.json", JsonUserText);

            }
            // we installed JSON to references and we need user class (in entities) 
        }
        public int Newregistration(DirectoryRegistration R)
        {
            int result = 0;
            try
            {
                // we need a general collection so we can do it in class level (const to DatabaseLogicLayer)...
                DirectoryRegistrationList(); // If there is data, we have filled our data into the collection we have created at the class level, if not, it already has no value in memory and it is waiting for a new value to be added.
                registrations.Add(R); // we added data to collection
                JsonDBUpdate(); // if there is  already data , this method overrides it , if there is not , creates a new Json


            }
            catch (Exception ex) // don't write only Exception!!!!!!
            {

                result = 0;
            }
            return result;
        }
        public int UpdateRegistration(DirectoryRegistration R)
        {
            int result = 0;
            try
            {
                // first we should call DirectoryRegistrationList method
                DirectoryRegistrationList(); // and now we should find special ID for each one
                int idindex = registrations.FindIndex(I => I.ID == R.ID);
                if(idindex > -1)
                {
                    registrations[idindex].Name = R.Name;
                    registrations[idindex].Surname = R.Surname;
                    registrations[idindex].PhoneNumberI = R.PhoneNumberI;
                    registrations[idindex].PhoneNumberII = R.PhoneNumberII;
                    registrations[idindex].PhoneNumberIII = R.PhoneNumberIII;
                    registrations[idindex].Adress = R.Adress;
                    registrations[idindex].EmailAdress = R.EmailAdress;
                    registrations[idindex].WebSite = R.WebSite;
                    registrations[idindex].Explanation = R.Explanation;
                }
                // we can call JsonUpdate method here
                JsonDBUpdate(); // now we go =>>> BLL 
                result = 1; // write this to show it is success
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }
        public int RemoveRegistration(Guid ID) // First DLL class then BLL 
        {
            int result = 0;
            try
            {
                DirectoryRegistrationList();
                DirectoryRegistration Removevalue = registrations.Find(I => I.ID == ID);
                if(Removevalue != null)
                {
                    registrations.Remove(Removevalue);                  
                }
                
                JsonDBUpdate(); // we do this for update database
                result = 1;
            }
            catch (Exception ex)
            {

                throw;
            }
            return result;
        }
        public List<DirectoryRegistration> DirectoryRegistrationList()
        {
            if (File.Exists(@"c:\PhoneDirectoryDB\Directory.json"))
            {
                string JsonDBText = File.ReadAllText(@"c:\PhoneDirectoryDB\Directory.json");
                registrations = Newtonsoft.Json.JsonConvert.DeserializeObject<List<DirectoryRegistration>>(JsonDBText);
            }
            return registrations;
        }
        public int UserControl(User user)
        {
            int UserResult = 0;
            if (File.Exists(@"c:\PhoneDirectoryDB\user.json"))
            {
                string JsonUserText = File.ReadAllText(@"c:\PhoneDirectoryDB\user.json"); // first we should read this text
                List<User> Users = Newtonsoft.Json.JsonConvert.DeserializeObject<List<User>>
                    (JsonUserText); // we convert this to List generic 

                // for Search we use LinQ
                UserResult = Users.FindAll(I => I.UserName == user.UserName && I.Password == user.Password).ToList().
                     Count(); // Because it's one type we write FindAll and it returns collection
            }
            return UserResult;
        }
        #endregion
        #region HelperMethods
        private void JsonDBUpdate()
        {
            if (registrations != null && registrations.Count > 0)
            {
                // first , it will convert registrations collection to Json  
                string JsonDB = Newtonsoft.Json.JsonConvert.SerializeObject(registrations);
                File.WriteAllText(@"c:\PhoneDirectoryDB\Directory.json", JsonDB); // if there is already a file , it will override it..

            }
        }
        #endregion
    }
}
