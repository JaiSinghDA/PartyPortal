using PartyInvitationsPortal.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace PartyInvitationsPortal.Test
{
    //class RegisterUserBuilder
    //{
    //}

        interface IRegisterUserBuilder
    {
        RegisterUserBuilder WithEmailId(string Email);
        RegisterUser Build();
    }


    public class RegisterUserBuilder : IRegisterUserBuilder
    {
        private RegisterUser registeruser { get; set; }
        public RegisterUserBuilder()
        {
            registeruser = new RegisterUser();
        }
        public RegisterUserBuilder WithEmailId(string Email)
        {
            registeruser.Email = Email;
            return this;
        }
      
        //public static implicit operator RegisterUser(RegisterUserBuilder instance)
        //{
        //    return instance.Build();
        //}

        public RegisterUser Build()
        {
            return registeruser;
        }
    }

}
