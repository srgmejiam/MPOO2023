namespace UI
{
    partial class AdministracionClientes
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
            lblNombreCliente = new Label();
            txtNombreCliente = new TextBox();
            txtNumero = new TextBox();
            label1 = new Label();
            txtCorreo = new TextBox();
            label2 = new Label();
            btnNuevo = new Button();
            btnGuardar = new Button();
            btnAnular = new Button();
            gridClientes = new DataGridView();
            label3 = new Label();
            ckEnviarCorreo = new CheckBox();
            txtMensaje = new TextBox();
            label4 = new Label();
            btnEnviar = new Button();
            ((System.ComponentModel.ISupportInitialize)gridClientes).BeginInit();
            SuspendLayout();
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Location = new Point(19, 31);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(139, 20);
            lblNombreCliente.TabIndex = 0;
            lblNombreCliente.Text = "Nombre del Cliente";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(19, 54);
            txtNombreCliente.MaxLength = 200;
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(519, 27);
            txtNombreCliente.TabIndex = 1;
            // 
            // txtNumero
            // 
            txtNumero.Location = new Point(19, 124);
            txtNumero.MaxLength = 8;
            txtNumero.Name = "txtNumero";
            txtNumero.Size = new Size(519, 27);
            txtNumero.TabIndex = 3;
            txtNumero.KeyPress += txtNumero_KeyPress;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(19, 101);
            label1.Name = "label1";
            label1.Size = new Size(144, 20);
            label1.TabIndex = 2;
            label1.Text = "Número de teléfono";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(19, 201);
            txtCorreo.MaxLength = 200;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(519, 27);
            txtCorreo.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 178);
            label2.Name = "label2";
            label2.Size = new Size(54, 20);
            label2.TabIndex = 4;
            label2.Text = "Correo";
            // 
            // btnNuevo
            // 
            btnNuevo.Location = new Point(12, 333);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(94, 29);
            btnNuevo.TabIndex = 6;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(134, 333);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(94, 29);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnAnular
            // 
            btnAnular.Location = new Point(261, 333);
            btnAnular.Name = "btnAnular";
            btnAnular.Size = new Size(94, 29);
            btnAnular.TabIndex = 8;
            btnAnular.Text = "Anular";
            btnAnular.UseVisualStyleBackColor = true;
            btnAnular.Click += btnAnular_Click;
            // 
            // gridClientes
            // 
            gridClientes.AllowUserToAddRows = false;
            gridClientes.AllowUserToDeleteRows = false;
            gridClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gridClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridClientes.Location = new Point(12, 395);
            gridClientes.MultiSelect = false;
            gridClientes.Name = "gridClientes";
            gridClientes.ReadOnly = true;
            gridClientes.RowHeadersVisible = false;
            gridClientes.RowHeadersWidth = 51;
            gridClientes.RowTemplate.Height = 29;
            gridClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gridClientes.Size = new Size(517, 303);
            gridClientes.TabIndex = 9;
            gridClientes.CellClick += gridClientes_CellClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 372);
            label3.Name = "label3";
            label3.Size = new Size(134, 20);
            label3.TabIndex = 10;
            label3.Text = "Listado de Clientes";
            // 
            // ckEnviarCorreo
            // 
            ckEnviarCorreo.AutoSize = true;
            ckEnviarCorreo.Location = new Point(420, 234);
            ckEnviarCorreo.Name = "ckEnviarCorreo";
            ckEnviarCorreo.Size = new Size(118, 24);
            ckEnviarCorreo.TabIndex = 11;
            ckEnviarCorreo.Text = "Enviar correo";
            ckEnviarCorreo.UseVisualStyleBackColor = true;
            ckEnviarCorreo.CheckedChanged += ckEnviarCorreo_CheckedChanged;
            // 
            // txtMensaje
            // 
            txtMensaje.Location = new Point(21, 266);
            txtMensaje.Multiline = true;
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(517, 61);
            txtMensaje.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 243);
            label4.Name = "label4";
            label4.Size = new Size(68, 20);
            label4.TabIndex = 13;
            label4.Text = "Mensaje ";
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(379, 333);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(94, 29);
            btnEnviar.TabIndex = 14;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // AdministracionClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 710);
            Controls.Add(btnEnviar);
            Controls.Add(label4);
            Controls.Add(txtMensaje);
            Controls.Add(ckEnviarCorreo);
            Controls.Add(label3);
            Controls.Add(gridClientes);
            Controls.Add(btnAnular);
            Controls.Add(btnGuardar);
            Controls.Add(btnNuevo);
            Controls.Add(txtCorreo);
            Controls.Add(label2);
            Controls.Add(txtNumero);
            Controls.Add(label1);
            Controls.Add(txtNombreCliente);
            Controls.Add(lblNombreCliente);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            MaximizeBox = false;
            Name = "AdministracionClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AdministracionClientes";
            Load += AdministracionClientes_Load;
            ((System.ComponentModel.ISupportInitialize)gridClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreCliente;
        private TextBox txtNombreCliente;
        private TextBox txtNumero;
        private Label label1;
        private TextBox txtCorreo;
        private Label label2;
        private Button btnNuevo;
        private Button btnGuardar;
        private Button btnAnular;
        private DataGridView gridClientes;
        private Label label3;
        private CheckBox ckEnviarCorreo;
        private TextBox txtMensaje;
        private Label label4;
        private Button btnEnviar;
    }
}