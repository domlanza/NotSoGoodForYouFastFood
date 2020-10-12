namespace NotSoGoodForYou
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
            this.lblName = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItemKey = new System.Windows.Forms.TextBox();
            this.btnMoreToOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAllDone = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrderCount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(151, 112);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(132, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Enter Your Name";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(473, 104);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(83, 42);
            this.btnOk.TabIndex = 1;
            this.btnOk.Text = "Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(320, 112);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 2;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(497, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Welcome to NotSoGoodForYou";
            // 
            // txtItemKey
            // 
            this.txtItemKey.Enabled = false;
            this.txtItemKey.Location = new System.Drawing.Point(226, 254);
            this.txtItemKey.Name = "txtItemKey";
            this.txtItemKey.Size = new System.Drawing.Size(100, 26);
            this.txtItemKey.TabIndex = 6;
            this.txtItemKey.TextChanged += new System.EventHandler(this.txtItemKey_TextChanged);
            // 
            // btnMoreToOrder
            // 
            this.btnMoreToOrder.BackColor = System.Drawing.Color.Cyan;
            this.btnMoreToOrder.Enabled = false;
            this.btnMoreToOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoreToOrder.Location = new System.Drawing.Point(49, 348);
            this.btnMoreToOrder.Name = "btnMoreToOrder";
            this.btnMoreToOrder.Size = new System.Drawing.Size(195, 81);
            this.btnMoreToOrder.TabIndex = 5;
            this.btnMoreToOrder.Text = "MORE TO ORDER";
            this.btnMoreToOrder.UseVisualStyleBackColor = false;
            this.btnMoreToOrder.Click += new System.EventHandler(this.btnMoreToOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Location = new System.Drawing.Point(45, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Order Here";
            // 
            // btnAllDone
            // 
            this.btnAllDone.BackColor = System.Drawing.Color.Crimson;
            this.btnAllDone.Enabled = false;
            this.btnAllDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllDone.Location = new System.Drawing.Point(429, 348);
            this.btnAllDone.Name = "btnAllDone";
            this.btnAllDone.Size = new System.Drawing.Size(195, 81);
            this.btnAllDone.TabIndex = 7;
            this.btnAllDone.Text = "ALL DONE";
            this.btnAllDone.UseVisualStyleBackColor = false;
            this.btnAllDone.Click += new System.EventHandler(this.btnAllDone_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Location = new System.Drawing.Point(241, 204);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Item Key";
            // 
            // txtOrderCount
            // 
            this.txtOrderCount.Enabled = false;
            this.txtOrderCount.Location = new System.Drawing.Point(402, 257);
            this.txtOrderCount.Name = "txtOrderCount";
            this.txtOrderCount.Size = new System.Drawing.Size(100, 26);
            this.txtOrderCount.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Location = new System.Drawing.Point(406, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Order Count";
            // 
            // btnAdd
            // 
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(579, 246);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(83, 42);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "ADD";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOrderCount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAllDone);
            this.Controls.Add(this.txtItemKey);
            this.Controls.Add(this.btnMoreToOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItemKey;
        private System.Windows.Forms.Button btnMoreToOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAllDone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrderCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
    }
}

