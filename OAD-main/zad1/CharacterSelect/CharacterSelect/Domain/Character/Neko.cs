using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Neko : Entity.Character
{
    public Neko(string name) : base(name, CharacterClass.Neko)
    {
        Health = 75;
        Strength = 10;
        Intelligence = 5;
        Agility = 50;
        Charisma = 15;
        Defence = 4;
        mainstat = Agility;
        skill = "[passive] Drinking Buddies:\n" +
                " 99% critical hit chance on Tuesdays while holding an empty beer";
    }
}