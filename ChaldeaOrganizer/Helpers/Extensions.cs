﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChaldeaOrganizer.Helpers
{
    public static class Extensions
    {
        public static string GetMaterialLabel(this string material)
        {
            var label = material switch
            {
                "Proof"                 => "Proof Of Hero",
                "Bone"                  => "Evil Bone",
                "Fang"                  => "Dragon Fang",
                "Dust"                  => "Void's Dust",
                "Chain"                 => "Fool's Chain",
                "Stinger"               => "Stinger of Certain Death",
                "Fluid"                 => "Magical Cerebrospinal Fluid",
                "Stake"                 => "Iron Stake of Evening Tears",
                "Gunpowder"             => "Reactive Gunpowder",
                "Seed"                  => "Seed of Yggdrasil",
                "Lantern"               => "Ghost Lantern",
                "Crystal"               => "Octuplet Crystals",
                "Jewel"                 => "Serpent Jewel",
                "Feather"               => "Pheonix Feather",
                "Gear"                  => "Eternal Gear",
                "Page"                  => "Forbidden Page",
                "Baby"                  => "Homunculus Baby",
                "Horseshoe"             => "Meteor Horseshoe",
                "Medal"                 => "Great Knight Medal",
                "Shell"                 => "Shell of Reminiscence",
                "Magatama"              => "Magatama",
                "Permafrost"            => "Permafrost",
                "Ring"                  => "Ring",
                "Steel"                 => "Steel",
                "Claw"                  => "Claw of Chaos",
                "Heart"                 => "Heart of the Foreign God",
                "Scale"                 => "Dragon's Reversal Scale",
                "Root"                  => "Spirit Root",
                "Horn"                  => "Warehorse's Young Horn",
                "Tearstone"             => "Tearstone of Blood",
                "Grease"                => "Black Beast Grease",
                "Lamp"                  => "Lamp of Evil Sealing",
                "Scarab"                => "Scarab of Wisdom",
                "Lanugo"                => "Lanugo",
                "Gallstone"             => "Cursed Beast Gallstone",
                "Wine"                  => "Wine",
                "SaberPiece"            => "Saber Piece",
                "ArcherPiece"           => "Archer Piece",
                "LancerPiece"           => "Lancer Piece",
                "RiderPiece"            => "Rider Piece",
                "CasterPiece"           => "Caster Piece",
                "AssassinPiece"         => "Assassin Piece",
                "BerserkerPiece"        => "Berseker Piece",
                "SaberMonument"         => "Saber Monument",
                "ArcherMonument"        => "Archer Monument",
                "LancerMonument"        => "Lancer Monument",
                "RiderMonument"         => "Rider Monument",
                "CasterMonument"        => "Caster Monument",
                "AssassinMonument"      => "Assassin Monument",
                "BerserkerMonument"     => "Berseker Monument",
                "GemOfSaber"            => "Gem Of Saber",
                "GemOfArcher"           => "Gem Of Archer",
                "GemOfLancer"           => "Gem Of Lancer",
                "GemOfRider"            => "Gem Of Rider",
                "GemOfCaster"           => "Gem Of Caster",
                "GemOfAssassin"         => "Gem Of Assassin",
                "GemOfBerserker"        => "Gem Of Berserker",
                "MagicGemOfSaber"       => "Magic Gem Of Saber",
                "MagicGemOfArcher"      => "Magic Gem Of Archer",
                "MagicGemOfLancer"      => "Magic Gem Of Lancer",
                "MagicGemOfRider"       => "Magic Gem Of Rider",
                "MagicGemOfCaster"      => "Magic Gem Of Caster",
                "MagicGemOfAssassin"    => "Magic Gem Of Assassin",
                "MagicGemOfBerserker"   => "Magic Gem Of Berserker",
                "SecretGemOfSaber"      => "Secret Gem Of Saber",
                "SecretGemOfArcher"     => "Secret Gem Of Archer",
                "SecretGemOfLancer"     => "Secret Gem Of Lancer",
                "SecretGemOfRider"      => "Secret Gem Of Rider",
                "SecretGemOfCaster"     => "Secret Gem Of Caster",
                "SecretGemOfAssassin"   => "Secret Gem Of Assassin",
                "SecretGemOfBerserker"  => "Secret Gem Of Berserker",
                _ => ""
            };



            return label;
        }
    }
}
