namespace TRABAJODECURSO
{
    public partial class Form1 : Form
    {
        bool visiblemenu = false;
        public Form1()
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
            groupBox1 .Visible = false;
        }

        private void gESTIONDEHABITACIONESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            visiblemenu = !visiblemenu;
            groupBox3.Visible = visiblemenu;
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }
    }
}
