using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodDeliverySYS.Business
{
    public class CardPaymentStrategy : IPaymentStrategy
    {
        private readonly string name;
        private readonly string cardNumber;
        private readonly string expiry;
        private readonly string cvv;

        public CardPaymentStrategy(string name, string cardNumber, string expiry, string cvv)
        {
            this.name = name;
            this.cardNumber = cardNumber;
            this.expiry = expiry;
            this.cvv = cvv;
        }
        public bool Pay(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException(
                    "Payment amount must be greater than zero");
            // Check the required card details.
            if (string.IsNullOrWhiteSpace(name))
                return false;

            if (string.IsNullOrEmpty(cardNumber) ||
                cardNumber.Length != 16 ||
                !cardNumber.All(char.IsDigit))
                return false;

            if (string.IsNullOrEmpty(cvv) ||
                cvv.Length != 3 ||
                !cvv.All(char.IsDigit))
                return false;

            // Read the expiry date in MM/yy format.
            DateTime expiryDate;
            if (!DateTime.TryParseExact(
                    expiry, "MM/yy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None, out expiryDate))
                return false;

            // A card remains valid throughout its expiry month.
            DateTime currentMonth =
                new DateTime(DateTime.Today.Year, DateTime.Today.Month, 1);

            if (expiryDate < currentMonth)
                return false;

            // Simulated approval after the checks pass.
            return true;
        }
    }
}
