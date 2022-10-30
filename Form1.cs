namespace Sinema_Bufe_Satis_Uygulamasi_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int kasatoplam = 0;
        private void hesapla_Click(object sender, EventArgs e)
        {
            int su, cay, soda, msuyu, tkahve, cola, fanta, sprite, nescafe, cikolata, oralet;
            su = Convert.ToInt32(sutxt.Text);
            cay = Convert.ToInt32(caytxt.Text);
            soda = Convert.ToInt32(sodatxt.Text);
            msuyu=Convert.ToInt32(msuyutxt.Text);
            tkahve=Convert.ToInt32(tkahvetxt.Text);
            cola = Convert.ToInt32(colatxt.Text);
            fanta = Convert.ToInt32(fantatxt.Text);
            sprite = Convert.ToInt32(spritetxt.Text);
            nescafe = Convert.ToInt32(nescafetxt.Text);
            cikolata = Convert.ToInt32(cikolatatxt.Text);
            oralet = Convert.ToInt32(oralettxt.Text);

            int sufiyat, cayfiyat, sodafiyat, msuyufiyat, tkahvefiyat, colafiyat, fantafiyat, spritefiyat, nescafefiyat, cikolatafiyat, oraletfiyat;

            sufiyat = Convert.ToInt32(sufyt.Text);
            cayfiyat = Convert.ToInt32(cayfyt.Text);
            sodafiyat = Convert.ToInt32(sodafyt.Text);
            msuyufiyat = Convert.ToInt32(msuyufyt.Text);
            tkahvefiyat = Convert.ToInt32(tkahvefyt.Text);
            colafiyat = Convert.ToInt32(colafyt.Text);
            fantafiyat = Convert.ToInt32(fantafyt.Text);
            spritefiyat = Convert.ToInt32(spritefyt.Text);
            nescafefiyat = Convert.ToInt32(nescafefyt.Text);
            cikolatafiyat = Convert.ToInt32(cikolatafyt.Text);
            oraletfiyat = Convert.ToInt32(oraletfyt.Text);


            int toplam=(su*sufiyat + cay*cayfiyat + soda+sodafiyat + msuyu*msuyufiyat + tkahve*tkahvefiyat + cola*colafiyat + fanta*fantafiyat+ sprite*spritefiyat+ nescafe*nescafefiyat+cikolata*cikolatafiyat+ oralet*oraletfiyat);
            adisyon.Text=Convert.ToString(toplam);

            kasatoplam = kasatoplam + toplam;
            kasaToplam.Text = Convert.ToString(kasatoplam);
        }

        private void Temizle_Click(object sender, EventArgs e)
        {
            sutxt.Text = "";
            caytxt.Text = "";
            sodatxt.Text = "";
            msuyutxt.Text = "";
            tkahvetxt.Text = "";
            colatxt.Text = "";
            fantatxt.Text = "";
            spritetxt.Text = "";
            nescafetxt.Text = "";
            cikolatatxt.Text = "";
            oralettxt.Text = "";
            adisyon.Text = "";
        }

        private void Sifirla_Click(object sender, EventArgs e)
        {
            kasaToplam.Text = "";
        }
    }
}