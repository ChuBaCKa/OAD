using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class BattleMaid : Entity.Character
{
    public BattleMaid(string name) : base(name, CharacterClass.BattleMaid)
    {
        Health = 300;
        Strength = 30;
        Intelligence = 30;
        Agility = 30;
        Charisma = 25;
        Defence = 1;
        mainstat = Strength;
        skill = "[passive] Omniscient:\n" +
                " instead of having varying stats, battle maids pull\n" +
                " them from their omniscience to distribute point evenly\n" +
                " among all attributes. Omniscient creatures also gain +40%\n" +
                " on all stats after initial distribution";
    }
}