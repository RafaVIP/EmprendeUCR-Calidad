using EmprendeUCR.Domain.Core.Entities;
using EmprendeUCR.Domain.Core.ValueObjects;
using EmprendeUCR.Domain.PaymentMethods.Entities;
using System.ComponentModel.DataAnnotations;

namespace EmprendeUCR.Domain.PaymentInfos.Entities
{
    public partial class CardPaymentInfo
    {
        public CardPaymentMethod CardPaymentMethod;
        [Key]
        public string Account_Number { get; private set; }
        public int Payment_Info_ID { get; private set; }
        public string? Name_Payment_Method { get; private set; }
        public CardPaymentInfo(string accountNumber, int paymentInfoID, string paymentMethodName)
        {
            Account_Number = accountNumber;
            Payment_Info_ID = paymentInfoID;
            Name_Payment_Method = paymentMethodName;
        }
        public CardPaymentInfo()
        {
            Account_Number = "";
            Payment_Info_ID = 0;
            Name_Payment_Method = null;
        }
        public void AssignPaymentMethod(CardPaymentMethod cardPaymentMethod)
        {
            CardPaymentMethod = cardPaymentMethod;
        }
    }
}

