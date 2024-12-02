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
            dgvDatos.Columns.Clear();

            dgvDatos.Columns.Add("Lado", "Lado Base");
            dgvDatos.Columns.Add("Cantidad", "Cantidad de Lados");
            dgvDatos.Columns.Add("Material", "Material");
            dgvDatos.Columns.Add("Volumen", "Volumen");
            dgvDatos.Columns.Add("Area", "Área Total");

            foreach (var piramide in repositorio.ObtenerPiramides())
            {
                dgvDatos.Rows.Add(
                    piramide.LadoBase,
                    4,
                    piramide.Material.ToString(),
                    piramide.Volumen.ToString("F2"),
                    piramide.AreaTotal.ToString("F2")
                );
            }
        }
    }
    }
        




