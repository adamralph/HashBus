﻿using System.Threading.Tasks;
using HashBus.ReadModel;
using HashBus.ReadModel.MongoDB;
using MongoDB.Driver;

namespace HashBus.Viewer.MentionLeaderboard
{
    class App
    {
        public static async Task RunAsync(
            string mongoConnectionString, string mongoDBDatabase, string hashtag, int refreshInterval, bool showPercentages)
        {
            var mongoDatabase = new MongoClient(mongoConnectionString).GetDatabase(mongoDBDatabase);

            await MentionLeaderboardView.StartAsync(
                hashtag,
                refreshInterval,
                new MongoDBListRepository<Mention>(mongoDatabase, "mention_leaderboard__mentions"),
                showPercentages);
        }
    }
}