/**
 * Created by martinboykov on 1/6/2017.
 */
'use strict';

function solve(args) {
    var n = +args[0];
    var onesBig = ['Zero', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine'];
    var onesSmall = ['', 'one', 'two', 'three', 'four', 'five', 'six', 'seven', 'eight', 'nine'];
    var onesHundrets = ['', 'One', 'Two', 'Three', 'Four', 'Five', 'Six', 'Seven', 'Eight', 'Nine'];
    var tensBig = ['', '', 'Twenty', 'Thirty', 'Forty', 'Fifty', 'Sixty', 'Seventy', 'Eighty', 'Ninety'];
    var tensSmall = ['', '', 'twenty', 'thirty', 'forty', 'fifty', 'sixty', 'seventy', 'eighty', 'ninety'];
    var teensBig = ['Ten', 'Eleven', 'Twelve', 'Thirteen', 'Fourteen', 'Fifteen', 'Sixteen', 'Seventeen', 'Eighteen', 'Nineteen'];
    var teensSmall = ['ten', 'eleven', 'twelve', 'thirteen', 'fourteen', 'fifteen', 'sixteen', 'seventeen', 'eighteen', 'nineteen'];

    //ones
    if (n <= 9) {
        for (let i = 0; i < onesBig.length; i += 1) {
            if (i === n)
                console.log(onesBig[i]);
        }
    } else if (n >= 10 && n <= 19) {
        for (let i = 10; i <= 19; i += 1) {
            if (i === n)
                console.log(teensBig[i - 10]);
        }
        //tens
    } else if (n >= 20 && n <= 99) {
        for (let i = 2; i < tensBig.length; i += 1) {
            if (i === (Math.trunc(n / 10)) % 10) {
                let tens = tensBig[i];
            }
        }
        for (let i = 0; i < onesSmall.length; i += 1) {
            if (i === (Math.trunc(n % 10))) {
                let ones = onesSmall[i];
            }
        }
        console.log(tens + ' ' + ones);
        //hundrets
    } else if (n >= 100 && n <= 999) {
        for (let i = 1; i < onesHundrets.length; i += 1) {
            if (i === (Math.trunc(n / 100)) % 10) {
                let hundrets = onesHundrets[i] + ' ' + 'hundred';
            }
        }
        for (let i = 0; i <= 9; i += 1) {
            if (i === (Math.trunc(n / 10)) % 10) {
                if (i === 0)
                    let tens = '';
                else if (i === 1)

                    let tens = '';
                else
                    let tens = ' and ' + tensSmall[i];
            }
        }
        if (((Math.trunc(n / 10)) % 10) === 0 && (Math.trunc(n % 10)) === 0) {
            let ones = '';
        } else if (((Math.trunc(n / 10)) % 10) === 1) {
            for (let i = 0; i <= 9; i += 1) {
                if (i === (Math.trunc(n % 10)))
                    let ones = 'and ' + teensSmall[i];
            }
        } else {
            for (let i = 0; i <= 9; i += 1) {
                if (i === (Math.trunc(n % 10)))
                    if (((Math.trunc(n / 10)) % 10) === 0) {
                        let ones = 'and ' + onesSmall[i];
                    } else {
                        let ones = onesSmall[i];
                    }
            }

        }
        console.log(hundrets + tens + ' ' + ones);
    }
}