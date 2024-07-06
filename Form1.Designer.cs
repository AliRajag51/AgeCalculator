namespace InventoryManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.calculateAgebtn = new System.Windows.Forms.Button();
            this.dbo = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.currentAgeShow = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "DateOfBirth";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // calculateAgebtn
            // 
            this.calculateAgebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateAgebtn.Location = new System.Drawing.Point(552, 218);
            this.calculateAgebtn.Name = "calculateAgebtn";
            this.calculateAgebtn.Size = new System.Drawing.Size(361, 45);
            this.calculateAgebtn.TabIndex = 1;
            this.calculateAgebtn.Text = "CalculateAge";
            this.calculateAgebtn.UseVisualStyleBackColor = true;
            this.calculateAgebtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dbo
            // 
            this.dbo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dbo.Location = new System.Drawing.Point(406, 145);
            this.dbo.Name = "dbo";
            this.dbo.Size = new System.Drawing.Size(507, 39);
            this.dbo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Age";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // currentAgeShow
            // 
            this.currentAgeShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentAgeShow.Location = new System.Drawing.Point(406, 301);
            this.currentAgeShow.Name = "currentAgeShow";
            this.currentAgeShow.Size = new System.Drawing.Size(507, 39);
            this.currentAgeShow.TabIndex = 4;
            this.currentAgeShow.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InventoryManagementSystem.Properties.Resources.AgeCalculatorBackground1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1054, 536);
            this.Controls.Add(this.currentAgeShow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dbo);
            this.Controls.Add(this.calculateAgebtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Age Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calculateAgebtn;
        private System.Windows.Forms.DateTimePicker dbo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentAgeShow;
    }
}

