﻿using CandidateApi.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CandidateApi.Models
{
    public class CandidateContext: DbContext
    {
            public CandidateContext(DbContextOptions<CandidateContext> options) : base(options)
            { }

            public DbSet<Candidate> Candidates { get; set; }
    }
}
