using System;

namespace Revisao
{
    class Program
    {
        private static int menu(){
            Console.WriteLine("Informe a opção desejada: ");
            Console.WriteLine("1 - Inserir novo aluno");
            Console.WriteLine("2 - Listar alunos");
            Console.WriteLine("3 - Calcular média geral");
            Console.WriteLine("0 - Sair");

            Console.WriteLine();

            int opcaoUsuario = int.Parse(Console.ReadLine());
            return opcaoUsuario;
        }
        static void Main(string[] args)
        {
            Aluno alunos = new Aluno("", 0);
            ListaAluno classe = new ListaAluno();

            int opcao = menu();

            while(opcao != 0){

                switch(opcao){
                    case 1:
                        Console.WriteLine("Informe o nome do aluno: ");
                        string _nome = Console.ReadLine();
                        
                        Console.WriteLine("informe a nota do aluno: ");
                        if(decimal.TryParse(Console.ReadLine(), out decimal _nota)){
                            
                        }else{
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }
                        alunos = new Aluno(_nome, _nota);
                        classe.inserirAluno(alunos);
                        break;
                    case 2:
                        classe.Imprimir();
                        break;
                    case 3:
                        Conceito conceitoGeral;

                        if(classe.calcularMedia() < 49){
                            conceitoGeral = Conceito.E;
                        }else if (classe.calcularMedia() < 59){
                            conceitoGeral = Conceito.D;
                        }else if (classe.calcularMedia() < 65){
                            conceitoGeral = Conceito.C;
                        }else if (classe.calcularMedia() < 89){
                            conceitoGeral = Conceito.B;
                        }else{
                            conceitoGeral = Conceito.A;
                        }
                        Console.WriteLine("Média da Turma: " + classe.calcularMedia() + " | Conceito: " + conceitoGeral);
                        break;
                    default:
                        // throw new ArgumentOutOfRangeException();
                        break;
                }
                opcao = menu();
            }
        }
    }
}

