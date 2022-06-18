namespace FoodOrderingSystem
{
    partial class frmFood
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
            this.pctShawarma = new System.Windows.Forms.PictureBox();
            this.pctCheeseBurger = new System.Windows.Forms.PictureBox();
            this.pctHamburger = new System.Windows.Forms.PictureBox();
            this.btnOrderHam = new System.Windows.Forms.Button();
            this.btnOrderCB = new System.Windows.Forms.Button();
            this.btnOrderSha = new System.Windows.Forms.Button();
            this.txtOrderHistory = new System.Windows.Forms.RichTextBox();
            this.checkHamDouble = new System.Windows.Forms.CheckBox();
            this.checkHamSpicy = new System.Windows.Forms.CheckBox();
            this.checkCBDouble = new System.Windows.Forms.CheckBox();
            this.checkCBSpicy = new System.Windows.Forms.CheckBox();
            this.checkShaDouble = new System.Windows.Forms.CheckBox();
            this.checkShaSpicy = new System.Windows.Forms.CheckBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblOrderHeadline = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctShawarma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCheeseBurger)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHamburger)).BeginInit();
            this.SuspendLayout();
            // 
            // pctShawarma
            // 
            this.pctShawarma.Image = global::FoodOrderingSystem.Properties.Resources.Shawarma;
            this.pctShawarma.Location = new System.Drawing.Point(388, 60);
            this.pctShawarma.Name = "pctShawarma";
            this.pctShawarma.Size = new System.Drawing.Size(163, 160);
            this.pctShawarma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctShawarma.TabIndex = 0;
            this.pctShawarma.TabStop = false;
            // 
            // pctCheeseBurger
            // 
            this.pctCheeseBurger.Image = global::FoodOrderingSystem.Properties.Resources.Ekran_Alıntısı;
            this.pctCheeseBurger.Location = new System.Drawing.Point(202, 60);
            this.pctCheeseBurger.Name = "pctCheeseBurger";
            this.pctCheeseBurger.Size = new System.Drawing.Size(167, 160);
            this.pctCheeseBurger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCheeseBurger.TabIndex = 0;
            this.pctCheeseBurger.TabStop = false;
            // 
            // pctHamburger
            // 
            this.pctHamburger.Image = global::FoodOrderingSystem.Properties.Resources.hamburger;
            this.pctHamburger.Location = new System.Drawing.Point(12, 60);
            this.pctHamburger.Name = "pctHamburger";
            this.pctHamburger.Size = new System.Drawing.Size(169, 160);
            this.pctHamburger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctHamburger.TabIndex = 0;
            this.pctHamburger.TabStop = false;
            // 
            // btnOrderHam
            // 
            this.btnOrderHam.Location = new System.Drawing.Point(52, 316);
            this.btnOrderHam.Name = "btnOrderHam";
            this.btnOrderHam.Size = new System.Drawing.Size(75, 23);
            this.btnOrderHam.TabIndex = 1;
            this.btnOrderHam.Text = "Order";
            this.btnOrderHam.UseVisualStyleBackColor = true;
            this.btnOrderHam.Click += new System.EventHandler(this.btnOrderHam_Click);
            // 
            // btnOrderCB
            // 
            this.btnOrderCB.Location = new System.Drawing.Point(248, 316);
            this.btnOrderCB.Name = "btnOrderCB";
            this.btnOrderCB.Size = new System.Drawing.Size(75, 23);
            this.btnOrderCB.TabIndex = 1;
            this.btnOrderCB.Text = "Order";
            this.btnOrderCB.UseVisualStyleBackColor = true;
            this.btnOrderCB.Click += new System.EventHandler(this.btnOrderCB_Click);
            // 
            // btnOrderSha
            // 
            this.btnOrderSha.Location = new System.Drawing.Point(433, 316);
            this.btnOrderSha.Name = "btnOrderSha";
            this.btnOrderSha.Size = new System.Drawing.Size(75, 23);
            this.btnOrderSha.TabIndex = 1;
            this.btnOrderSha.Text = "Order";
            this.btnOrderSha.UseVisualStyleBackColor = true;
            this.btnOrderSha.Click += new System.EventHandler(this.btnOrderSha_Click);
            // 
            // txtOrderHistory
            // 
            this.txtOrderHistory.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOrderHistory.Location = new System.Drawing.Point(591, 60);
            this.txtOrderHistory.Name = "txtOrderHistory";
            this.txtOrderHistory.Size = new System.Drawing.Size(180, 293);
            this.txtOrderHistory.TabIndex = 2;
            this.txtOrderHistory.Text = "";
            // 
            // checkHamDouble
            // 
            this.checkHamDouble.AutoSize = true;
            this.checkHamDouble.Location = new System.Drawing.Point(52, 281);
            this.checkHamDouble.Name = "checkHamDouble";
            this.checkHamDouble.Size = new System.Drawing.Size(87, 17);
            this.checkHamDouble.TabIndex = 5;
            this.checkHamDouble.Text = "Double Meat";
            this.checkHamDouble.UseVisualStyleBackColor = true;
            // 
            // checkHamSpicy
            // 
            this.checkHamSpicy.AutoSize = true;
            this.checkHamSpicy.Location = new System.Drawing.Point(52, 248);
            this.checkHamSpicy.Name = "checkHamSpicy";
            this.checkHamSpicy.Size = new System.Drawing.Size(52, 17);
            this.checkHamSpicy.TabIndex = 6;
            this.checkHamSpicy.Text = "Spicy";
            this.checkHamSpicy.UseVisualStyleBackColor = true;
            // 
            // checkCBDouble
            // 
            this.checkCBDouble.AutoSize = true;
            this.checkCBDouble.Location = new System.Drawing.Point(248, 281);
            this.checkCBDouble.Name = "checkCBDouble";
            this.checkCBDouble.Size = new System.Drawing.Size(87, 17);
            this.checkCBDouble.TabIndex = 5;
            this.checkCBDouble.Text = "Double Meat";
            this.checkCBDouble.UseVisualStyleBackColor = true;
            // 
            // checkCBSpicy
            // 
            this.checkCBSpicy.AutoSize = true;
            this.checkCBSpicy.Location = new System.Drawing.Point(248, 248);
            this.checkCBSpicy.Name = "checkCBSpicy";
            this.checkCBSpicy.Size = new System.Drawing.Size(52, 17);
            this.checkCBSpicy.TabIndex = 6;
            this.checkCBSpicy.Text = "Spicy";
            this.checkCBSpicy.UseVisualStyleBackColor = true;
            // 
            // checkShaDouble
            // 
            this.checkShaDouble.AutoSize = true;
            this.checkShaDouble.Location = new System.Drawing.Point(433, 281);
            this.checkShaDouble.Name = "checkShaDouble";
            this.checkShaDouble.Size = new System.Drawing.Size(102, 17);
            this.checkShaDouble.TabIndex = 5;
            this.checkShaDouble.Text = "Double Chicken";
            this.checkShaDouble.UseVisualStyleBackColor = true;
            // 
            // checkShaSpicy
            // 
            this.checkShaSpicy.AutoSize = true;
            this.checkShaSpicy.Location = new System.Drawing.Point(433, 248);
            this.checkShaSpicy.Name = "checkShaSpicy";
            this.checkShaSpicy.Size = new System.Drawing.Size(52, 17);
            this.checkShaSpicy.TabIndex = 6;
            this.checkShaSpicy.Text = "Spicy";
            this.checkShaSpicy.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(12, 23);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 26);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblOrderHeadline
            // 
            this.lblOrderHeadline.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOrderHeadline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderHeadline.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderHeadline.ForeColor = System.Drawing.Color.Black;
            this.lblOrderHeadline.Location = new System.Drawing.Point(613, 23);
            this.lblOrderHeadline.Name = "lblOrderHeadline";
            this.lblOrderHeadline.Size = new System.Drawing.Size(145, 26);
            this.lblOrderHeadline.TabIndex = 8;
            this.lblOrderHeadline.Text = "What You Ordered";
            this.lblOrderHeadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmFood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 381);
            this.Controls.Add(this.lblOrderHeadline);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.checkShaSpicy);
            this.Controls.Add(this.checkCBSpicy);
            this.Controls.Add(this.checkHamSpicy);
            this.Controls.Add(this.checkShaDouble);
            this.Controls.Add(this.checkCBDouble);
            this.Controls.Add(this.checkHamDouble);
            this.Controls.Add(this.txtOrderHistory);
            this.Controls.Add(this.btnOrderSha);
            this.Controls.Add(this.btnOrderCB);
            this.Controls.Add(this.btnOrderHam);
            this.Controls.Add(this.pctShawarma);
            this.Controls.Add(this.pctCheeseBurger);
            this.Controls.Add(this.pctHamburger);
            this.Name = "frmFood";
            this.Text = "Food Section";
            this.Load += new System.EventHandler(this.frmFood_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctShawarma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCheeseBurger)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctHamburger)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctHamburger;
        private System.Windows.Forms.PictureBox pctCheeseBurger;
        private System.Windows.Forms.PictureBox pctShawarma;
        private System.Windows.Forms.Button btnOrderHam;
        private System.Windows.Forms.Button btnOrderCB;
        private System.Windows.Forms.Button btnOrderSha;
        private System.Windows.Forms.RichTextBox txtOrderHistory;
        private System.Windows.Forms.CheckBox checkHamDouble;
        private System.Windows.Forms.CheckBox checkHamSpicy;
        private System.Windows.Forms.CheckBox checkCBDouble;
        private System.Windows.Forms.CheckBox checkCBSpicy;
        private System.Windows.Forms.CheckBox checkShaDouble;
        private System.Windows.Forms.CheckBox checkShaSpicy;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblOrderHeadline;
    }
}