using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Procesamiento_por_lotes
{
    public partial class Lotes : Form
    {
        int lotes = 0, procesos = 0, lot_act = 1;
        int act = 0;
        double tiempo_usado = 0, tiempo_restante = 0;

        List<process> lista = new List<process>();

        public Lotes(){
            InitializeComponent();
            start.Enabled = false;
            string sr = "Proceso.txt";
            if (!File.Exists(sr))
            {
                execute_btn.Enabled = false;
            }
        }

        private void add_process_Click(object sender, EventArgs e){
            Proceso process = new Proceso();
            process.Show();
            this.Hide();
        }

        private void reset_Click(object sender, EventArgs e)
        {
            Lotes lot = new Lotes();
            lot.Show();
            this.Hide();
        }

        private void clock_Tick(object sender, EventArgs e){
            Double tiempo = Convert.ToDouble(time_label.Text);
            tiempo = tiempo + 1;
            time_label.Text = tiempo.ToString();

            if(lista[act] != null){
                name_label.Text = "Nombre: " + lista[act].getProgramador();
                id_label.Text = "ID:" + lista[act].getNum().ToString();
                op_label.Text = "Operación: " + lista[act].getOperacion();
                tme_label.Text = "Tiempo Máximo Estimado: " + lista[act].getTME().ToString();
                tt_label.Text = "Tiempo Trasncurrido: " + (tiempo - tiempo_usado);
                tiempo_restante = lista[act].getTME() - (tiempo - tiempo_usado);
                tr_label.Text = "Tiempo restante: " + tiempo_restante;
            }

            if (tiempo_restante == 0){
                if(lista[act] != null) {
                    tiempo_usado = tiempo_usado + lista[act].getTME();
                    dataGridView1.Rows.RemoveAt(0);
                    dataGridView2.Rows.Add();
                    dataGridView2.Rows[act].Cells[0].Value = lista[act].getNum();
                    dataGridView2.Rows[act].Cells[1].Value = lista[act].getOperacion();
                    dataGridView2.Rows[act].Cells[2].Value = lista[act].getResultado();
                    dataGridView2.Rows[act].Cells[3].Value = (act / 3) + 1;
                }

                if ((act/3+1) != ((act+1)/3+1)){
                    // Mostrar el total de lotes
                    dataGridView1.Rows.Clear();
                    lotes--;
                    lot_act++;
                    wait_lot_label.Text = "Número de lotes pendientes: " + (lotes-1);
                    lot_label.Text = "Lote actual: " + lot_act;

                    if (lista.Count() != (act+1))
                    {


                        if (lista[act + 1] != null)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[0].Cells[0].Value = lista[act + 1].getProgramador();
                            dataGridView1.Rows[0].Cells[1].Value = lista[act + 1].getTME();
                            if (lista[act + 2] != null)
                            {
                                dataGridView1.Rows.Add();
                                dataGridView1.Rows[1].Cells[0].Value = lista[act + 2].getProgramador();
                                dataGridView1.Rows[1].Cells[1].Value = lista[act + 2].getTME();
                                if (lista[act + 3] != null)
                                {
                                    dataGridView1.Rows.Add();
                                    dataGridView1.Rows[2].Cells[0].Value = lista[act + 3].getProgramador();
                                    dataGridView1.Rows[2].Cells[1].Value = lista[act + 3].getTME();
                                }
                            }
                        }
                    }
                }
                act++;

                if (act >= lista.Count() || lista[act] == null){
                    clock.Stop();
                    start.Enabled = false;
                    MessageBox.Show("Procesos terminados con exito!!");
                }
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            clock.Start();
        }

        private void execute_btn_Click(object sender, EventArgs e){
            String line;
            lista.Clear();
            try{
                StreamReader sr = new StreamReader("Proceso.txt");
                int num1;
                line = sr.ReadLine();

                while (line != null)
                {
                    process pro = new process();
                    if (line == "#JOB"){
                        procesos++;
                    }

                    // Asignar el programador al proceso
                    line = sr.ReadLine();
                    pro.setProgramador(line);

                    // Avanzar linea, convertir a int y guardar el numero de programa
                    line = sr.ReadLine();
                    num1 = int.Parse(line);
                    pro.setNum(num1);

                    // Avanzar linea, convertir a int y guardar el TME
                    line = sr.ReadLine();
                    num1 = int.Parse(line);
                    pro.setTME(num1);

                    // Asignar la operación
                    line = sr.ReadLine();
                    pro.setOperacion(line);

                    // Avanzar linea, convertir a int y guardar el resultado
                    line = sr.ReadLine();
                    num1 = int.Parse(line);
                    pro.setResultado(num1);

                    // Avanzar la linea de #END
                    line = sr.ReadLine();

                    lista.Add(pro);
                    // Avanzar una linea adicional para encontrar otro #JOB
                    line = sr.ReadLine();
                }
                sr.Close();
                while ((lista.Count() % 3) != 0){
                    lista.Add(null);
                }
                // Obtener el total de lotes a procesar
                //lotes = (procesos / 3) + (procesos%3);
                lotes = (lista.Count()/3) + (lista.Count()%3);
            }
            finally{
                // Mostrar el total de lotes
                dataGridView1.Rows.Clear();
                wait_lot_label.Text = "Número de lotes pendientes: " + (lotes-1);
                lot_label.Text = "Lote actual: " + lot_act;

                if(lista[0] != null){
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[0].Cells[0].Value = lista[0].getProgramador();
                    dataGridView1.Rows[0].Cells[1].Value = lista[0].getTME();
                    if (lista[1] != null){
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[1].Cells[0].Value = lista[1].getProgramador();
                        dataGridView1.Rows[1].Cells[1].Value = lista[1].getTME();
                        if (lista[2] != null){
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[2].Cells[0].Value = lista[2].getProgramador();
                            dataGridView1.Rows[2].Cells[1].Value = lista[2].getTME();
                        }
                    }
                }

                start.Enabled = true;
            }
        }


    }
}
