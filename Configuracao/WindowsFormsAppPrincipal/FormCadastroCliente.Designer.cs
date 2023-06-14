namespace WindowsFormsAppPrincipal
{
    partial class FormCadastroCliente
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label cPFLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label foneLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label rGLabel;
            this.buttonSalvar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.cPFTextBox = new System.Windows.Forms.TextBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.foneTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.rGTextBox = new System.Windows.Forms.TextBox();
            cPFLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            foneLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            rGLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cPFLabel
            // 
            cPFLabel.AutoSize = true;
            cPFLabel.Location = new System.Drawing.Point(36, 216);
            cPFLabel.Name = "cPFLabel";
            cPFLabel.Size = new System.Drawing.Size(36, 16);
            cPFLabel.TabIndex = 4;
            cPFLabel.Text = "CPF:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(28, 336);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(44, 16);
            emailLabel.TabIndex = 5;
            emailLabel.Text = "Email:";
            // 
            // foneLabel
            // 
            foneLabel.AutoSize = true;
            foneLabel.Location = new System.Drawing.Point(31, 294);
            foneLabel.Name = "foneLabel";
            foneLabel.Size = new System.Drawing.Size(41, 16);
            foneLabel.TabIndex = 7;
            foneLabel.Text = "Fone:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Location = new System.Drawing.Point(25, 178);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(47, 16);
            nomeLabel.TabIndex = 9;
            nomeLabel.Text = "Nome:";
            // 
            // rGLabel
            // 
            rGLabel.AutoSize = true;
            rGLabel.Location = new System.Drawing.Point(42, 255);
            rGLabel.Name = "rGLabel";
            rGLabel.Size = new System.Drawing.Size(30, 16);
            rGLabel.TabIndex = 11;
            rGLabel.Text = "RG:";
            // 
            // buttonSalvar
            // 
            this.buttonSalvar.Location = new System.Drawing.Point(599, 415);
            this.buttonSalvar.Name = "buttonSalvar";
            this.buttonSalvar.Size = new System.Drawing.Size(75, 23);
            this.buttonSalvar.TabIndex = 2;
            this.buttonSalvar.Text = "Salvar";
            this.buttonSalvar.UseVisualStyleBackColor = true;
            this.buttonSalvar.Click += new System.EventHandler(this.buttonSalvar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancelar.Location = new System.Drawing.Point(697, 415);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(75, 23);
            this.buttonCancelar.TabIndex = 3;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 42);
            this.label1.TabIndex = 4;
            this.label1.Text = "CADASTRO DE CLIENTE";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // cPFTextBox
            // 
            this.cPFTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "CPF", true));
            this.cPFTextBox.Location = new System.Drawing.Point(78, 213);
            this.cPFTextBox.Name = "cPFTextBox";
            this.cPFTextBox.Size = new System.Drawing.Size(269, 22);
            this.cPFTextBox.TabIndex = 5;
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Models.Cliente);
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(78, 333);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 22);
            this.emailTextBox.TabIndex = 6;
            // 
            // foneTextBox
            // 
            this.foneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Fone", true));
            this.foneTextBox.Location = new System.Drawing.Point(78, 291);
            this.foneTextBox.Name = "foneTextBox";
            this.foneTextBox.Size = new System.Drawing.Size(100, 22);
            this.foneTextBox.TabIndex = 8;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(78, 175);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(269, 22);
            this.nomeTextBox.TabIndex = 10;
            // 
            // rGTextBox
            // 
            this.rGTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clienteBindingSource, "RG", true));
            this.rGTextBox.Location = new System.Drawing.Point(78, 252);
            this.rGTextBox.Name = "rGTextBox";
            this.rGTextBox.Size = new System.Drawing.Size(100, 22);
            this.rGTextBox.TabIndex = 12;
            // 
            // FormCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(rGLabel);
            this.Controls.Add(this.rGTextBox);
            this.Controls.Add(nomeLabel);
            this.Controls.Add(this.nomeTextBox);
            this.Controls.Add(foneLabel);
            this.Controls.Add(this.foneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(cPFLabel);
            this.Controls.Add(this.cPFTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonSalvar);
            this.Name = "FormCadastroCliente";
            this.Text = "FormCadastroCliente";
            this.Load += new System.EventHandler(this.FormCadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.Button buttonSalvar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label label1;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.TextBox cPFTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox foneTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox rGTextBox;
    }
}