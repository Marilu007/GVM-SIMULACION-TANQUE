
namespace GVM_SIMULACION_DE_TANQUE
{
    partial class Simulacion
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.PanelAgua = new System.Windows.Forms.Panel();
            this.PanelTanque = new System.Windows.Forms.Panel();
            this.PanelBordeTanque = new System.Windows.Forms.Panel();
            this.Vaciar = new System.Windows.Forms.Button();
            this.tmrllenar = new System.Windows.Forms.Timer(this.components);
            this.tmrvaciar = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.Llenar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PanelBordeTanque.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(633, 313);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(233, 25);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // PanelAgua
            // 
            this.PanelAgua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PanelAgua.Location = new System.Drawing.Point(17, 257);
            this.PanelAgua.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PanelAgua.Name = "PanelAgua";
            this.PanelAgua.Size = new System.Drawing.Size(194, 257);
            this.PanelAgua.TabIndex = 0;
            // 
            // PanelTanque
            // 
            this.PanelTanque.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PanelTanque.Location = new System.Drawing.Point(17, 0);
            this.PanelTanque.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PanelTanque.Name = "PanelTanque";
            this.PanelTanque.Size = new System.Drawing.Size(194, 513);
            this.PanelTanque.TabIndex = 3;
            // 
            // PanelBordeTanque
            // 
            this.PanelBordeTanque.BackColor = System.Drawing.SystemColors.GrayText;
            this.PanelBordeTanque.Controls.Add(this.PanelAgua);
            this.PanelBordeTanque.Controls.Add(this.PanelTanque);
            this.PanelBordeTanque.Location = new System.Drawing.Point(346, 264);
            this.PanelBordeTanque.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.PanelBordeTanque.Name = "PanelBordeTanque";
            this.PanelBordeTanque.Size = new System.Drawing.Size(229, 531);
            this.PanelBordeTanque.TabIndex = 0;
            // 
            // Vaciar
            // 
            this.Vaciar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Vaciar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Vaciar.Location = new System.Drawing.Point(595, 350);
            this.Vaciar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Vaciar.Name = "Vaciar";
            this.Vaciar.Size = new System.Drawing.Size(85, 57);
            this.Vaciar.TabIndex = 2;
            this.Vaciar.Text = "Vaciar";
            this.Vaciar.UseVisualStyleBackColor = false;
            this.Vaciar.Click += new System.EventHandler(this.Vaciar_Click);
            // 
            // tmrllenar
            // 
            this.tmrllenar.Tick += new System.EventHandler(this.tmrllenar_Tick);
            // 
            // tmrvaciar
            // 
            this.tmrvaciar.Tick += new System.EventHandler(this.tmrvaciar_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(208, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 38);
            this.label1.TabIndex = 4;
            this.label1.Text = "TANQUE DE AGUA ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Llenar
            // 
            this.Llenar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Llenar.Font = new System.Drawing.Font("Modern No. 20", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Llenar.Location = new System.Drawing.Point(216, 350);
            this.Llenar.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Llenar.Name = "Llenar";
            this.Llenar.Size = new System.Drawing.Size(87, 57);
            this.Llenar.TabIndex = 3;
            this.Llenar.Text = "Llenar";
            this.Llenar.UseVisualStyleBackColor = false;
            this.Llenar.Click += new System.EventHandler(this.Llenar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GVM_SIMULACION_DE_TANQUE.Properties.Resources.MV;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(937, 796);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Llenar);
            this.Controls.Add(this.Vaciar);
            this.Controls.Add(this.PanelBordeTanque);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.Name = "Simulacion";
            this.Text = "Simulador de vaciado y llenado del tanque ";
            this.PanelBordeTanque.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel PanelAgua;
        private System.Windows.Forms.Panel PanelTanque;
        private System.Windows.Forms.Panel PanelBordeTanque;
        private System.Windows.Forms.Button Vaciar;
        private System.Windows.Forms.Button Llenar;
        private System.Windows.Forms.Timer tmrllenar;
        private System.Windows.Forms.Timer tmrvaciar;
        private System.Windows.Forms.Label label1;
    }
}

