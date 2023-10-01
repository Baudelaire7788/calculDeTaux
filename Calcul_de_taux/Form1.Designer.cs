namespace Calcul_de_taux
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_montant = new System.Windows.Forms.TextBox();
            this.text_taux = new System.Windows.Forms.TextBox();
            this.text_total = new System.Windows.Forms.TextBox();
            this.btn_calculer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Saisir le montant d\'achat en FCFA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Le taux de réduction est de : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "La somme à payer est :";
            // 
            // text_montant
            // 
            this.text_montant.Location = new System.Drawing.Point(292, 58);
            this.text_montant.Name = "text_montant";
            this.text_montant.Size = new System.Drawing.Size(353, 22);
            this.text_montant.TabIndex = 3;
            // 
            // text_taux
            // 
            this.text_taux.Location = new System.Drawing.Point(292, 134);
            this.text_taux.Name = "text_taux";
            this.text_taux.ReadOnly = true;
            this.text_taux.Size = new System.Drawing.Size(353, 22);
            this.text_taux.TabIndex = 4;
            // 
            // text_total
            // 
            this.text_total.Location = new System.Drawing.Point(292, 212);
            this.text_total.Name = "text_total";
            this.text_total.ReadOnly = true;
            this.text_total.Size = new System.Drawing.Size(353, 22);
            this.text_total.TabIndex = 5;
            // 
            // btn_calculer
            // 
            this.btn_calculer.Location = new System.Drawing.Point(546, 265);
            this.btn_calculer.Name = "btn_calculer";
            this.btn_calculer.Size = new System.Drawing.Size(99, 58);
            this.btn_calculer.TabIndex = 6;
            this.btn_calculer.Text = "Calculer";
            this.btn_calculer.UseVisualStyleBackColor = true;
            this.btn_calculer.Click += new System.EventHandler(this.btn_calculer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 386);
            this.Controls.Add(this.btn_calculer);
            this.Controls.Add(this.text_total);
            this.Controls.Add(this.text_taux);
            this.Controls.Add(this.text_montant);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_montant;
        private System.Windows.Forms.TextBox text_taux;
        private System.Windows.Forms.TextBox text_total;
        private System.Windows.Forms.Button btn_calculer;
    }
}

