Artifact BRAINTREE_DROP_IN_ARTIFACT				= new Artifact ("Braintree.DropIn",			 "9.7.0", "10.0", ComponentGroup.Firebase, csprojName: "DropIn");
Artifact BRAINTREE_APPLE_PAY_ARTIFACT            = new Artifact ("Braintree.ApplePay",		"5.12.0", "10.0", ComponentGroup.Firebase, csprojName: "ApplePay");
Artifact BRAINTREE_CARD_ARTIFACT               	= new Artifact ("Braintree.Card",			"5.12.0", "10.0", ComponentGroup.Firebase, csprojName: "Card");
Artifact BRAINTREE_CORE_ARTIFACT                 = new Artifact ("Braintree.Core",			"5.12.0", "10.0", ComponentGroup.Firebase, csprojName: "Core");
Artifact BRAINTREE_UNION_PAY_ARTIFACT         	= new Artifact ("Braintree.UnionPay",		"5.12.0", "10.0", ComponentGroup.Firebase, csprojName: "UnionPay");
Artifact BRAINTREE_PAYPAL_ARTIFACT         		= new Artifact ("Braintree.PayPal",			"5.12.0", "10.0", ComponentGroup.Firebase, csprojName: "PayPal");
Artifact BRAINTREE_THREE_D_SECURE_ARTIFACT       = new Artifact ("Braintree.ThreeDSecure",	"5.12.0", "10.0", ComponentGroup.Firebase, csprojName: "ThreeDSecure");
Artifact BRAINTREE_VENMO_ARTIFACT                = new Artifact ("Braintree.Venmo",			"5.12.0", "10.0", ComponentGroup.Firebase, csprojName: "Venmo");

var ARTIFACTS = new Dictionary<string, Artifact> {
	{ "Braintree.DropIn",				BRAINTREE_DROP_IN_ARTIFACT },
	{ "Braintree.ApplePay",				BRAINTREE_APPLE_PAY_ARTIFACT },
	{ "Braintree.Card",					BRAINTREE_CARD_ARTIFACT },
	{ "Braintree.Core",					BRAINTREE_CORE_ARTIFACT },
	{ "Braintree.UnionPay",				BRAINTREE_UNION_PAY_ARTIFACT },
	{ "Braintree.PayPal",				BRAINTREE_PAYPAL_ARTIFACT },
	{ "Braintree.ThreeDSecure",         BRAINTREE_THREE_D_SECURE_ARTIFACT },
	{ "Braintree.Venmo",				BRAINTREE_VENMO_ARTIFACT },
};

void SetArtifactsDependencies ()
{
	BRAINTREE_DROP_IN_ARTIFACT.Dependencies			= new [] { BRAINTREE_APPLE_PAY_ARTIFACT, BRAINTREE_CARD_ARTIFACT, BRAINTREE_CORE_ARTIFACT, BRAINTREE_UNION_PAY_ARTIFACT, BRAINTREE_PAYPAL_ARTIFACT, BRAINTREE_THREE_D_SECURE_ARTIFACT, BRAINTREE_VENMO_ARTIFACT };
	BRAINTREE_APPLE_PAY_ARTIFACT.Dependencies		= new Artifact [] { };
	BRAINTREE_CARD_ARTIFACT.Dependencies				= new Artifact [] { };
	BRAINTREE_CORE_ARTIFACT.Dependencies				= new Artifact [] { };
	BRAINTREE_UNION_PAY_ARTIFACT.Dependencies		= new Artifact [] { };
	BRAINTREE_PAYPAL_ARTIFACT.Dependencies			= new Artifact [] { };
	BRAINTREE_THREE_D_SECURE_ARTIFACT.Dependencies	= new Artifact [] { };
	BRAINTREE_VENMO_ARTIFACT.Dependencies			= new Artifact [] { };
}

void SetArtifactsPodSpecs ()
{
	FIREBASE_CLOUD_FIRESTORE_ARTIFACT.PodSpecs = new [] {
		PodSpec.Create ("BraintreeDropIn",        	 "9.7.2",       frameworkSource: FrameworkSource.Pods, frameworkName: "BraintreeDropIn", targetName: "BraintreeDropIn"),
		PodSpec.Create ("Braintree",          		"5.12.0", 		frameworkSource: FrameworkSource.Pods, frameworkName: "Braintree", subSpecs: new [] { "ApplePay", "Card", "Core", "UnionPay", "PayPal", "ThreeDSecure", "Venmo" })
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
	// Firebase components
	BRAINTREE_DROP_IN_ARTIFACT.Samples				= null; // new [] { "AnalyticsSample" };
	BRAINTREE_APPLE_PAY_ARTIFACT.Samples			= null;
	BRAINTREE_CARD_ARTIFACT.Samples					= null;
	BRAINTREE_CORE_ARTIFACT.Samples					= null;
	BRAINTREE_UNION_PAY_ARTIFACT.Samples			= null;
	BRAINTREE_PAYPAL_ARTIFACT.Samples				= null;
	BRAINTREE_THREE_D_SECURE_ARTIFACT.Samples		= null;
	BRAINTREE_VENMO_ARTIFACT.Samples				= null;
}
