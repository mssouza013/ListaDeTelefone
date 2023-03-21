namespace BLL
{
    public class Telefone
    {
        //Declarando variáveis
        public string Nome { get; set; } = string.Empty;
        public string Numero { get; set; } = string.Empty;

        //Metodo para que quando o for para aprensentar o Texto o mesmo já saia formatado.
        public override string ToString()
        {
            return $"O Número do/a {Nome} é : {Numero} ";
        }
    }
}