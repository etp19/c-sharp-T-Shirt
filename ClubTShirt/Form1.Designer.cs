namespace ClubTShirt
{
    partial class T_Shirt_Sell
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
            this.Size_Label = new MetroFramework.Controls.MetroLabel();
            this.Amount_label = new MetroFramework.Controls.MetroLabel();
            this.size_chose = new MetroFramework.Controls.MetroComboBox();
            this.Make_Order = new MetroFramework.Controls.MetroButton();
            this.Process_menu = new System.Windows.Forms.MenuStrip();
            this.processToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Process_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Size_Label
            // 
            this.Size_Label.AutoSize = true;
            this.Size_Label.Location = new System.Drawing.Point(23, 161);
            this.Size_Label.Name = "Size_Label";
            this.Size_Label.Size = new System.Drawing.Size(70, 19);
            this.Size_Label.TabIndex = 0;
            this.Size_Label.Text = "Select Size";
            // 
            // Amount_label
            // 
            this.Amount_label.AutoSize = true;
            this.Amount_label.Location = new System.Drawing.Point(23, 212);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(90, 19);
            this.Amount_label.TabIndex = 0;
            this.Amount_label.Text = "Enter Amount";
            // 
            // size_chose
            // 
            this.size_chose.FormattingEnabled = true;
            this.size_chose.ItemHeight = 23;
            this.size_chose.Location = new System.Drawing.Point(152, 161);
            this.size_chose.Name = "size_chose";
            this.size_chose.Size = new System.Drawing.Size(121, 29);
            this.size_chose.TabIndex = 1;
            this.size_chose.UseSelectable = true;
            // 
            // Make_Order
            // 
            this.Make_Order.Location = new System.Drawing.Point(287, 321);
            this.Make_Order.Name = "Make_Order";
            this.Make_Order.Size = new System.Drawing.Size(94, 34);
            this.Make_Order.TabIndex = 2;
            this.Make_Order.Text = "Make Order";
            this.Make_Order.UseSelectable = true;
            // 
            // Process_menu
            // 
            this.Process_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.processToolStripMenuItem});
            this.Process_menu.Location = new System.Drawing.Point(20, 60);
            this.Process_menu.Name = "Process_menu";
            this.Process_menu.Size = new System.Drawing.Size(370, 24);
            this.Process_menu.TabIndex = 3;
            this.Process_menu.Text = "Process";
            // 
            // processToolStripMenuItem
            // 
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(52, 19);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // T_Shirt_Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 378);
            this.Controls.Add(this.Make_Order);
            this.Controls.Add(this.size_chose);
            this.Controls.Add(this.Amount_label);
            this.Controls.Add(this.Size_Label);
            this.Controls.Add(this.Process_menu);
            this.MainMenuStrip = this.Process_menu;
            this.Name = "T_Shirt_Sell";
            this.Text = "T-Shirt";
            this.Process_menu.ResumeLayout(false);
            this.Process_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel Size_Label;
        private MetroFramework.Controls.MetroLabel Amount_label;
        private MetroFramework.Controls.MetroComboBox size_chose;
        private MetroFramework.Controls.MetroButton Make_Order;
        private System.Windows.Forms.MenuStrip Process_menu;
        private System.Windows.Forms.ToolStripMenuItem processToolStripMenuItem;
    }
}

