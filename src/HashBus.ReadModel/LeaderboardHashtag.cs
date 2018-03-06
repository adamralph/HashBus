namespace HashBus.ReadModel
{
    using System;

    public class LeaderboardHashtag
    {
        public DateTime HashtaggedAt { get; set; }

        public long TweetId { get; set; }

        public string Text { get; set; }
    }
}
