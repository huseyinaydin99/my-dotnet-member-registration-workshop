using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.Business.Concrete
{
    public class MemberManager : IMemberService
    {
        private IMemberService _memberService;

        public MemberManager(IMemberService memberService)
        {
            _memberService = memberService;
        }

        public void Add(Member member)
        {
            _memberService.Add(member);
        }
    }
}
