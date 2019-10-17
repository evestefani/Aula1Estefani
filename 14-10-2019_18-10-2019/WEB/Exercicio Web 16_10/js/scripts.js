var crrncy = { 'BRL': { 'USD': 4.16 }, 'USD': { 'BRL': 0.24 } }
var btn = document.querySelector('.calculate-btn');
var baseCurrencyInput = document.getElementById('currency-1');
var secondCurrencyInput = document.getElementById('currency-2');
var amountInput = document.getElementById('amount');
var toShowAmount = document.querySelector('.given-amount');
var toShowBase = document.querySelector('.base-currency');
var toShowSecond = document.querySelector('.second-currency');
var toShowResult = document.querySelector('.final-result');



function convertCurrency(event) {
    event.preventDefault();
    var amount = amountInput.value;
    var from = baseCurrencyInput.value;
    var to = secondCurrencyInput.value;
    var result = 0;

    try {
        if (from == to) {
            result = amount;
        } else {
            result = amount * crrncy[from][to];
        }
    }
    catch (err) {
        result = amount * (1 / crrncy[to][from]);
    }

    toShowAmount.innerHTML = amount;
    toShowBase.textContent = from + ' = ';
    toShowSecond.textContent = to;
    toShowResult.textContent = result;
}

btn.addEventListener('click', convertCurrency);


(function ($) {

    var mask = {
        money: function () {
            var el = this
                , exec = function (v) {
                    v = v.replace(/\D/g, "");
                    v = new String(Number(v));
                    var len = v.length;
                    if (1 == len)
                        v = v.replace(/(\d)/, "0.0$1");
                    else if (2 == len)
                        v = v.replace(/(\d)/, "0.$1");
                    else if (len > 2) {
                        v = v.replace(/(\d{2})$/, '.$1');
                    }
                    return v;
                };

            setTimeout(function () {
                el.value = exec(el.value);
            }, 1);
        }
    }


    $.fn.formatValor = function () {
        $('#amount').bind('keypress', mask.money);
        $('#amount').bind('keyup', mask.money);
    };

})(jQuery);