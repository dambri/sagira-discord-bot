using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using sagira_bot_discord.Models;

namespace sagira_bot_discord.Modules
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        Random random;

        [Command("random_raid")]
        public async Task RadomRaid()
        {
            List<Raid> raidList = new Raid().GetRaids();
            random = new Random();

            int randomNextIndex = random.Next(raidList.Count);
            Raid raid = raidList[randomNextIndex];

            var embed = new EmbedBuilder
            {
                Title = raid.Name,
                Description = raid.Objective,
                Color = raid.RaidColor,
                ImageUrl = raid.UrlImage,
                ThumbnailUrl = "https://www.bungie.net/common/destiny2_content/icons/8b1bfd1c1ce1cab51d23c78235a6e067.png"
            };

            embed.AddField("Bosses:", raid.BossName)
                .AddField("Location:", raid.Location)
                .AddField("Number of players:", raid.NumberOfPlayers)
                .AddField("Recommended light level:", raid.RecommendedLightLevel.ToString())
                .WithFooter(footer => footer.Text = "From Ragnarhawk")
                .WithCurrentTimestamp();

            await ReplyAsync("", false, embed.Build());
        }

        [Command("zerox")]
        public async Task Zerox()
        {
            await ReplyAsync("@MRZER0X Pas solide !!!!");
        }
    }
}
