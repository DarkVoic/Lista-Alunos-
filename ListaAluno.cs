using System;

namespace Revisao
{
    public class ListaAluno
    {
        public Aluno primeiro;
        public Aluno ultimo;
        public ListaAluno(){
            primeiro = new Aluno("", 0);
            ultimo = primeiro;
        }
        public void inserirAluno(Aluno novo){
            ultimo.proximo = novo;
            ultimo = ultimo.proximo;
        }

        public decimal calcularMedia(){
            Aluno aux = primeiro.proximo;

            decimal notas = 0;
            int cont = 0;
            while(aux != null){
                notas += aux.nota;  
                aux = aux.proximo;  
                cont++;   
            }
            return  notas / cont;
        }
        public void Imprimir(){
            Aluno aux = primeiro.proximo;

            if(aux == null){

                Console.WriteLine("lista vazia");
            }else{
                while(aux != null){

                    Console.WriteLine(aux.toString());
                    aux = aux.proximo;
                }
            }
        }
    }
}