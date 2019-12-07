using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFilaMedicamento
{
    class Medicamento
    {
        #region ATRIBUTOS
        private int id;
        private string nome;
        private string laboratorio;
        private Queue<Lote> lotes;
        #endregion
        #region CONSTRUTOR
        public Medicamento(int id, string nome, string laboratorio)
        {
            this.Id = id;
            this.Nome = nome;
            this.Laboratorio = laboratorio;
            this.lotes = new Queue<Lote>();
        }

        public Medicamento(int id): this(id, "", "")
        {
        }
        public Medicamento(): this(0,"","")
        {
        }
        #endregion
        #region PROPRIEDADES

        public int Id {
            get => id;
            set => id = value; }
        public string Nome {
            get => nome;
            set => nome = value; }
        public string Laboratorio {
            get => laboratorio;
            set => laboratorio = value; }
        internal Queue<Lote> Lotes {
            get => lotes;
            set => lotes = value; }
        #endregion
        #region METODOS
        public int qtdeDisponivel()
        {
            int qtdeDisponivel = 0;

            
               
            return qtdeDisponivel;
        } 
        public void comprar(Lote lote)
        {
            lotes.Enqueue(lote);
        }

        public bool vender(int qtde)
        {

            return true;
        }
        public override string ToString()
        {
            return id + "-" + nome + "-" + laboratorio + "-" + qtdeDisponivel();
        }
        public override bool Equals(object obj)
        {
            return this.id.Equals(((Medicamento)(obj)).id);
        }

        #endregion
    }
}
