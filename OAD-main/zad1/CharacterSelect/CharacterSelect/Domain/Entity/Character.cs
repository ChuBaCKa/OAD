using System;
using CharacterSelect.Application;
using CharacterSelect.Domain.Enum;

namespace CharacterSelect.Domain.Entity;

public abstract class Character
{
    public string Name { get; set; }
    public CharacterClass Class { get; }
    public int Health { get; protected set; }
    public int Strength { get; protected set; }
    public int Intelligence { get; protected set; }
    public int Agility { get; protected set; }
    public int Charisma { get; protected set; }
    public int Defence { get; protected set; }
    public int mainstat { get; protected set; }
    public string skill { get; protected set; }


    protected Character(string name, CharacterClass @class)
    {
        Name = string.IsNullOrWhiteSpace(name) ? @class.ToString() : name.Trim();
        Class = @class;
    }

    public virtual void Describe()
    {
        Console.WriteLine($"[{Class}] {Name}");
        Console.WriteLine($"  HP: {Health}");
        Console.WriteLine($"  STR: {Strength}  INT: {Intelligence}  AGI: {Agility}  CHA: {Charisma}  DEF: {Defence}");
    }

    public virtual void Attack()
    {
        Console.WriteLine($"  attack: {mainstat * 3}");
    }

    public virtual void UseSpecial()
    {
        Console.WriteLine($"  your character cust: {skill}");
    }
}