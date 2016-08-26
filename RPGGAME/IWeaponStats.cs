namespace RPGGAME
{
    public interface IWeaponStats
    {
        int Minimal_Damage { get; set; }
        int Maximum_Damage { get; set; }
        IAttributes Stats { get; set; }
        byte Rarity { get; set; }
        byte Prefix_Index { get; set; }
        byte Sufix_Index { get; set; }
        string Prefix_Name { get; set; }
        string Sufix_Name { get; set; }
        float Prefix_effect { get; set; }
        float Sufix_effect { get; set; }


    }
}