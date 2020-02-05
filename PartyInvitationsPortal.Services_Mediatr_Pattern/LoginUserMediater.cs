using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using PartyInvitationsPortal.Contracts;

namespace PartyInvitationsPortal.Services_Mediatr_Pattern
{
    class LoginUserMediater : IRequestHandler<PartyThrowerOrGuest, bool>
    {
        public LoginUserMediater()
        {

        }
   

        public Task<bool> Handle(PartyThrowerOrGuest partyThrowerOrGuest, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
