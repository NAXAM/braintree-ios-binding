Artifact BRAINTREE_DROP_IN_ARTIFACT					= new Artifact ("Braintree.DropIn.iOS",					 "9.7.0", "12.0", ComponentGroup.Braintree, csprojName: "DropIn");
Artifact BRAINTREE_APPLE_PAY_ARTIFACT            	= new Artifact ("Braintree.ApplePay.iOS",				"5.12.0", "12.0", ComponentGroup.Braintree, csprojName: "ApplePay");
Artifact BRAINTREE_CARD_ARTIFACT               		= new Artifact ("Braintree.Card.iOS",					"5.12.0", "12.0", ComponentGroup.Braintree, csprojName: "Card");
Artifact BRAINTREE_CORE_ARTIFACT                 	= new Artifact ("Braintree.Core.iOS",					"5.12.0", "12.0", ComponentGroup.Braintree, csprojName: "Core");
Artifact BRAINTREE_UNION_PAY_ARTIFACT         		= new Artifact ("Braintree.UnionPay.iOS",				"5.12.0", "12.0", ComponentGroup.Braintree, csprojName: "UnionPay");
Artifact BRAINTREE_PAYPAL_ARTIFACT         			= new Artifact ("Braintree.PayPal.iOS",					"5.12.0", "12.0", ComponentGroup.Braintree, csprojName: "PayPal");
Artifact BRAINTREE_THREE_D_SECURE_ARTIFACT       	= new Artifact ("Braintree.ThreeDSecure.iOS",			"5.12.0", "12.0", ComponentGroup.Braintree, csprojName: "ThreeDSecure");
Artifact BRAINTREE_VENMO_ARTIFACT                	= new Artifact ("Braintree.Venmo.iOS",					"5.12.0", "12.0", ComponentGroup.Braintree, csprojName: "Venmo");
Artifact BRAINTREE_PAYMENT_FLOW_ARTIFACT             = new Artifact ("Braintree.PaymentFlow.iOS",			"5.12.0", "12.0", ComponentGroup.Braintree, csprojName: "PaymentFlow");
Artifact BRAINTREE_PAYPAL_DATA_COLLECTOR_ARTIFACT     = new Artifact ("Braintree.PayPalDataCollector.iOS",	"5.12.0", "12.0", ComponentGroup.Braintree, csprojName: "PayPalDataCollector");

var ARTIFACTS = new Dictionary<string, Artifact> {
	{ "Braintree.DropIn.iOS",				BRAINTREE_DROP_IN_ARTIFACT },
	{ "Braintree.ApplePay.iOS",				BRAINTREE_APPLE_PAY_ARTIFACT },
	{ "Braintree.Card.iOS",					BRAINTREE_CARD_ARTIFACT },
	{ "Braintree.Core.iOS",					BRAINTREE_CORE_ARTIFACT },
	{ "Braintree.UnionPay.iOS",				BRAINTREE_UNION_PAY_ARTIFACT },
	{ "Braintree.PayPal.iOS",				BRAINTREE_PAYPAL_ARTIFACT },
	{ "Braintree.ThreeDSecure.iOS",         BRAINTREE_THREE_D_SECURE_ARTIFACT },
	{ "Braintree.Venmo.iOS",				BRAINTREE_VENMO_ARTIFACT },
	{ "Braintree.PaymentFlow.iOS",         	BRAINTREE_PAYMENT_FLOW_ARTIFACT },
	{ "Braintree.PayPalDataCollector.iOS",	BRAINTREE_PAYPAL_DATA_COLLECTOR_ARTIFACT },
};

