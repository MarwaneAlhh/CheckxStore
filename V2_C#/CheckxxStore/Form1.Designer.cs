using System;

namespace CheckxxStore
{
    partial class Form1
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CheckStore = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filterStore = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.listView1.ForeColor = System.Drawing.Color.White;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(183, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(805, 411);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Columns.Add("Number of Store");
            this.listView1.Columns.Add("Shop name");
            this.listView1.Columns.Add("Country");
            this.listView1.Columns.Add("Company code");

            /*   this.listView1.Columns.Add("Number of Store");
            this.listView1.Columns.Add("Shop name");
            this.listView1.Columns.Add("Country");
            this.listView1.Columns.Add("Company code");
            */

            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.CheckStore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(156, 500);
            this.panel1.TabIndex = 2;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.GhostWhite;
            this.button3.Location = new System.Drawing.Point(3, 229);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 43);
            this.button3.TabIndex = 2;
            this.button3.Text = "bouton 3";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.GhostWhite;
            this.button2.Location = new System.Drawing.Point(3, 183);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 43);
            this.button2.TabIndex = 1;
            this.button2.Text = "Boutton 2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // CheckStore
            // 
            this.CheckStore.FlatAppearance.BorderSize = 0;
            this.CheckStore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CheckStore.ForeColor = System.Drawing.Color.GhostWhite;
            this.CheckStore.Location = new System.Drawing.Point(3, 134);
            this.CheckStore.Name = "CheckStore";
            this.CheckStore.Size = new System.Drawing.Size(150, 43);
            this.CheckStore.TabIndex = 0;
            this.CheckStore.Text = "Check Store";
            this.CheckStore.UseVisualStyleBackColor = true;
            this.CheckStore.Click += new System.EventHandler(this.CheckStore_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.GhostWhite;
            this.panel2.Location = new System.Drawing.Point(159, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 46);
            this.panel2.TabIndex = 3;
            // 
            // filterStore
            // 
            this.filterStore.Location = new System.Drawing.Point(183, 44);
            this.filterStore.Name = "filterStore";
            this.filterStore.Size = new System.Drawing.Size(269, 27);
            this.filterStore.TabIndex = 4;
            this.filterStore.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.filterStore);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.Text = "CheckDatabase";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CheckStore;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox filterStore;
    }
}

