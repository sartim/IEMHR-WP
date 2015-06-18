using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Xml;
using System.IO.IsolatedStorage;
using System.Xml.Serialization;
using System.IO;

namespace IEMHR_WP
{
    public partial class Registration : PhoneApplicationPage
    {
        public Registration()
        {
            InitializeComponent();
            UserNameTextBox.Text = "";
            EmailTextBox.Text = "";
            PasswordTextBox.Text = "";
            FullNameTextBox.Text = "";
        }

        public class UserInfo
        {
            string uname;
            string email;
            string pwd;
            string fname;

            public string Username
            {
                get { return uname; }
                set { uname = value; }
            }

            public string Email
            {
                get { return email; }
                set { email = value; }
            }

            public string Password
            {
                get { return pwd; }
                set { pwd = value; }
            }

            public string Fullname
            {
                get { return fname; }
                set { fname = value; }
            }
        }
        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            if (UserNameTextBox.Text == "") { MessageBox.Show("Please fill the user name field"); }
            if (EmailTextBox.Text == "") { MessageBox.Show("Please fill the email field"); }
            if (PasswordTextBox.Text == "") { MessageBox.Show("Please fill the password field"); }
            if (FullNameTextBox.Text == "") { MessageBox.Show("Please fill the full name field"); }

            // Write to the Isolated Storage
            XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
            xmlWriterSettings.Indent = true;
            using (IsolatedStorageFile myIsolatedStorage = IsolatedStorageFile.GetUserStoreForApplication())
            {
                using (IsolatedStorageFileStream stream = myIsolatedStorage.OpenFile("People.xml", FileMode.Create))
                {
		    
                    XmlSerializer serializer = new XmlSerializer(typeof(List<UserInfo>));
                    using (XmlWriter xmlWriter = XmlWriter.Create(stream, xmlWriterSettings))
                    {
                        serializer.Serialize(xmlWriter, GeneratePersonData());
                        NavigationService.Navigate(new Uri("/congate.xaml", UriKind.Relative));
                    }
                }
            }
        }
        private List<UserInfo> GeneratePersonData()
        {
            List<UserInfo> data = new List<UserInfo>();
            UserInfo ui = new UserInfo();
            ui.Username = UserNameTextBox.Text;
            ui.Email = EmailTextBox.Text;
            ui.Password = PasswordTextBox.Text;
            ui.Fullname = FullNameTextBox.Text;
            data.Add(ui);
            return data;
        }
    }
}