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
    public partial class Proceso : Form
    {
        List<process> lista = new List<process>();

        public Proceso(){
            InitializeComponent();
            operador.SelectedIndex = 0;
        }

        private void op1_TextChanged(object sender, EventArgs e)
        {
            if (op1.Text == ""){
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(op1.Text, "^[0-9]+$")){
            }
            else{
                op1.Clear();
                MessageBox.Show("Por favor ingrese solo números en este campo");
            }
        }

        private void op2_TextChanged(object sender, EventArgs e)
        {
            if (op2.Text == ""){
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(op2.Text, "^[0-9]+$")){
            }
            else{
                op2.Clear();
                MessageBox.Show("Por favor ingrese solo números en este campo");
            }

            if(operador.Text == "/" || operador.Text == "%")
            {
                if (op2.Text == "0")
                {
                    op2.Clear();
                    MessageBox.Show("No puede realizar esta operación con un valor 0");
                }
            }
        }

        private void tme_TextChanged(object sender, EventArgs e)
        {

            if (tme.Text == ""){
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(tme.Text, "^[0-9]+$")){
                if(tme.Text == "0"){
                    tme.Clear();
                    MessageBox.Show("El número debe ser mayor que 0");
                }
            }
            else{
                tme.Clear();
                MessageBox.Show("Por favor ingrese solo números en este campo, el número debe ser mayor que 0");
            }
        }

        private void num_TextChanged(object sender, EventArgs e)
        {
            if (num.Text == ""){
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(num.Text, "^[0-9]+$")){
            }
            else{
                num.Clear();
                MessageBox.Show("Por favor ingrese solo números en este campo");
            }
        }

        private void end_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Lotes lot = new Lotes();
            //lot.Show();
            Lotes lot = new Lotes();
            lot.Show();

            this.Close();

        }

        private void clear_Click(object sender, EventArgs e)
        {
            op1.Clear();
            op2.Clear();
            programador.Clear();
            tme.Clear();
            num.Clear();
        }

        private void operador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(operador.Text == "/" || operador.Text == "%")
            {
                if (op2.Text == "0")
                {
                    op2.Clear();
                    MessageBox.Show("No puede realizar esta operación con un valor 0");
                }
            }
        }

        private void add_Click(object sender, EventArgs e){

            if (op1.Text == "" || op2.Text == "" || programador.Text == "" || tme.Text == "" || num.Text == ""){
                MessageBox.Show("No puedes dejar campos vacios");
            }
            else{
                StreamReader sidr = new StreamReader("id.txt");
                string line = "";
                bool exist = false;
                line = sidr.ReadLine();
                while(line != null){
                    if (num.Text == line){
                        MessageBox.Show("ID repetido, favor de modificar");
                        num.Clear();
                        exist = true;
                    }
                    line = sidr.ReadLine();
                }
                sidr.Close();

                if(exist == false)
                {
                    try{
                        string sr = "Proceso.txt";
                        string previous = "";
                        if (File.Exists(sr)){
                            previous = File.ReadAllText(sr);
                        }
                        //Crear el archivo y el Writer
                        StreamWriter sw = new StreamWriter("Proceso.txt");

                        sw.Write(previous);
                        //Iniciar nueva escritura
                        sw.WriteLine("#JOB");
                        sw.WriteLine(programador.Text);
                        sw.WriteLine(num.Text);
                        sw.WriteLine(tme.Text);
                        sw.WriteLine(op1.Text + operador.Text + op2.Text);

                        int num1, num2, res = 0;
                        num1 = int.Parse(op1.Text);
                        num2 = int.Parse(op2.Text);

                        if (operador.Text == "+")
                        {
                            res = num1 + num2;
                        }
                        else if (operador.Text == "-")
                        {
                            res = num1 - num2;
                        }
                        else if (operador.Text == "*")
                        {
                            res = num1 * num2;
                        }
                        else if (operador.Text == "/")
                        {
                            res = num1 / num2;
                        }
                        else if (operador.Text == "%")
                        {
                            res = num1 % num2;
                        }

                        string result = Convert.ToString(res);
                        sw.WriteLine(result);
                        sw.WriteLine("#END");

                        //Cerrar el archivo
                        sw.Close();

                        StreamWriter sidw = File.AppendText("id.txt");
                        sidw.WriteLine(num.Text);
                        sidw.Close();
                    }
                    finally
                    {

                    }

                    // Limpiar datos
                    op1.Clear();
                    op2.Clear();
                    programador.Clear();
                    tme.Clear();
                    num.Clear();

                    // Confirmación
                    MessageBox.Show("Proceso Agregado!");
                }
               
            }
        }

        private void Proceso_Load(object sender, EventArgs e){
        }

        private void empty_Click(object sender, EventArgs e){
            File.Delete("Proceso.txt");
            StreamWriter sr = new StreamWriter("id.txt");
            sr.Write("");
            sr.Close();
            MessageBox.Show("Lista de procesos vacia!");
        }
    }
}
