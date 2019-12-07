using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFilaMedicamento
{
    class Lote
    {
        #region ATRIBUTOS
        private int id;
        private int qtde;
        private DateTime venc;
        #endregion
        #region CONSTRUTOR
        public Lote(int id, int qtde)
        {
            this.id = id;
            this.qtde = qtde;
            this.venc = new DateTime();
        }
        public Lote(int id) : this(id, 0)
        {
        }
        public Lote() : this(0, 0 )
        {
        }
        #endregion

        #region PROPRIEDADES
        public int Id {
            get => id;
            set => id = value; }
        public int Qtde {
            get => qtde;
            set => qtde = value; }
        public DateTime Venc {
            get => venc;
            set => venc = value; }
        #endregion
        public override string ToString()
        {
            return id + "-" + qtde + "-" + venc;
        }
        public override bool Equals(object obj)
        {
            return this.id.Equals(((Lote)(obj)).id);
        }


    }
}
