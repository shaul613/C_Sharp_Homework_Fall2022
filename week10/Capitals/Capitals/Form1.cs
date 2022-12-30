using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO.Ports;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Capitals
{
    public partial class Form1 : Form
    {
        IDictionary<int, string> capitals = new Dictionary<int, string>();
        string cityName = string.Empty;
        int numberOfQuestions = 0;
        int numberOfCorrectAnswers = 0;
        int numberOfIncorrectAnswers = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fillDictionary();
        }

        private void fillDictionary()
        {
            capitals.Add(1, "Afghanistan-Kabul");
            capitals.Add(2, "Albania-Tirana / Tirane)");
            capitals.Add(3, "Algeria-Algiers");
            capitals.Add(4, "Andorra-Andorra la Vella");
            capitals.Add(5, "Angola-Luanda");
            capitals.Add(6, "Antigua and Barbuda-Saint John's");
            capitals.Add(7, "Argentina-Buenos Aires");
            capitals.Add(8, "Armenia-Yerevan");
            capitals.Add(9, "Australia-Canberra");
            capitals.Add(10, "Austria-Vienna");
            capitals.Add(11, "Azerbaijan-Baku");
            capitals.Add(12, "Bahamas-Nassau");
            capitals.Add(13, "Bahrain-Manama");
            capitals.Add(14, "Bangladesh-Dhaka");
            capitals.Add(15, "Barbados-Bridgetown");
            capitals.Add(16, "Belarus-Minsk");
            capitals.Add(17, "Belgium-Brussels");
            capitals.Add(18, "Belize-Belmopan");
            capitals.Add(19, "Benin-Porto Novo");
            capitals.Add(20, "Bhutan-Thimphu");
            capitals.Add(21, "Bolivia-La Paz / Sucre");
            capitals.Add(22, "Bosnia and Herzegovina-Sarajevo");
            capitals.Add(23, "Botswana-Gaborone");
            capitals.Add(24, "Brazil-Brasilia");
            capitals.Add(25, "Brunei-Bandar Seri Begawan");
            capitals.Add(26, "Bulgaria-Sofia");
            capitals.Add(27, "Burkina Faso-Ouagadougou");
            capitals.Add(28, "Burundi-Gitega");
            capitals.Add(29, "Cambodia-Phnom Penh");
            capitals.Add(30, "Cameroon-Yaounde");
            capitals.Add(31, "Canada-Ottawa");
            capitals.Add(32, "Cape Verde-Praia");
            capitals.Add(33, "Central African Republic-Bangui");
            capitals.Add(34, "Chad-N'Djamena");
            capitals.Add(35, "Chile-Santiago");
            capitals.Add(36, "China-Beijing");
            capitals.Add(37, "Colombia-Bogota");
            capitals.Add(38, "Comoros-Moroni");
            capitals.Add(39, "Congo-Democratic Republic of the-Kinshasa");
            capitals.Add(40, "Congo-Republic of the-Brazzaville");
            capitals.Add(41, "Costa Rica-San Jose");
            capitals.Add(42, "Côte d'Ivoire/Ivory Coast-Yamoussoukro");
            capitals.Add(43, "Croatia-Zagreb");
            capitals.Add(44, "Cuba-Havana");
            capitals.Add(45, "Cyprus-Nicosia");
            capitals.Add(46, "Czech Republic-Prague");
            capitals.Add(47, "Denmark-Copenhagen");
            capitals.Add(48, "Djibouti-Djibouti");
            capitals.Add(49, "Dominica-Roseau");
            capitals.Add(50, "Dominican Republic-Santo Domingo");
            capitals.Add(51, "East Timor-Dili");
            capitals.Add(52, "Ecuador-Quito");
            capitals.Add(53, "Egypt-Cairo");
            capitals.Add(54, "El Salvador-San Salvador");
            capitals.Add(55, "England-London");
            capitals.Add(56, "Equatorial Guinea-Malabo");
            capitals.Add(57, "Eritrea-Asmara");
            capitals.Add(58, "Estonia-Tallinn");
            capitals.Add(59, "Eswatini-Mbabana");
            capitals.Add(60, "Ethiopia-Addis Ababa");
            capitals.Add(61, "Federated States of Micronesia-Palikir");
            capitals.Add(62, "Fiji-Suva");
            capitals.Add(63, "Finland-Helsinki");
            capitals.Add(64, "France-Paris");
            capitals.Add(65, "Gabon-Libreville");
            capitals.Add(66, "Gambia-Banjul");
            capitals.Add(67, "Georgia-Tbilisi");
            capitals.Add(68, "Germany-Berlin");
            capitals.Add(69, "Ghana-Accra");
            capitals.Add(70, "Greece-Athens");
            capitals.Add(71, "Grenada-Saint George's");
            capitals.Add(72, "Guatemala-Guatemala City");
            capitals.Add(73, "Guinea-Conakry");
            capitals.Add(74, "Guinea-Bissau-Bissau");
            capitals.Add(75, "Guyana-Georgetown");
            capitals.Add(76, "Haiti-Port au Prince");
            capitals.Add(77, "Honduras-Tegucigalpa");
            capitals.Add(78, "Hungary-Budapest");
            capitals.Add(79, "Iceland-Reykjavik");
            capitals.Add(80, "India-New Delhi");
            capitals.Add(81, "Indonesia-Jakarta");
            capitals.Add(82, "Iran-Tehran");
            capitals.Add(83, "Iraq-Baghdad");
            capitals.Add(84, "Ireland-Dublin");
            capitals.Add(85, "Israel-Jerusalem");
            capitals.Add(86, "Italy-Rome");
            capitals.Add(87, "Jamaica-Kingston");
            capitals.Add(88, "Japan-Tokyo");
            capitals.Add(89, "Jordan-Amman");
            capitals.Add(90, "Kazakhstan-Nur - Sultan");
            capitals.Add(91, "Kenya-Nairobi");
            capitals.Add(92, "Kiribati-Tarawa Atoll");
            capitals.Add(93, "Kosovo-Pristina");
            capitals.Add(94, "Kuwait-Kuwait City");
            capitals.Add(95, "Kyrgyzstan-Bishkek");
            capitals.Add(96, "Laos-Vientiane");
            capitals.Add(97, "Latvia-Riga");
            capitals.Add(98, "Lebanon-Beirut");
            capitals.Add(99, "Lesotho-Maseru");
            capitals.Add(100, "Liberia-Monrovia");
            capitals.Add(101, "Libya-Tripoli");
            capitals.Add(102, "Liechtenstein-Vaduz");
            capitals.Add(103, "Lithuania-Vilnius");
            capitals.Add(104, "Luxembourg-Luxembourg");
            capitals.Add(105, "Madagascar-Antananarivo");
            capitals.Add(106, "Malawi-Lilongwe");
            capitals.Add(107, "Malaysia-Kuala Lumpur");
            capitals.Add(108, "Maldives-Male");
            capitals.Add(109, "Mali-Bamako");
            capitals.Add(110, "Malta-Valletta");
            capitals.Add(111, "Marshall Islands-Majuro");
            capitals.Add(112, "Mauritania-Nouakchott");
            capitals.Add(113, "Mauritius-Port Louis");
            capitals.Add(114, "Mexico-Mexico City");
            capitals.Add(115, "Moldova-Chisinau");
            capitals.Add(116, "Monaco-Monaco");
            capitals.Add(117, "Mongolia-Ulaanbaatar");
            capitals.Add(118, "Montenegro-Podgorica");
            capitals.Add(119, "Morocco-Rabat");
            capitals.Add(120, "Mozambique-Maputo");
            capitals.Add(121, "Myanmar/Burma-Nay Pyi Taw");
            capitals.Add(122, "Namibia-Windhoek");
            capitals.Add(123, "Nauru-No official capital");
            capitals.Add(124, "Nepal-Kathmandu");
            capitals.Add(125, "Netherlands-Amsterdam");
            capitals.Add(126, "New Zealand-Wellington");
            capitals.Add(127, "Nicaragua-Managua");
            capitals.Add(128, "Niger-Niamey");
            capitals.Add(129, "Nigeria-Abuja");
            capitals.Add(130, "North Korea-Pyongyang");
            capitals.Add(131, "North Macedonia/Macedonia-Skopje");
            capitals.Add(132, "Northern Ireland-Belfast");
            capitals.Add(133, "Norway-Oslo");
            capitals.Add(134, "Oman-Muscat");
            capitals.Add(135, "Pakistan-Islamabad");
            capitals.Add(136, "Palau-Melekeok");
            capitals.Add(137, "Palestine-Jerusalem");
            capitals.Add(138, "Panama-Panama City");
            capitals.Add(139, "Papua New Guinea-Port Moresby");
            capitals.Add(140, "Paraguay-Asuncion");
            capitals.Add(141, "Peru-Lima");
            capitals.Add(142, "Philippines-Manila");
            capitals.Add(143, "Poland-Warsaw");
            capitals.Add(144, "Portugal-Lisbon");
            capitals.Add(145, "Qatar-Doha");
            capitals.Add(146, "Romania-Bucharest");
            capitals.Add(147, "Russia-Moscow");
            capitals.Add(148, "Rwanda-Kigali");
            capitals.Add(149, "Saint Kitts and Nevis-Basseterre");
            capitals.Add(150, "Saint Lucia-Castries");
            capitals.Add(151, "Saint Vincent and the Grenadines-Kingstown");
            capitals.Add(152, "Samoa-Apia");
            capitals.Add(153, "San Marino-San Marino");
            capitals.Add(154, "Sao Tome and Principe-Sao Tome");
            capitals.Add(155, "Saudi Arabia-Riyadh");
            capitals.Add(156, "Scotland-Edinburgh");
            capitals.Add(157, "Senegal-Dakar");
            capitals.Add(158, "Serbia-Belgrade");
            capitals.Add(159, "Seychelles-Victoria");
            capitals.Add(160, "Sierra Leone-Freetown");
            capitals.Add(161, "Singapore-Singapore");
            capitals.Add(162, "Slovakia-Bratislava");
            capitals.Add(163, "Slovenia-Ljubljana");
            capitals.Add(164, "Solomon Islands-Honiara");
            capitals.Add(165, "Somalia-Mogadishu");
            capitals.Add(166, "South Africa-Pretoria/Bloemfontein/Cape Town");
            capitals.Add(167, "South Korea-Seoul");
            capitals.Add(168, "South Sudan-Juba");
            capitals.Add(169, "Spain-Madrid");
            capitals.Add(170, "Sri Lanka-Sri Jayawardenapura Kotte");
            capitals.Add(171, "Sudan-Khartoum");
            capitals.Add(172, "Suriname-Paramaribo");
            capitals.Add(173, "Sweden-Stockholm");
            capitals.Add(174, "Switzerland-Bern");
            capitals.Add(175, "Syria-Damascus");
            capitals.Add(176, "Taiwan-Taipei");
            capitals.Add(177, "Tajikistan-Dushanbe");
            capitals.Add(178, "Tanzania-Dodoma");
            capitals.Add(179, "Thailand-Bangkok");
            capitals.Add(180, "Togo-Lome");
            capitals.Add(181, "Tonga-Nuku'alofa");
            capitals.Add(182, "Trinidad and Tobago-Port of Spain");
            capitals.Add(183, "Tunisia-Tunis");
            capitals.Add(184, "Türkiye/Turkey-Ankara");
            capitals.Add(185, "Turkmenistan-Ashgabat");
            capitals.Add(186, "Tuvalu-Funafuti");
            capitals.Add(187, "Uganda-Kampala");
            capitals.Add(188, "Ukraine-Kyiv or Kiev");
            capitals.Add(189, "United Arab Emirates-Abu Dhabi");
            capitals.Add(190, "United Kingdom-London");
            capitals.Add(191, "United States-Washington D.C.");
            capitals.Add(192, "Uruguay-Montevideo");
            capitals.Add(193, "Uzbekistan-Tashkent");
            capitals.Add(194, "Vanuatu-Port Vila");
            capitals.Add(195, "Vatican City-Vatican City");
            capitals.Add(196, "Venezuela-Caracas");
            capitals.Add(197, "Vietnam-Hanoi");
            capitals.Add(198, "Wales-Cardiff");
            capitals.Add(199, "Yemen-Sana'a");
            capitals.Add(200, "Zambia-Lusaka");
            capitals.Add(201, "Zimbabwe-Harare");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getDataFromDictionaryRandomly();
            this.button1.Enabled = false;
            this.button2.Enabled = true;
            this.button4.Enabled = true;
        }

        private void getDataFromDictionaryRandomly()
        {
            Random random = new Random();
            int number = random.Next(1, 201);
            data(number);
            this.textBox1.Enabled = true;
            this.textBox1.Focus();
        }

        private void data(int number)
        {
            string data = string.Empty;

            data = capitals[number];
            int index = data.IndexOf("-");
            if (index >= 0)
            {
                label1.Text = "Please enter the capital of " + data.Substring(0, index);
                cityName = data.Substring(index + 1);
                numberOfQuestions++;
            }
        }

        private void checkCorrectAnswer()
        {
            if(this.textBox1.Text.ToString().ToUpper().Trim().Length >= 4)
            {
                if (cityName.ToUpper().Contains(this.textBox1.Text.ToString().ToUpper().Trim()))
                {
                    numberOfCorrectAnswers++;
                    lblCorrectAnswers.Text = numberOfCorrectAnswers.ToString().Trim() + " correct answers.";
                    if (numberOfCorrectAnswers == 1)
                    {
                        lblCorrectAnswers.Text = lblCorrectAnswers.Text.Replace("answers.", "answer.");
                    }
                }
                numberOfIncorrectAnswers = numberOfQuestions - numberOfCorrectAnswers;
                lblQuestions.Text = numberOfIncorrectAnswers.ToString().Trim() + " incorrect answers.";
                if (numberOfQuestions == 1)
                {
                    lblQuestions.Text = lblQuestions.Text.Replace("answers.", "answer.");
                }
                this.textBox1.Text = string.Empty;
                this.textBox1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please, enter a valid name of the city to continue...");
                this.textBox1.Text = string.Empty;
                this.textBox1.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(this.textBox1.Text))
            {
                checkCorrectAnswer();
                getDataFromDictionaryRandomly();
            }
            else
            {
                MessageBox.Show("Please, enter name of the city to continue...");
                this.textBox1.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button1.Enabled = true;
            this.button4.Enabled= false;
            label1.Text = "--- Country ---";
            lblQuestions.Text = "0 incorrect answers";
            lblCorrectAnswers.Text  = "0 correct answers";
        }
    }
}
