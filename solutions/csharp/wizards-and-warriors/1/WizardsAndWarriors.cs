abstract class Character
{
    private string characterType;
    
    protected Character(string characterType)
    {
        this.characterType = characterType;
    }

    public abstract int DamagePoints(Character target);

    public virtual bool Vulnerable() => false;

    public override string ToString() => $"Character is a {characterType}";
}

class Warrior : Character
{
    public Warrior() : base("Warrior")
    {
    }

    public override int DamagePoints(Character target)
    {
        if(target.Vulnerable())
        {
            return 10;
        }
        else 
        {
            return 6;
        }
    }
}

class Wizard : Character
{
    public Wizard() : base("Wizard")
    {
    }

    private bool spell = false;
    
    public override int DamagePoints(Character target)
    {
        if(spell)
        {
           return 12;
        }
       else 
       {
           return 3;
       }
    }

    public void PrepareSpell() => spell = true;

    public override bool Vulnerable()
    {
        if(spell == false)
        {
            return true;
        }
        return false;
    }
}
