
namespace ZOOLOGICO
{
    partial class Localizacion
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
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnRapaces = new System.Windows.Forms.Button();
            this.btnMamiferos = new System.Windows.Forms.Button();
            this.btnReptiles = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(143, 184);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.Size = new System.Drawing.Size(582, 244);
            this.DataGridView1.TabIndex = 70;
            // 
            // btnRapaces
            // 
            this.btnRapaces.Location = new System.Drawing.Point(571, 98);
            this.btnRapaces.Name = "btnRapaces";
            this.btnRapaces.Size = new System.Drawing.Size(100, 53);
            this.btnRapaces.TabIndex = 69;
            this.btnRapaces.Text = "Rapaces";
            this.btnRapaces.UseVisualStyleBackColor = true;
            // 
            // btnMamiferos
            // 
            this.btnMamiferos.Location = new System.Drawing.Point(392, 98);
            this.btnMamiferos.Name = "btnMamiferos";
            this.btnMamiferos.Size = new System.Drawing.Size(98, 53);
            this.btnMamiferos.TabIndex = 68;
            this.btnMamiferos.Text = "Mamiferos";
            this.btnMamiferos.UseVisualStyleBackColor = true;
            // 
            // btnReptiles
            // 
            this.btnReptiles.Location = new System.Drawing.Point(203, 98);
            this.btnReptiles.Name = "btnReptiles";
            this.btnReptiles.Size = new System.Drawing.Size(108, 53);
            this.btnReptiles.TabIndex = 67;
            this.btnReptiles.Text = "Reptiles";
            this.btnReptiles.UseVisualStyleBackColor = true;
            // 
            // Localizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ZOOLOGICO.Properties.Resources.pngwing_com__2_;
            this.ClientSize = new System.Drawing.Size(868, 526);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.btnRapaces);
            this.Controls.Add(this.btnMamiferos);
            this.Controls.Add(this.btnReptiles);
            this.Name = "Localizacion";
            this.Text = "Localizacion";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.DataGridView DataGridView1;
        internal System.Windows.Forms.Button btnRapaces;
        internal System.Windows.Forms.Button btnMamiferos;
        internal System.Windows.Forms.Button btnReptiles;
    }
}