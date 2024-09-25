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
            BtnKalkuluj = new Button();
            LblWalutaPoKalk = new Label();
            GrpBoxToWaluta = new GroupBox();
            NumBoxWalutaDoKalk = new NumericUpDown();
            NumBoxWalutaPoKalk = new NumericUpDown();
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
            RadBtnToUSD.Size = new Size(61, 19);
            RadBtnToUSD.TabIndex = 0;
            RadBtnToUSD.TabStop = true;
            RadBtnToUSD.Text = "to USD";
            RadBtnToUSD.UseVisualStyleBackColor = true;
            // 
            // RadBtnToEUR
            // 
            RadBtnToEUR.AutoSize = true;
            RadBtnToEUR.Location = new Point(73, 15);
            RadBtnToEUR.Name = "RadBtnToEUR";
            RadBtnToEUR.Size = new Size(60, 19);
            RadBtnToEUR.TabIndex = 1;
            RadBtnToEUR.TabStop = true;
            RadBtnToEUR.Text = "to EUR";
            RadBtnToEUR.UseVisualStyleBackColor = true;
            // 
            // RadBtnToRUB
            // 
            RadBtnToRUB.AutoSize = true;
            RadBtnToRUB.Location = new Point(139, 15);
            RadBtnToRUB.Name = "RadBtnToRUB";
            RadBtnToRUB.Size = new Size(61, 19);
            RadBtnToRUB.TabIndex = 2;
            RadBtnToRUB.TabStop = true;
            RadBtnToRUB.Text = "to RUB";
            RadBtnToRUB.UseVisualStyleBackColor = true;
            // 
            // RadBtnToBAT
            // 
            RadBtnToBAT.AutoSize = true;
            RadBtnToBAT.Location = new Point(206, 15);
            RadBtnToBAT.Name = "RadBtnToBAT";
            RadBtnToBAT.Size = new Size(59, 19);
            RadBtnToBAT.TabIndex = 3;
            RadBtnToBAT.TabStop = true;
            RadBtnToBAT.Text = "to BAT";
            RadBtnToBAT.UseVisualStyleBackColor = true;
            // 
            // BtnKalkuluj
            // 
            BtnKalkuluj.Location = new Point(12, 56);
            BtnKalkuluj.Name = "BtnKalkuluj";
            BtnKalkuluj.Size = new Size(480, 23);
            BtnKalkuluj.TabIndex = 5;
            BtnKalkuluj.Text = "Kalkuluj";
            BtnKalkuluj.UseVisualStyleBackColor = true;
            BtnKalkuluj.Click += BtnKalkuluj_Click;
            // 
            // LblWalutaPoKalk
            // 
            LblWalutaPoKalk.AutoSize = true;
            LblWalutaPoKalk.Location = new Point(423, 9);
            LblWalutaPoKalk.Name = "LblWalutaPoKalk";
            LblWalutaPoKalk.Size = new Size(0, 15);
            LblWalutaPoKalk.TabIndex = 1;
            // 
            // GrpBoxToWaluta
            // 
            GrpBoxToWaluta.Controls.Add(RadBtnToUSD);
            GrpBoxToWaluta.Controls.Add(RadBtnToEUR);
            GrpBoxToWaluta.Controls.Add(RadBtnToRUB);
            GrpBoxToWaluta.Controls.Add(RadBtnToBAT);
            GrpBoxToWaluta.Location = new Point(118, 12);
            GrpBoxToWaluta.Name = "GrpBoxToWaluta";
            GrpBoxToWaluta.Size = new Size(268, 38);
            GrpBoxToWaluta.TabIndex = 3;
            GrpBoxToWaluta.TabStop = false;
            GrpBoxToWaluta.Text = "Typ kalkulacji";
            // 
            // NumBoxWalutaDoKalk
            // 
            NumBoxWalutaDoKalk.DecimalPlaces = 2;
            NumBoxWalutaDoKalk.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NumBoxWalutaDoKalk.Location = new Point(12, 23);
            NumBoxWalutaDoKalk.Name = "NumBoxWalutaDoKalk";
            NumBoxWalutaDoKalk.Size = new Size(100, 23);
            NumBoxWalutaDoKalk.TabIndex = 2;
            // 
            // NumBoxWalutaPoKalk
            // 
            NumBoxWalutaPoKalk.DecimalPlaces = 2;
            NumBoxWalutaPoKalk.Increment = new decimal(new int[] { 1, 0, 0, 131072 });
            NumBoxWalutaPoKalk.Location = new Point(392, 23);
            NumBoxWalutaPoKalk.Name = "NumBoxWalutaPoKalk";
            NumBoxWalutaPoKalk.Size = new Size(100, 23);
            NumBoxWalutaPoKalk.TabIndex = 4;
            // 
            // FormPrzelicznikWalut
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 90);
            Controls.Add(NumBoxWalutaPoKalk);
            Controls.Add(NumBoxWalutaDoKalk);
            Controls.Add(GrpBoxToWaluta);
            Controls.Add(LblWalutaPoKalk);
            Controls.Add(BtnKalkuluj);
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
        private Button BtnKalkuluj;
        private Label LblWalutaPoKalk;
        private GroupBox GrpBoxToWaluta;
        private NumericUpDown NumBoxWalutaDoKalk;
        private NumericUpDown NumBoxWalutaPoKalk;
    }
}
