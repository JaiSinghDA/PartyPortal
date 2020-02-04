using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartyInvitationsPortal.Contracts;
using PartyInvitationsPortal.Controllers;
using PartyPortalInvitations.DataAccess;
using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PartyInvitationsPortal.Test
{
   public class SecurityControllerTest
    {
        private RegisterUser _registerUserobj;

        public SecurityControllerTest(RegisterUserBuilder registerUserBuilderobj)
        {
            _registerUserobj = registerUserBuilderobj.WithEmailId("dfhs@sdjfg").Build();
            

        }

       
        public void NewUsersCanRegister()
        {

            //SecurityController securityController = new SecurityController();
            //ViewResult v = securityController.Register(new RegisterUser() { Email = "test1@gmail.com", Id = 0, Name = "test" });
            //Assert.NotNull(v);

        }

    }
}