void SetArtifactsDependencies ()
{
	BRAINTREE_DROP_IN_ARTIFACT.Dependencies							= new [] { BRAINTREE_APPLE_PAY_ARTIFACT, BRAINTREE_CARD_ARTIFACT, BRAINTREE_CORE_ARTIFACT, BRAINTREE_UNION_PAY_ARTIFACT, BRAINTREE_PAYPAL_ARTIFACT, BRAINTREE_THREE_D_SECURE_ARTIFACT, BRAINTREE_VENMO_ARTIFACT };
	BRAINTREE_APPLE_PAY_ARTIFACT.Dependencies						= new Artifact [] { BRAINTREE_CORE_ARTIFACT };
	BRAINTREE_CARD_ARTIFACT.Dependencies							= new Artifact [] { BRAINTREE_CORE_ARTIFACT };
	BRAINTREE_CORE_ARTIFACT.Dependencies							= new Artifact [] { };
	BRAINTREE_UNION_PAY_ARTIFACT.Dependencies						= new Artifact [] { BRAINTREE_CORE_ARTIFACT };
	BRAINTREE_PAYPAL_ARTIFACT.Dependencies							= new Artifact [] { BRAINTREE_CORE_ARTIFACT, BRAINTREE_PAYPAL_DATA_COLLECTOR_ARTIFACT, };
	BRAINTREE_THREE_D_SECURE_ARTIFACT.Dependencies					= new Artifact [] { BRAINTREE_CORE_ARTIFACT, BRAINTREE_PAYMENT_FLOW_ARTIFACT, };
	BRAINTREE_VENMO_ARTIFACT.Dependencies							= new Artifact [] { BRAINTREE_CORE_ARTIFACT };
	BRAINTREE_PAYMENT_FLOW_ARTIFACT.Dependencies					= new Artifact [] { BRAINTREE_CORE_ARTIFACT, BRAINTREE_PAYPAL_DATA_COLLECTOR_ARTIFACT, };
	BRAINTREE_PAYPAL_DATA_COLLECTOR_ARTIFACT.Dependencies			= new Artifact [] { };
}

void SetArtifactsPodSpecs ()
{
	BRAINTREE_DROP_IN_ARTIFACT.PodSpecs = new [] {
		PodSpec.Create ("BraintreeDropIn",        	 "9.7.0",       frameworkSource: FrameworkSource.Pods, frameworkName: "BraintreeDropIn", targetName: "BraintreeDropIn"),
	};
	BRAINTREE_APPLE_PAY_ARTIFACT.PodSpecs		= new PodSpec [] {
		PodSpec.Create ("Braintree",          		"5.12.0", 		frameworkSource: FrameworkSource.Pods, frameworkName: "BraintreeApplePay", subSpecs: new [] { "ApplePay", }),
	};
	BRAINTREE_CARD_ARTIFACT.PodSpecs							= new PodSpec [] {
		PodSpec.Create ("Braintree",          		"5.12.0", 		frameworkSource: FrameworkSource.Pods, frameworkName: "BraintreeApplePay", subSpecs: new [] { "ApplePay", "Card", "Core", "UnionPay", "PayPal", "ThreeDSecure", "Venmo", "PaymentFlow", "PayPalDataCollector" }),
	};
	BRAINTREE_CORE_ARTIFACT.PodSpecs							= new PodSpec [] { 
		PodSpec.Create ("Braintree",          		"5.12.0", 		frameworkSource: FrameworkSource.Pods, frameworkName: "BraintreeApplePay", subSpecs: new [] { "ApplePay", "Card", "Core", "UnionPay", "PayPal", "ThreeDSecure", "Venmo", "PaymentFlow", "PayPalDataCollector" }),
	};
	BRAINTREE_UNION_PAY_ARTIFACT.PodSpecs						= new PodSpec [] { 
		PodSpec.Create ("Braintree",          		"5.12.0", 		frameworkSource: FrameworkSource.Pods, frameworkName: "BraintreeApplePay", subSpecs: new [] { "ApplePay", "Card", "Core", "UnionPay", "PayPal", "ThreeDSecure", "Venmo", "PaymentFlow", "PayPalDataCollector" }),
	};
	BRAINTREE_PAYPAL_ARTIFACT.PodSpecs							= new PodSpec [] { 
		PodSpec.Create ("Braintree",          		"5.12.0", 		frameworkSource: FrameworkSource.Pods, frameworkName: "BraintreeApplePay", subSpecs: new [] { "ApplePay", "Card", "Core", "UnionPay", "PayPal", "ThreeDSecure", "Venmo", "PaymentFlow", "PayPalDataCollector" }),
	};
	BRAINTREE_THREE_D_SECURE_ARTIFACT.PodSpecs					= new PodSpec [] { 
		PodSpec.Create ("Braintree",          		"5.12.0", 		frameworkSource: FrameworkSource.Pods, frameworkName: "BraintreeApplePay", subSpecs: new [] { "ApplePay", "Card", "Core", "UnionPay", "PayPal", "ThreeDSecure", "Venmo", "PaymentFlow", "PayPalDataCollector" }),
	};
	BRAINTREE_VENMO_ARTIFACT.PodSpecs							= new PodSpec [] { 
		PodSpec.Create ("Braintree",          		"5.12.0", 		frameworkSource: FrameworkSource.Pods, frameworkName: "BraintreeApplePay", subSpecs: new [] { "ApplePay", "Card", "Core", "UnionPay", "PayPal", "ThreeDSecure", "Venmo", "PaymentFlow", "PayPalDataCollector" }),
	};
	BRAINTREE_PAYMENT_FLOW_ARTIFACT.PodSpecs					= new PodSpec [] { 
		PodSpec.Create ("Braintree",          		"5.12.0", 		frameworkSource: FrameworkSource.Pods, frameworkName: "BraintreeApplePay", subSpecs: new [] { "ApplePay", "Card", "Core", "UnionPay", "PayPal", "ThreeDSecure", "Venmo", "PaymentFlow", "PayPalDataCollector" }),
	};
	BRAINTREE_PAYPAL_DATA_COLLECTOR_ARTIFACT.PodSpecs			= new PodSpec [] { 
		PodSpec.Create ("Braintree",          		"5.12.0", 		frameworkSource: FrameworkSource.Pods, frameworkName: "BraintreeApplePay", subSpecs: new [] { "ApplePay", "Card", "Core", "UnionPay", "PayPal", "ThreeDSecure", "Venmo", "PaymentFlow", "PayPalDataCollector" }),
	};
}

