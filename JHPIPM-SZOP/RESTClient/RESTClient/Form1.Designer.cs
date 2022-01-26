
namespace RESTClient
{
    partial class Form1
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
            this.label12 = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Allatkert_Grid = new System.Windows.Forms.DataGridView();
            this.allatkert_megnv = new System.Windows.Forms.TextBox();
            this.allatkert_nem = new System.Windows.Forms.TextBox();
            this.allatkert_id = new System.Windows.Forms.NumericUpDown();
            this.allatkert_eletkor = new System.Windows.Forms.NumericUpDown();
            this.allatkert_szektor = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.hozzaad_bt = new System.Windows.Forms.Button();
            this.modosit_bt = new System.Windows.Forms.Button();
            this.torol_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Allatkert_Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allatkert_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allatkert_eletkor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allatkert_szektor)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Agency FB", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(30, 35);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 50);
            this.label12.TabIndex = 111;
            this.label12.Text = "Állatkert";
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(143, 661);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(157, 47);
            this.Exit_button.TabIndex = 98;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click_1);
            // 
            // Allatkert_Grid
            // 
            this.Allatkert_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Allatkert_Grid.Location = new System.Drawing.Point(386, 35);
            this.Allatkert_Grid.Name = "Allatkert_Grid";
            this.Allatkert_Grid.RowHeadersWidth = 51;
            this.Allatkert_Grid.RowTemplate.Height = 24;
            this.Allatkert_Grid.Size = new System.Drawing.Size(767, 673);
            this.Allatkert_Grid.TabIndex = 123;
            this.Allatkert_Grid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Allatkert_Grid_CellClick);
            this.Allatkert_Grid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Allatkert_Grid_CellContentClick);
            // 
            // allatkert_megnv
            // 
            this.allatkert_megnv.Location = new System.Drawing.Point(153, 164);
            this.allatkert_megnv.Name = "allatkert_megnv";
            this.allatkert_megnv.Size = new System.Drawing.Size(147, 22);
            this.allatkert_megnv.TabIndex = 124;
            this.allatkert_megnv.TextChanged += new System.EventHandler(this.allatkert_megnv_TextChanged);
            // 
            // allatkert_nem
            // 
            this.allatkert_nem.Location = new System.Drawing.Point(153, 199);
            this.allatkert_nem.Name = "allatkert_nem";
            this.allatkert_nem.Size = new System.Drawing.Size(147, 22);
            this.allatkert_nem.TabIndex = 127;
            // 
            // allatkert_id
            // 
            this.allatkert_id.Location = new System.Drawing.Point(153, 136);
            this.allatkert_id.Name = "allatkert_id";
            this.allatkert_id.Size = new System.Drawing.Size(147, 22);
            this.allatkert_id.TabIndex = 128;
            // 
            // allatkert_eletkor
            // 
            this.allatkert_eletkor.Location = new System.Drawing.Point(153, 236);
            this.allatkert_eletkor.Name = "allatkert_eletkor";
            this.allatkert_eletkor.Size = new System.Drawing.Size(147, 22);
            this.allatkert_eletkor.TabIndex = 129;
            // 
            // allatkert_szektor
            // 
            this.allatkert_szektor.Location = new System.Drawing.Point(153, 273);
            this.allatkert_szektor.Name = "allatkert_szektor";
            this.allatkert_szektor.Size = new System.Drawing.Size(147, 22);
            this.allatkert_szektor.TabIndex = 130;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 17);
            this.label3.TabIndex = 131;
            this.label3.Text = "Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 17);
            this.label4.TabIndex = 132;
            this.label4.Text = "Megnevezés:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 17);
            this.label5.TabIndex = 133;
            this.label5.Text = "Nem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 17);
            this.label6.TabIndex = 134;
            this.label6.Text = "Életkor(hónapokban)";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(87, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 17);
            this.label7.TabIndex = 135;
            this.label7.Text = "Szektor:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 103);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(239, 17);
            this.label8.TabIndex = 136;
            this.label8.Text = "Adj hozzá egy állatot az állatkerthez:";
            // 
            // hozzaad_bt
            // 
            this.hozzaad_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.hozzaad_bt.Location = new System.Drawing.Point(143, 326);
            this.hozzaad_bt.Name = "hozzaad_bt";
            this.hozzaad_bt.Size = new System.Drawing.Size(157, 45);
            this.hozzaad_bt.TabIndex = 137;
            this.hozzaad_bt.Text = "Hozzáad";
            this.hozzaad_bt.UseVisualStyleBackColor = true;
            this.hozzaad_bt.Click += new System.EventHandler(this.hozzaad_bt_Click);
            // 
            // modosit_bt
            // 
            this.modosit_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.modosit_bt.Location = new System.Drawing.Point(143, 377);
            this.modosit_bt.Name = "modosit_bt";
            this.modosit_bt.Size = new System.Drawing.Size(157, 45);
            this.modosit_bt.TabIndex = 138;
            this.modosit_bt.Text = "Módosít";
            this.modosit_bt.UseVisualStyleBackColor = true;
            this.modosit_bt.Click += new System.EventHandler(this.modosit_bt_Click);
            // 
            // torol_bt
            // 
            this.torol_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.torol_bt.Location = new System.Drawing.Point(143, 428);
            this.torol_bt.Name = "torol_bt";
            this.torol_bt.Size = new System.Drawing.Size(157, 45);
            this.torol_bt.TabIndex = 139;
            this.torol_bt.Text = "Töröl";
            this.torol_bt.UseVisualStyleBackColor = true;
            this.torol_bt.Click += new System.EventHandler(this.torol_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 308);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 17);
            this.label1.TabIndex = 141;
            this.label1.Text = "Válassz egy műveletet:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 761);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.torol_bt);
            this.Controls.Add(this.modosit_bt);
            this.Controls.Add(this.hozzaad_bt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.allatkert_szektor);
            this.Controls.Add(this.allatkert_eletkor);
            this.Controls.Add(this.allatkert_id);
            this.Controls.Add(this.allatkert_nem);
            this.Controls.Add(this.allatkert_megnv);
            this.Controls.Add(this.Allatkert_Grid);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.Exit_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Allatkert_Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allatkert_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allatkert_eletkor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allatkert_szektor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.DataGridView Allatkert_Grid;
        private System.Windows.Forms.TextBox allatkert_megnv;
        private System.Windows.Forms.TextBox allatkert_nem;
        private System.Windows.Forms.NumericUpDown allatkert_id;
        private System.Windows.Forms.NumericUpDown allatkert_eletkor;
        private System.Windows.Forms.NumericUpDown allatkert_szektor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button hozzaad_bt;
        private System.Windows.Forms.Button modosit_bt;
        private System.Windows.Forms.Button torol_bt;
        private System.Windows.Forms.Label label1;
    }
}

