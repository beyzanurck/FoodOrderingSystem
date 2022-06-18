namespace FoodOrderingSystem
{
    partial class frmMain
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
            this.pctMainMenu = new System.Windows.Forms.PictureBox();
            this.pctDrink = new System.Windows.Forms.PictureBox();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.btnDrink = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctMainMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDrink)).BeginInit();
            this.SuspendLayout();
            // 
            // pctMainMenu
            // 
            this.pctMainMenu.Image = global::FoodOrderingSystem.Properties.Resources.mainCover;
            this.pctMainMenu.Location = new System.Drawing.Point(96, 61);
            this.pctMainMenu.Name = "pctMainMenu";
            this.pctMainMenu.Size = new System.Drawing.Size(180, 232);
            this.pctMainMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctMainMenu.TabIndex = 0;
            this.pctMainMenu.TabStop = false;
            // 
            // pctDrink
            // 
            this.pctDrink.Image = global::FoodOrderingSystem.Properties.Resources.drinkCover;
            this.pctDrink.Location = new System.Drawing.Point(392, 61);
            this.pctDrink.Name = "pctDrink";
            this.pctDrink.Size = new System.Drawing.Size(180, 232);
            this.pctDrink.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctDrink.TabIndex = 0;
            this.pctDrink.TabStop = false;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(132, 311);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(107, 29);
            this.btnMainMenu.TabIndex = 1;
            this.btnMainMenu.Text = "Food";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // btnDrink
            // 
            this.btnDrink.Location = new System.Drawing.Point(439, 311);
            this.btnDrink.Name = "btnDrink";
            this.btnDrink.Size = new System.Drawing.Size(107, 29);
            this.btnDrink.TabIndex = 1;
            this.btnDrink.Text = "Drink";
            this.btnDrink.UseVisualStyleBackColor = true;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Yellowtail", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(286, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 26);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Welcome";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 381);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnDrink);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.pctDrink);
            this.Controls.Add(this.pctMainMenu);
            this.Name = "frmMain";
            this.Text = "Food Ordering System";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctMainMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctDrink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pctMainMenu;
        private System.Windows.Forms.PictureBox pctDrink;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Button btnDrink;
        private System.Windows.Forms.Label lblName;
    }
}

