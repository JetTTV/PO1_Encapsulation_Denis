namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Personnage joueur = new Personnage();
            joueur.Pv = 10;
            MessageBox.Show(joueur.Pv.ToString());
            DateTime rightNow = DateTime.Now;
            rightNow
        }

        private void btn_attaquer_Click(object sender, EventArgs e)
        {

        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {

        }

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {

        }
    }
}