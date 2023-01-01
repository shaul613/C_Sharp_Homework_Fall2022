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
            personalData.name = "HOMER SIMPSON";
            personalData.address = "742 EVERGREEN TERRACE";
            personalData.age = "40";
            personalData.phoneNumber = "123-456-7890";

            //MY FAMILY MEMBER'S INFORMATION
            familyData.name = "BART SIMPSON";
            familyData.address = "742 EVERGREEN TERRACE";
            familyData.age = "10";
            familyData.phoneNumber = "123-456-7890";

            //MY FRIEND'S INFORMATION
            friendData.name = "MOE SIZSLACK";
            friendData.address = "MOE'S BAR";
            friendData.age = "45";
            friendData.phoneNumber = "333-BAR-MOES";
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
