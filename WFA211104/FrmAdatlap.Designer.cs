
namespace WFA211104
{
    partial class FrmAdatlap
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
            this.label1 = new System.Windows.Forms.Label();
            this.cbTulajok = new System.Windows.Forms.ComboBox();
            this.nudSuly = new System.Windows.Forms.NumericUpDown();
            this.rbKanca = new System.Windows.Forms.RadioButton();
            this.pbUni = new System.Windows.Forms.PictureBox();
            this.BtmInsert = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rbCsodor = new System.Windows.Forms.RadioButton();
            this.cbFajtak = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudSuly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUni)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Thistle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(105, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fajta:";
            // 
            // cbTulajok
            // 
            this.cbTulajok.BackColor = System.Drawing.Color.Thistle;
            this.cbTulajok.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTulajok.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbTulajok.FormattingEnabled = true;
            this.cbTulajok.Location = new System.Drawing.Point(199, 145);
            this.cbTulajok.Name = "cbTulajok";
            this.cbTulajok.Size = new System.Drawing.Size(156, 28);
            this.cbTulajok.TabIndex = 1;
            // 
            // nudSuly
            // 
            this.nudSuly.BackColor = System.Drawing.Color.Thistle;
            this.nudSuly.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nudSuly.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudSuly.Location = new System.Drawing.Point(229, 200);
            this.nudSuly.Maximum = new decimal(new int[] {
            550,
            0,
            0,
            0});
            this.nudSuly.Name = "nudSuly";
            this.nudSuly.Size = new System.Drawing.Size(88, 26);
            this.nudSuly.TabIndex = 2;
            this.nudSuly.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // rbKanca
            // 
            this.rbKanca.AutoSize = true;
            this.rbKanca.BackColor = System.Drawing.Color.Thistle;
            this.rbKanca.Checked = true;
            this.rbKanca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbKanca.Location = new System.Drawing.Point(199, 254);
            this.rbKanca.Name = "rbKanca";
            this.rbKanca.Size = new System.Drawing.Size(72, 24);
            this.rbKanca.TabIndex = 3;
            this.rbKanca.TabStop = true;
            this.rbKanca.Text = "Kanca";
            this.rbKanca.UseVisualStyleBackColor = false;
            // 
            // pbUni
            // 
            this.pbUni.BackColor = System.Drawing.Color.Thistle;
            this.pbUni.Location = new System.Drawing.Point(487, 54);
            this.pbUni.Name = "pbUni";
            this.pbUni.Size = new System.Drawing.Size(200, 250);
            this.pbUni.TabIndex = 4;
            this.pbUni.TabStop = false;
            // 
            // BtmInsert
            // 
            this.BtmInsert.BackColor = System.Drawing.Color.Thistle;
            this.BtmInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BtmInsert.Location = new System.Drawing.Point(68, 363);
            this.BtmInsert.Name = "BtmInsert";
            this.BtmInsert.Size = new System.Drawing.Size(619, 58);
            this.BtmInsert.TabIndex = 5;
            this.BtmInsert.Text = "Új egyed rögzítése az adatbázisba";
            this.BtmInsert.UseVisualStyleBackColor = false;
            this.BtmInsert.Click += new System.EventHandler(this.BtmInsert_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Thistle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(64, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tulajdonos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(111, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Súly:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Thistle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(108, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Nem:";
            // 
            // rbCsodor
            // 
            this.rbCsodor.AutoSize = true;
            this.rbCsodor.BackColor = System.Drawing.Color.Thistle;
            this.rbCsodor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbCsodor.Location = new System.Drawing.Point(277, 254);
            this.rbCsodor.Name = "rbCsodor";
            this.rbCsodor.Size = new System.Drawing.Size(78, 24);
            this.rbCsodor.TabIndex = 3;
            this.rbCsodor.Text = "Csődör";
            this.rbCsodor.UseVisualStyleBackColor = false;
            // 
            // cbFajtak
            // 
            this.cbFajtak.BackColor = System.Drawing.Color.Thistle;
            this.cbFajtak.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFajtak.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbFajtak.FormattingEnabled = true;
            this.cbFajtak.Location = new System.Drawing.Point(199, 91);
            this.cbFajtak.Name = "cbFajtak";
            this.cbFajtak.Size = new System.Drawing.Size(156, 28);
            this.cbFajtak.TabIndex = 1;
            this.cbFajtak.SelectedIndexChanged += new System.EventHandler(this.CbFajtak_SelectedIndexChanged);
            // 
            // FrmAdatlap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(745, 479);
            this.Controls.Add(this.BtmInsert);
            this.Controls.Add(this.pbUni);
            this.Controls.Add(this.rbCsodor);
            this.Controls.Add(this.rbKanca);
            this.Controls.Add(this.nudSuly);
            this.Controls.Add(this.cbFajtak);
            this.Controls.Add(this.cbTulajok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmAdatlap";
            this.Text = "FrmAdatlap";
            this.Load += new System.EventHandler(this.FrmAdatlap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudSuly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbUni)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbTulajok;
        private System.Windows.Forms.NumericUpDown nudSuly;
        private System.Windows.Forms.RadioButton rbKanca;
        private System.Windows.Forms.PictureBox pbUni;
        private System.Windows.Forms.Button BtmInsert;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbCsodor;
        private System.Windows.Forms.ComboBox cbFajtak;
    }
}