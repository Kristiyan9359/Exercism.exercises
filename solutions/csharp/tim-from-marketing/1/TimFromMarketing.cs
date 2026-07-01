static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        if(department == null)
        {
            if (id == null)
        {
            return $"{name} - {"OWNER"}";
}
            return $"[{id?.ToString()}] - {name} - {"OWNER"}";
        }

        else if(id == null) 
        {
            return $"{name} - {department?.ToUpper()}";
        }

       return $"[{id?.ToString()}] - {name} - {department?.ToUpper()}";
    }
}
