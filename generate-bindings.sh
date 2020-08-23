#! /bin/bash

function generate() {
    sharpie bind -sdk iphoneos -dry-run -output ./bindings/$1 -namespace $1 ./frameworks/$1.framework/Headers/*.h
}

frameworks=(
    Braintree3DSecure
    BraintreeApplePay
    BraintreeCard
    BraintreeCore
    BraintreeDataCollector
    BraintreePayPal
    BraintreeVenmo
    BraintreeUI
    BraintreeUnionPay
    PayPalDataCollector
    PayPalOneTouch
    PayPalUtils
    CardinalMobile
)
for framework in "${frameworks[@]}"
do
generate $framework
done