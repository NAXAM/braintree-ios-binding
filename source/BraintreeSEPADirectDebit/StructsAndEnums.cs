using ObjCRuntime;

namespace BraintreeSEPADirectDebit
{
	[Native]
	public enum BTSEPADirectDebitMandateType : long
	{
		OneOff = 0,
		Recurrent = 1
	}
}
