namespace TesteCommand
{
    public class ComandoAumentarVolume : IComando
    {
        private Televisao _aumentarVolume;

        public ComandoAumentarVolume(Televisao aumentarVolume)
        {
            _aumentarVolume = aumentarVolume;
        }

        public void Executar()
        {
            _aumentarVolume.AumentarVolume();
        }
    }
}
