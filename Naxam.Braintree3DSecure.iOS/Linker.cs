using System;
namespace Braintree3DSecure
{
    [Foundation.Preserve(AllMembers = true)]
    public static class Linker
    {
        public static void Preserve () {
            new BraintreeCard.BTCard();
        }
    }
}