using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LlamandoDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Registrarse_Click(object sender, EventArgs e)
        {
            if (Password.Text == CheckPassw.Text)
            {
                if (UsuarioDAL.CrearCuenta(NameBox.Text, Password.Text) > 0)
                {
                    MessageBox.Show("Cuenta creada con exito");
                }
                else
                {
                    MessageBox.Show("error al registrar");
                }

            }
            else
            {
                Random random = new Random();
                int numero = random.Next(1, 9); // Genera un número entre 1 y 5 (el límite superior es exclusivo)

                switch (numero)
                {
                    case 1:
                        MessageBox.Show("su mama le dio un cromosoma de mas");
                        break;
                    case 2:
                        MessageBox.Show("¿por que su papa no lo abandono?");
                        break;
                    case 3:
                        MessageBox.Show("su mamá esta gorda quee");
                        MessageBox.Show("Que necesito dos cuadros de texto");
                        break;
                    case 4:
                        MessageBox.Show("eres imbecil o masticas agua?");
                        break;
                    case 5:
                        MessageBox.Show("Porque lo sigues intentando ");
                        break;
                    case 6:
                        MessageBox.Show("Su papá está tan imbécil que cuando se pone a pensar, el pensamiento se va de vacaciones");
                        break;
                    case 7:
                        MessageBox.Show("u mamá está tan gorda que cuando se pone un vestido con rayas, los satélites la confunden con una carretera.");
                        break;
                    case 8:
                        MessageBox.Show("kEscribe bien ni que te fuera a contagear de gonorrea con el teclado ");
                        break;
                    case 9:
                        MessageBox.Show("si llegas aqui no debistes nacer");
                        break;
                }
            }
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            IniciarSesion iniosSesion = new IniciarSesion();
            this.Hide();
            iniosSesion.Show();
        
        }
    }
}
