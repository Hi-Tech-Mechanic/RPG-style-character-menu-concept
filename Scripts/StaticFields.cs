using System;

namespace SameGame
{
    public class StaticFields
    {
        public static byte StatsCount = (byte)Enum.GetValues(typeof(Stats)).Length;

        public enum Stats
        {
            Health,
            Armor,
            Damage,
            CritChance,
            CritDamage
        }

        public class DropdownList
        {
            public enum ItemTags
            {
                Helm,
                Body,
                Legs,
                Boots,
                MainWeapon,
                Pistol
            }
        }
    }
}
