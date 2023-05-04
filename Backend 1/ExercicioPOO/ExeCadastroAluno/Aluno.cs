namespace ExeCadastroAluno
{
    public class Aluno
    {

        public string Nome = "";
        public string Curso = "";
        public int Idade;
        public string Rg = "";
        public bool Bolsista;
        public float MediaFinal;
        public float ValorMensa;

        public void VerMediaFinal()
        {

            Console.WriteLine($"Media final igual a: {this.MediaFinal}");


        }
        public float VerMensalidade()
        {


            if (this.Bolsista)
            {

                if (this.MediaFinal >= 8)
                {

                    this.ValorMensa = this.ValorMensa * 0.5F;
                }

                else if (this.MediaFinal > 6)
                {
                    this.ValorMensa = this.ValorMensa * 0.7F;
                }

                else
                {
                    this.ValorMensa = this.ValorMensa * 1F;
                }

            }

            else
            {
                this.ValorMensa = this.ValorMensa * 1F;

            }


            return this.ValorMensa;

        }

    }
}







// Nome, Curso, Idade, RG, Bolsista (boolean), Média Final e Valor da Mensalidade. 

// VerMediaFinal() e VerMensalidade(), caso seja bolsista faremos o cálculo da mensalidade.

// obs:
// bolsista e média final maior ou igual a 8 conceder 50% de desconto na mensalidade
// bolsista e média final maior que 6 e menor que 8 conceder 30% de desconto na mensalidade 
// outros casos a mensalidade será integral
// Receba os dados do cadastro via console e crie um menu para o usuário escolher se quer visualizar a média ou o valor da mensalidade.
