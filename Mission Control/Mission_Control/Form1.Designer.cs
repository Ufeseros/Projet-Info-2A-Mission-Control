namespace Mission_Control
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
<<<<<<< HEAD
<<<<<<< HEAD
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(370, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
=======
            this.chargerMission = new System.Windows.Forms.Button();
            this.AfficheJours = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chargerMission
            // 
            this.chargerMission.Location = new System.Drawing.Point(12, 14);
            this.chargerMission.Name = "chargerMission";
            this.chargerMission.Size = new System.Drawing.Size(108, 23);
            this.chargerMission.TabIndex = 0;
            this.chargerMission.Text = "Charger mission";
            this.chargerMission.UseVisualStyleBackColor = true;
            this.chargerMission.Click += new System.EventHandler(this.chargerMission_Click);
            // 
            // AfficheJours
            // 
            this.AfficheJours.Location = new System.Drawing.Point(198, 12);
            this.AfficheJours.Name = "AfficheJours";
            this.AfficheJours.Size = new System.Drawing.Size(121, 657);
            this.AfficheJours.TabIndex = 1;
            this.AfficheJours.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.AfficheJours_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Afficher la carte";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
>>>>>>> origin/master
            // 
=======
            this.SuspendLayout();
            // 
>>>>>>> parent of fdfd1c8... des
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(853, 591);
            this.Controls.Add(this.button1);
=======
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.AfficheJours);
            this.Controls.Add(this.chargerMission);
>>>>>>> origin/master
=======
            this.ClientSize = new System.Drawing.Size(284, 261);
>>>>>>> parent of fdfd1c8... des
            this.Name = "Form1";
            this.Text = "Controle de mission";
            this.ResumeLayout(false);

        }

        #endregion
<<<<<<< HEAD

<<<<<<< HEAD
=======
        private System.Windows.Forms.Button chargerMission;
        private System.Windows.Forms.TreeView AfficheJours;
>>>>>>> origin/master
        private System.Windows.Forms.Button button1;
=======
>>>>>>> parent of fdfd1c8... des
    }
}

