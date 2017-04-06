using System.Drawing;

namespace MusicSingles
{
    partial class SinglesForm
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
            this.singlesListView = new System.Windows.Forms.ListView();
            this.Load += new System.EventHandler(singleForm_Load);
            this.zeroColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.titleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.authorColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.trackDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.styleColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.singlesCountStrip = new System.Windows.Forms.StatusStrip();
            this.singlesCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.singlesEditStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addSingleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editSingleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSingleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.olderCheckBox = new System.Windows.Forms.CheckBox();
            this.newerCheckBox = new System.Windows.Forms.CheckBox();
            this.allCheckBox = new System.Windows.Forms.CheckBox();
            this.singlesCountStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // singlesListView
            // 
            this.singlesListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.zeroColumn,
            this.titleColumn,
            this.authorColumn,
            this.trackDateColumn,
            this.styleColumn});
            this.singlesListView.FullRowSelect = true;
            this.singlesListView.Location = new System.Drawing.Point(0, 2);
            this.singlesListView.MultiSelect = false;
            this.singlesListView.Name = "singlesListView";
            this.singlesListView.Size = new System.Drawing.Size(605, 259);
            this.singlesListView.TabIndex = 1;
            this.singlesListView.UseCompatibleStateImageBehavior = false;
            this.singlesListView.View = System.Windows.Forms.View.Details;
            // 
            // zeroColumn
            // 
            this.zeroColumn.DisplayIndex = 4;
            this.zeroColumn.Text = "";
            this.zeroColumn.Width = 0;
            // 
            // titleColumn
            // 
            this.titleColumn.DisplayIndex = 0;
            this.titleColumn.Text = "Title";
            this.titleColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.titleColumn.Width = 150;
            // 
            // authorColumn
            // 
            this.authorColumn.DisplayIndex = 1;
            this.authorColumn.Text = "Author";
            this.authorColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.authorColumn.Width = 150;
            // 
            // trackDateColumn
            // 
            this.trackDateColumn.DisplayIndex = 2;
            this.trackDateColumn.Text = "Track Date";
            this.trackDateColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.trackDateColumn.Width = 150;
            // 
            // styleColumn
            // 
            this.styleColumn.DisplayIndex = 3;
            this.styleColumn.Text = "Style";
            this.styleColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.styleColumn.Width = 150;
            // 
            // singlesCountStrip
            // 
            this.singlesCountStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singlesCountStatusLabel});
            this.singlesCountStrip.Location = new System.Drawing.Point(0, 239);
            this.singlesCountStrip.Name = "singlesCountStrip";
            this.singlesCountStrip.Size = new System.Drawing.Size(684, 22);
            this.singlesCountStrip.TabIndex = 2;
            // 
            // singlesCountStatusLabel
            // 
            this.singlesCountStatusLabel.Name = "singlesCountStatusLabel";
            this.singlesCountStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singlesEditStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(484, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.Visible = false;
            // 
            // singlesEditStripMenuItem
            // 
            this.singlesEditStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSingleToolStripMenuItem,
            this.editSingleToolStripMenuItem,
            this.deleteSingleToolStripMenuItem});
            this.singlesEditStripMenuItem.Name = "singlesEditStripMenuItem";
            this.singlesEditStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.singlesEditStripMenuItem.Text = "Main Menu";
            // 
            // addSingleToolStripMenuItem
            // 
            this.addSingleToolStripMenuItem.Name = "addSingleToolStripMenuItem";
            this.addSingleToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.addSingleToolStripMenuItem.Text = "Add Single";
            this.addSingleToolStripMenuItem.Click += new System.EventHandler(this.addSingleToolStripMenuItem_Click);
            // 
            // editSingleToolStripMenuItem
            // 
            this.editSingleToolStripMenuItem.Name = "editSingleToolStripMenuItem";
            this.editSingleToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.editSingleToolStripMenuItem.Text = "Edit Single";
            this.editSingleToolStripMenuItem.Click += new System.EventHandler(this.editSingleToolStripMenuItem_Click);
            // 
            // deleteSingleToolStripMenuItem
            // 
            this.deleteSingleToolStripMenuItem.Name = "deleteSingleToolStripMenuItem";
            this.deleteSingleToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.deleteSingleToolStripMenuItem.Text = "Delete Single";
            this.deleteSingleToolStripMenuItem.Click += new System.EventHandler(this.deleteSingleToolStripMenuItem_Click);
            // 
            // olderCheckBox
            // 
            this.olderCheckBox.AutoSize = true;
            this.olderCheckBox.Location = new System.Drawing.Point(611, 63);
            this.olderCheckBox.Name = "olderCheckBox";
            this.olderCheckBox.Size = new System.Drawing.Size(59, 17);
            this.olderCheckBox.TabIndex = 4;
            this.olderCheckBox.Text = "< 2000";
            this.olderCheckBox.UseVisualStyleBackColor = true;
            this.olderCheckBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // newerCheckBox
            // 
            this.newerCheckBox.AutoSize = true;
            this.newerCheckBox.Location = new System.Drawing.Point(611, 111);
            this.newerCheckBox.Name = "newerCheckBox";
            this.newerCheckBox.Size = new System.Drawing.Size(65, 17);
            this.newerCheckBox.TabIndex = 5;
            this.newerCheckBox.Text = ">= 2000";
            this.newerCheckBox.UseVisualStyleBackColor = true;
            this.newerCheckBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // allCheckBox
            // 
            this.allCheckBox.AutoSize = true;
            this.allCheckBox.Location = new System.Drawing.Point(611, 161);
            this.allCheckBox.Name = "allCheckBox";
            this.allCheckBox.Size = new System.Drawing.Size(37, 17);
            this.allCheckBox.TabIndex = 6;
            this.allCheckBox.Text = "All";
            this.allCheckBox.UseVisualStyleBackColor = true;
            this.allCheckBox.Click += new System.EventHandler(this.checkBox_Click);
            // 
            // SinglesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 261);
            this.Controls.Add(this.allCheckBox);
            this.Controls.Add(this.newerCheckBox);
            this.Controls.Add(this.olderCheckBox);
            this.Controls.Add(this.singlesCountStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.singlesListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SinglesForm";
            this.Text = "Singles";
            this.singlesCountStrip.ResumeLayout(false);
            this.singlesCountStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView singlesListView;
        private System.Windows.Forms.ColumnHeader titleColumn;
        private System.Windows.Forms.ColumnHeader authorColumn;
        private System.Windows.Forms.ColumnHeader trackDateColumn;
        private System.Windows.Forms.ColumnHeader styleColumn;
        private System.Windows.Forms.ColumnHeader zeroColumn;
        public System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem singlesEditStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addSingleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editSingleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSingleToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel singlesCountStatusLabel;
        private System.Windows.Forms.StatusStrip singlesCountStrip;
        private System.Windows.Forms.CheckBox olderCheckBox;
        private System.Windows.Forms.CheckBox newerCheckBox;
        private System.Windows.Forms.CheckBox allCheckBox;
    }
}