namespace Procesamiento_por_lotes
{
    partial class Lotes
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.add_process = new System.Windows.Forms.Button();
            this.wait_lot_label = new System.Windows.Forms.Label();
            this.lot_label = new System.Windows.Forms.Label();
            this.execute_groupbox = new System.Windows.Forms.GroupBox();
            this.tr_label = new System.Windows.Forms.Label();
            this.tt_label = new System.Windows.Forms.Label();
            this.tme_label = new System.Windows.Forms.Label();
            this.op_label = new System.Windows.Forms.Label();
            this.id_label = new System.Windows.Forms.Label();
            this.name_label = new System.Windows.Forms.Label();
            this.end_lot_label = new System.Windows.Forms.Label();
            this.crono_label = new System.Windows.Forms.Label();
            this.execute_btn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.start = new System.Windows.Forms.Button();
            this.time_label = new System.Windows.Forms.Label();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Operacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reset = new System.Windows.Forms.Button();
            this.execute_groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // add_process
            // 
            this.add_process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.add_process.Location = new System.Drawing.Point(12, 28);
            this.add_process.Name = "add_process";
            this.add_process.Size = new System.Drawing.Size(103, 26);
            this.add_process.TabIndex = 0;
            this.add_process.Text = "Agregar Proceso";
            this.add_process.UseVisualStyleBackColor = false;
            this.add_process.Click += new System.EventHandler(this.add_process_Click);
            // 
            // wait_lot_label
            // 
            this.wait_lot_label.AutoSize = true;
            this.wait_lot_label.Location = new System.Drawing.Point(40, 77);
            this.wait_lot_label.Name = "wait_lot_label";
            this.wait_lot_label.Size = new System.Drawing.Size(142, 13);
            this.wait_lot_label.TabIndex = 1;
            this.wait_lot_label.Text = "Número de lotes pendientes:";
            // 
            // lot_label
            // 
            this.lot_label.AutoSize = true;
            this.lot_label.Location = new System.Drawing.Point(40, 108);
            this.lot_label.Name = "lot_label";
            this.lot_label.Size = new System.Drawing.Size(63, 13);
            this.lot_label.TabIndex = 2;
            this.lot_label.Text = "Lote actual:";
            // 
            // execute_groupbox
            // 
            this.execute_groupbox.Controls.Add(this.tr_label);
            this.execute_groupbox.Controls.Add(this.tt_label);
            this.execute_groupbox.Controls.Add(this.tme_label);
            this.execute_groupbox.Controls.Add(this.op_label);
            this.execute_groupbox.Controls.Add(this.id_label);
            this.execute_groupbox.Controls.Add(this.name_label);
            this.execute_groupbox.Location = new System.Drawing.Point(267, 77);
            this.execute_groupbox.Name = "execute_groupbox";
            this.execute_groupbox.Size = new System.Drawing.Size(215, 243);
            this.execute_groupbox.TabIndex = 3;
            this.execute_groupbox.TabStop = false;
            this.execute_groupbox.Text = "Proceso en ejecución";
            // 
            // tr_label
            // 
            this.tr_label.AutoSize = true;
            this.tr_label.Location = new System.Drawing.Point(22, 212);
            this.tr_label.Name = "tr_label";
            this.tr_label.Size = new System.Drawing.Size(91, 13);
            this.tr_label.TabIndex = 5;
            this.tr_label.Text = "Tiempo Restante:";
            // 
            // tt_label
            // 
            this.tt_label.AutoSize = true;
            this.tt_label.Location = new System.Drawing.Point(19, 176);
            this.tt_label.Name = "tt_label";
            this.tt_label.Size = new System.Drawing.Size(107, 13);
            this.tt_label.TabIndex = 4;
            this.tt_label.Text = "Tiempo Transcurrido:";
            // 
            // tme_label
            // 
            this.tme_label.AutoSize = true;
            this.tme_label.Location = new System.Drawing.Point(19, 143);
            this.tme_label.Name = "tme_label";
            this.tme_label.Size = new System.Drawing.Size(130, 13);
            this.tme_label.TabIndex = 3;
            this.tme_label.Text = "Tiempo Máximo Estimado:";
            // 
            // op_label
            // 
            this.op_label.AutoSize = true;
            this.op_label.Location = new System.Drawing.Point(22, 107);
            this.op_label.Name = "op_label";
            this.op_label.Size = new System.Drawing.Size(59, 13);
            this.op_label.TabIndex = 2;
            this.op_label.Text = "Operación:";
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(22, 73);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(21, 13);
            this.id_label.TabIndex = 1;
            this.id_label.Text = "ID:";
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Location = new System.Drawing.Point(19, 40);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(50, 13);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Nombre: ";
            // 
            // end_lot_label
            // 
            this.end_lot_label.AutoSize = true;
            this.end_lot_label.Location = new System.Drawing.Point(488, 77);
            this.end_lot_label.Name = "end_lot_label";
            this.end_lot_label.Size = new System.Drawing.Size(108, 13);
            this.end_lot_label.TabIndex = 4;
            this.end_lot_label.Text = "Procesos terminados:";
            // 
            // crono_label
            // 
            this.crono_label.AutoSize = true;
            this.crono_label.Location = new System.Drawing.Point(488, 35);
            this.crono_label.Name = "crono_label";
            this.crono_label.Size = new System.Drawing.Size(110, 13);
            this.crono_label.TabIndex = 5;
            this.crono_label.Text = "Tiempo Transcurrido: ";
            // 
            // execute_btn
            // 
            this.execute_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.execute_btn.Location = new System.Drawing.Point(150, 28);
            this.execute_btn.Name = "execute_btn";
            this.execute_btn.Size = new System.Drawing.Size(103, 26);
            this.execute_btn.TabIndex = 6;
            this.execute_btn.Text = "Cargar lote";
            this.execute_btn.UseVisualStyleBackColor = false;
            this.execute_btn.Click += new System.EventHandler(this.execute_btn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.TME});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView1.Location = new System.Drawing.Point(12, 135);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(241, 293);
            this.dataGridView1.TabIndex = 7;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // TME
            // 
            this.TME.HeaderText = "TME";
            this.TME.Name = "TME";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Operacion,
            this.Resultado,
            this.Lote});
            this.dataGridView2.Enabled = false;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dataGridView2.Location = new System.Drawing.Point(489, 135);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(441, 293);
            this.dataGridView2.TabIndex = 8;
            // 
            // clock
            // 
            this.clock.Interval = 1000;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.Turquoise;
            this.start.Location = new System.Drawing.Point(289, 28);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(75, 26);
            this.start.TabIndex = 9;
            this.start.Text = "Iniciar";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // time_label
            // 
            this.time_label.AutoSize = true;
            this.time_label.Location = new System.Drawing.Point(604, 35);
            this.time_label.Name = "time_label";
            this.time_label.Size = new System.Drawing.Size(13, 13);
            this.time_label.TabIndex = 10;
            this.time_label.Text = "0";
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Número";
            this.Numero.Name = "Numero";
            // 
            // Operacion
            // 
            this.Operacion.HeaderText = "Operación";
            this.Operacion.Name = "Operacion";
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "Resultado";
            this.Resultado.Name = "Resultado";
            // 
            // Lote
            // 
            this.Lote.HeaderText = "Lote";
            this.Lote.Name = "Lote";
            // 
            // reset
            // 
            this.reset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.reset.Location = new System.Drawing.Point(407, 30);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(75, 23);
            this.reset.TabIndex = 11;
            this.reset.Text = "Reiniciar";
            this.reset.UseVisualStyleBackColor = false;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // Lotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(949, 450);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.time_label);
            this.Controls.Add(this.start);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.execute_btn);
            this.Controls.Add(this.crono_label);
            this.Controls.Add(this.end_lot_label);
            this.Controls.Add(this.execute_groupbox);
            this.Controls.Add(this.lot_label);
            this.Controls.Add(this.wait_lot_label);
            this.Controls.Add(this.add_process);
            this.Name = "Lotes";
            this.Text = "Procesamiento por Lotes";
            this.execute_groupbox.ResumeLayout(false);
            this.execute_groupbox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button add_process;
        private System.Windows.Forms.Label wait_lot_label;
        private System.Windows.Forms.Label lot_label;
        private System.Windows.Forms.GroupBox execute_groupbox;
        private System.Windows.Forms.Label tr_label;
        private System.Windows.Forms.Label tt_label;
        private System.Windows.Forms.Label tme_label;
        private System.Windows.Forms.Label op_label;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.Label end_lot_label;
        private System.Windows.Forms.Label crono_label;
        private System.Windows.Forms.Button execute_btn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn TME;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label time_label;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Operacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lote;
        private System.Windows.Forms.Button reset;
    }
}

