using Microsoft.EntityFrameworkCore;
using System;

namespace ChietaApp.Models
{
    public class EnquiryDBContext : DbContext
    {
        public EnquiryDBContext(DbContextOptions<EnquiryDBContext> options) : base(options)
        {

        }
    }
}

