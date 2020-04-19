namespace cryptage
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
            this.Crypte = new System.Windows.Forms.TextBox();
            this.decrypte = new System.Windows.Forms.TextBox();
            this.DecrypteBtn = new System.Windows.Forms.Button();
            this.CrypteBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Clear = new System.Windows.Forms.Button();
            this.clear_ = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Crypte
            // 
            this.Crypte.Location = new System.Drawing.Point(12, 36);
            this.Crypte.Multiline = true;
            this.Crypte.Name = "Crypte";
            this.Crypte.Size = new System.Drawing.Size(517, 260);
            this.Crypte.TabIndex = 0;
            // 
            // decrypte
            // 
            this.decrypte.Location = new System.Drawing.Point(612, 36);
            this.decrypte.Multiline = true;
            this.decrypte.Name = "decrypte";
            this.decrypte.Size = new System.Drawing.Size(474, 260);
            this.decrypte.TabIndex = 0;
            // 
            // DecrypteBtn
            // 
            this.DecrypteBtn.Location = new System.Drawing.Point(547, 89);
            this.DecrypteBtn.Name = "DecrypteBtn";
            this.DecrypteBtn.Size = new System.Drawing.Size(49, 73);
            this.DecrypteBtn.TabIndex = 1;
            this.DecrypteBtn.Text = ">>";
            this.DecrypteBtn.UseVisualStyleBackColor = true;
            this.DecrypteBtn.Click += new System.EventHandler(this.DecrypteBtn_Click);
            // 
            // CrypteBtn
            // 
            this.CrypteBtn.Location = new System.Drawing.Point(547, 197);
            this.CrypteBtn.Name = "CrypteBtn";
            this.CrypteBtn.Size = new System.Drawing.Size(49, 73);
            this.CrypteBtn.TabIndex = 1;
            this.CrypteBtn.Text = "<<";
            this.CrypteBtn.UseVisualStyleBackColor = true;
            this.CrypteBtn.Click += new System.EventHandler(this.CrypteBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(197, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Crypte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(833, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Decrypte";
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold);
            this.Clear.Location = new System.Drawing.Point(150, 302);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(147, 36);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // clear_
            // 
            this.clear_.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_.Location = new System.Drawing.Point(803, 302);
            this.clear_.Name = "clear_";
            this.clear_.Size = new System.Drawing.Size(147, 36);
            this.clear_.TabIndex = 3;
            this.clear_.Text = "Clear";
            this.clear_.UseVisualStyleBackColor = true;
            this.clear_.Click += new System.EventHandler(this.clear__Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 350);
            this.Controls.Add(this.clear_);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CrypteBtn);
            this.Controls.Add(this.DecrypteBtn);
            this.Controls.Add(this.decrypte);
            this.Controls.Add(this.Crypte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.Text = "Vider";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Crypte;
        private System.Windows.Forms.TextBox decrypte;
        private System.Windows.Forms.Button DecrypteBtn;
        private System.Windows.Forms.Button CrypteBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button clear_;
    }
}

