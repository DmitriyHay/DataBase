namespace SchoolSearch
{
    partial class Add_Forms
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
            this.lb_FirstName = new System.Windows.Forms.Label();
            this.lb_Bus = new System.Windows.Forms.Label();
            this.lb_TFirstName = new System.Windows.Forms.Label();
            this.lb_TLast_Name = new System.Windows.Forms.Label();
            this.tb_FirstName = new System.Windows.Forms.TextBox();
            this.tb_SecondName = new System.Windows.Forms.TextBox();
            this.tb_Grade = new System.Windows.Forms.TextBox();
            this.tb_Classroom = new System.Windows.Forms.TextBox();
            this.tb_Bus = new System.Windows.Forms.TextBox();
            this.tb_TFirstName = new System.Windows.Forms.TextBox();
            this.tb_TLastName = new System.Windows.Forms.TextBox();
            this.bt_Add = new System.Windows.Forms.Button();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_FirstName
            // 
            this.lb_FirstName.AutoSize = true;
            this.lb_FirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_FirstName.Location = new System.Drawing.Point(4, 19);
            this.lb_FirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_FirstName.Name = "lb_FirstName";
            this.lb_FirstName.Size = new System.Drawing.Size(84, 15);
            this.lb_FirstName.TabIndex = 0;
            this.lb_FirstName.Text = "Имя студента:";
            // 
            // lb_Bus
            // 
            this.lb_Bus.AutoSize = true;
            this.lb_Bus.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lb_Bus.Location = new System.Drawing.Point(4, 136);
            this.lb_Bus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_Bus.Name = "lb_Bus";
            this.lb_Bus.Size = new System.Drawing.Size(136, 20);
            this.lb_Bus.TabIndex = 4;
            this.lb_Bus.Text = "Номер маршруту:";
            // 
            // lb_TFirstName
            // 
            this.lb_TFirstName.AutoSize = true;
            this.lb_TFirstName.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lb_TFirstName.Location = new System.Drawing.Point(4, 165);
            this.lb_TFirstName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TFirstName.Name = "lb_TFirstName";
            this.lb_TFirstName.Size = new System.Drawing.Size(119, 20);
            this.lb_TFirstName.TabIndex = 5;
            this.lb_TFirstName.Text = "Ім\'я викладача:";
            // 
            // lb_TLast_Name
            // 
            this.lb_TLast_Name.AutoSize = true;
            this.lb_TLast_Name.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lb_TLast_Name.Location = new System.Drawing.Point(4, 194);
            this.lb_TLast_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_TLast_Name.Name = "lb_TLast_Name";
            this.lb_TLast_Name.Size = new System.Drawing.Size(161, 20);
            this.lb_TLast_Name.TabIndex = 6;
            this.lb_TLast_Name.Text = "Прізвище викладача:";
            // 
            // tb_FirstName
            // 
            this.tb_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_FirstName.Location = new System.Drawing.Point(199, 15);
            this.tb_FirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_FirstName.Name = "tb_FirstName";
            this.tb_FirstName.Size = new System.Drawing.Size(122, 26);
            this.tb_FirstName.TabIndex = 7;
            // 
            // tb_SecondName
            // 
            this.tb_SecondName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_SecondName.Location = new System.Drawing.Point(199, 44);
            this.tb_SecondName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_SecondName.Name = "tb_SecondName";
            this.tb_SecondName.Size = new System.Drawing.Size(122, 26);
            this.tb_SecondName.TabIndex = 8;
            // 
            // tb_Grade
            // 
            this.tb_Grade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Grade.Location = new System.Drawing.Point(199, 73);
            this.tb_Grade.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Grade.Name = "tb_Grade";
            this.tb_Grade.Size = new System.Drawing.Size(122, 26);
            this.tb_Grade.TabIndex = 9;
            this.tb_Grade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Grade_KeyPress);
            // 
            // tb_Classroom
            // 
            this.tb_Classroom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Classroom.Location = new System.Drawing.Point(199, 102);
            this.tb_Classroom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Classroom.Name = "tb_Classroom";
            this.tb_Classroom.Size = new System.Drawing.Size(122, 26);
            this.tb_Classroom.TabIndex = 10;
            this.tb_Classroom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Classroom_KeyPress);
            // 
            // tb_Bus
            // 
            this.tb_Bus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_Bus.Location = new System.Drawing.Point(199, 132);
            this.tb_Bus.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_Bus.Name = "tb_Bus";
            this.tb_Bus.Size = new System.Drawing.Size(122, 26);
            this.tb_Bus.TabIndex = 11;
            this.tb_Bus.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Bus_KeyPress);
            // 
            // tb_TFirstName
            // 
            this.tb_TFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_TFirstName.Location = new System.Drawing.Point(199, 161);
            this.tb_TFirstName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_TFirstName.Name = "tb_TFirstName";
            this.tb_TFirstName.Size = new System.Drawing.Size(122, 26);
            this.tb_TFirstName.TabIndex = 12;
            // 
            // tb_TLastName
            // 
            this.tb_TLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.tb_TLastName.Location = new System.Drawing.Point(199, 190);
            this.tb_TLastName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tb_TLastName.Name = "tb_TLastName";
            this.tb_TLastName.Size = new System.Drawing.Size(122, 26);
            this.tb_TLastName.TabIndex = 13;
            // 
            // bt_Add
            // 
            this.bt_Add.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bt_Add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Add.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Add.Location = new System.Drawing.Point(216, 220);
            this.bt_Add.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Add.Name = "bt_Add";
            this.bt_Add.Size = new System.Drawing.Size(90, 28);
            this.bt_Add.TabIndex = 14;
            this.bt_Add.Text = "Додати";
            this.bt_Add.UseVisualStyleBackColor = false;
            this.bt_Add.Click += new System.EventHandler(this.bt_Add_Click);
            // 
            // bt_Reset
            // 
            this.bt_Reset.BackColor = System.Drawing.SystemColors.Control;
            this.bt_Reset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Reset.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bt_Reset.Location = new System.Drawing.Point(8, 240);
            this.bt_Reset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(90, 28);
            this.bt_Reset.TabIndex = 15;
            this.bt_Reset.Text = "Очистити";
            this.bt_Reset.UseVisualStyleBackColor = false;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(4, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ім\'я студента:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(4, 48);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Прізвище студента:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(4, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Клас:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(4, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Номер класу:";
            // 
            // frm_Add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(328, 277);
            this.Controls.Add(this.bt_Reset);
            this.Controls.Add(this.bt_Add);
            this.Controls.Add(this.tb_TLastName);
            this.Controls.Add(this.tb_TFirstName);
            this.Controls.Add(this.tb_Bus);
            this.Controls.Add(this.tb_Classroom);
            this.Controls.Add(this.tb_Grade);
            this.Controls.Add(this.tb_SecondName);
            this.Controls.Add(this.tb_FirstName);
            this.Controls.Add(this.lb_TLast_Name);
            this.Controls.Add(this.lb_TFirstName);
            this.Controls.Add(this.lb_Bus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_FirstName);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_Add";
            this.Text = "Add New Student";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_FirstName;
        private System.Windows.Forms.Label lb_Bus;
        private System.Windows.Forms.Label lb_TFirstName;
        private System.Windows.Forms.Label lb_TLast_Name;
        private System.Windows.Forms.TextBox tb_FirstName;
        private System.Windows.Forms.TextBox tb_SecondName;
        private System.Windows.Forms.TextBox tb_Grade;
        private System.Windows.Forms.TextBox tb_Classroom;
        private System.Windows.Forms.TextBox tb_Bus;
        private System.Windows.Forms.TextBox tb_TFirstName;
        private System.Windows.Forms.TextBox tb_TLastName;
        private System.Windows.Forms.Button bt_Add;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}