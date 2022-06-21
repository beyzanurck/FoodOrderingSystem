namespace FoodOrderingSystem
{
    partial class frmDrink
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
            this.lblOrderHeadline = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtOrderHistory = new System.Windows.Forms.RichTextBox();
            this.btnOrderSmothie = new System.Windows.Forms.Button();
            this.btnOrderLime = new System.Windows.Forms.Button();
            this.btnOrderCola = new System.Windows.Forms.Button();
            this.pctSmothie = new System.Windows.Forms.PictureBox();
            this.pctLemonade = new System.Windows.Forms.PictureBox();
            this.pctCola = new System.Windows.Forms.PictureBox();
            this.checkIcedCola = new System.Windows.Forms.CheckBox();
            this.checkIcedLime = new System.Windows.Forms.CheckBox();
            this.checkIcedSmothie = new System.Windows.Forms.CheckBox();
            this.radioSCola = new System.Windows.Forms.RadioButton();
            this.radioMCola = new System.Windows.Forms.RadioButton();
            this.radioLCola = new System.Windows.Forms.RadioButton();
            this.radioSLime = new System.Windows.Forms.RadioButton();
            this.radioMLime = new System.Windows.Forms.RadioButton();
            this.radioLLime = new System.Windows.Forms.RadioButton();
            this.radioSSmothie = new System.Windows.Forms.RadioButton();
            this.radioMSmothie = new System.Windows.Forms.RadioButton();
            this.radioLSmothie = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pctSmothie)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLemonade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCola)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOrderHeadline
            // 
            this.lblOrderHeadline.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblOrderHeadline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOrderHeadline.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrderHeadline.ForeColor = System.Drawing.Color.Black;
            this.lblOrderHeadline.Location = new System.Drawing.Point(594, 18);
            this.lblOrderHeadline.Name = "lblOrderHeadline";
            this.lblOrderHeadline.Size = new System.Drawing.Size(145, 26);
            this.lblOrderHeadline.TabIndex = 23;
            this.lblOrderHeadline.Text = "What You Ordered";
            this.lblOrderHeadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(12, 18);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(58, 26);
            this.btnBack.TabIndex = 22;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // txtOrderHistory
            // 
            this.txtOrderHistory.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOrderHistory.Location = new System.Drawing.Point(579, 50);
            this.txtOrderHistory.Name = "txtOrderHistory";
            this.txtOrderHistory.Size = new System.Drawing.Size(180, 305);
            this.txtOrderHistory.TabIndex = 15;
            this.txtOrderHistory.Text = "";
            // 
            // btnOrderSmothie
            // 
            this.btnOrderSmothie.Location = new System.Drawing.Point(464, 346);
            this.btnOrderSmothie.Name = "btnOrderSmothie";
            this.btnOrderSmothie.Size = new System.Drawing.Size(75, 23);
            this.btnOrderSmothie.TabIndex = 12;
            this.btnOrderSmothie.Text = "Order";
            this.btnOrderSmothie.UseVisualStyleBackColor = true;
            this.btnOrderSmothie.Click += new System.EventHandler(this.btnOrderSmothie_Click);
            // 
            // btnOrderLime
            // 
            this.btnOrderLime.Location = new System.Drawing.Point(248, 346);
            this.btnOrderLime.Name = "btnOrderLime";
            this.btnOrderLime.Size = new System.Drawing.Size(75, 23);
            this.btnOrderLime.TabIndex = 13;
            this.btnOrderLime.Text = "Order";
            this.btnOrderLime.UseVisualStyleBackColor = true;
            this.btnOrderLime.Click += new System.EventHandler(this.btnOrderLime_Click);
            // 
            // btnOrderCola
            // 
            this.btnOrderCola.Location = new System.Drawing.Point(43, 346);
            this.btnOrderCola.Name = "btnOrderCola";
            this.btnOrderCola.Size = new System.Drawing.Size(75, 23);
            this.btnOrderCola.TabIndex = 14;
            this.btnOrderCola.Text = "Order";
            this.btnOrderCola.UseVisualStyleBackColor = true;
            this.btnOrderCola.Click += new System.EventHandler(this.btnOrderCola_Click);
            // 
            // pctSmothie
            // 
            this.pctSmothie.Image = global::FoodOrderingSystem.Properties.Resources.smothie;
            this.pctSmothie.Location = new System.Drawing.Point(433, 50);
            this.pctSmothie.Name = "pctSmothie";
            this.pctSmothie.Size = new System.Drawing.Size(135, 182);
            this.pctSmothie.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctSmothie.TabIndex = 9;
            this.pctSmothie.TabStop = false;
            // 
            // pctLemonade
            // 
            this.pctLemonade.Image = global::FoodOrderingSystem.Properties.Resources.Limonata;
            this.pctLemonade.Location = new System.Drawing.Point(205, 50);
            this.pctLemonade.Name = "pctLemonade";
            this.pctLemonade.Size = new System.Drawing.Size(179, 182);
            this.pctLemonade.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctLemonade.TabIndex = 10;
            this.pctLemonade.TabStop = false;
            // 
            // pctCola
            // 
            this.pctCola.Image = global::FoodOrderingSystem.Properties.Resources.cola;
            this.pctCola.Location = new System.Drawing.Point(12, 50);
            this.pctCola.Name = "pctCola";
            this.pctCola.Size = new System.Drawing.Size(146, 182);
            this.pctCola.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctCola.TabIndex = 11;
            this.pctCola.TabStop = false;
            // 
            // checkIcedCola
            // 
            this.checkIcedCola.AutoSize = true;
            this.checkIcedCola.Location = new System.Drawing.Point(60, 250);
            this.checkIcedCola.Name = "checkIcedCola";
            this.checkIcedCola.Size = new System.Drawing.Size(47, 17);
            this.checkIcedCola.TabIndex = 18;
            this.checkIcedCola.Text = "Iced";
            this.checkIcedCola.UseVisualStyleBackColor = true;
            // 
            // checkIcedLime
            // 
            this.checkIcedLime.AutoSize = true;
            this.checkIcedLime.Location = new System.Drawing.Point(276, 250);
            this.checkIcedLime.Name = "checkIcedLime";
            this.checkIcedLime.Size = new System.Drawing.Size(47, 17);
            this.checkIcedLime.TabIndex = 18;
            this.checkIcedLime.Text = "Iced";
            this.checkIcedLime.UseVisualStyleBackColor = true;
            // 
            // checkIcedSmothie
            // 
            this.checkIcedSmothie.AutoSize = true;
            this.checkIcedSmothie.Location = new System.Drawing.Point(481, 250);
            this.checkIcedSmothie.Name = "checkIcedSmothie";
            this.checkIcedSmothie.Size = new System.Drawing.Size(47, 17);
            this.checkIcedSmothie.TabIndex = 18;
            this.checkIcedSmothie.Text = "Iced";
            this.checkIcedSmothie.UseVisualStyleBackColor = true;
            // 
            // radioSCola
            // 
            this.radioSCola.AutoSize = true;
            this.radioSCola.Location = new System.Drawing.Point(60, 273);
            this.radioSCola.Name = "radioSCola";
            this.radioSCola.Size = new System.Drawing.Size(32, 17);
            this.radioSCola.TabIndex = 24;
            this.radioSCola.TabStop = true;
            this.radioSCola.Text = "S";
            this.radioSCola.UseVisualStyleBackColor = true;
            // 
            // radioMCola
            // 
            this.radioMCola.AutoSize = true;
            this.radioMCola.Location = new System.Drawing.Point(60, 296);
            this.radioMCola.Name = "radioMCola";
            this.radioMCola.Size = new System.Drawing.Size(34, 17);
            this.radioMCola.TabIndex = 24;
            this.radioMCola.TabStop = true;
            this.radioMCola.Text = "M";
            this.radioMCola.UseVisualStyleBackColor = true;
            // 
            // radioLCola
            // 
            this.radioLCola.AutoSize = true;
            this.radioLCola.Location = new System.Drawing.Point(60, 319);
            this.radioLCola.Name = "radioLCola";
            this.radioLCola.Size = new System.Drawing.Size(31, 17);
            this.radioLCola.TabIndex = 24;
            this.radioLCola.TabStop = true;
            this.radioLCola.Text = "L";
            this.radioLCola.UseVisualStyleBackColor = true;
            // 
            // radioSLime
            // 
            this.radioSLime.AutoSize = true;
            this.radioSLime.Location = new System.Drawing.Point(276, 273);
            this.radioSLime.Name = "radioSLime";
            this.radioSLime.Size = new System.Drawing.Size(32, 17);
            this.radioSLime.TabIndex = 24;
            this.radioSLime.TabStop = true;
            this.radioSLime.Text = "S";
            this.radioSLime.UseVisualStyleBackColor = true;
            // 
            // radioMLime
            // 
            this.radioMLime.AutoSize = true;
            this.radioMLime.Location = new System.Drawing.Point(276, 296);
            this.radioMLime.Name = "radioMLime";
            this.radioMLime.Size = new System.Drawing.Size(34, 17);
            this.radioMLime.TabIndex = 24;
            this.radioMLime.TabStop = true;
            this.radioMLime.Text = "M";
            this.radioMLime.UseVisualStyleBackColor = true;
            // 
            // radioLLime
            // 
            this.radioLLime.AutoSize = true;
            this.radioLLime.Location = new System.Drawing.Point(276, 319);
            this.radioLLime.Name = "radioLLime";
            this.radioLLime.Size = new System.Drawing.Size(31, 17);
            this.radioLLime.TabIndex = 24;
            this.radioLLime.TabStop = true;
            this.radioLLime.Text = "L";
            this.radioLLime.UseVisualStyleBackColor = true;
            // 
            // radioSSmothie
            // 
            this.radioSSmothie.AutoSize = true;
            this.radioSSmothie.Location = new System.Drawing.Point(481, 273);
            this.radioSSmothie.Name = "radioSSmothie";
            this.radioSSmothie.Size = new System.Drawing.Size(32, 17);
            this.radioSSmothie.TabIndex = 24;
            this.radioSSmothie.TabStop = true;
            this.radioSSmothie.Text = "S";
            this.radioSSmothie.UseVisualStyleBackColor = true;
            // 
            // radioMSmothie
            // 
            this.radioMSmothie.AutoSize = true;
            this.radioMSmothie.Location = new System.Drawing.Point(481, 296);
            this.radioMSmothie.Name = "radioMSmothie";
            this.radioMSmothie.Size = new System.Drawing.Size(34, 17);
            this.radioMSmothie.TabIndex = 24;
            this.radioMSmothie.TabStop = true;
            this.radioMSmothie.Text = "M";
            this.radioMSmothie.UseVisualStyleBackColor = true;
            // 
            // radioLSmothie
            // 
            this.radioLSmothie.AutoSize = true;
            this.radioLSmothie.Location = new System.Drawing.Point(481, 319);
            this.radioLSmothie.Name = "radioLSmothie";
            this.radioLSmothie.Size = new System.Drawing.Size(31, 17);
            this.radioLSmothie.TabIndex = 24;
            this.radioLSmothie.TabStop = true;
            this.radioLSmothie.Text = "L";
            this.radioLSmothie.UseVisualStyleBackColor = true;
            // 
            // frmDrink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 381);
            this.Controls.Add(this.radioLSmothie);
            this.Controls.Add(this.radioMSmothie);
            this.Controls.Add(this.radioLLime);
            this.Controls.Add(this.radioMLime);
            this.Controls.Add(this.radioSSmothie);
            this.Controls.Add(this.radioLCola);
            this.Controls.Add(this.radioSLime);
            this.Controls.Add(this.radioMCola);
            this.Controls.Add(this.radioSCola);
            this.Controls.Add(this.lblOrderHeadline);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.checkIcedSmothie);
            this.Controls.Add(this.checkIcedLime);
            this.Controls.Add(this.checkIcedCola);
            this.Controls.Add(this.txtOrderHistory);
            this.Controls.Add(this.btnOrderSmothie);
            this.Controls.Add(this.btnOrderLime);
            this.Controls.Add(this.btnOrderCola);
            this.Controls.Add(this.pctSmothie);
            this.Controls.Add(this.pctLemonade);
            this.Controls.Add(this.pctCola);
            this.Name = "frmDrink";
            this.Text = "frmDrink";
            this.Load += new System.EventHandler(this.frmDrink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctSmothie)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctLemonade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctCola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOrderHeadline;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.RichTextBox txtOrderHistory;
        private System.Windows.Forms.Button btnOrderSmothie;
        private System.Windows.Forms.Button btnOrderLime;
        private System.Windows.Forms.Button btnOrderCola;
        private System.Windows.Forms.PictureBox pctSmothie;
        private System.Windows.Forms.PictureBox pctLemonade;
        private System.Windows.Forms.PictureBox pctCola;
        private System.Windows.Forms.CheckBox checkIcedCola;
        private System.Windows.Forms.CheckBox checkIcedLime;
        private System.Windows.Forms.CheckBox checkIcedSmothie;
        private System.Windows.Forms.RadioButton radioSCola;
        private System.Windows.Forms.RadioButton radioMCola;
        private System.Windows.Forms.RadioButton radioLCola;
        private System.Windows.Forms.RadioButton radioSLime;
        private System.Windows.Forms.RadioButton radioMLime;
        private System.Windows.Forms.RadioButton radioLLime;
        private System.Windows.Forms.RadioButton radioSSmothie;
        private System.Windows.Forms.RadioButton radioMSmothie;
        private System.Windows.Forms.RadioButton radioLSmothie;
    }
}