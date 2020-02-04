using Microsoft.EntityFrameworkCore;
using PartyInvitationsPortal.Contracts;
using PartyPortalInvitations.DataAccess;
using StructureMap;
using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PartyInvitationsPortal.StructureMap
{
    public class StructureMapRegistery : Registry
    {

        public StructureMapRegistery()
        {

            For<IPartyThrowerOrGuestRepositry>().LifecycleIs(Lifecycles.Container)
                                    .Use<PartyThrowerOrGuestRepositry>();

            For<DbContext>().LifecycleIs(Lifecycles.Container)
                        .Use<AppDbcontext>();
        }
    }

}
