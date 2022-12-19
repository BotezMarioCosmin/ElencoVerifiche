namespace ElencoVerifiche
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderMateria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderVoto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderData = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonElimina = new System.Windows.Forms.Button();
            this.buttonModifica = new System.Windows.Forms.Button();
            this.textBoxMedia = new System.Windows.Forms.TextBox();
            this.comboBoxMedia = new System.Windows.Forms.ComboBox();
            this.labelMedia = new System.Windows.Forms.Label();
            this.buttonAggiungi = new System.Windows.Forms.Button();
            this.labelId = new System.Windows.Forms.Label();
            this.labelMateria = new System.Windows.Forms.Label();
            this.labelVoto = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.comboBoxVoto = new System.Windows.Forms.ComboBox();
            this.comboBoxMateria = new System.Windows.Forms.ComboBox();
            this.buttonOggi = new System.Windows.Forms.Button();
            this.panelElimina = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBoxEliminaId = new System.Windows.Forms.ComboBox();
            this.buttonX = new System.Windows.Forms.Button();
            this.panelElimina.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderMateria,
            this.columnHeaderVoto,
            this.columnHeaderData});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 89);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(605, 349);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeaderId
            // 
            this.columnHeaderId.Text = "Id";
            this.columnHeaderId.Width = 150;
            // 
            // columnHeaderMateria
            // 
            this.columnHeaderMateria.Text = "Materia";
            this.columnHeaderMateria.Width = 150;
            // 
            // columnHeaderVoto
            // 
            this.columnHeaderVoto.Text = "Voto";
            this.columnHeaderVoto.Width = 150;
            // 
            // columnHeaderData
            // 
            this.columnHeaderData.Text = "Data";
            this.columnHeaderData.Width = 150;
            // 
            // buttonElimina
            // 
            this.buttonElimina.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonElimina.Location = new System.Drawing.Point(623, 151);
            this.buttonElimina.Name = "buttonElimina";
            this.buttonElimina.Size = new System.Drawing.Size(165, 56);
            this.buttonElimina.TabIndex = 1;
            this.buttonElimina.Text = "Elimina";
            this.buttonElimina.UseVisualStyleBackColor = true;
            this.buttonElimina.Click += new System.EventHandler(this.buttonElimina_Click);
            // 
            // buttonModifica
            // 
            this.buttonModifica.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonModifica.Location = new System.Drawing.Point(623, 89);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(165, 56);
            this.buttonModifica.TabIndex = 2;
            this.buttonModifica.Text = "Modifica";
            this.buttonModifica.UseVisualStyleBackColor = true;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // textBoxMedia
            // 
            this.textBoxMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMedia.Location = new System.Drawing.Point(623, 366);
            this.textBoxMedia.Name = "textBoxMedia";
            this.textBoxMedia.Size = new System.Drawing.Size(165, 31);
            this.textBoxMedia.TabIndex = 3;
            // 
            // comboBoxMedia
            // 
            this.comboBoxMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMedia.FormattingEnabled = true;
            this.comboBoxMedia.Location = new System.Drawing.Point(623, 403);
            this.comboBoxMedia.Name = "comboBoxMedia";
            this.comboBoxMedia.Size = new System.Drawing.Size(165, 33);
            this.comboBoxMedia.TabIndex = 4;
            this.comboBoxMedia.SelectedIndexChanged += new System.EventHandler(this.comboBoxMedia_SelectedIndexChanged);
            // 
            // labelMedia
            // 
            this.labelMedia.AutoSize = true;
            this.labelMedia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMedia.Location = new System.Drawing.Point(666, 338);
            this.labelMedia.Name = "labelMedia";
            this.labelMedia.Size = new System.Drawing.Size(78, 25);
            this.labelMedia.TabIndex = 5;
            this.labelMedia.Text = "MEDIA";
            // 
            // buttonAggiungi
            // 
            this.buttonAggiungi.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAggiungi.Location = new System.Drawing.Point(623, 13);
            this.buttonAggiungi.Name = "buttonAggiungi";
            this.buttonAggiungi.Size = new System.Drawing.Size(165, 56);
            this.buttonAggiungi.TabIndex = 6;
            this.buttonAggiungi.Text = "Aggiungi";
            this.buttonAggiungi.UseVisualStyleBackColor = true;
            this.buttonAggiungi.Click += new System.EventHandler(this.buttonAggiungi_Click);
            // 
            // labelId
            // 
            this.labelId.AutoSize = true;
            this.labelId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelId.Location = new System.Drawing.Point(13, 13);
            this.labelId.Name = "labelId";
            this.labelId.Size = new System.Drawing.Size(27, 20);
            this.labelId.TabIndex = 7;
            this.labelId.Text = "Id:";
            // 
            // labelMateria
            // 
            this.labelMateria.AutoSize = true;
            this.labelMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMateria.Location = new System.Drawing.Point(174, 13);
            this.labelMateria.Name = "labelMateria";
            this.labelMateria.Size = new System.Drawing.Size(66, 20);
            this.labelMateria.TabIndex = 8;
            this.labelMateria.Text = "Materia:";
            // 
            // labelVoto
            // 
            this.labelVoto.AutoSize = true;
            this.labelVoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVoto.Location = new System.Drawing.Point(13, 53);
            this.labelVoto.Name = "labelVoto";
            this.labelVoto.Size = new System.Drawing.Size(47, 20);
            this.labelVoto.TabIndex = 9;
            this.labelVoto.Text = "Voto:";
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelData.Location = new System.Drawing.Point(174, 53);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(48, 20);
            this.labelData.TabIndex = 10;
            this.labelData.Text = "Data:";
            // 
            // textBoxId
            // 
            this.textBoxId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxId.Location = new System.Drawing.Point(66, 10);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(102, 26);
            this.textBoxId.TabIndex = 11;
            // 
            // textBoxData
            // 
            this.textBoxData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxData.Location = new System.Drawing.Point(241, 50);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(187, 26);
            this.textBoxData.TabIndex = 14;
            // 
            // comboBoxVoto
            // 
            this.comboBoxVoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxVoto.FormattingEnabled = true;
            this.comboBoxVoto.Location = new System.Drawing.Point(66, 50);
            this.comboBoxVoto.Name = "comboBoxVoto";
            this.comboBoxVoto.Size = new System.Drawing.Size(102, 28);
            this.comboBoxVoto.TabIndex = 15;
            // 
            // comboBoxMateria
            // 
            this.comboBoxMateria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMateria.FormattingEnabled = true;
            this.comboBoxMateria.Location = new System.Drawing.Point(241, 10);
            this.comboBoxMateria.Name = "comboBoxMateria";
            this.comboBoxMateria.Size = new System.Drawing.Size(187, 28);
            this.comboBoxMateria.TabIndex = 16;
            // 
            // buttonOggi
            // 
            this.buttonOggi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOggi.Location = new System.Drawing.Point(434, 50);
            this.buttonOggi.Name = "buttonOggi";
            this.buttonOggi.Size = new System.Drawing.Size(75, 27);
            this.buttonOggi.TabIndex = 17;
            this.buttonOggi.Text = "OGGI";
            this.buttonOggi.UseVisualStyleBackColor = true;
            this.buttonOggi.Click += new System.EventHandler(this.buttonOggi_Click);
            // 
            // panelElimina
            // 
            this.panelElimina.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelElimina.Controls.Add(this.buttonX);
            this.panelElimina.Controls.Add(this.comboBoxEliminaId);
            this.panelElimina.Controls.Add(this.button1);
            this.panelElimina.Controls.Add(this.label1);
            this.panelElimina.Location = new System.Drawing.Point(623, 151);
            this.panelElimina.Name = "panelElimina";
            this.panelElimina.Size = new System.Drawing.Size(165, 102);
            this.panelElimina.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Id:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(162, 38);
            this.button1.TabIndex = 19;
            this.button1.Text = "Elimina";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBoxEliminaId
            // 
            this.comboBoxEliminaId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxEliminaId.FormattingEnabled = true;
            this.comboBoxEliminaId.Location = new System.Drawing.Point(44, 29);
            this.comboBoxEliminaId.Name = "comboBoxEliminaId";
            this.comboBoxEliminaId.Size = new System.Drawing.Size(76, 28);
            this.comboBoxEliminaId.TabIndex = 19;
            // 
            // buttonX
            // 
            this.buttonX.BackColor = System.Drawing.Color.IndianRed;
            this.buttonX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonX.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonX.Location = new System.Drawing.Point(130, -1);
            this.buttonX.Name = "buttonX";
            this.buttonX.Size = new System.Drawing.Size(34, 23);
            this.buttonX.TabIndex = 20;
            this.buttonX.Text = "X";
            this.buttonX.UseVisualStyleBackColor = false;
            this.buttonX.Click += new System.EventHandler(this.buttonX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelElimina);
            this.Controls.Add(this.buttonOggi);
            this.Controls.Add(this.comboBoxMateria);
            this.Controls.Add(this.comboBoxVoto);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.labelVoto);
            this.Controls.Add(this.labelMateria);
            this.Controls.Add(this.labelId);
            this.Controls.Add(this.buttonAggiungi);
            this.Controls.Add(this.labelMedia);
            this.Controls.Add(this.comboBoxMedia);
            this.Controls.Add(this.textBoxMedia);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.buttonElimina);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Voti";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelElimina.ResumeLayout(false);
            this.panelElimina.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonElimina;
        private System.Windows.Forms.Button buttonModifica;
        private System.Windows.Forms.TextBox textBoxMedia;
        private System.Windows.Forms.ComboBox comboBoxMedia;
        private System.Windows.Forms.Label labelMedia;
        private System.Windows.Forms.Button buttonAggiungi;
        private System.Windows.Forms.Label labelId;
        private System.Windows.Forms.Label labelMateria;
        private System.Windows.Forms.Label labelVoto;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxId;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.ComboBox comboBoxVoto;
        private System.Windows.Forms.ComboBox comboBoxMateria;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderMateria;
        private System.Windows.Forms.ColumnHeader columnHeaderVoto;
        private System.Windows.Forms.ColumnHeader columnHeaderData;
        private System.Windows.Forms.Button buttonOggi;
        private System.Windows.Forms.Panel panelElimina;
        private System.Windows.Forms.Button buttonX;
        private System.Windows.Forms.ComboBox comboBoxEliminaId;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

