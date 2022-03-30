
namespace ZOOLOGICO
{
    partial class Venta
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
            this.btncomprar = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btncomprar
            // 
            this.btncomprar.Location = new System.Drawing.Point(685, 335);
            this.btncomprar.Name = "btncomprar";
            this.btncomprar.Size = new System.Drawing.Size(88, 60);
            this.btncomprar.TabIndex = 64;
            this.btncomprar.Text = "Comprar animal";
            this.btncomprar.UseVisualStyleBackColor = true;
            // 
            // btnmostrar
            // 
            this.btnmostrar.Location = new System.Drawing.Point(685, 248);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(88, 69);
            this.btnmostrar.TabIndex = 63;
            this.btnmostrar.Text = "Mostrar animales";
            this.btnmostrar.UseVisualStyleBackColor = true;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(97, 162);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(567, 282);
            this.DataGridView1.TabIndex = 62;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Lucida Handwriting", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Gray;
            this.Label5.Location = new System.Drawing.Point(172, 55);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(513, 27);
            this.Label5.TabIndex = 61;
            this.Label5.Text = "Sistema Mundial de Animales sin Casa";
            this.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZOOLOGICO.Properties.Resources._05a4e0e651735015bca1bc661d743517;
            this.ClientSize = new System.Drawing.Size(828, 555);
            this.Controls.Add(this.btncomprar);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.Label5);
            this.Name = "Venta";
            this.Text = "Venta";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btncomprar;
        internal System.Windows.Forms.Button btnmostrar;
        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Label Label5;
    }
}