using EmprendeUCR.Domain.Core.Entities;
using EmprendeUCR.Domain.Core.Exceptions;
using EmprendeUCR.Domain.Core.ValueObjects;
using EmprendeUCR.Domain.PaymentInfos.Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EmprendeUCR.Domain.PaymentMethods.Entities
{
    public partial class CardPaymentMethod
    {
        public IReadOnlyCollection<CardPaymentInfo> CardPaymentInfos;
        private readonly List<CardPaymentInfo> _cardPaymentInfos;
        [Key]
        public string Name { get; private set; }
        public bool Status { get; private set; }
        public CardPaymentMethod(string name, bool status)
        {
            Name = name;
            Status = status;
            _cardPaymentInfos = new List<CardPaymentInfo>();
        }
        public void ChangeStatus()
        {
            Status = !Status;
        }

        public void AddCardPaymentInfo(CardPaymentInfo cardPaymentInfo)
        {
            if (_cardPaymentInfos.Exists(p => p.Account_Number == cardPaymentInfo.Account_Number))
                throw new DomainException("Ese número de teléfono ya se encuentra agregado");
            _cardPaymentInfos.Add(cardPaymentInfo);
            cardPaymentInfo.AssignPaymentMethod(this);
        }

        public void RemovePhonePaymentInfo(CardPaymentInfo cardPaymentInfo)
        {
            if (_cardPaymentInfos.Exists(p => p == cardPaymentInfo))
            {
                _cardPaymentInfos.Remove(cardPaymentInfo);
                cardPaymentInfo.AssignPaymentMethod(null);
            }
        }
    }
}
