using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Character;

public sealed class Succubus : Entity.Character
{
    public Succubus(string name) : base(name, CharacterClass.Succubus)
    {
        Health = 120;
        Strength = 18;
        Intelligence = 25;
        Agility = 22;
        Charisma = 15;
        Defence = 4;
        mainstat = (Intelligence + Charisma) / 2;
        skill = "[Active]Sonic Wave:" +
                "\n Creates a gigantic wave of" +
                "\n sound in front of Queen of Pain," +
                "\n dealing heavy damage to all" +
                "\n enemy units in its wake and pushing them back.";
    }
}