namespace PrzeliczanieNBP
{
    partial class FormPrzelicznikWalut
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LblWalutaDoKalk = new Label();
            RadBtnToUSD = new RadioButton();
            RadBtnToEUR = new RadioButton();
            RadBtnToRUB = new RadioButton();
            RadBtnToBAT = new RadioButton();
            BtnKalkulujZPLN = new Button();
            LblWalutaPoKalk = new Label();
            GrpBoxToWaluta = new GroupBox();
            NumBoxWalutaDoKalk = new NumericUpDown();
            NumBoxWalutaPoKalk = new NumericUpDown();
            BtnKalkulujDoPLN = new Button();
            GrpBoxToWaluta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumBoxWalutaDoKalk).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumBoxWalutaPoKalk).BeginInit();
            SuspendLayout();
            // 
            // LblWalutaDoKalk
            // 
            LblWalutaDoKalk.AutoSize = true;
            LblWalutaDoKalk.Location = new Point(42, 9);
            LblWalutaDoKalk.Name = "LblWalutaDoKalk";
            LblWalutaDoKalk.Size = new Size(29, 15);
            LblWalutaDoKalk.TabIndex = 0;
            LblWalutaDoKalk.Text = "PLN";
            // 
            // RadBtnToUSD
            // 
            RadBtnToUSD.AutoSize = true;
            RadBtnToUSD.Location = new Point(6, 15);
            RadBtnToUSD.Name = "RadBtnToUSD";
            RadBtnToUSD.Size = new Size(92, 19);
            RadBtnToUSD.TabIndex = 0;
            RadBtnToUSD.TabStop = true;
            RadBtnToUSD.Text = "to/from USD";
            RadBtnToUSD.UseVisualStyleBackColor = true;
            RadBtnToUSD.CheckedChanged += RadBtnToUSD_CheckedChanged;
            // 
            // RadBtnToEUR
            // 
            RadBtnToEUR.AutoSize = true;
            RadBtnToEUR.Location = new Point(104, 15);
            RadBtnToEUR.Name = "RadBtnToEUR";
            RadBtnToEUR.Size = new Size(91, 19);
            RadBtnToEUR.TabIndex = 1;
            RadBtnToEUR.TabStop = true;
            RadBtnToEUR.Text = "to/from EUR";
            RadBtnToEUR.UseVisualStyleBackColor = true;
            RadBtnToEUR.CheckedChanged += RadBtnToEUR_CheckedChanged;
            // 
            // RadBtnToRUB
            // 
            RadBtnToRUB.AutoSize = true;
            RadBtnToRUB.Location = new Point(6, 40);
            RadBtnToRUB.Name = "RadBtnToRUB";
            RadBtnToRUB.Size = new Size(92, 19);
            RadBtnToRUB.TabIndex = 2;
            RadBtnToRUB.TabStop = true;
            RadBtnToRUB.Text = "to/from RUB";
            RadBtnToRUB.UseVisualStyleBackColor = true;
            RadBtnToRUB.CheckedChanged += RadBtnToRUB_CheckedChanged;
            // 
            // RadBtnToBAT
            // 
            RadBtnToBAT.AutoSize = true;
            RadBtnToBAT.Location = new Point(104, 40);
            RadBtnToBAT.Name = "RadBtnToBAT";
            RadBtnToBAT.Size = new Size(90, 19);
            RadBtnToBAT.TabIndex = 3;
            RadBtnToBAT.TabStop = true;
            RadBtnToBAT.Text = "to/from BAT";
            RadBtnToBAT.UseVisualStyleBackColor = true;
            RadBtnToBAT.CheckedChanged += RadBtnToBAT_CheckedChanged;
            // 
            // BtnKalkulujZPLN
            // 
            BtnKalkulujZPLN.Location = new Point(12, 83);
            BtnKalkulujZPLN.Name = "BtnKalkulujZPLN";
            BtnKalkulujZPLN.Size = new Size(204, 23);
            BtnKalkulujZPLN.TabIndex = 5;
            BtnKalkulujZPLN.Text = "Kalkuluj z PLN";
            BtnKalkulujZPLN.UseVisualStyleBackColor = true;
            BtnKalkulujZPLN.Click += BtnKalkuluj_Click;
            // 
            // LblWalutaPoKalk
            // 
            LblWalutaPoKalk.AutoSize = true;
            LblWalutaPoKalk.Location = new Point(342, 9);
            LblWalutaPoKalk.Name = "LblWalutaPoKalk";
            LblWalutaPoKalk.Size = new Size(0, 15);
            LblWalutaPoKalk.TabIndex = 1;
            // 
            // GrpBoxToWaluta
            // 
            GrpBoxToWaluta.Controls.Add(RadBtnToUSD);
            GrpBoxToWaluta.Controls.Add(RadBtnToEUR);
            GrpBoxToWaluta.Controls.Add(RadBtnToBAT);
            GrpBoxToWaluta.Controls.Add(RadBtnToRUB);
            GrpBoxToWaluta.Location = new Point(118, 12);
            GrpBoxToWaluta.Name = "GrpBoxToWaluta";
            GrpBoxToWaluta.Size = new Size(201, 65);
            GrpBoxToWaluta.TabIndex = 3;
            GrpBoxToWaluta.TabStop = false;
            GrpBoxToWaluta.Text = "Typ kalkulacji";
            // 
            // NumBoxWalutaDoKalk
            // 
            NumBoxWalutaDoKalk.DecimalPlaces = 2;
            NumBoxWalutaDoKalk.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NumBoxWalutaDoKalk.Location = new Point(12, 23);
            NumBoxWalutaDoKalk.Maximum = new decimal(new int[] { -1981284352, -1966660860, 0, 0 });
            NumBoxWalutaDoKalk.Name = "NumBoxWalutaDoKalk";
            NumBoxWalutaDoKalk.Size = new Size(100, 23);
            NumBoxWalutaDoKalk.TabIndex = 2;
            // 
            // NumBoxWalutaPoKalk
            // 
            NumBoxWalutaPoKalk.DecimalPlaces = 2;
            NumBoxWalutaPoKalk.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NumBoxWalutaPoKalk.Location = new Point(325, 23);
            NumBoxWalutaPoKalk.Maximum = new decimal(new int[] { -159383552, 46653770, 5421, 0 });
            NumBoxWalutaPoKalk.Name = "NumBoxWalutaPoKalk";
            NumBoxWalutaPoKalk.Size = new Size(102, 23);
            NumBoxWalutaPoKalk.TabIndex = 4;
            // 
            // BtnKalkulujDoPLN
            // 
            BtnKalkulujDoPLN.Location = new Point(222, 83);
            BtnKalkulujDoPLN.Name = "BtnKalkulujDoPLN";
            BtnKalkulujDoPLN.Size = new Size(205, 23);
            BtnKalkulujDoPLN.TabIndex = 6;
            BtnKalkulujDoPLN.Text = "Kalkuluj do PLN";
            BtnKalkulujDoPLN.UseVisualStyleBackColor = true;
            BtnKalkulujDoPLN.Click += BtnKalkulujDoPLN_Click;
            // 
            // FormPrzelicznikWalut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 118);
            Controls.Add(BtnKalkulujDoPLN);
            Controls.Add(NumBoxWalutaPoKalk);
            Controls.Add(NumBoxWalutaDoKalk);
            Controls.Add(GrpBoxToWaluta);
            Controls.Add(LblWalutaPoKalk);
            Controls.Add(BtnKalkulujZPLN);
            Controls.Add(LblWalutaDoKalk);
            Name = "FormPrzelicznikWalut";
            Text = "PrzelicznikWalut";
            GrpBoxToWaluta.ResumeLayout(false);
            GrpBoxToWaluta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumBoxWalutaDoKalk).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumBoxWalutaPoKalk).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label LblWalutaDoKalk;
        private RadioButton RadBtnToUSD;
        private RadioButton RadBtnToEUR;
        private RadioButton RadBtnToRUB;
        private RadioButton RadBtnToBAT;
        private Button BtnKalkulujZPLN;
        private Label LblWalutaPoKalk;
        private GroupBox GrpBoxToWaluta;
        private NumericUpDown NumBoxWalutaDoKalk;
        private NumericUpDown NumBoxWalutaPoKalk;
        private Button BtnKalkulujDoPLN;
    }
}
