using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PartyInvitationsPortal.Contracts
{


    [Table("RegisterUser")]
    public class RegisterUser : IRequest<bool>
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }


        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
           ErrorMessage = "Please enter a valid email address")]

        [Key]
        public string Email { get; set; }





    }
}
