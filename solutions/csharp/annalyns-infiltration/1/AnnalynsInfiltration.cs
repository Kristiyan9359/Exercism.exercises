static class QuestLogic
{
    public static bool CanFastAttack(bool knightIsAwake)
    {
        if (knightIsAwake == false) 
        {
            return true;
        }
        return false;
    }

    public static bool CanSpy(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake)
    {
        if(knightIsAwake == true || archerIsAwake == true || prisonerIsAwake == true)
        {
            return true;
        }
        return false;
    }

    public static bool CanSignalPrisoner(bool archerIsAwake, bool prisonerIsAwake)
    {
        if (archerIsAwake == false && prisonerIsAwake == true)
        {
            return true;
        }
        return false;
    }

    public static bool CanFreePrisoner(bool knightIsAwake, bool archerIsAwake, bool prisonerIsAwake, bool petDogIsPresent)
    {
        if (petDogIsPresent == true && archerIsAwake == false)
        {
            return true;
        }
        if (knightIsAwake == false && archerIsAwake == false && prisonerIsAwake == true)
        {
            return true;
        }
        return false;
    }
}
