using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Rogue : Entity.Character
{
    public Rogue(string name) : base(name, CharacterClass.Rogue)
    {
        Health = 110;
        Strength = 10;
        Intelligence = 6;
        Agility = 49;
        Charisma = 15;
        Defence = 2;
        mainstat = Agility;
        skill = "[active]Butterfly Flurry:\n" +
                "Seele enters the Amplification state and deals\n" +
                " Quantum DMG equal to 255%—459% of her ATK to a single enemy.";
    }
}