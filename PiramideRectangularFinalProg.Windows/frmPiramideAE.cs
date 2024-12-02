using PiramideRectangularFinalProg.Datos;
using PiramideRectangularFinalProg.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PiramideRectangularFinalProg.Windows
{
    public partial class frmPiramideAE : Form
    {
        private RepositorioDePiramides repositorio;

        public frmPiramideAE(RepositorioDePiramides repo)
        {
            InitializeComponent();
            repositorio = repo;
        }

      
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

      
        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
              
                if (string.IsNullOrWhiteSpace(txtLadoBase.Text) || string.IsNullOrWhiteSpace(txtAltura.Text))
                {
                    MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtLadoBase.Text, out int ladoBase) || !int.TryParse(txtAltura.Text, out int altura))
                {
                    MessageBox.Show("Por favor ingrese valores válidos para LadoBase y Altura.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                Material material;
                if (rbtnPlastico.Checked)
                {
                    material = Material.Plastico;
                }
                else if (rbtnVidrio.Checked)
                {
                    material = Material.Vidrio;
                }
                else if (rbtnMadera.Checked)
                {
                    material = Material.Madera;
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un material.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                
                PiramideRegular piramide = new PiramideRegular(ladoBase, altura, material);

              
                if (repositorio.AgregarPiramide(piramide))
                {
                    MessageBox.Show($"Piramide creada");
                    this.DialogResult = DialogResult.OK; 
                }
                else
                {
                    MessageBox.Show("La pirámide ya existe.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    
        private void frmPiramideAE_Load(object sender, EventArgs e)
        {
        }
    }
}