using StructureMap.Pipeline;
using System;
using System.Collections.Generic;
using System.Text;
using StructureMap;

namespace PartyInvitationsPortal.Test.StructureMap
{
    class StructureMapRegistery_Test :Registry
    {

        public StructureMapRegistery_Test()
        {

            //For<IRegisterUserBuilder>().LifecycleIs(Lifecycles.Container)
            //                      .Use<RegisterUserBuilder>();
        }
    }
}
