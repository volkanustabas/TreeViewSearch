namespace TreeViewSearch
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
            this.tv_main = new System.Windows.Forms.TreeView();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.lbl_info_search = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tv_main
            // 
            this.tv_main.Location = new System.Drawing.Point(15, 110);
            this.tv_main.Name = "tv_main";
            this.tv_main.Size = new System.Drawing.Size(407, 320);
            this.tv_main.TabIndex = 0;
            // 
            // tb_search
            // 
            this.tb_search.Location = new System.Drawing.Point(15, 30);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(320, 20);
            this.tb_search.TabIndex = 1;
            this.tb_search.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tb_search_KeyUp);
            // 
            // lbl_info_search
            // 
            this.lbl_info_search.AutoSize = true;
            this.lbl_info_search.Location = new System.Drawing.Point(15, 10);
            this.lbl_info_search.Name = "lbl_info_search";
            this.lbl_info_search.Size = new System.Drawing.Size(41, 13);
            this.lbl_info_search.TabIndex = 2;
            this.lbl_info_search.Text = "Search";
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(15, 80);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Load Data";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(345, 30);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 450);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.lbl_info_search);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.tv_main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "TreeViewSearch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView tv_main;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Label lbl_info_search;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_search;
    }
}

