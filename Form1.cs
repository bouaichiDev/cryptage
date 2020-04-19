using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cryptage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       public static Event Event = new Event();
        private void DecrypteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string decryptTxt = Event.Decrypt(Crypte.Text);
                decrypte.Text = decryptTxt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chaine invalide", "Erreur", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
          
        }

        private void CrypteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string cryptTxt = Event.Encrypt(decrypte.Text);
                Crypte.Text = cryptTxt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Chaine invalide", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Crypte.Text = "";
        }

        private void clear__Click(object sender, EventArgs e)
        {
            decrypte.Text = "";
        }
    }
}
