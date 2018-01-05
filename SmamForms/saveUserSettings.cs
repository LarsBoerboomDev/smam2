using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmamForms
{
    class saveUserSettings
    {       
        public void getUserSettings()
        {

        }
        public override string ToString()
        {
            return Properties.Settings.Default.Name.ToString() + " - " + Properties.Settings.Default.City.ToString() + " - " + Properties.Settings.Default.School.ToString() + " - " + Properties.Settings.Default.Education.ToString() + " - " + Properties.Settings.Default.dayRent.ToString();      
        }
        public void saveUser(string name, string city, string street, string school, string education, string dayrent) {
            Properties.Settings.Default.Name = name;
            Properties.Settings.Default.City = city;
            Properties.Settings.Default.Street = street;
            Properties.Settings.Default.School = school;
            Properties.Settings.Default.Education = education;
            Properties.Settings.Default.dayRent = dayrent;            
            Properties.Settings.Default.Save();
            Console.WriteLine(Properties.Settings.Default.Name);
        }
        public void isInstalled()
        {
            Properties.Settings.Default.hasStarted = "1";
        }
        public string getCity()
        {
            return Properties.Settings.Default.City;
        }
        public userSetting getSettings()
        {
            userSetting setting = new userSetting();
            setting.Name = Properties.Settings.Default.Name;
            setting.City = Properties.Settings.Default.City;
            setting.Street = Properties.Settings.Default.Street;
            setting.School = Properties.Settings.Default.School;
            setting.Education = Properties.Settings.Default.Education;
            setting.RentDay = Properties.Settings.Default.dayRent;
            return setting;
        }
    }

    class userSetting
    {
        private string name;
        private string city;
        private string street;
        private string school;
        private string education;
        private string rentDay;

        public string Name { get => name; set => name = value; }
        public string City { get => city; set => city = value; }
        public string Street { get => street; set => street = value; }
        public string School { get => school; set => school = value; }
        public string Education { get => education; set => education = value; }
        public string RentDay { get => rentDay; set => rentDay = value; }
    }
}
