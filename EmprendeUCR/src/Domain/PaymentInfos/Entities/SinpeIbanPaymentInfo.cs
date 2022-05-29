using EmprendeUCR.Domain.Core.Entities;
using EmprendeUCR.Domain.Core.ValueObjects;
using EmprendeUCR.Domain.PaymentMethods.Entities;
using System.ComponentModel.DataAnnotations;

namespace EmprendeUCR.Domain.PaymentInfos.Entities
{
    public partial class SinpeIbanPaymentInfo
    {
        public SinpeIbanPaymentMethod SinpeIbanPaymentMethod;
        [Key]
        public string Account_Number { get; private set; }
        public int Payment_Info_ID { get; private set; }
        public string? Name_Payment_Method { get; private set; }
        public SinpeIbanPaymentInfo(string accountNumber, int paymentInfoID, string paymentMethodName)
        {
            Account_Number = accountNumber;
            Payment_Info_ID = paymentInfoID;
            Name_Payment_Method = paymentMethodName;
        }
        public SinpeIbanPaymentInfo()
        {
            Account_Number = "";
            Payment_Info_ID = 0;
            Name_Payment_Method = null;
        }
        public void AssignPaymentMethod(SinpeIbanPaymentMethod sinpeIbanPaymentMethod)
        {
            SinpeIbanPaymentMethod = sinpeIbanPaymentMethod;
        }
    }
}

