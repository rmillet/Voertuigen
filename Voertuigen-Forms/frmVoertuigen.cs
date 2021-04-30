using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Voertuigen_Business;

namespace Voertuigen_Forms
{
    public partial class frmVoertuigen : Form
    {
        //we maken objecten van de verschillende klassen waarmee we gaan spelen.
        private Fiets _velo;
        private Auto _wagen;

        public frmVoertuigen()
        {
            InitializeComponent();            
        }
              

       
        private void btnToon2_Click(object sender, EventArgs e)
        {
            //invoer van data
            if (radAuto.Checked == true)
            {
                _wagen = new Auto();
                if (chkMotor.Checked == true)
                {
                    _wagen.Motor = true;
                }
                else
                {
                    _wagen.Motor = false;
                }
                _wagen.AantalWielen = Convert.ToInt32(txtAantalWielen.Text);
                _wagen.Nummerplaat = txtNummerplaat.Text;
                _wagen.Merk = txtMerk.Text;

                //uitvoer
                lblDetails.Text = _wagen.getDetails();
            }
            else
            {
                _velo = new Fiets();
                if (chkMotor.Checked==true)
                {
                    _velo.Motor = true;
                }
                else
                {
                    _velo.Motor = false;
                }
                if (chkBagagedrager.Checked == true)
                {
                    _velo.Bagagedrager = true;
                }
                else
                {
                    _velo.Bagagedrager = false;

                }
                _velo.Merk = txtMerk.Text;
                _velo.AantalWielen = Convert.ToInt32(txtAantalWielen.Text);

                //uitvoer
                lblDetails.Text = _velo.getDetails() + " " + _velo.Motor;
            }

           
        }
       

        private void KeuzeVoertuig(object sender, EventArgs e)
        {
            if (radAuto.Checked == true)
            {
                lblNummerplaat.Visible = true;
                chkBagagedrager.Visible = false;
                txtNummerplaat.Visible = true;
            }
            else
            {
                lblNummerplaat.Visible = false;
                chkBagagedrager.Visible = true;                
                txtNummerplaat.Visible = false;
            }
        }
    }
}
