using TesteCommand;

Televisao televisao = new Televisao();
ControleRemoto controleRemoto = new ControleRemoto();

IComando ligarTV = new ComandoLigarTV(televisao);
IComando desligarTV = new ComandoDesligarTV(televisao);
IComando aumentarVolumeTV = new ComandoAumentarVolume(televisao);
IComando diminuirVolumeTV = new ComandoDiminuirVolume(televisao);

controleRemoto.DefinirComando(ligarTV);
controleRemoto.ExecutarComando();

//controleRemoto.DefinirComando(aumentarVolumeTV);
//controleRemoto.ExecutarComando();

//controleRemoto.DefinirComando(diminuirVolumeTV);
//controleRemoto.ExecutarComando();

//controleRemoto.DefinirComando(desligarTV);
//controleRemoto.ExecutarComando();

//controleRemoto.DefinirComando(aumentarVolumeTV);
//controleRemoto.ExecutarComando();

//controleRemoto.DefinirComando(diminuirVolumeTV);
//controleRemoto.ExecutarComando();