//=================================================
//Copyright (c) Coalition of Good-Hearted-Engineers
//Feel Free to Use It
//=================================================
using Microsoft.EntityFrameworkCore;
using Sheenam.Api.Models.Foundations.Guests;

namespace Sheenam.Api.Brokers.Storages
{
    public partial class StorageBroker
    {
        public DbSet<Guest> Guests{get; set;}
    }
}
