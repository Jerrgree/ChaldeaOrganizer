using ChaldeaCommon.Enums;

namespace ChaldeaCommon.Extensions
{
    public static class Extensions
    {
        public static string GetMaterialLabel(this Material material)
        {
            var label = material switch
            {
                Material.Proof => "Proof Of Hero",
                Material.Bone => "Evil Bone",
                Material.Fang => "Dragon Fang",
                Material.Dust => "Void's Dust",
                Material.Chain => "Fool's Chain",
                Material.Stinger => "Stinger of Certain Death",
                Material.Fluid => "Magical Cerebrospinal Fluid",
                Material.Stake => "Iron Stake of Evening Tears",
                Material.Gunpowder => "Reactive Gunpowder",
                Material.Seed => "Seed of Yggdrasil",
                Material.Lantern => "Ghost Lantern",
                Material.Crystal => "Octuplet Crystals",
                Material.Jewel => "Serpent Jewel",
                Material.Feather => "Pheonix Feather",
                Material.Gear => "Eternal Gear",
                Material.Page => "Forbidden Page",
                Material.Baby => "Homunculus Baby",
                Material.Horseshoe => "Meteor Horseshoe",
                Material.Medal => "Great Knight Medal",
                Material.Shell => "Shell of Reminiscence",
                Material.Magatama => "Magatama",
                Material.Permafrost => "Permafrost",
                Material.Ring => "Ring",
                Material.Steel => "Steel",
                Material.Claw => "Claw of Chaos",
                Material.Heart => "Heart of the Foreign God",
                Material.Scale => "Dragon's Reversal Scale",
                Material.Root => "Spirit Root",
                Material.Horn => "Warehorse's Young Horn",
                Material.Tearstone => "Tearstone of Blood",
                Material.Grease => "Black Beast Grease",
                Material.Lamp => "Lamp of Evil Sealing",
                Material.Scarab => "Scarab of Wisdom",
                Material.Lanugo => "Lanugo",
                Material.Gallstone => "Cursed Beast Gallstone",
                Material.Wine => "Wine",
                Material.SaberPiece => "Saber Piece",
                Material.ArcherPiece => "Archer Piece",
                Material.LancerPiece => "Lancer Piece",
                Material.RiderPiece => "Rider Piece",
                Material.CasterPiece => "Caster Piece",
                Material.AssassinPiece => "Assassin Piece",
                Material.BerserkerPiece => "Berseker Piece",
                Material.SaberMonument => "Saber Monument",
                Material.ArcherMonument => "Archer Monument",
                Material.LancerMonument => "Lancer Monument",
                Material.RiderMonument => "Rider Monument",
                Material.CasterMonument => "Caster Monument",
                Material.AssassinMonument => "Assassin Monument",
                Material.BerserkerMonument => "Berseker Monument",
                Material.GemOfSaber => "Gem Of Saber",
                Material.GemOfArcher => "Gem Of Archer",
                Material.GemOfLancer => "Gem Of Lancer",
                Material.GemOfRider => "Gem Of Rider",
                Material.GemOfCaster => "Gem Of Caster",
                Material.GemOfAssassin => "Gem Of Assassin",
                Material.GemOfBerserker => "Gem Of Berserker",
                Material.MagicGemOfSaber => "Magic Gem Of Saber",
                Material.MagicGemOfArcher => "Magic Gem Of Archer",
                Material.MagicGemOfLancer => "Magic Gem Of Lancer",
                Material.MagicGemOfRider => "Magic Gem Of Rider",
                Material.MagicGemOfCaster => "Magic Gem Of Caster",
                Material.MagicGemOfAssassin => "Magic Gem Of Assassin",
                Material.MagicGemOfBerserker => "Magic Gem Of Berserker",
                Material.SecretGemOfSaber => "Secret Gem Of Saber",
                Material.SecretGemOfArcher => "Secret Gem Of Archer",
                Material.SecretGemOfLancer => "Secret Gem Of Lancer",
                Material.SecretGemOfRider => "Secret Gem Of Rider",
                Material.SecretGemOfCaster => "Secret Gem Of Caster",
                Material.SecretGemOfAssassin => "Secret Gem Of Assassin",
                Material.SecretGemOfBerserker => "Secret Gem Of Berserker",
                _ => ""
            };

            return label;
        }
    }
}