using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KApitel8
{
    public partial class sten_sax_påse : Form
    {
        int nrDatorVinster; //gör om koden till tal.
        int nrSpelarVinster; //gör om koden till tal.

        public sten_sax_påse()
        {
            InitializeComponent();
        }

        private void btnSpela_Click(object sender, EventArgs e) //aktiverade knappen
        {
            gbxStenSaxPåse.Enabled = true; // aktiverar groupboxen StenSaxPåse
            btnSpela.Enabled = false; // aktiverar knappen Spela
            lblDatornsVal.Text = " "; // tömer etiketten Datornsval
            lblResultat.Text = " "; //Tömer etiketten Resultat
            nrDatorVinster = 0; // Sätter antalet datorvinster till 0
            nrSpelarVinster = 0; // sätter antalet spelarvinster till 0

        }

        private void pbxSten_Click(object sender, EventArgs e) 
        {
            Random slump = new Random();//Gör så att datorn slumpar mellan 1 till 3
            int datornsTal = slump.Next(1, 04);
            String datornsVal = " "; // skriver om talet till bokstäver
            switch (datornsTal)
            {
                case 1:
                    datornsVal = "Sten";
                    break;
                case 2:
                    datornsVal = "Sax";
                    break;
                case 3:
                    datornsVal = "Påse";
                    break;
            }//om datorn väljer påse vinner datorn.
            lblDatornsVal.Text = datornsVal; //om datorn väljer Sax vinner spelaren.
            
            if (datornsVal.Equals("Sax"))
            {
                nrSpelarVinster++;
            }
            else if (datornsVal.Equals("Påse"))
            {
                nrDatorVinster++;
            }
            //visa aktuell ställning i ettiketen resultat.
            lblResultat.Text = "Dator: " + nrDatorVinster + " Spelar: " + nrSpelarVinster;
            //kontrollera om datorn eller spelaren vunnit omgången
            if (nrDatorVinster > 2 || nrSpelarVinster > 2)
            {
                gbxStenSaxPåse.Enabled = false;
                btnSpela.Enabled = true;
                tbxMinaResultat.AppendText("dator: " + nrDatorVinster + " Spelar: "
                    + nrSpelarVinster + "\r\n");
            }

        }

        private void pbxSax_Click(object sender, EventArgs e)
        {
            Random slump = new Random();//Gör så att datorn slumpar mellan 1 till 3
            int datornsTal = slump.Next(1, 04);
            String datornsVal = " "; // skriver om talet till bokstäver
            switch (datornsTal)
            {
                case 1:
                    datornsVal = "Sten";
                    break;
                case 2:
                    datornsVal = "Sax";
                    break;
                case 3:
                    datornsVal = "Påse";
                    break;
            }//om datorn väljer påse vinner datorn.
            lblDatornsVal.Text = datornsVal; //om datorn väljer Sax vinner spelaren.

            if (datornsVal.Equals("Påse"))
            {
                nrSpelarVinster++;
            }
            else if (datornsVal.Equals("Sten"))
            {
                nrDatorVinster++;
            }
            //visa aktuell ställning i ettiketen resultat.
            lblResultat.Text = "Dator: " + nrDatorVinster + " Spelar: " + nrSpelarVinster;
            //kontrollera om datorn eller spelaren vunnit omgången
            if (nrDatorVinster > 2 || nrSpelarVinster > 2)
            {
                gbxStenSaxPåse.Enabled = false;
                btnSpela.Enabled = true;
                tbxMinaResultat.AppendText("dator: " + nrDatorVinster + " Spelar: "
                    + nrSpelarVinster + "\r\n");
            }
        }

        private void pbxPåse_Click(object sender, EventArgs e)
        {
            Random slump = new Random();//Gör så att datorn slumpar mellan 1 till 3
            int datornsTal = slump.Next(1, 04);
            String datornsVal = " "; // skriver om talet till bokstäver
            switch (datornsTal)
            {
                case 1:
                    datornsVal = "Sten";
                    break;
                case 2:
                    datornsVal = "Sax";
                    break;
                case 3:
                    datornsVal = "Påse";
                    break;
            }//om datorn väljer påse vinner datorn.
            lblDatornsVal.Text = datornsVal; //om datorn väljer Sax vinner spelaren.

            if (datornsVal.Equals("Sten"))
            {
                nrSpelarVinster++;
            }
            else if (datornsVal.Equals("Sax"))
            {
                nrDatorVinster++;
            }
            //visa aktuell ställning i ettiketen resultat.
            lblResultat.Text = "Dator: " + nrDatorVinster + " Spelar: " + nrSpelarVinster;
            //kontrollera om datorn eller spelaren vunnit omgången
            if (nrDatorVinster > 2 || nrSpelarVinster > 2)
            {
                gbxStenSaxPåse.Enabled = false;
                btnSpela.Enabled = true;
                tbxMinaResultat.AppendText("dator: " + nrDatorVinster + " Spelar: "
                    + nrSpelarVinster + "\r\n");
            }
        }
    }
}
