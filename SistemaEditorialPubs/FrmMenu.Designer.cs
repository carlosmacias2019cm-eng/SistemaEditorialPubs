namespace SistemaEditorialPubs
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            panel1 = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            btnAutores = new Button();
            btnEditoriales = new Button();
            btnTitulos = new Button();
            bntAutoresPorTitulo = new Button();
            bntTiendas = new Button();
            bntVentas = new Button();
            btnRegalias = new Button();
            btnDescuentos = new Button();
            btnPuestos = new Button();
            btnInformacionEditorial = new Button();
            btnEmpleados = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkCyan;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(322, 676);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(51, 417);
            label2.Name = "label2";
            label2.Size = new Size(201, 20);
            label2.TabIndex = 3;
            label2.Text = "Gestión de publicaciones";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(42, 129);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(224, 210);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(21, 362);
            label1.Name = "label1";
            label1.Size = new Size(268, 38);
            label1.TabIndex = 1;
            label1.Text = "Sistema Editorial";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkGreen;
            label3.Location = new Point(484, 104);
            label3.Name = "label3";
            label3.Size = new Size(387, 25);
            label3.TabIndex = 2;
            label3.Text = "Seleccione una opción para continuar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkGreen;
            label4.Location = new Point(525, 27);
            label4.Name = "label4";
            label4.Size = new Size(311, 51);
            label4.TabIndex = 3;
            label4.Text = "Menú principal";
            // 
            // btnAutores
            // 
            btnAutores.BackColor = Color.DarkGreen;
            btnAutores.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAutores.ForeColor = Color.Transparent;
            btnAutores.Location = new Point(373, 201);
            btnAutores.Name = "btnAutores";
            btnAutores.Size = new Size(161, 63);
            btnAutores.TabIndex = 4;
            btnAutores.Text = "Autores";
            btnAutores.UseVisualStyleBackColor = false;
            btnAutores.Click += btnAutores_Click;
            // 
            // btnEditoriales
            // 
            btnEditoriales.BackColor = Color.DarkGreen;
            btnEditoriales.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditoriales.ForeColor = Color.Transparent;
            btnEditoriales.Location = new Point(593, 201);
            btnEditoriales.Name = "btnEditoriales";
            btnEditoriales.Size = new Size(161, 63);
            btnEditoriales.TabIndex = 5;
            btnEditoriales.Text = "Editoriales";
            btnEditoriales.UseVisualStyleBackColor = false;
            btnEditoriales.Click += btnEditoriales_Click;
            // 
            // btnTitulos
            // 
            btnTitulos.BackColor = Color.DarkGreen;
            btnTitulos.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTitulos.ForeColor = Color.Transparent;
            btnTitulos.Location = new Point(373, 284);
            btnTitulos.Name = "btnTitulos";
            btnTitulos.Size = new Size(161, 62);
            btnTitulos.TabIndex = 6;
            btnTitulos.Text = "Títulos";
            btnTitulos.UseVisualStyleBackColor = false;
            btnTitulos.Click += btnTitulos_Click;
            // 
            // bntAutoresPorTitulo
            // 
            bntAutoresPorTitulo.BackColor = Color.DarkGreen;
            bntAutoresPorTitulo.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntAutoresPorTitulo.ForeColor = Color.Transparent;
            bntAutoresPorTitulo.Location = new Point(398, 463);
            bntAutoresPorTitulo.Name = "bntAutoresPorTitulo";
            bntAutoresPorTitulo.Size = new Size(242, 63);
            bntAutoresPorTitulo.TabIndex = 7;
            bntAutoresPorTitulo.Text = "Autores por título";
            bntAutoresPorTitulo.UseVisualStyleBackColor = false;
            bntAutoresPorTitulo.Click += bntAutoresPorTitulo_Click;
            // 
            // bntTiendas
            // 
            bntTiendas.BackColor = Color.DarkGreen;
            bntTiendas.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntTiendas.ForeColor = Color.Transparent;
            bntTiendas.Location = new Point(808, 362);
            bntTiendas.Name = "bntTiendas";
            bntTiendas.Size = new Size(163, 61);
            bntTiendas.TabIndex = 8;
            bntTiendas.Text = "Tiendas";
            bntTiendas.UseVisualStyleBackColor = false;
            bntTiendas.Click += bntTiendas_Click;
            // 
            // bntVentas
            // 
            bntVentas.BackColor = Color.DarkGreen;
            bntVentas.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bntVentas.ForeColor = Color.Transparent;
            bntVentas.Location = new Point(373, 365);
            bntVentas.Name = "bntVentas";
            bntVentas.Size = new Size(161, 58);
            bntVentas.TabIndex = 9;
            bntVentas.Text = "Ventas";
            bntVentas.UseVisualStyleBackColor = false;
            bntVentas.Click += bntVentas_Click;
            // 
            // btnRegalias
            // 
            btnRegalias.BackColor = Color.DarkGreen;
            btnRegalias.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegalias.ForeColor = Color.Transparent;
            btnRegalias.Location = new Point(593, 365);
            btnRegalias.Name = "btnRegalias";
            btnRegalias.Size = new Size(161, 58);
            btnRegalias.TabIndex = 10;
            btnRegalias.Text = "Regalías";
            btnRegalias.UseVisualStyleBackColor = false;
            btnRegalias.Click += btnRegalias_Click;
            // 
            // btnDescuentos
            // 
            btnDescuentos.BackColor = Color.DarkGreen;
            btnDescuentos.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDescuentos.ForeColor = Color.Transparent;
            btnDescuentos.Location = new Point(593, 284);
            btnDescuentos.Name = "btnDescuentos";
            btnDescuentos.Size = new Size(161, 62);
            btnDescuentos.TabIndex = 11;
            btnDescuentos.Text = "Descuentos";
            btnDescuentos.UseVisualStyleBackColor = false;
            btnDescuentos.Click += btnDescuentos_Click;
            // 
            // btnPuestos
            // 
            btnPuestos.BackColor = Color.DarkGreen;
            btnPuestos.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPuestos.ForeColor = Color.Transparent;
            btnPuestos.Location = new Point(808, 284);
            btnPuestos.Name = "btnPuestos";
            btnPuestos.Size = new Size(163, 62);
            btnPuestos.TabIndex = 12;
            btnPuestos.Text = "Puestos";
            btnPuestos.UseVisualStyleBackColor = false;
            btnPuestos.Click += btnPuestos_Click;
            // 
            // btnInformacionEditorial
            // 
            btnInformacionEditorial.BackColor = Color.DarkGreen;
            btnInformacionEditorial.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInformacionEditorial.ForeColor = Color.Transparent;
            btnInformacionEditorial.Location = new Point(695, 463);
            btnInformacionEditorial.Name = "btnInformacionEditorial";
            btnInformacionEditorial.Size = new Size(276, 63);
            btnInformacionEditorial.TabIndex = 13;
            btnInformacionEditorial.Text = "Información editorial";
            btnInformacionEditorial.UseVisualStyleBackColor = false;
            btnInformacionEditorial.Click += btnInformacionEditorial_Click;
            // 
            // btnEmpleados
            // 
            btnEmpleados.BackColor = Color.DarkGreen;
            btnEmpleados.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmpleados.ForeColor = Color.Transparent;
            btnEmpleados.Location = new Point(808, 201);
            btnEmpleados.Name = "btnEmpleados";
            btnEmpleados.Size = new Size(163, 63);
            btnEmpleados.TabIndex = 14;
            btnEmpleados.Text = "Empleados";
            btnEmpleados.UseVisualStyleBackColor = false;
            btnEmpleados.Click += btnEmpleados_Click;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1044, 667);
            Controls.Add(btnEmpleados);
            Controls.Add(btnInformacionEditorial);
            Controls.Add(btnPuestos);
            Controls.Add(btnDescuentos);
            Controls.Add(btnRegalias);
            Controls.Add(bntVentas);
            Controls.Add(bntTiendas);
            Controls.Add(bntAutoresPorTitulo);
            Controls.Add(btnTitulos);
            Controls.Add(btnEditoriales);
            Controls.Add(btnAutores);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "FrmMenu";
            Text = "FrmMenu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Button btnAutores;
        private Button btnEditoriales;
        private Button btnTitulos;
        private Button bntAutoresPorTitulo;
        private Button bntTiendas;
        private Button bntVentas;
        private Button btnRegalias;
        private Button btnDescuentos;
        private Button btnPuestos;
        private Button btnInformacionEditorial;
        private Button btnEmpleados;
        private PictureBox pictureBox1;
        private Label label2;
    }
}