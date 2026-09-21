using AulaAbstracaoClasse;

Cachorro cachorro = new Cachorro();
FazerAnimalFalar(cachorro);

Gato gato = new Gato();
FazerAnimalFalar(gato);

void FazerAnimalFalar(Animal animal)
{
    animal.EmitirSom();
}