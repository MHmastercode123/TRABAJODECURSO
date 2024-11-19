namespace TRABAJODECURSO
{
    partial class FrmmenuPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmmenuPrincipal));
            splitContainer1 = new SplitContainer();
            groupBox3 = new GroupBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            groupBox2 = new GroupBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button3 = new Button();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            gESTIONDERESERVASToolStripMenuItem = new ToolStripMenuItem();
            gESTIONDECLIENTESToolStripMenuItem = new ToolStripMenuItem();
            gESTIONDEHABITACIONESToolStripMenuItem = new ToolStripMenuItem();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox3);
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            splitContainer1.Panel1.Controls.Add(menuStrip1);
            splitContainer1.Panel1.RightToLeft = RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tabControl1);
            splitContainer1.Panel2.RightToLeft = RightToLeft.No;
            splitContainer1.Size = new Size(914, 625);
            splitContainer1.SplitterDistance = 159;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ButtonFace;
            groupBox3.Controls.Add(button7);
            groupBox3.Controls.Add(button8);
            groupBox3.Controls.Add(button9);
            groupBox3.Cursor = Cursors.Hand;
            groupBox3.Dock = DockStyle.Left;
            groupBox3.Location = new Point(503, 33);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(250, 126);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Visible = false;
            // 
            // button7
            // 
            button7.Dock = DockStyle.Left;
            button7.Location = new Point(165, 24);
            button7.Margin = new Padding(3, 4, 3, 4);
            button7.Name = "button7";
            button7.Size = new Size(81, 98);
            button7.TabIndex = 5;
            button7.Text = "Eliminar habitacion";
            button7.UseVisualStyleBackColor = true;
            button7.Click += EliminarHabitacion;
            // 
            // button8
            // 
            button8.Dock = DockStyle.Left;
            button8.Location = new Point(84, 24);
            button8.Margin = new Padding(3, 4, 3, 4);
            button8.Name = "button8";
            button8.Size = new Size(81, 98);
            button8.TabIndex = 6;
            button8.Text = "Editar habitacion";
            button8.UseVisualStyleBackColor = true;
            button8.Click += EditarHabitacion;
            // 
            // button9
            // 
            button9.BackgroundImageLayout = ImageLayout.Stretch;
            button9.Dock = DockStyle.Left;
            button9.Location = new Point(3, 24);
            button9.Margin = new Padding(3, 4, 3, 4);
            button9.Name = "button9";
            button9.RightToLeft = RightToLeft.No;
            button9.Size = new Size(81, 98);
            button9.TabIndex = 4;
            button9.Text = "Añadir habitacion";
            button9.TextImageRelation = TextImageRelation.ImageAboveText;
            button9.UseVisualStyleBackColor = true;
            button9.Click += AñadirHabitacion;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ButtonFace;
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(button5);
            groupBox2.Controls.Add(button6);
            groupBox2.Cursor = Cursors.Hand;
            groupBox2.Dock = DockStyle.Left;
            groupBox2.Location = new Point(253, 33);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(250, 126);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Visible = false;
            // 
            // button4
            // 
            button4.Dock = DockStyle.Left;
            button4.Location = new Point(165, 24);
            button4.Margin = new Padding(3, 4, 3, 4);
            button4.Name = "button4";
            button4.Size = new Size(81, 98);
            button4.TabIndex = 5;
            button4.Text = "Eliminar cliente";
            button4.UseVisualStyleBackColor = true;
            button4.Click += EliminarCliente;
            // 
            // button5
            // 
            button5.Dock = DockStyle.Left;
            button5.Location = new Point(84, 24);
            button5.Margin = new Padding(3, 4, 3, 4);
            button5.Name = "button5";
            button5.Size = new Size(81, 98);
            button5.TabIndex = 6;
            button5.Text = "Editar cliente";
            button5.UseVisualStyleBackColor = true;
            button5.Click += EditarClientes;
            // 
            // button6
            // 
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.Dock = DockStyle.Left;
            button6.Location = new Point(3, 24);
            button6.Margin = new Padding(3, 4, 3, 4);
            button6.Name = "button6";
            button6.RightToLeft = RightToLeft.No;
            button6.Size = new Size(81, 98);
            button6.TabIndex = 4;
            button6.Text = "Añadir cliente";
            button6.TextImageRelation = TextImageRelation.ImageAboveText;
            button6.UseVisualStyleBackColor = true;
            button6.Click += AñadirClientes;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ButtonFace;
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button3);
            groupBox1.Controls.Add(button1);
            groupBox1.Cursor = Cursors.Hand;
            groupBox1.Dock = DockStyle.Left;
            groupBox1.Location = new Point(0, 33);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(253, 126);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Left;
            button2.Location = new Point(165, 24);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(81, 98);
            button2.TabIndex = 2;
            button2.Text = "Eliminar reserva";
            button2.UseVisualStyleBackColor = true;
            button2.Click += EliminarReserva;
            // 
            // button3
            // 
            button3.Dock = DockStyle.Left;
            button3.Location = new Point(84, 24);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(81, 98);
            button3.TabIndex = 3;
            button3.Text = "Editar reserva";
            button3.UseVisualStyleBackColor = true;
            button3.Click += EditarReserva;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.Dock = DockStyle.Left;
            button1.Location = new Point(3, 24);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.No;
            button1.Size = new Size(81, 98);
            button1.TabIndex = 1;
            button1.Text = "Añadir reserva";
            button1.TextImageRelation = TextImageRelation.ImageAboveText;
            button1.UseVisualStyleBackColor = true;
            button1.Click += AñadirReserva;
            // 
            // menuStrip1
            // 
            menuStrip1.BackColor = Color.Maroon;
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { gESTIONDERESERVASToolStripMenuItem, gESTIONDECLIENTESToolStripMenuItem, gESTIONDEHABITACIONESToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 33);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // gESTIONDERESERVASToolStripMenuItem
            // 
            gESTIONDERESERVASToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gESTIONDERESERVASToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            gESTIONDERESERVASToolStripMenuItem.Image = (Image)resources.GetObject("gESTIONDERESERVASToolStripMenuItem.Image");
            gESTIONDERESERVASToolStripMenuItem.Name = "gESTIONDERESERVASToolStripMenuItem";
            gESTIONDERESERVASToolStripMenuItem.Size = new Size(271, 27);
            gESTIONDERESERVASToolStripMenuItem.Text = "GESTION DE RESERVAS";
            gESTIONDERESERVASToolStripMenuItem.Click += gESTIONDERESERVASToolStripMenuItem_Click;
            // 
            // gESTIONDECLIENTESToolStripMenuItem
            // 
            gESTIONDECLIENTESToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gESTIONDECLIENTESToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            gESTIONDECLIENTESToolStripMenuItem.Image = (Image)resources.GetObject("gESTIONDECLIENTESToolStripMenuItem.Image");
            gESTIONDECLIENTESToolStripMenuItem.Name = "gESTIONDECLIENTESToolStripMenuItem";
            gESTIONDECLIENTESToolStripMenuItem.Size = new Size(269, 27);
            gESTIONDECLIENTESToolStripMenuItem.Text = "GESTION DE CLIENTES";
            gESTIONDECLIENTESToolStripMenuItem.Click += gESTIONDECLIENTESToolStripMenuItem_Click;
            // 
            // gESTIONDEHABITACIONESToolStripMenuItem
            // 
            gESTIONDEHABITACIONESToolStripMenuItem.BackgroundImageLayout = ImageLayout.Stretch;
            gESTIONDEHABITACIONESToolStripMenuItem.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gESTIONDEHABITACIONESToolStripMenuItem.ForeColor = SystemColors.ButtonHighlight;
            gESTIONDEHABITACIONESToolStripMenuItem.Image = (Image)resources.GetObject("gESTIONDEHABITACIONESToolStripMenuItem.Image");
            gESTIONDEHABITACIONESToolStripMenuItem.ImageTransparentColor = Color.White;
            gESTIONDEHABITACIONESToolStripMenuItem.Name = "gESTIONDEHABITACIONESToolStripMenuItem";
            gESTIONDEHABITACIONESToolStripMenuItem.Size = new Size(321, 27);
            gESTIONDEHABITACIONESToolStripMenuItem.Text = "GESTION DE HABITACIONES";
            gESTIONDEHABITACIONESToolStripMenuItem.Click += gESTIONDEHABITACIONESToolStripMenuItem_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 461);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(906, 428);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(906, 428);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // FrmmenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 625);
            Controls.Add(splitContainer1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmmenuPrincipal";
            Text = "MENU PRINCIPAL";
            Load += Form1_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem gESTIONDERESERVASToolStripMenuItem;
        private ToolStripMenuItem gESTIONDECLIENTESToolStripMenuItem;
        private ToolStripMenuItem gESTIONDEHABITACIONESToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button button3;
        private Button button2;
        private Button button1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Button button4;
        private Button button5;
        private Button button6;
        private GroupBox groupBox3;
        private Button button7;
        private Button button8;
        private Button button9;
    }
}
