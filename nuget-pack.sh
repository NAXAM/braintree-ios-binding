#! /bin/bash

function generate() {
    nuget pack $1.nuspec
}

frameworks=(
    braintree-3dsecure
    braintree-applepay
    braintree-card
    braintree-core
    braintree-datacollector
    braintree-paypal
    braintree-venmo
    braintree-ui
    braintree-unionpay
    paypal-datacollector
    paypal-onetouch
    paypal-utils
)
for framework in "${frameworks[@]}"
do
generate $framework
done