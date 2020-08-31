using System;
using BraintreeCore;
using UIKit;

namespace DropinQs
{
    public class BraintreeDemoBaseViewController : UIViewController
    {
        public event Action<string> Progress;
		public event Action<BTPaymentMethodNonce> Completion;
		public event Action Transaction;

        readonly string authorization;

        public BraintreeDemoBaseViewController(string authorization)
        {
            this.authorization = authorization;
        }
    }
}
