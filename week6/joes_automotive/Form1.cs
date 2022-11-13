using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace joes_automotive
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Method takes total without tax and returns total + 6%
        public double TaxCharges(double amount){
            return amount * 1.06;
        }

        // Method for calculating total
        public double TotalCharges(double oil, double flush, double misc, double laborAndParts){
            return oil + flush + misc + laborAndParts;
        }

        // Oil and lube
        public double OilLubeCharges(bool oil, bool lube){
          double oilCharge = oil ? 26.00 : 0.00;
          double lubeCharge = lube ? 18.00 : 0.00;
          return oilCharge + lubeCharge;
        }

        // Flush
        public double FlushCharges(bool radiator, bool transmission){
          double radiatorCharge = radiator ? 30.00 : 0.00;
          double transmissionCharge = transmission ? 80.00 : 0.00;
          return radiatorCharge + transmissionCharge;
        }

        // Misc
        public double MiscCharges(bool inspection, bool muffler, bool rotation){
          double inspectionCharge = inspection ? 15.00 : 0.00;
          double mufflerCharge = muffler ? 100.00 : 0.00;
          double rotationCharge = rotation ? 20.00 : 0.00;
          return inspectionCharge + mufflerCharge + rotationCharge;
        }

        // Labor and parts, (+ tax on parts!)
        public double OtherCharges(double hoursOfLabor, double partsCharge){
          double partsWithTax = TaxCharges(partsCharge); // Using method to get parts with tax
          double laborCharge = hoursOfLabor * 20.00;
          return partsWithTax + laborCharge;
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }
    }
}
