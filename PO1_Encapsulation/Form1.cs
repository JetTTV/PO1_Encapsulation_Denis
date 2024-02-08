namespace PO1_Encapsulation
{
    public partial class Form1 : Form
    {
        Personnage joueur = new Personnage();
        Personnage dragon = new Personnage();
        public Form1()
        {
            InitializeComponent();
            joueur.Pv = 10;
            dragon.Pv = joueur.Pv * 3;
            joueur.Strength = 1;
            dragon.Strength = joueur.Strength * 3;

            MessageBox.Show(joueur.Pv.ToString());
            
        }

        private void ActualiserLabel()
        {
            lbl_pointsVieJoueur.Text = "Health Points: " + joueur.Pv.ToString();
            lbl_pointsVieDragon.Text = "Health Points: " + dragon.Pv.ToString();
            lbl_puissanceAttaqueJoueur.Text ="Attack Power: " + joueur.Strength.ToString();
            lbl_puissanceAttaqueDragon.Text = "Attack Power: " + dragon.Strength.ToString();
        }
        private void btn_attaquer_Click(object sender, EventArgs e)
        {
            dragon.Pv -= joueur.Strength;
            TourDragon();
            ActualiserLabel();
        }

        private void btn_seSoigner_Click(object sender, EventArgs e)
        {
            joueur.Pv += 5;
            TourDragon();
            ActualiserLabel();
            joueur.Pv = Math.Clamp(joueur.Pv, 0, 10);

        private void btn_puissanceAttaque_Click(object sender, EventArgs e)
        {
            joueur.Strength += 1;
            TourDragon();
            ActualiserLabel();
        }

        private void TourDragon()
        {
            joueur.Pv -= dragon.Strength;
        }
    }
}