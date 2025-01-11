namespace Assignment_Session_3_OOP.Enums
{
    [Flags]
    internal enum SecurityLevel : byte // Enum for Employee Security Levels
    {
        guest = 1,
        Developer=2,
        secretary=4,
        DBA=8
    }
}
