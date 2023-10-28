using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.Concrete;
using MemberRegistration.Business.ServiceAdapters;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.DataAccess.Concrete.EntityFramework;
using Ninject.Modules;

namespace MemberRegistration.Business.DependencyResolvers.Ninject.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IMemberService>().To<MemberManager>().InSingletonScope();
            Bind<IMemberDal>().To<EfMemberDal>().InSingletonScope();

            Bind<IKpsService>().To<KpsServiceAdapter>().InSingletonScope();
        }
    }
}
