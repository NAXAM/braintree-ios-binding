using System;
namespace Naxam.BraintreeUnionPay.iOS
{
    [Foundation.Preserve(AllMembers = true)]
    public static class Linker
    {
        public static void Preserve () {
            new BraintreeCard.BTCard();
        }
    }
}