void SetArtifactsExtraPodfileLines ()
{
	var dynamicFrameworkLines = new [] {	
		"=begin",
		"This override the static_framework flag to false,",
		"in order to be able to build dynamic frameworks.",
		"=end",
		"pre_install do |installer|",
		"\tinstaller.pod_targets.each do |pod|",
		"\tputs \"Forcing a static_framework to false for #{pod.name}\"",
		"\t\tif Pod::VERSION >= \"1.7.0\"",
		"\t\t\tif pod.build_as_static?",
		"\t\t\t\tdef pod.build_as_static?; false end",
		"\t\t\t\tdef pod.build_as_static_framework?; false end",
		"\t\t\t\tdef pod.build_as_dynamic?; true end",
		"\t\t\t\tdef pod.build_as_dynamic_framework?; true end",
		"\t\t\tend",
		"\t\telse",
		"\t\t\tdef pod.static_framework?; false end",
		"\t\tend",
		"\tend",
		"end",
	};

	BRAINTREE_DROP_IN_ARTIFACT.ExtraPodfileLines = dynamicFrameworkLines;
	BRAINTREE_APPLE_PAY_ARTIFACT.ExtraPodfileLines = dynamicFrameworkLines;
	BRAINTREE_CARD_ARTIFACT.ExtraPodfileLines = dynamicFrameworkLines;
	BRAINTREE_CORE_ARTIFACT.ExtraPodfileLines = dynamicFrameworkLines;
	BRAINTREE_UNION_PAY_ARTIFACT.ExtraPodfileLines = dynamicFrameworkLines;
	BRAINTREE_PAYPAL_ARTIFACT.ExtraPodfileLines = dynamicFrameworkLines;
	BRAINTREE_THREE_D_SECURE_ARTIFACT.ExtraPodfileLines = dynamicFrameworkLines;
	BRAINTREE_VENMO_ARTIFACT.ExtraPodfileLines = dynamicFrameworkLines;
}

void SetArtifactsSamples ()
{
	BRAINTREE_DROP_IN_ARTIFACT.Samples				= null; // new [] { "AnalyticsSample" };
	BRAINTREE_APPLE_PAY_ARTIFACT.Samples			= null;
	BRAINTREE_CARD_ARTIFACT.Samples					= null;
	BRAINTREE_CORE_ARTIFACT.Samples					= null;
	BRAINTREE_UNION_PAY_ARTIFACT.Samples			= null;
	BRAINTREE_PAYPAL_ARTIFACT.Samples				= null;
	BRAINTREE_THREE_D_SECURE_ARTIFACT.Samples		= null;
	BRAINTREE_VENMO_ARTIFACT.Samples				= null;
}
