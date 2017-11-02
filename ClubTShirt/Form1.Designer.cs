using System.ComponentModel;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace ClubTShirt
{
    partial class T_Shirt_Sell
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.displayOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Amount_TextBox = new MetroFramework.Controls.MetroTextBox();
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
            this.Amount_label.Location = new System.Drawing.Point(23, 225);
            this.Amount_label.Name = "Amount_label";
            this.Amount_label.Size = new System.Drawing.Size(90, 19);
            this.Amount_label.TabIndex = 0;
            this.Amount_label.Text = "Enter Amount";
            // 
            // size_chose
            // 
            this.size_chose.FormattingEnabled = true;
            this.size_chose.ItemHeight = 23;
            this.size_chose.Items.AddRange(new object[] {
            "S",
            "M",
            "L",
            "XL"});
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
            this.Make_Order.Click += new System.EventHandler(this.Make_Order_Click);
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
            this.processToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.displayOrderToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.processToolStripMenuItem.Name = "processToolStripMenuItem";
            this.processToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.processToolStripMenuItem.Text = "Process";
            // 
            // displayOrderToolStripMenuItem
            // 
            this.displayOrderToolStripMenuItem.Name = "displayOrderToolStripMenuItem";
            this.displayOrderToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.displayOrderToolStripMenuItem.Text = "Display Order";
            this.displayOrderToolStripMenuItem.Click += new System.EventHandler(this.displayOrderToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // Amount_TextBox
            // 
            // 
            // 
            // 
            this.Amount_TextBox.CustomButton.Image = null;
            this.Amount_TextBox.CustomButton.Location = new System.Drawing.Point(99, 1);
            this.Amount_TextBox.CustomButton.Name = "";
            this.Amount_TextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.Amount_TextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.Amount_TextBox.CustomButton.TabIndex = 1;
            this.Amount_TextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Amount_TextBox.CustomButton.UseSelectable = true;
            this.Amount_TextBox.CustomButton.Visible = false;
            this.Amount_TextBox.Lines = new string[0];
            this.Amount_TextBox.Location = new System.Drawing.Point(152, 220);
            this.Amount_TextBox.MaxLength = 32767;
            this.Amount_TextBox.Name = "Amount_TextBox";
            this.Amount_TextBox.PasswordChar = '\0';
            this.Amount_TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.Amount_TextBox.SelectedText = "";
            this.Amount_TextBox.SelectionLength = 0;
            this.Amount_TextBox.SelectionStart = 0;
            this.Amount_TextBox.ShortcutsEnabled = true;
            this.Amount_TextBox.Size = new System.Drawing.Size(121, 23);
            this.Amount_TextBox.TabIndex = 4;
            this.Amount_TextBox.UseSelectable = true;
            this.Amount_TextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.Amount_TextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // T_Shirt_Sell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 378);
            this.Controls.Add(this.Amount_TextBox);
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

        private MetroLabel Size_Label;
        private MetroLabel Amount_label;
        private MetroComboBox size_chose;
        private MetroButton Make_Order;
        private MenuStrip Process_menu;
        private ToolStripMenuItem processToolStripMenuItem;
        private ToolStripMenuItem displayOrderToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private MetroTextBox Amount_TextBox;
    }
}

