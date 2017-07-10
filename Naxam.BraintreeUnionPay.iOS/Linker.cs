using System;
namespace BraintreeUnionPay
{
    [Foundation.Preserve(AllMembers = true)]
    public static class Linker
    {
        public static void Preserve () {
            new BraintreeCard.BTCard();
        }
    }
}