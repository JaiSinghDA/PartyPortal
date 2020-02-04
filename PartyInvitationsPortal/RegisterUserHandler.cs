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
    internal interface IRequestHandlerCustom<T1, T2>
    {
    }


    class RegisterUserHandler : IRequestHandlerCustom<RegisterUser, bool>
    {
        private IPartyThrowerOrGuestRepositry _PTorGRepositryObj;
        private DbContext _appDbContext;

        public RegisterUserHandler(IPartyThrowerOrGuestRepositry PTorGRepositryObj, DbContext appDbContext)
        {
            _PTorGRepositryObj = PTorGRepositryObj;
            _appDbContext = appDbContext;
        }

        public bool Handle(RegisterUser user)
        {
            _appDbContext.Add<RegisterUser>(user);
                   _appDbContext.SaveChanges();
            return true;
        }

    //public Task<bool> Handle(RegisterUser request, CancellationToken cancellationToken)
    //    {
    //        _appDbContext.Add<RegisterUser>(request);
    //        _appDbContext.SaveChanges();
    //        return new Task<bool>(() => true);

    //    }
    }

    
}
