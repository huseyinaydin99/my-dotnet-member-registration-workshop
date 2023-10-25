using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.ServiceAdapters;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.Business.Concrete
{
    public class MemberManager : IMemberService
    {
        private IMemberService _memberService;
        private IKpsService _kpsService;
        public MemberManager(IMemberService memberService, IKpsService kpsService)
        {
            _memberService = memberService;
            _kpsService = kpsService;
        }

        public void Add(Member member)
        {
            if (!_kpsService.ValidateUser(member)) throw new Exception("Girilen kullanıcı geçerli değil!");
                //return;
            _memberService.Add(member);
        }
    }
}