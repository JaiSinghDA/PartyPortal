using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PartyInvitationsPortal.Contracts
{

    public class PartyThrowerOrGuest :   IRequest<bool>
    {
        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
           ErrorMessage = "Please enter a valid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please specify whether you'll attend")]
        public string PTorG { get; set; }

        public string isPTorG(PartyThrowerOrGuest response)
        {
            return response.PTorG.ToString();
        }

    }

}
