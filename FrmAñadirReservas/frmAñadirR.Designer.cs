namespace FrmAñadirReservas
{
    partial class frmAñadirR
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
            label1 = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            label4 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            button2 = new Button();
            label5 = new Label();
            comboBox2 = new ComboBox();
            listView1 = new ListView();
            button3 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(67, 9);
            label1.Name = "label1";
            label1.Size = new Size(260, 26);
            label1.TabIndex = 0;
            label1.Text = "GESTOR DE RESERVAS";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(144, 40);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(114, 27);
            dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(319, 40);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(114, 27);
            dateTimePicker2.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 45);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 3;
            label2.Text = "Fecha de inicio ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 45);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 4;
            label3.Text = "Hasta";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(41, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(469, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(20, 45);
            label4.Name = "label4";
            label4.Size = new Size(105, 20);
            label4.TabIndex = 6;
            label4.Text = "Elija el cliente ";
            label4.Click += label4_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(131, 43);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(319, 42);
            button1.Name = "button1";
            button1.Size = new Size(132, 29);
            button1.TabIndex = 8;
            button1.Text = "Nuevo cliente ?";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(comboBox1);
            groupBox2.Location = new Point(41, 146);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(469, 100);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(label5);
            groupBox3.Controls.Add(comboBox2);
            groupBox3.Location = new Point(41, 252);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(469, 100);
            groupBox3.TabIndex = 10;
            groupBox3.TabStop = false;
            groupBox3.Text = "groupBox3";
            // 
            // button2
            // 
            button2.Location = new Point(328, 26);
            button2.Name = "button2";
            button2.Size = new Size(123, 58);
            button2.TabIndex = 2;
            button2.Text = "No hay habitaciones ?";
            button2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 37);
            label5.Name = "label5";
            label5.Size = new Size(131, 40);
            label5.TabIndex = 1;
            label5.Text = "Elija la habitacion \r\ndisponible";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(157, 37);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 0;
            // 
            // listView1
            // 
            listView1.Location = new Point(537, 47);
            listView1.Name = "listView1";
            listView1.Size = new Size(240, 326);
            listView1.TabIndex = 12;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // button3
            // 
            button3.Location = new Point(50, 370);
            button3.Name = "button3";
            button3.Size = new Size(211, 29);
            button3.TabIndex = 13;
            button3.Text = "GUARDAR DATOS";
            button3.UseVisualStyleBackColor = true;
            // 
            // frmAñadirR
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(listView1);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmAñadirR";
            Text = "GESTOR DE RESERVAS";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Label label3;
        private GroupBox groupBox1;
        private Label label4;
        private ComboBox comboBox1;
        private Button button1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label5;
        private ComboBox comboBox2;
        private Button button2;
        private ListView listView1;
        private Button button3;
    }
}
