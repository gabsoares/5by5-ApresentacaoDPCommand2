namespace TesteCommand
{
    public class ComandoDiminuirVolume : IComando
    {
        private Televisao _diminuirVolume;

        public ComandoDiminuirVolume(Televisao diminuirVolume)
        {
            _diminuirVolume = diminuirVolume;
        }

        public void Executar()
        {
            _diminuirVolume.DiminuirVolume();
        }
    }
}
