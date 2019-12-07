using projFilaMedicamento.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projFilaMedicamento.controller {
    class Medicamentos {
        private List<Medicamento> listaMedicamentos;

        internal List<Medicamento> ListaMedicamentos { get => listaMedicamentos; set => listaMedicamentos = value; }

        Medicamentos() { }
        
        public void adicionar(Medicamento medicamento) {
            //Adicionar o medicamento na lista de medicamentos 
        }
        public bool deletar(Medicamento medicamento) {
            // Remover o medicamento da lista somente se a quantidade disponível
            // for 0(zero).Indicar sucesso / fracasso da operação com true / false
            return false;
        }
        public Medicamento pesquisar(Medicamento medicamento) {
            // Procurar o medicamento indicado na lista de Medicamentos
            // utilizando o id do objeto como chave.Caso encontrado, retornar o
            // objeto completo. Caso não encontrado, retornar um objeto vazio. 
            return medicamento;
        }
            
    }
}
