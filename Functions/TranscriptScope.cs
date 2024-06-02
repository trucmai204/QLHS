using Database_Connector;
using Entities;

namespace Functions
{
    public static class TranscriptScope
    {
        private static AppDbContext Db { get; set; } = new AppDbContext();
        public static List<Transcript> GetTranscripts()
        {
            return Db.Transcript.ToList();
        }
    }
}
