namespace Milestone_Inventory_Application
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.hotPink = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.viewInventory = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchInventory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hotPink)).BeginInit();
            this.SuspendLayout();
            // 
            // hotPink
            // 
            this.hotPink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("hotPink.BackgroundImage")));
            this.hotPink.Location = new System.Drawing.Point(-3, -2);
            this.hotPink.Margin = new System.Windows.Forms.Padding(2);
            this.hotPink.Name = "hotPink";
            this.hotPink.Size = new System.Drawing.Size(196, 369);
            this.hotPink.TabIndex = 0;
            this.hotPink.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Inventory Management";
            // 
            // viewInventory
            // 
            this.viewInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.viewInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewInventory.Location = new System.Drawing.Point(46, 74);
            this.viewInventory.Margin = new System.Windows.Forms.Padding(2);
            this.viewInventory.Name = "viewInventory";
            this.viewInventory.Size = new System.Drawing.Size(85, 50);
            this.viewInventory.TabIndex = 2;
            this.viewInventory.Text = "View Inventory";
            this.viewInventory.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(46, 128);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "Add Inventory";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchInventory
            // 
            this.searchInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.searchInventory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchInventory.Location = new System.Drawing.Point(46, 178);
            this.searchInventory.Margin = new System.Windows.Forms.Padding(2);
            this.searchInventory.Name = "searchInventory";
            this.searchInventory.Size = new System.Drawing.Size(85, 49);
            this.searchInventory.TabIndex = 4;
            this.searchInventory.Text = "Search Inventory";
            this.searchInventory.UseVisualStyleBackColor = false;
            this.searchInventory.Click += new System.EventHandler(this.searchInventory_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1099, 605);
            this.Controls.Add(this.searchInventory);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.viewInventory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hotPink);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Main";
            this.Text = "Crafty Southern Heifers";
            ((System.ComponentModel.ISupportInitialize)(this.hotPink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox hotPink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button viewInventory;
        private System.Windows.Forms.Button searchInventory;
        public System.Windows.Forms.Button button1;
    }
}

