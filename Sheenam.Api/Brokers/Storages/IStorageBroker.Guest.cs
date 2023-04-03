//=================================================
//Copyright (c) Coalition of Good-Hearted-Engineers
//Feel Free to Use It
//=================================================
using Sheenam.Api.Models.Foundations.Guests;

namespace Sheenam.Api.Brokers.Storages
{
    public partial interface IStorageBroker
    {
        ValueTask <Guest> InsertGuestAsync (Guest guest);
    }
}
