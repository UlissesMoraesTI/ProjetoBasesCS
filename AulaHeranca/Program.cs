using AulaHeranca;

CarroEsportivo carroEsportivo = new CarroEsportivo();
carroEsportivo.Modelo = "F8 Tributo";
carroEsportivo.Marca = "Ferrari";
carroEsportivo.Cor = "Vermelho";
carroEsportivo.AnoFabricacao = 2026;
carroEsportivo.AnoModelo = 2027;
carroEsportivo.Ligar();
carroEsportivo.Acelerar();
carroEsportivo.AtivarTurbo();
carroEsportivo.Frear();
carroEsportivo.Desligar();

CarroPremium carroPremium = new CarroPremium();
carroPremium.Modelo = "S-Class";
carroPremium.Marca = "Mercedes-Benz";
carroPremium.Cor = "Preto";
carroPremium.AnoFabricacao = 2023;
carroPremium.AnoModelo = 2024;
carroPremium.Ligar();
carroPremium.Acelerar();
carroPremium.AbrirTetoSolar();
carroPremium.Frear();
carroPremium.Desligar();