using FrmAñadirReservas;

namespace TRABAJODECURSO
{
    public partial class FrmmenuPrincipal : Form
    {
        bool visiblemenu = false;
        public FrmmenuPrincipal()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void gESTIONDERESERVASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visiblemenu = !visiblemenu;
            groupBox1.Visible = visiblemenu;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
        }

        private void gESTIONDECLIENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visiblemenu = !visiblemenu;
            groupBox2.Visible = visiblemenu;
            groupBox3.Visible = false;
            groupBox1.Visible = false;
        }

        private void gESTIONDEHABITACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visiblemenu = !visiblemenu;
            groupBox3.Visible = visiblemenu;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void AñadirReserva(object sender, EventArgs e)
        {
            CargarFormularioInternoEnTabPage();
            
            
        }

        private void CargarFormularioInternoEnTabPage()
        {
            // Crear una instancia del formulario interno
            frmAñadirR formularAñadirR = new frmAñadirR();

            // Configurar el formulario interno
            formularAñadirR.TopLevel = false; // Importante para que se pueda mostrar en el contenedor
            formularAñadirR.FormBorderStyle = FormBorderStyle.None; // Quitar bordes
            formularAñadirR.Dock = DockStyle.Fill; // Llenar el Panel

            // Verificar si el TabPage ya tiene un Panel para evitar excepciones
            if (tabPage1.Controls["panelFormulario"] == null)
            {
                // Crear un Panel para contener el formulario interno
                Panel panel = new Panel
                {
                    Name = "panelFormulario", // Asignar un nombre para referencia
                    Dock = DockStyle.Fill // Llenar el TabPage
                };

                // Agregar el Panel al TabPage
                tabPage1.Controls.Add(panel);
            }
     
            Panel existePanel = (Panel)tabPage1.Controls["panelFormulario"];
            existePanel.Controls.Clear();
            existePanel.Controls.Add(formularAñadirR);

            tabPage1.Text = "Añadir reservas";
              
            formularAñadirR.Show();
        }

            private void EditarReserva(object sender, EventArgs e)
        {

        }

        private void EliminarReserva(object sender, EventArgs e)
        {

        }

        private void AñadirClientes(object sender, EventArgs e)
        {

        }

        private void EditarClientes(object sender, EventArgs e)
        {

        }

        private void EliminarCliente(object sender, EventArgs e)
        {

        }

        private void AñadirHabitacion(object sender, EventArgs e)
        {

        }

        private void EditarHabitacion(object sender, EventArgs e)
        {

        }

        private void EliminarHabitacion(object sender, EventArgs e)
        {

        }
    }
}
