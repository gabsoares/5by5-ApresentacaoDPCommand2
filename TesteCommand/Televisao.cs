namespace TesteCommand
{
    public class Televisao
    {
        private bool _estaDesligada;
        private int _volumeTV;

        public Televisao()
        {
            _estaDesligada = true;
            _volumeTV = 10;
        }

        public void LigarTelevisao()
        {
            if (this._estaDesligada)
            {
                Console.WriteLine("Ligou a televisao!!!");
                _estaDesligada = false;
            }
            else
            {
                Console.WriteLine("Nao tem como ligar a TV pois ja esta ligada!!!");
            }
        }

        public void DesligarTelevisao()
        {
            if (!this._estaDesligada)
            {
                _estaDesligada = true;
                Console.WriteLine("Desligou a televisao!!!");
            }
            else
            {
                Console.WriteLine("Nao tem como desligar a TV pois ja esta desligada!!!");
            }
        }

        public void AumentarVolume()
        {
            if (_volumeTV != 100 && _estaDesligada == false)
            {
                _volumeTV += 1;
                Console.WriteLine("Volume da TV: " + _volumeTV);
            }
            else if (_estaDesligada == true)
            {
                Console.WriteLine("TV está desligada!!!");
            }
            else
            {
                Console.WriteLine("Volume ja esta no maximo, nao tem como aumentar mais!!!");
            }
        }

        public void DiminuirVolume()
        {
            if (_volumeTV > 0 && _estaDesligada == false)
            {
                _volumeTV -= 1;
                Console.WriteLine("Volume da TV: " + _volumeTV);
            }
            else if (_estaDesligada == true)
            {
                Console.WriteLine("TV está desligada!!!");
            }
            else
            {
                Console.WriteLine("Volume ja esta zerado, nao tem como diminuir mais!!!");
            }
        }
    }
}
