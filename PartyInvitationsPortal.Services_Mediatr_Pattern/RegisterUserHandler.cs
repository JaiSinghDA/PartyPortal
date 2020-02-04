using MediatR;
using Microsoft.EntityFrameworkCore;
using PartyInvitationsPortal.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace PartyInvitationsPortal.Services_Mediatr_Pattern
{
    class RegisterUserHandler : IRequestHandler<RegisterUser, bool>
    {
        private IPartyThrowerOrGuestRepositry _PTorGRepositryObj;
        private DbContext _appDbContext;

        public RegisterUserHandler(IPartyThrowerOrGuestRepositry PTorGRepositryObj, DbContext appDbContext)
        {
            _PTorGRepositryObj = PTorGRepositryObj;
            _appDbContext = appDbContext;
        }


      


        public Task<bool> Handle(RegisterUser request, CancellationToken cancellationToken)
        {
            _appDbContext.Add<RegisterUser>(request);
            _appDbContext.SaveChanges();
            return new Task<bool>(() => true);

        }
    }
}
