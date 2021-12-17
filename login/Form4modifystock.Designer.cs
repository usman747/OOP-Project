namespace login
{
    partial class Form4modifystock
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bar_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.item_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cost = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1_delete = new System.Windows.Forms.Button();
            this.button2_save = new System.Windows.Forms.Button();
            this.edit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bar_code,
            this.item_name,
            this.unit_price,
            this.quantity,
            this.cost});
            this.dataGridView1.Location = new System.Drawing.Point(3, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 110);
            this.dataGridView1.TabIndex = 0;
            // 
            // bar_code
            // 
            this.bar_code.HeaderText = "BAR CODE";
            this.bar_code.Name = "bar_code";
            // 
            // item_name
            // 
            this.item_name.HeaderText = "ITEM NAME";
            this.item_name.Name = "item_name";
            // 
            // unit_price
            // 
            this.unit_price.HeaderText = "UNIT PRICE";
            this.unit_price.Name = "unit_price";
            // 
            // quantity
            // 
            this.quantity.HeaderText = "QUANTITY";
            this.quantity.Name = "quantity";
            // 
            // cost
            // 
            this.cost.HeaderText = "COST";
            this.cost.Name = "cost";
            // 
            // button1_delete
            // 
            this.button1_delete.BackColor = System.Drawing.SystemColors.Desktop;
            this.button1_delete.ForeColor = System.Drawing.SystemColors.Control;
            this.button1_delete.Location = new System.Drawing.Point(12, 161);
            this.button1_delete.Name = "button1_delete";
            this.button1_delete.Size = new System.Drawing.Size(86, 53);
            this.button1_delete.TabIndex = 1;
            this.button1_delete.Text = "DELETE";
            this.button1_delete.UseVisualStyleBackColor = false;
            this.button1_delete.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2_save
            // 
            this.button2_save.BackColor = System.Drawing.SystemColors.Desktop;
            this.button2_save.ForeColor = System.Drawing.SystemColors.Control;
            this.button2_save.Location = new System.Drawing.Point(188, 160);
            this.button2_save.Name = "button2_save";
            this.button2_save.Size = new System.Drawing.Size(86, 54);
            this.button2_save.TabIndex = 2;
            this.button2_save.Text = "SAVE";
            this.button2_save.UseVisualStyleBackColor = false;
            this.button2_save.Click += new System.EventHandler(this.button2_Click);
            // 
            // edit
            // 
            this.edit.BackColor = System.Drawing.SystemColors.Desktop;
            this.edit.ForeColor = System.Drawing.SystemColors.Control;
            this.edit.Location = new System.Drawing.Point(370, 161);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(86, 54);
            this.edit.TabIndex = 3;
            this.edit.Text = "EDIT";
            this.edit.UseVisualStyleBackColor = false;
            this.edit.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(649, 48);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(649, 74);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(649, 22);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(577, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "BAR_CODE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(577, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "ITEM NAME";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(577, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "UNIT_PRICE";
            // 
            // Form4modifystock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(797, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.edit);
            this.Controls.Add(this.button2_save);
            this.Controls.Add(this.button1_delete);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4modifystock";
            this.Text = "Form4addstock";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1_delete;
        private System.Windows.Forms.Button button2_save;
        private System.Windows.Forms.Button edit;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn bar_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn item_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_price;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn cost;
    }
}