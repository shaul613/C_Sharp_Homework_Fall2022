using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonalInformation
{
    public partial class Form1 : Form
    {
        Data personalData= new Data();
        Data familyData = new Data();
        Data friendData = new Data();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MY PERSONAL INFORMATION
            personalData.name = "Shaul Lifschitz";
            personalData.address = "447 Sequelize St, Soql NY, 12345";
            personalData.age = "23";
            personalData.phoneNumber = "201-688-6039";

            //MY FAMILY MEMBER'S INFORMATION
            familyData.name = "My Best Uncle";
            familyData.address = "123 Javascript St, Knex NJ, 00001";
            familyData.age = "57";
            familyData.phoneNumber = "201-555-5555";

            //MY FRIEND'S INFORMATION
            friendData.name = "My Dear Friend";
            friendData.address = "123 Hello World St, Salesforce FL, 00027";
            friendData.age = "23";
            friendData.phoneNumber = "201-999-9999";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txtPersonalName.Text = String.Empty;
            this.txtPersonalAddress.Text = String.Empty;
            this.txtPersonalAge.Text = String.Empty;
            this.txtPersonalPhoneNumber.Text = String.Empty;

            this.txtFamilyName.Text = String.Empty;
            this.txtFamilyAddress.Text = String.Empty;
            this.txtFamilyAge.Text = String.Empty;
            this.txtFamilyPhoneNumber.Text = String.Empty;

            this.txtFriendName.Text = String.Empty;
            this.txtFriendAddress.Text = String.Empty;
            this.txtFriendAge.Text = String.Empty;
            this.txtFriendPhoneNumber.Text = String.Empty;

            this.button2.Enabled = true;
            this.button1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //MY PERSONAL INFORMATION
            this.txtPersonalName.Text = personalData.name;
            this.txtPersonalAddress.Text = personalData.address;
            this.txtPersonalAge.Text = personalData.age;
            this.txtPersonalPhoneNumber.Text = personalData.phoneNumber;

            //MY FAMILY MEMBER'S INFORMATION
            this.txtFamilyName.Text = familyData.name;
            this.txtFamilyAddress.Text = familyData.address;
            this.txtFamilyAge.Text = familyData.age;
            this.txtFamilyPhoneNumber.Text = familyData.phoneNumber;

            //MY FRIEND'S INFORMATION
            this.txtFriendName.Text = friendData.name;
            this.txtFriendAddress.Text = friendData.address;
            this.txtFriendAge.Text = friendData.age;
            this.txtFriendPhoneNumber.Text = friendData.phoneNumber;

            this.button2.Enabled = false;
            this.button1.Enabled = true;
        }
    }
}
