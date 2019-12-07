using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFilaMedicamento
{
    class Medicamentos
    {
        #region ATRIBUTOS
        private List<Medicamento> listaMedicamentos;

        #endregion

        #region CONSTRUTOR
        public Medicamentos()
        {
            this.listaMedicamentos = new List<Medicamento>();
        }
        #endregion

        #region PROPRIEDADES
        internal List<Medicamento> ListaMedicamentos {
            get => listaMedicamentos;
            set => listaMedicamentos = value; }
        #endregion

        public void adicionar(Medicamento medicamento)
        {
            listaMedicamentos.Add(medicamento);
        }
        public bool deletar(Medicamento medicamento)
        {
            bool delete = false;

            foreach (Medicamento m in this.listaMedicamentos)
            {
                if (m.Equals(medicamento))
                {
                    this.listaMedicamentos.Remove(medicamento);

                    delete = true;
                }

            }
            return delete;
        }
        public Medicamento pesqusiar(Medicamento medicamento)
        {
            Medicamento medicamentoAchado = new Medicamento();

            foreach(Medicamento m in this.listaMedicamentos)
            {
                if (m.Equals(medicamento)){

                    medicamentoAchado = m;
                }
            }
            return medicamentoAchado;
        }
    }
}
