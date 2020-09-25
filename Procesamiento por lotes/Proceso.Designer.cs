namespace Procesamiento_por_lotes
{
    partial class Proceso
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
            this.programador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.op1 = new System.Windows.Forms.TextBox();
            this.operador = new System.Windows.Forms.ComboBox();
            this.op2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.add = new System.Windows.Forms.Button();
            this.clear = new System.Windows.Forms.Button();
            this.end = new System.Windows.Forms.Button();
            this.empty = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar procesos";
            // 
            // programador
            // 
            this.programador.Location = new System.Drawing.Point(107, 61);
            this.programador.Name = "programador";
            this.programador.Size = new System.Drawing.Size(193, 20);
            this.programador.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Programador";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Operación";
            // 
            // op1
            // 
            this.op1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.op1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.op1.Location = new System.Drawing.Point(107, 97);
            this.op1.Name = "op1";
            this.op1.Size = new System.Drawing.Size(67, 20);
            this.op1.TabIndex = 5;
            this.op1.TextChanged += new System.EventHandler(this.op1_TextChanged);
            // 
            // operador
            // 
            this.operador.Cursor = System.Windows.Forms.Cursors.Default;
            this.operador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.operador.FormattingEnabled = true;
            this.operador.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/",
            "%"});
            this.operador.Location = new System.Drawing.Point(180, 96);
            this.operador.Name = "operador";
            this.operador.Size = new System.Drawing.Size(47, 21);
            this.operador.TabIndex = 6;
            this.operador.SelectedIndexChanged += new System.EventHandler(this.operador_SelectedIndexChanged);
            // 
            // op2
            // 
            this.op2.Location = new System.Drawing.Point(233, 96);
            this.op2.Name = "op2";
            this.op2.Size = new System.Drawing.Size(67, 20);
            this.op2.TabIndex = 7;
            this.op2.TextChanged += new System.EventHandler(this.op2_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiempo Máximo Estimado";
            // 
            // tme
            // 
            this.tme.Location = new System.Drawing.Point(180, 131);
            this.tme.MaxLength = 2;
            this.tme.Name = "tme";
            this.tme.Size = new System.Drawing.Size(120, 20);
            this.tme.TabIndex = 9;
            this.tme.TextChanged += new System.EventHandler(this.tme_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Número de programa";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(180, 157);
            this.num.MaxLength = 10;
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(120, 20);
            this.num.TabIndex = 11;
            this.num.TextChanged += new System.EventHandler(this.num_TextChanged);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add.Location = new System.Drawing.Point(37, 192);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(75, 23);
            this.add.TabIndex = 12;
            this.add.Text = "Agregar";
            this.add.UseVisualStyleBackColor = false;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.clear.Location = new System.Drawing.Point(131, 192);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(75, 23);
            this.clear.TabIndex = 13;
            this.clear.Text = "Limpiar";
            this.clear.UseVisualStyleBackColor = false;
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // end
            // 
            this.end.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.end.Location = new System.Drawing.Point(225, 192);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(75, 23);
            this.end.TabIndex = 14;
            this.end.Text = "Terminar";
            this.end.UseVisualStyleBackColor = false;
            this.end.Click += new System.EventHandler(this.end_Click);
            // 
            // empty
            // 
            this.empty.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.empty.Location = new System.Drawing.Point(225, 23);
            this.empty.Name = "empty";
            this.empty.Size = new System.Drawing.Size(75, 23);
            this.empty.TabIndex = 15;
            this.empty.Text = "Vaciar";
            this.empty.UseVisualStyleBackColor = false;
            this.empty.Click += new System.EventHandler(this.empty_Click);
            // 
            // Proceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(326, 239);
            this.Controls.Add(this.empty);
            this.Controls.Add(this.end);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tme);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.op2);
            this.Controls.Add(this.operador);
            this.Controls.Add(this.op1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.programador);
            this.Controls.Add(this.label1);
            this.Name = "Proceso";
            this.Text = "Agregar Procesos";
            this.Load += new System.EventHandler(this.Proceso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox programador;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox op1;
        private System.Windows.Forms.ComboBox operador;
        private System.Windows.Forms.TextBox op2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Button clear;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.Button empty;
    }
}