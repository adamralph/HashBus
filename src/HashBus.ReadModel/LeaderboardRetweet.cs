namespace HashBus.ReadModel
{
    using System;

    public class LeaderboardRetweet
    {
        public DateTime RetweetedAt { get; set; }

        public long TweetId { get; set; }

        public long UserId { get; set; }

        public string UserName { get; set; }

        public string UserScreenName { get; set; }
    }
}
