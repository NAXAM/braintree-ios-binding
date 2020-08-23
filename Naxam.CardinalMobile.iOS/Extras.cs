using Foundation;

namespace CardinalMobile
{
    [Preserve(AllMembers = true)]
    public static class CardinalMobileLinker
    {
        /// <summary>
        /// PayPalUtils and PayPalDataCollector are in use internally by BrainTreePayPal.
        /// BUT from public APIs, Xamarin.iOS couldn't know that.
        /// This code is to tell Xamarin.iOS that we need those both frameworks.
        /// </summary>
        public static void Init()
        {
        }
    }
}
