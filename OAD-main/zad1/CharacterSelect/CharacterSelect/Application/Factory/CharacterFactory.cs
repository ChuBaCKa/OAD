using CharacterSelect.Domain.Character;
using CharacterSelect.Domain.Entity;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Application.Factory;

public static class CharacterFactory
{
    public static Character Create(CharacterClass cls, string? name)
    {
        return cls switch
        {
            CharacterClass.Chieftain => new Chieftain(name ?? "Chieftain"),
            CharacterClass.Mage    => new Mage(name ?? "Mage"),
            CharacterClass.Rogue   => new Rogue(name ?? "Rogue"),
            CharacterClass.Succubus   => new Succubus(name ?? "Succubus"),
            CharacterClass.Neko   => new Neko(name ?? "Neko"),
            CharacterClass.BattleMaid   => new BattleMaid(name ?? "BattleMaid"),
            CharacterClass.BunnyGirl   => new BunnyGirl(name ?? "BunnyGirl"),
            _ => throw new ArgumentOutOfRangeException(nameof(cls), "Nieznana klasa postaci.")
        };
    }
}