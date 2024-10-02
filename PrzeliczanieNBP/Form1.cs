using System.Windows.Forms;

namespace PrzeliczanieNBP
{
    public partial class FormPrzelicznikWalut : Form
    {
        Dictionary<string, decimal> WartoœæWalutyZPLN = new Dictionary<string, decimal> { };
        Dictionary<string, decimal> WartoœæWalutyDoPLN = new Dictionary<string, decimal> { };

        public FormPrzelicznikWalut()
        {
            InitializeComponent();

            NumBoxWalutaDoKalk.Controls.RemoveAt(0);
            NumBoxWalutaPoKalk.Controls.RemoveAt(0);

            WartoœæWalutyZPLN.Add("Dolar", Convert.ToDecimal(0.2626));
            WartoœæWalutyZPLN.Add("Euro", Convert.ToDecimal(0.2347));
            WartoœæWalutyZPLN.Add("Rubel", Convert.ToDecimal(24.3931));
            WartoœæWalutyZPLN.Add("Bat", Convert.ToDecimal(8.5834));

            WartoœæWalutyDoPLN.Add("Dolar", Convert.ToDecimal(3.8415));
            WartoœæWalutyDoPLN.Add("Euro", Convert.ToDecimal(4.2763));
            WartoœæWalutyDoPLN.Add("Rubel", Convert.ToDecimal(0.04138));
            WartoœæWalutyDoPLN.Add("Bat", Convert.ToDecimal(0.1183));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnKalkuluj_Click(object sender, EventArgs e)
        {
            if (RadBtnToUSD.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * WartoœæWalutyZPLN["Dolar"];
            }
            else if (RadBtnToEUR.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * WartoœæWalutyZPLN["Euro"];
            }
            else if (RadBtnToRUB.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * WartoœæWalutyZPLN["Rubel"];
            }
            else if (RadBtnToBAT.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * WartoœæWalutyZPLN["Bat"];
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
                NumBoxWalutaDoKalk.Value = NumBoxWalutaPoKalk.Value * WartoœæWalutyDoPLN["Dolar"];
            }
            else if (RadBtnToEUR.Checked)
            {
                NumBoxWalutaDoKalk.Value = NumBoxWalutaPoKalk.Value * WartoœæWalutyDoPLN["Euro"];
            }
            else if (RadBtnToRUB.Checked)
            {
                NumBoxWalutaDoKalk.Value = NumBoxWalutaPoKalk.Value * WartoœæWalutyDoPLN["Rubel"];
            }
            else if (RadBtnToBAT.Checked)
            {
                NumBoxWalutaDoKalk.Value = NumBoxWalutaPoKalk.Value * WartoœæWalutyDoPLN["Bat"];
            }
        }

        private void FormPrzelicznikWalut_Load(object sender, EventArgs e)
        {

        }
    }
}
