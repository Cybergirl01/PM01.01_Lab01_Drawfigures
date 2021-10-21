using System.Windows.Forms;

namespace Bessonova483_draw
{
    partial class Formdraw
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
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.comboBoxFigures = new System.Windows.Forms.ComboBox();
            this.pictureBoxfigures = new System.Windows.Forms.PictureBox();
            this.listBoxfigures = new System.Windows.Forms.ListBox();
            this.labelforcircle = new System.Windows.Forms.Label();
            this.textBoxRad = new System.Windows.Forms.TextBox();
            this.labelforsquare = new System.Windows.Forms.Label();
            this.textBoxside = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfigures)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(22, 12);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(126, 12);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 1;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // comboBoxFigures
            // 
            this.comboBoxFigures.FormattingEnabled = true;
            this.comboBoxFigures.Items.AddRange(new object[] {
            "circle",
            "square"});
            this.comboBoxFigures.Location = new System.Drawing.Point(234, 14);
            this.comboBoxFigures.Name = "comboBoxFigures";
            this.comboBoxFigures.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFigures.TabIndex = 2;
            this.comboBoxFigures.SelectedIndexChanged += new System.EventHandler(this.comboBoxFigures_SelectedIndexChanged);
            // 
            // pictureBoxfigures
            // 
            this.pictureBoxfigures.Location = new System.Drawing.Point(211, 65);
            this.pictureBoxfigures.Name = "pictureBoxfigures";
            this.pictureBoxfigures.Size = new System.Drawing.Size(524, 333);
            this.pictureBoxfigures.TabIndex = 3;
            this.pictureBoxfigures.TabStop = false;
            this.pictureBoxfigures.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxfigures_Paint);
            this.pictureBoxfigures.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxfigures_MouseDown);
            this.pictureBoxfigures.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxfigures_MouseMove);
            // 
            // listBoxfigures
            // 
            this.listBoxfigures.FormattingEnabled = true;
            this.listBoxfigures.Location = new System.Drawing.Point(13, 65);
            this.listBoxfigures.Name = "listBoxfigures";
            this.listBoxfigures.Size = new System.Drawing.Size(188, 329);
            this.listBoxfigures.TabIndex = 4;
            // 
            // labelforcircle
            // 
            this.labelforcircle.AutoSize = true;
            this.labelforcircle.Location = new System.Drawing.Point(380, 9);
            this.labelforcircle.Name = "labelforcircle";
            this.labelforcircle.Size = new System.Drawing.Size(0, 13);
            this.labelforcircle.TabIndex = 5;
            // 
            // textBoxRad
            // 
            this.textBoxRad.Location = new System.Drawing.Point(422, 9);
            this.textBoxRad.Name = "textBoxRad";
            this.textBoxRad.Size = new System.Drawing.Size(100, 20);
            this.textBoxRad.TabIndex = 6;
            // 
            // labelforsquare
            // 
            this.labelforsquare.AutoSize = true;
            this.labelforsquare.Location = new System.Drawing.Point(380, 40);
            this.labelforsquare.Name = "labelforsquare";
            this.labelforsquare.Size = new System.Drawing.Size(0, 13);
            this.labelforsquare.TabIndex = 7;
            // 
            // textBoxside
            // 
            this.textBoxside.Location = new System.Drawing.Point(422, 40);
            this.textBoxside.Name = "textBoxside";
            this.textBoxside.Size = new System.Drawing.Size(100, 20);
            this.textBoxside.TabIndex = 8;
            // 
            // Formdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 410);
            this.Controls.Add(this.textBoxside);
            this.Controls.Add(this.labelforsquare);
            this.Controls.Add(this.textBoxRad);
            this.Controls.Add(this.labelforcircle);
            this.Controls.Add(this.listBoxfigures);
            this.Controls.Add(this.pictureBoxfigures);
            this.Controls.Add(this.comboBoxFigures);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Name = "Formdraw";
            this.Text = "Figures - Bessonova 483";
            this.Load += new System.EventHandler(this.Formdraw_Load);
            this.Resize += new System.EventHandler(this.Formdraw_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxfigures)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.ComboBox comboBoxFigures;
        private System.Windows.Forms.PictureBox pictureBoxfigures;
        private System.Windows.Forms.ListBox listBoxfigures;
        private System.Windows.Forms.Label labelforcircle;
        private System.Windows.Forms.TextBox textBoxRad;
        private System.Windows.Forms.Label labelforsquare;
        private System.Windows.Forms.TextBox textBoxside;
    }
}

