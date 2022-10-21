using Back_ER02.interfaces;

namespace Back_ER02.classes
{
    public class PessoaFisica : Pessoa, IPessoaFisica
    {
        public string? cpf { get; set; }

        public DateTime DataNasc { get; set; }

        public override float CalcularImposto(float rendimento)
        {
            throw new NotImplementedException();
        }

        public bool ValidarDataNasc(DateTime dataNasc)
        {
            throw new NotImplementedException();
        }
    }
}