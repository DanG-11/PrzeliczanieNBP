using System.Windows.Forms;

namespace PrzeliczanieNBP
{
    public partial class FormPrzelicznikWalut : Form
    {
        Dictionary<string, decimal> exchangeRates = new Dictionary<string, decimal> { };

        public FormPrzelicznikWalut()
        {
            InitializeComponent();
            NumBoxWalutaDoKalk.Controls.RemoveAt(0);
            NumBoxWalutaPoKalk.Controls.RemoveAt(0);
            exchangeRates.Add("Dolar", Convert.ToDecimal(0.2626));
            exchangeRates.Add("Euro", Convert.ToDecimal(0.2347));
            exchangeRates.Add("Rubel", Convert.ToDecimal(24.3931));
            exchangeRates.Add("Bat", Convert.ToDecimal(8.5834));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnKalkuluj_Click(object sender, EventArgs e)
        {
            if (RadBtnToUSD.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * exchangeRates["Dolar"];
                LblWalutaPoKalk.Text = "Dolar";
            }
            else if (RadBtnToEUR.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * exchangeRates["Euro"];
                LblWalutaPoKalk.Text = "Euro";
            }
            else if (RadBtnToRUB.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * exchangeRates["Rubel"];
                LblWalutaPoKalk.Text = "Rubel";
            }
            else if (RadBtnToBAT.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * exchangeRates["Bat"];
                LblWalutaPoKalk.Text = "Bat";
            }
        }
    }
}
