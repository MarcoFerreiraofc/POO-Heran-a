namespace POO_Heranca.Classes
{
    public class PessoaJuridica : Pessoa
    {
        public string cnpj;
        public string inscrcaoEstadual;

        public bool ValidarCNPJ(string documento)
        { if(documento != "" && documento.Length>10)
            {
                return true;
            }
            return false;
    }}
}