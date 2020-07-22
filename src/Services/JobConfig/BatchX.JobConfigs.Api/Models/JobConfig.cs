using System;

namespace BatchX.JobConfig.Api.Models
{
    public class JobConfig
    {
        public string Id { get; set; }

        public string Name { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }

        public DateTimeOffset CreationDate { get; set; }

        public DateTimeOffset UpdateDate { get; set; }
    }
}
