using System.Windows.Forms;

namespace PrzeliczanieNBP
{
    public partial class FormPrzelicznikWalut : Form
    {

        public FormPrzelicznikWalut()
        {
            InitializeComponent();
            NumBoxWalutaDoKalk.Controls.RemoveAt(0);
            NumBoxWalutaPoKalk.Controls.RemoveAt(0);
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnKalkuluj_Click(object sender, EventArgs e)
        {

            decimal Dolar = Convert.ToDecimal(0.26);
            decimal Euro = Convert.ToDecimal(0.23);
            decimal Rubel = Convert.ToDecimal(24.38);
            decimal Bat = Convert.ToDecimal(8.58);

            if (RadBtnToUSD.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * Dolar;
                LblWalutaPoKalk.Text = "Dolar";
            }
            else if (RadBtnToEUR.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * Euro;
                LblWalutaPoKalk.Text = "Euro";
            }
            else if (RadBtnToRUB.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * Rubel;
                LblWalutaPoKalk.Text = "Rubel";
            }
            else if (RadBtnToBAT.Checked)
            {
                NumBoxWalutaPoKalk.Value = NumBoxWalutaDoKalk.Value * Bat;
                LblWalutaPoKalk.Text = "Bat";
            }
        }
    }
}
