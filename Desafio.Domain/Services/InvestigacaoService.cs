namespace Desafio.Domain.Services
{
    public class InvestigacaoService
    {
        private const int VALOR_ROUBADO = 150;

        public bool PodeTerRoubado(int[] carteira)
        {              
            if (carteira == null || carteira.Length < 2)
            {
                return false;
            }

            int esquerda = 0;
            int direita = carteira.Length - 1;

            while (esquerda < direita)
            {
                int soma = carteira[esquerda] + carteira[direita];

                if (soma == VALOR_ROUBADO)
                {
                    return true;
                }
                else if (soma < VALOR_ROUBADO)
                {
                
                    esquerda++;
                }
                else 
                {
            
                    direita--;
                }
            }
                        
            return false;
        }
    }
}