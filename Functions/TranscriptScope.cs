using Database_Connector;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Functions
{
    public static class TranscriptScope
    {
        public static AppDbContext Db {  get; set; } = new AppDbContext();
        public static List<Transcript> GetTranscripts()
        {
            return Db.Transcript.ToList();
        }
    }
}
