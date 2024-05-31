namespace TesteCommand
{
    internal class ComandoDesligarTV : IComando
    {
        private Televisao _desligarTV;

        public ComandoDesligarTV(Televisao desligarTV)
        {
            _desligarTV = desligarTV;
        }

        public void Executar()
        {
            _desligarTV.DesligarTelevisao();
        }
    }
}
