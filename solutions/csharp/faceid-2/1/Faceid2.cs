using System;
using System.Collections.Generic;


public class FacialFeatures
{
    public string EyeColor { get; }
    public decimal PhiltrumWidth { get; }

    public FacialFeatures(string eyeColor, decimal philtrumWidth)
    {
        EyeColor = eyeColor;
        PhiltrumWidth = philtrumWidth;
    }

   public override bool Equals(object obj)
   {
       if(obj is FacialFeatures other)
       {
          return EyeColor == other.EyeColor &&
           PhiltrumWidth == other.PhiltrumWidth;
       }
           return false;
   }

    public override int GetHashCode()
    {
        return HashCode.Combine(EyeColor, PhiltrumWidth);
    }
}

public class Identity
{
    public string Email { get; }
    public FacialFeatures FacialFeatures { get; }

    public Identity(string email, FacialFeatures facialFeatures)
    {
        Email = email;
        FacialFeatures = facialFeatures;
    }

    public override bool Equals(object obj)
    {
        if(obj is Identity other)
        {
            return Email == other.Email &&
                FacialFeatures.Equals(other.FacialFeatures);
        }
        return false;
    }

   public override int GetHashCode()
    {
        return HashCode.Combine(Email, FacialFeatures);
    }
}

public class Authenticator
{
    public static bool AreSameFace(FacialFeatures faceA, FacialFeatures faceB)
    {
        if(faceA.Equals(faceB))
        {
            return true;
        }
        return false;
    }

    public bool IsAdmin(Identity identity)
    {
       Identity admin = new Identity
           (
           "admin@exerc.ism", 
           new FacialFeatures ("green", 0.9m)
           );

        return admin.Equals(identity);
    }

     private List<Identity> registeredIdentities = new List<Identity>();
    
    public bool Register(Identity identity)
    {

        if(registeredIdentities.Contains(identity))
        {
            return false;
        }
        
        registeredIdentities.Add(identity);
        
        return true;
    }

    public bool IsRegistered(Identity identity)
    {
         if(registeredIdentities.Contains(identity))
        {
            return true;
        }
                
        return false;
    }

    public static bool AreSameObject(Identity identityA, Identity identityB)
    {
        if(identityA == identityB)
        {
            return true;
        }
        return false;
    }
}
