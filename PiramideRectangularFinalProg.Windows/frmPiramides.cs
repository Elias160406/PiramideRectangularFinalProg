using PiramideRectangularFinalProg.Datos;

namespace PiramideRectangularFinalProg.Windows
{
    
    public partial class frmPiramides : Form
    {
        private RepositorioDePiramides repositorio;
        public frmPiramides()
        {
            InitializeComponent();
            repositorio = new RepositorioDePiramides();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
          
            frmPiramideAE formPiramideAE = new frmPiramideAE(repositorio);

            
            formPiramideAE.ShowDialog();

            
            ActualizarGrilla();

        }
        private void ActualizarGrilla()
        {
            
            dgvDatos.DataSource = null;

            
            dgvDatos.DataSource = repositorio.ObtenerPiramides();
            
            dgvDatos.Columns.Clear();

            
            dgvDatos.Columns.Add("LadoBase", "Lado Base");
            dgvDatos.Columns.Add("Altura", "Altura");
            dgvDatos.Columns.Add("Material", "Material");

            
            foreach (var piramide in repositorio.ObtenerPiramides())
            {
                dgvDatos.Rows.Add(piramide.LadoBase, piramide.Altura, piramide.Material);
            }
        }
    }
    }

 

