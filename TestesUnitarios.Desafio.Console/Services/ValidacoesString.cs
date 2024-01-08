namespace TestesUnitarios.Desafio.Console.Services
{
    public class ValidacoesString
    {
        //verificar quando caracteres tem o texto
        public int RetornarQuantidadeCaracteres(string texto)
        {
            var numeroCaracteres = texto.Length;
            return numeroCaracteres;
        }
        //verificar se o texto tem o caracter/texto procurado
        public bool ContemCaractere(string texto, string textoProcurado)
        {
            var contem = texto.Contains(textoProcurado);
            return contem;
        }
        //se o texto termina com o texto que você está buscando
        public bool TextoTerminaCom(string texto, string textoProcurado)
        {
            var termina = texto.EndsWith(textoProcurado);
            return termina;
        }
    }
}