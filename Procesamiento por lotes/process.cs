using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesamiento_por_lotes
{
    class process{
        private String programador = "";
        private String operacion = "";
        private int no_programa = 0;
        private int tme = 0;
        private int resultado = 0;

        public string getProgramador(){
            return this.programador;
        }

        public string getOperacion(){
            return this.operacion;
        }

        public int getNum(){
            return this.no_programa;
        }

        public int getTME(){
            return this.tme;
        }

        public int getResultado(){
            return this.resultado;
        }

        public void setProgramador(string aux){
            this.programador = aux;
        }

        public void setOperacion(string aux){
            this.operacion = aux;
        }

        public void setNum(int aux){
            this.no_programa = aux;
        }

        public void setTME(int aux){
            this.tme = aux;
        }

        public void setResultado(int aux){
            this.resultado = aux;
        }
    }
}
