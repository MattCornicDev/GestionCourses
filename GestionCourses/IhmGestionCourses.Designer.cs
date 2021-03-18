
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
            this.textBoxSql = new System.Windows.Forms.TextBox();
            this.labelRequeteSql = new System.Windows.Forms.Label();
            this.buttonExecuter = new System.Windows.Forms.Button();
            this.textBoxResultat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Etat de la connexion";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // buttonConnexion
            // 
            this.buttonConnexion.Location = new System.Drawing.Point(95, 66);
            this.buttonConnexion.Name = "buttonConnexion";
            this.buttonConnexion.Size = new System.Drawing.Size(355, 42);
            this.buttonConnexion.TabIndex = 1;
            this.buttonConnexion.Text = "Connexion";
            this.buttonConnexion.UseVisualStyleBackColor = true;
            this.buttonConnexion.Click += new System.EventHandler(this.buttonConnexion_Click);
            // 
            // buttonDeconnexion
            // 
            this.buttonDeconnexion.Location = new System.Drawing.Point(522, 66);
            this.buttonDeconnexion.Name = "buttonDeconnexion";
            this.buttonDeconnexion.Size = new System.Drawing.Size(356, 42);
            this.buttonDeconnexion.TabIndex = 2;
            this.buttonDeconnexion.Text = "Déconnexion";
            this.buttonDeconnexion.UseVisualStyleBackColor = true;
            // 
            // textBoxEtat
            // 
            this.textBoxEtat.Location = new System.Drawing.Point(95, 178);
            this.textBoxEtat.Name = "textBoxEtat";
            this.textBoxEtat.Size = new System.Drawing.Size(718, 31);
            this.textBoxEtat.TabIndex = 3;
            // 
            // textBoxSql
            // 
            this.textBoxSql.Location = new System.Drawing.Point(95, 293);
            this.textBoxSql.Name = "textBoxSql";
            this.textBoxSql.Size = new System.Drawing.Size(718, 31);
            this.textBoxSql.TabIndex = 4;
            // 
            // labelRequeteSql
            // 
            this.labelRequeteSql.AutoSize = true;
            this.labelRequeteSql.Location = new System.Drawing.Point(90, 242);
            this.labelRequeteSql.Name = "labelRequeteSql";
            this.labelRequeteSql.Size = new System.Drawing.Size(141, 25);
            this.labelRequeteSql.TabIndex = 5;
            this.labelRequeteSql.Text = "Requête SQL";
            // 
            // buttonExecuter
            // 
            this.buttonExecuter.Location = new System.Drawing.Point(95, 364);
            this.buttonExecuter.Name = "buttonExecuter";
            this.buttonExecuter.Size = new System.Drawing.Size(203, 42);
            this.buttonExecuter.TabIndex = 6;
            this.buttonExecuter.Text = "Exécuter";
            this.buttonExecuter.UseVisualStyleBackColor = true;
            this.buttonExecuter.Click += new System.EventHandler(this.buttonExecuter_Click);
            // 
            // textBoxResultat
            // 
            this.textBoxResultat.Location = new System.Drawing.Point(95, 433);
            this.textBoxResultat.Multiline = true;
            this.textBoxResultat.Name = "textBoxResultat";
            this.textBoxResultat.ReadOnly = true;
            this.textBoxResultat.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxResultat.Size = new System.Drawing.Size(718, 195);
            this.textBoxResultat.TabIndex = 7;
            // 
            // IhmGestionCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1383, 642);
            this.Controls.Add(this.textBoxResultat);
            this.Controls.Add(this.buttonExecuter);
            this.Controls.Add(this.labelRequeteSql);
            this.Controls.Add(this.textBoxSql);
            this.Controls.Add(this.textBoxEtat);
            this.Controls.Add(this.buttonDeconnexion);
            this.Controls.Add(this.buttonConnexion);
            this.Controls.Add(this.label1);
            this.Name = "IhmGestionCourses";
            this.Text = "Gestion de Courses à pied";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonConnexion;
        private System.Windows.Forms.Button buttonDeconnexion;
        private System.Windows.Forms.TextBox textBoxEtat;
        private System.Windows.Forms.TextBox textBoxSql;
        private System.Windows.Forms.Label labelRequeteSql;
        private System.Windows.Forms.Button buttonExecuter;
        private System.Windows.Forms.TextBox textBoxResultat;
    }
}

