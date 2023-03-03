namespace Gimnasio
{
    partial class GimnasioRobles
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.group_gender = new System.Windows.Forms.GroupBox();
            this.rbtn_female = new System.Windows.Forms.RadioButton();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.txt_identification = new System.Windows.Forms.TextBox();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_salary = new System.Windows.Forms.TextBox();
            this.txt_stratum = new System.Windows.Forms.TextBox();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_calcule = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.group_gender.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(369, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Indentificación";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(369, 158);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre completo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 227);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sueldo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(369, 288);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Estrato económico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(369, 520);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Costo Mensualidad";
            // 
            // group_gender
            // 
            this.group_gender.Controls.Add(this.rbtn_female);
            this.group_gender.Controls.Add(this.rbtn_male);
            this.group_gender.Location = new System.Drawing.Point(369, 357);
            this.group_gender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_gender.Name = "group_gender";
            this.group_gender.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_gender.Size = new System.Drawing.Size(193, 130);
            this.group_gender.TabIndex = 5;
            this.group_gender.TabStop = false;
            this.group_gender.Text = "Género";
            // 
            // rbtn_female
            // 
            this.rbtn_female.AutoSize = true;
            this.rbtn_female.Location = new System.Drawing.Point(21, 77);
            this.rbtn_female.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_female.Name = "rbtn_female";
            this.rbtn_female.Size = new System.Drawing.Size(115, 29);
            this.rbtn_female.TabIndex = 1;
            this.rbtn_female.TabStop = true;
            this.rbtn_female.Text = "Femenino";
            this.rbtn_female.UseVisualStyleBackColor = true;
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Location = new System.Drawing.Point(21, 35);
            this.rbtn_male.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(117, 29);
            this.rbtn_male.TabIndex = 0;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "Masculino";
            this.rbtn_male.UseVisualStyleBackColor = true;
            // 
            // txt_identification
            // 
            this.txt_identification.Location = new System.Drawing.Point(589, 87);
            this.txt_identification.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_identification.Name = "txt_identification";
            this.txt_identification.Size = new System.Drawing.Size(210, 31);
            this.txt_identification.TabIndex = 6;
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(589, 153);
            this.txt_name.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(210, 31);
            this.txt_name.TabIndex = 7;
            // 
            // txt_salary
            // 
            this.txt_salary.Location = new System.Drawing.Point(589, 222);
            this.txt_salary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_salary.Name = "txt_salary";
            this.txt_salary.Size = new System.Drawing.Size(210, 31);
            this.txt_salary.TabIndex = 8;
            // 
            // txt_stratum
            // 
            this.txt_stratum.Location = new System.Drawing.Point(589, 283);
            this.txt_stratum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_stratum.Name = "txt_stratum";
            this.txt_stratum.Size = new System.Drawing.Size(210, 31);
            this.txt_stratum.TabIndex = 9;
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txt_total.Location = new System.Drawing.Point(589, 520);
            this.txt_total.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(210, 31);
            this.txt_total.TabIndex = 10;
            // 
            // btn_register
            // 
            this.btn_register.ForeColor = System.Drawing.Color.Teal;
            this.btn_register.Location = new System.Drawing.Point(369, 608);
            this.btn_register.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(107, 38);
            this.btn_register.TabIndex = 11;
            this.btn_register.Text = "Registrar";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_calcule
            // 
            this.btn_calcule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_calcule.Location = new System.Drawing.Point(693, 608);
            this.btn_calcule.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_calcule.Name = "btn_calcule";
            this.btn_calcule.Size = new System.Drawing.Size(107, 38);
            this.btn_calcule.TabIndex = 12;
            this.btn_calcule.Text = "Calcular";
            this.btn_calcule.UseVisualStyleBackColor = true;
            this.btn_calcule.Click += new System.EventHandler(this.btn_calcule_Click);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.Cornsilk;
            this.btn_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_close.Location = new System.Drawing.Point(1019, 692);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(107, 38);
            this.btn_close.TabIndex = 13;
            this.btn_close.Text = "Salir";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // GimnasioRobles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1143, 750);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_calcule);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.txt_stratum);
            this.Controls.Add(this.txt_salary);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.txt_identification);
            this.Controls.Add(this.group_gender);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "GimnasioRobles";
            this.Text = "Gimnasio Robles";
            this.Load += new System.EventHandler(this.GimnasioRobles_Load);
            this.group_gender.ResumeLayout(false);
            this.group_gender.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox group_gender;
        private RadioButton rbtn_female;
        private RadioButton rbtn_male;
        private TextBox txt_identification;
        private TextBox txt_name;
        private TextBox txt_salary;
        private TextBox txt_stratum;
        private TextBox txt_total;
        private Button btn_register;
        private Button btn_calcule;
        private Button btn_close;
    }
}