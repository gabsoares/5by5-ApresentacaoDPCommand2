namespace TesteCommand
{
    public class ComandoLigarTV : IComando
    {
        private Televisao _ligarTV;

        public ComandoLigarTV(Televisao ligarTV)
        {
            _ligarTV = ligarTV;
        }

        public void Executar()
        {
            _ligarTV.LigarTelevisao();
        }
    }
}
