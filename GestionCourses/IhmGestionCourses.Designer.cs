
namespace GestionCourses
{
    partial class IhmGestionCourses
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
            this.buttonConnexion = new System.Windows.Forms.Button();
            this.buttonDeconnexion = new System.Windows.Forms.Button();
            this.textBoxEtat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 314);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etat de la connexion";
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(95, 66);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(731, 56);
            this.buttonConnexion.TabIndex = 1;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Location = new System.Drawing.Point(95, 188);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(731, 56);
            this.buttonDeconnexion.TabIndex = 2;
            this.buttonDeconnexion.Text = "Déconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = true;
            // 
            // textBoxEtat
            // 
            this.textBoxEtat.Location = new System.Drawing.Point(108, 390);
            this.textBoxEtat.Name = "textBoxEtat";
            this.textBoxEtat.Size = new System.Drawing.Size(718, 31);
            this.textBoxEtat.TabIndex = 3;
            // 
            // IhmGestionCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 621);
            this.Controls.Add(this.textBoxEtat);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.label1);
            this.Name = "IhmGestionCourses";
            this.Text = "Gestion de Courses à pied";
            this.Load += new System.EventHandler(this.IhmGestionCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button buttonDeconnexion;
        private System.Windows.Forms.TextBox textBoxEtat;
    }
}

