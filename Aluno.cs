namespace Revisao
{
    public class Aluno
    {
        public string nome;
        public decimal nota;
        public Aluno proximo;

        public Aluno(string name, decimal note){
            this.nome = name;
            this.nota = note;
            proximo = null;
        }

        public string toString(){
            
            return "Aluno: " + this.nome + "| Nota: " + this.nota;
        }
    }
}