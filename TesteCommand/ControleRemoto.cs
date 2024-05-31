namespace TesteCommand
{
    public class ControleRemoto
    {
        private IComando _comando;

        public void DefinirComando(IComando comando)
        {
            _comando = comando;
        }

        public void ExecutarComando()
        {
            _comando.Executar();
        }
    }
}
