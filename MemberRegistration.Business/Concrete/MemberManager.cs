using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AydinCompany.Core.Aspects.Postsharp.ValidationAspects;
using MemberRegistration.Business.Abstract;
using MemberRegistration.Business.ServiceAdapters;
using MemberRegistration.Business.ValidationRules.FluentValidation;
using MemberRegistration.DataAccess.Abstract;
using MemberRegistration.Entities.Concrete;

namespace MemberRegistration.Business.Concrete
{
    public class MemberManager : IMemberService
    {
        private IMemberDal _memberDal;
        private IKpsService _kpsService;
        public MemberManager(IMemberDal memberDal, IKpsService kpsService)
        {
            _memberDal = memberDal;
            _kpsService = kpsService;
        }

        [FluentValidationAspect(typeof(MemberValidator))]
        public void Add(Member member)
        {
            CheckMemberExists(member);
            CheckIfUserValidFromKps(member);
        }

        private void CheckIfUserValidFromKps(Member member)
        {
            if (!_kpsService.ValidateUser(member)) throw new Exception("Girilen kullanıcı geçerli değil!");
            //return;
            _memberDal.Add(member);
        }

        private void CheckMemberExists(Member member)
        {
            if (_memberDal.Get(m => m.TCNO == member.TCNO) != null)
                throw new Exception("Kullanıcı kaydı zaten var bir daha kayıt olmanıza gerek yok.");
        }
    }
}