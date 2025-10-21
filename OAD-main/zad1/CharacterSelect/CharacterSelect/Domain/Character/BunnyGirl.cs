using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class BunnyGirl : Entity.Character
{
    public BunnyGirl(string name) : base(name, CharacterClass.BunnyGirl)
    {
        Health = 200;
        Strength = 45;
        Intelligence = 1;
        Agility = 19;
        Charisma = 0;
        Defence = 10;
        mainstat = Strength;
        skill = "[passive]Useless: you do not affect plot";
    }
}