﻿namespace prjCustomerSystem
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.檢視ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.視窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.水平排序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.垂直排序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.階梯式排序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.關閉目前視窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.關閉所有視窗ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客戶系統ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.員工資料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton2,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(91, 36);
            this.toolStripButton3.Text = "客戶系統";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(91, 36);
            this.toolStripButton2.Text = "員工資料";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(67, 36);
            this.toolStripButton1.Text = "離開";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.編輯ToolStripMenuItem,
            this.檢視ToolStripMenuItem,
            this.視窗ToolStripMenuItem,
            this.說明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.客戶系統ToolStripMenuItem,
            this.員工資料ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檔案ToolStripMenuItem.Text = "檔案";
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.編輯ToolStripMenuItem.Text = "編輯";
            // 
            // 檢視ToolStripMenuItem
            // 
            this.檢視ToolStripMenuItem.Name = "檢視ToolStripMenuItem";
            this.檢視ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.檢視ToolStripMenuItem.Text = "檢視";
            // 
            // 視窗ToolStripMenuItem
            // 
            this.視窗ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.水平排序ToolStripMenuItem,
            this.垂直排序ToolStripMenuItem,
            this.階梯式排序ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.關閉目前視窗ToolStripMenuItem,
            this.關閉所有視窗ToolStripMenuItem});
            this.視窗ToolStripMenuItem.Name = "視窗ToolStripMenuItem";
            this.視窗ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.視窗ToolStripMenuItem.Text = "視窗";
            // 
            // 水平排序ToolStripMenuItem
            // 
            this.水平排序ToolStripMenuItem.Name = "水平排序ToolStripMenuItem";
            this.水平排序ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.水平排序ToolStripMenuItem.Text = "水平排序";
            this.水平排序ToolStripMenuItem.Click += new System.EventHandler(this.水平排序ToolStripMenuItem_Click);
            // 
            // 垂直排序ToolStripMenuItem
            // 
            this.垂直排序ToolStripMenuItem.Name = "垂直排序ToolStripMenuItem";
            this.垂直排序ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.垂直排序ToolStripMenuItem.Text = "垂直排序";
            this.垂直排序ToolStripMenuItem.Click += new System.EventHandler(this.垂直排序ToolStripMenuItem_Click);
            // 
            // 階梯式排序ToolStripMenuItem
            // 
            this.階梯式排序ToolStripMenuItem.Name = "階梯式排序ToolStripMenuItem";
            this.階梯式排序ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.階梯式排序ToolStripMenuItem.Text = "階梯式排序";
            this.階梯式排序ToolStripMenuItem.Click += new System.EventHandler(this.階梯式排序ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // 關閉目前視窗ToolStripMenuItem
            // 
            this.關閉目前視窗ToolStripMenuItem.Name = "關閉目前視窗ToolStripMenuItem";
            this.關閉目前視窗ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.關閉目前視窗ToolStripMenuItem.Text = "關閉目前視窗";
            this.關閉目前視窗ToolStripMenuItem.Click += new System.EventHandler(this.關閉目前視窗ToolStripMenuItem_Click);
            // 
            // 關閉所有視窗ToolStripMenuItem
            // 
            this.關閉所有視窗ToolStripMenuItem.Name = "關閉所有視窗ToolStripMenuItem";
            this.關閉所有視窗ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.關閉所有視窗ToolStripMenuItem.Text = "關閉所有視窗";
            this.關閉所有視窗ToolStripMenuItem.Click += new System.EventHandler(this.關閉所有視窗ToolStripMenuItem_Click);
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.說明ToolStripMenuItem.Text = "說明";
            // 
            // 客戶系統ToolStripMenuItem
            // 
            this.客戶系統ToolStripMenuItem.Name = "客戶系統ToolStripMenuItem";
            this.客戶系統ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.客戶系統ToolStripMenuItem.Text = "客戶系統";
            // 
            // 員工資料ToolStripMenuItem
            // 
            this.員工資料ToolStripMenuItem.Name = "員工資料ToolStripMenuItem";
            this.員工資料ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.員工資料ToolStripMenuItem.Text = "員工資料";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 檢視ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 視窗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 水平排序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 垂直排序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 階梯式排序ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 關閉目前視窗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關閉所有視窗ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客戶系統ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 員工資料ToolStripMenuItem;
    }
}