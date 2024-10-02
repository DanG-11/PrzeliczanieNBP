using System.Windows.Forms;

namespace PrzeliczanieNBP
{
    public partial class FormPrzelicznikWalut : Form
    {
        Dictionary<string, decimal> Warto��WalutyZPLN = new Dictionary<string, decimal> { };
        Dictionary<string, decimal> Warto��WalutyDoPLN = new Dictionary<string, decimal> { };

        public FormPrzelicznikWalut()
        {
            InitializeComponent();

            NumBoxWalutaDoKalk.Controls.RemoveAt(0);
            NumBoxWalutaPoKalk.Controls.RemoveAt(0);

            Warto��WalutyZPLN.Add("Dolar", Convert.ToDecimal(0.2626));
            Warto��WalutyZPLN.Add("Euro", Convert.ToDecimal(0.2347));
            Warto��WalutyZPLN.Add("Rubel", Convert.ToDecimal(24.3931));
            Warto��WalutyZPLN.Add("Bat", Convert.ToDecimal(8.5834));

            Warto��WalutyDoPLN.Add("Dolar", Convert.ToDecimal(3.8415));
            Warto��WalutyDoPLN.Add("Euro", Convert.ToDecimal(4.2763));
            Warto��WalutyDoPLN.Add("Rubel", Convert.ToDecimal(0.04138));
            Warto��WalutyDoPLN.Add("Bat", Convert.ToDecimal(0.1183));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnKalkuluj_Click(object sender, EventArgs e)
        {
            if (RadBtnToUSD.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * Warto��WalutyZPLN["Dolar"];
            }
            else if (RadBtnToEUR.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * Warto��WalutyZPLN["Euro"];
            }
            else if (RadBtnToRUB.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * Warto��WalutyZPLN["Rubel"];
            }
            else if (RadBtnToBAT.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * Warto��WalutyZPLN["Bat"];
            }
        }

        private void RadBtnToUSD_CheckedChanged(object sender, EventArgs e)
        {
            LblWalutaPoKalk.Text = "Dolar";
        }

        private void RadBtnToEUR_CheckedChanged(object sender, EventArgs e)
        {
            LblWalutaPoKalk.Text = "Euro";
        }

        private void RadBtnToRUB_CheckedChanged(object sender, EventArgs e)
        {
            LblWalutaPoKalk.Text = "Rubel";
        }

        private void RadBtnToBAT_CheckedChanged(object sender, EventArgs e)
        {
            LblWalutaPoKalk.Text = "Bat";
        }

        private void BtnKalkulujDoPLN_Click(object sender, EventArgs e)
        {
            if (RadBtnToUSD.Checked)
            {
                NumBoxWalutaDoKalk.Value = NumBoxWalutaPoKalk.Value * Warto��WalutyDoPLN["Dolar"];
            }
            else if (RadBtnToEUR.Checked)
            {
                NumBoxWalutaDoKalk.Value = NumBoxWalutaPoKalk.Value * Warto��WalutyDoPLN["Euro"];
            }
            else if (RadBtnToRUB.Checked)
            {
                NumBoxWalutaDoKalk.Value = NumBoxWalutaPoKalk.Value * Warto��WalutyDoPLN["Rubel"];
            }
            else if (RadBtnToBAT.Checked)
            {
                NumBoxWalutaDoKalk.Value = NumBoxWalutaPoKalk.Value * Warto��WalutyDoPLN["Bat"];
            }
        }

        private void FormPrzelicznikWalut_Load(object sender, EventArgs e)
        {

        }
    }
}
