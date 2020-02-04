using System;
using System.Collections.Generic;
using System.Text;

namespace PartyInvitationsPortal.Contracts
{

    public interface IPartyThrowerOrGuestRepositry
    {
         string isPTorG(PartyThrowerOrGuest response);
    }

    public class PartyThrowerOrGuestRepositry : IPartyThrowerOrGuestRepositry
    {
       

        public  string isPTorG(PartyThrowerOrGuest response)
        {
            return response.PTorG.ToString();
        }

        


    }
}
