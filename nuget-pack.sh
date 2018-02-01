#! /bin/bash

function generate() {
    nuget pack $1.nuspec
}

frameworks=(
    braintree-3dsecure
    braintree-applepay
    braintree-amerianexpress
    braintree-card
    braintree-core
    braintree-datacollector
    braintree-paymentflow
    braintree-paypal
    braintree-venmo
    braintree-ui
    braintree-unionpay
    paypal-datacollector
    paypal-onetouch
    paypal-utils
    paypal-risk
)
for framework in "${frameworks[@]}"
do
generate $framework
done