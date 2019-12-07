using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
namespace projFilaMedicamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Medicamento oMedicamento = new Medicamento();
            Medicamentos osMedicamentos = new Medicamentos();
            Lote oLote = new Lote();

            int id = 0;
            string nome = "";
            string laboratorio = "";
            int qtde = 0;
            DateTime venc;
            int opt = 1000;


            
            while(opt!= 0)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n ----------------------------------------------------" +
                                  "\n|                0. Finalizar processo               |" +
                                  "\n|                1. Cadastrar medicamento            |" +
                                  "\n|                2. Consultar medicamento (Sintético)|" +
                                  "\n|                3. Consultar medicamento (Analítico)|" +
                                  "\n|                4. Comprar medicamento              |" +
                                  "\n|                5. Vender medicamento               |" +
                                  "\n|                6. Listar medicamentos              |" +
                                  "\n-----------------------------------------------------");
                opt = int.Parse(Console.ReadLine());
                switch (opt)
                {
                    // CADASTRANDO MEDICAMENTO
                    case 1:
                        Console.Clear();
                        Console.Write("Id: ");
                        id = int.Parse(Console.ReadLine());
                        Console.Write("\nNome: ");
                        nome = Console.ReadLine();
                        Console.Write("\nLaboratorio: ");
                        laboratorio = Console.ReadLine();
                        osMedicamentos.adicionar(new Medicamento(id, nome, laboratorio));
                        break;
                    //CONSULTA SINTETICA
                    case 2:
                        Console.Clear();
                        Console.Write("Id: ");
                        id = int.Parse(Console.ReadLine());
                        Medicamento medicamento = new Medicamento(id);
                        oMedicamento = osMedicamentos.pesqusiar(medicamento);
                        Console.Write("Medicamento: " + oMedicamento.ToString());
                        Console.Write("\nLote: " + oMedicamento.Lotes.ToString());
                        
                        Console.ReadKey();
                        break;
                    //CONSULTA ANALITICA
                    case 3:
                        Console.Clear();
                        Console.Write("Id: ");
                        id = 0;
                        id = int.Parse(Console.ReadLine());
                        medicamento = new Medicamento(id);
                        medicamento = osMedicamentos.pesqusiar(medicamento);
                        Console.Write("Medicamento: " + medicamento.ToString());
                        Console.Write("\n\nLote: " + medicamento.Lotes.ToString());
                        Console.ReadKey();
                        break;
                    //CADASTRA LOTE
                    case 4:
                        Console.Clear();
                        Console.WriteLine("Insira os dados do lote:");
                        Console.Write("\n\nId: ");
                        int loteId = int.Parse(Console.ReadLine());
                        Console.Write("\nNome: ");
                        qtde = int.Parse(Console.ReadLine());
                        Console.Write("\nLaboratorio: ");
                        venc = DateTime.Parse(Console.ReadLine());

                        Console.Write("\n\nInsira o Id do medicamento comprado: ");
                        id = int.Parse(Console.ReadLine());
                        medicamento = new Medicamento(id);
                        if(osMedicamentos.pesqusiar(medicamento) != null )

                            oMedicamento.comprar(new Lote(loteId,qtde));

                        Console.ReadKey();
                        break;
                    //VENDER MEDICAMENTO
                    case 5:
                        Console.Clear();
                        Console.Write("Insira o ID do medicamento: ");
                        id = int.Parse(Console.ReadLine());
                        
                        medicamento = new Medicamento(id);
                        if (osMedicamentos.pesqusiar(medicamento) != null)

                          //  osMedicamentos.ListaMedicamentos

                        Console.ReadKey();
                        break;
                    //LISTAR MEDICAMENTO
                    case 6:
                        Console.Clear();

                        for (int i = 0; i < osMedicamentos.ListaMedicamentos.Count; i++ )
                        {
                            osMedicamentos.ListaMedicamentos.ToString();
                        }

                            Console.ReadKey();
                        break;


                }
            }
        }
=======
namespace projFilaMedicamento {
    class Program {
        static void Main(string[] args) {
            
        }

        public void exibeMenu() {
            Console.WriteLine(
                "--------------------------------------------------------------------" +
                "| 0. Finalizar processo                                            |" +
                "| 1. Cadastrar medicamento                                         |" +
                "| 2. Consultar medicamento (sintético: informar dados)             |" +
                "| 3. Consultar medicamento (analítico: informar dados1 + lotes)    |" +
                "| 4. Comprar medicamento (cadastrar lote)                          |" +
                "| 5. Vender medicamento (abater do lote mais antigo)               |" +
                "| 6. Listar medicamentos (informando dados sintéticos)             |" +
                "--------------------------------------------------------------------" +
                "-> Digite a opção: "
                );
        }
        public void cadastraMedicamento() { }
        public void consultaMedicamentoSintetico() {
            // Dados do medicamento: ID + NOME + LABORATÓRIO + QTDE DISPONÍVEL
        }
        public void consultaMedicamentoAnalitico() {
            // Dados do lote: ID + QTDE + DATA DE VENCIMENTO
        }
        public void compraMedicamento() { }
        public void vendeMedicamento() { }
        public void listaMedicamento() { }

>>>>>>> 607dc948b7eb7695f534c65b046c86377876f22b
    }
}
