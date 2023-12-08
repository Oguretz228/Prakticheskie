using System;

class Wizard
{
public string Name { get; set; }
private int mana;

public Wizard(string name, int mana)
{
Name = name;
this.mana = mana;
}

public void CastSpell(string spellName, int requiredMana)
{
if (this.mana < requiredMana)
{
Console.WriteLine($"Для использования {spellName} не хватает {requiredMana - this.mana} единиц маны. Хлебните зелья!");
}
else
{
this.mana -= requiredMana;
Console.WriteLine($"{Name} колдует! Эффект от {spellName}.");
}
}
}

class Program
{
static void Main()
{
Wizard gandalf = new Wizard("Волшебник", 50);
gandalf.CastSpell("огненный шар", 30);
gandalf.CastSpell("восстановление", 70);
}
}
