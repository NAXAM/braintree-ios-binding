#! /bin/bash

function generate() {
    sharpie bind -sdk iphoneos10.3 -f ./frameworks/$1 -output ./bindings/$1 -namespace $1
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
)
for framework in "${frameworks[@]}"
do
generate $framework
done