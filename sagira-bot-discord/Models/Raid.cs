using System;
using System.Collections.Generic;
using Discord;

namespace sagira_bot_discord.Models
{
    public class Raid
    {
        public string Name;
        public string UrlImage;
        public string BossName;
        public string Location;
        public string Objective;
        public string NumberOfPlayers;
        public int RecommendedLightLevel;
        public Color RaidColor;

        public List<Raid> GetRaids()
        {
            var raidList = new List<Raid>
            {
                new Raid
                {
                    Name = "Leviathan, Crown of Sorrow",
                    UrlImage = "https://www.bungie.net/img/destiny_content/pgcr/raids_leviathan_eater_of_worlds.jpg",
                    Objective = "Enter the Menagerie and assassinate Gahlran, the Sorrow-Bearer, who has gone mad with power from wearing the Crown of Sorrow.",
                    BossName = " Gahlran's Deception\n Gahlran, the Sorrow-Bearer (Final Boss)",
                    Location = "The Leviathan, Nessus Orbit",
                    NumberOfPlayers = "1-6",
                    RecommendedLightLevel = 750,
                    RaidColor = new Color(102, 51, 0)
                },
                new Raid
                {
                    Name = "Garden of Salvation",
                    UrlImage = "https://www.bungie.net/img/destiny_content/pgcr/raid_garden_of_salvation.jpg",
                    Objective = "Track the source of the Unknown Artifact's signal into the Black Garden.",
                    BossName = " Consecrated Mind, Sol Inherent\n Sanctified Mind, Sol Inherent (Final Boss)",
                    Location = "The Black Garden",
                    NumberOfPlayers = "1-6",
                    RecommendedLightLevel = 940,
                    RaidColor = new Color(128, 255, 0)
                },
                new Raid
                {
                    Name = "Last Wish",
                    UrlImage = "https://www.bungie.net/img/destiny_content/pgcr/raid_beanstalk.jpg",
                    Objective = "Put an end to the Taken curse within the Dreaming City through killing Riven.",
                    BossName = " Kalli, the Corrupted\n Shuro Chi, the Corrupted\n Morgeth, the Spirekeeper\n Riven, of a Thousand Voices (Final Boss)",
                    Location = "The Dreaming City",
                    NumberOfPlayers = "1-6",
                    RecommendedLightLevel = 750,
                    RaidColor = new Color(51, 255, 255)
                },
                new Raid
                {
                    Name = "Leviathan",
                    UrlImage = "https://www.bungie.net/img/destiny_content/pgcr/raid_gluttony.jpg",
                    Objective = "Answer the invitation of Emperor Calus and complete his trials.",
                    BossName = " Aru'un\n B'ael\n M'orn\n Ta'aurc\n Tho'ourg\n Va'ase\n Gra'ask (Prestige only)\n Za'ahn (Prestige only)\n Emperor Calus (Final Boss)",
                    Location = "The Leviathan, Nessus Orbit",
                    NumberOfPlayers = "1-6",
                    RecommendedLightLevel = 750,
                    RaidColor = new Color(255, 255, 0)
                },
                new Raid
                {
                    Name = "Leviathan, Eater of Worlds",
                    UrlImage = "https://www.bungie.net/img/destiny_content/pgcr/raids_leviathan_eater_of_worlds.jpg",
                    Objective = "Assist Emperor Calus with clearing out a Vex transgression in the Leviathan's core.",
                    BossName = " Argos, Planetary Core (Final Boss)",
                    Location = "The Leviathan, Nessus Orbit",
                    NumberOfPlayers = "1-6",
                    RecommendedLightLevel = 750,
                    RaidColor = new Color(255, 153, 51)
                },
                new Raid
                {
                    Name = "Scourge of the Past",
                    UrlImage = "https://www.bungie.net/img/destiny_content/pgcr/raids.1305rh0093145r13t5hn10tnz.raid_sunset.jpg",
                    Objective = "Confront the Fallen war machine that has breached the Last City.",
                    BossName = " Ablazed Glory, Kell's Scourge\n Insurrection Prime, Kell's Scourge (Final Boss)",
                    Location = "The Last City, Earth",
                    NumberOfPlayers = "1-6",
                    RecommendedLightLevel = 750,
                    RaidColor = new Color(0, 0, 255)
                },
                new Raid
                {
                    Name = "Spire of Stars",
                    UrlImage = "https://www.bungie.net/img/destiny_content/pgcr/raid_greed.jpg",
                    Objective = "Stop the Red Legion invasion upon the Leviathan, destroy their fleet and kill Val Ca'uor.",
                    BossName = "Val ca'uor (Final Boss)",
                    Location = "The Leviathan, Nessus Orbit",
                    NumberOfPlayers = "1-6",
                    RecommendedLightLevel = 750,
                    RaidColor = new Color(255, 255, 51)
                }
            };

            return raidList;
        }
    }
}
