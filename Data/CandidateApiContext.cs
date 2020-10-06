using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CandidateApi.Data
{
    public class CandidateApiContext : DbContext
    {
        public CandidateApiContext (DbContextOptions<CandidateApiContext> options)
            : base(options)
        {
        }

        public DbSet<CandidateApi.Data.Candidate> Candidate { get; set; }
    }
}
