using AydinCompany.Core.DataAccess.EntityFramework;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.DataAccess.Concrete.EntityFramework
{
    public class EfMemberDal : EfEntityRepositoryBase<Member, MembershipContext, IMemberDal
    {

    }
}
