using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PartyInvitationsPortal.Contracts;
using PartyPortalInvitations.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvitationsPortal.Controllers
{
    public class SecurityController : Controller
    {
        private IPartyThrowerOrGuestRepositry _PTorGRepositryObj;
        private DbContext _appDbContext;
        protected DbSet<RegisterUser> _dbSet { get; set; }

        private IMediator _mediator;

        public SecurityController(IPartyThrowerOrGuestRepositry PTorGRepositryObj, DbContext appDbContext, IMediator mediator)
        {
            _PTorGRepositryObj = PTorGRepositryObj;
            _appDbContext = appDbContext;

            _dbSet = _appDbContext.Set<RegisterUser>();

            _mediator = mediator;

        }




        [HttpPost]
        public ActionResult Register(RegisterUser registerUser)
        {
            ///////////////////
            if (ModelState.IsValid)
            {
              _mediator.Send(registerUser);

                return View("LoginAs");
            }
            else
            {

                return View();
            }
            ///////////////////////

            //if (ModelState.IsValid)
            //{

            //    _appDbContext.Add<RegisterUser>(registerUser);
            //    _appDbContext.SaveChanges();
            // //show alert registeration sucessfull and navigate to login page
            //    return View("LoginAs");


            //}
            //else
            //{

            //    return View();
            //}
        }




        [HttpGet]
        public ViewResult Register()
        {
            return View();
        }


        [HttpPost]
        public ViewResult LoginAs(PartyThrowerOrGuest partyThrowerOrGuest)
        {
            if (ModelState.IsValid)
            {
              
                

                RegisterUser userFound = _dbSet.Find(partyThrowerOrGuest.Email.ToString());

                if (userFound != null)
                {
                    ViewBag.clientresponse = _PTorGRepositryObj.isPTorG(partyThrowerOrGuest); ;
                    if (_PTorGRepositryObj.isPTorG(partyThrowerOrGuest).Equals("PartyThrower"))
                    {
                        return View("~/Views/Home/EnterResturantAndMenuItems.cshtml");

                    }
                    else
                    {
                        return View("Guest", partyThrowerOrGuest);
                    }

                }
                else
                {
                    return View("~/Views/Security/Register.cshtml");
                }




          
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public ViewResult LoginAs()
        {
            return View();
        }


    }


}
