using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Chieftain : Entity.Character
{
    public Chieftain(string name) : base(name, CharacterClass.Chieftain)
    {
        Health = 160;
        Strength = 30;
        Intelligence = 25;
        Agility = 10;
        Charisma = 20;
        Defence = 20;
        mainstat = Strength;
        skill = "[Active]Righteous Fire\n" +
                " Engulfs you in magical fire that rapidly burns you and nearby enemies.\n" +
                " Your spell damage is substantially increased while under this effect.\n" +
                " The effect ends when you have 1 life remaining.";
    }
}