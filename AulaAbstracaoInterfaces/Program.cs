using Animais;

Cachorro cachorro = new Cachorro();
FazerAnimalFalar(cachorro);

Gato gato = new Gato();
FazerAnimalFalar(gato);

void FazerAnimalFalar(IAnimal animal)
{
    animal.EmitirSom();
}