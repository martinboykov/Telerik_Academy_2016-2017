class Product {
    constructor(productType, name, price) {
        this._productType = productType;
        this._name = name;
        this._price = price;
    }


    get productType() {
        return this._productType;
    }

    set productType(x) {

        this._productType = x;
    }

    get name() {
        return this._name;
    }

    set name(x) {

        this._name = x;
    }

    get price() {
        return this._price;
    }

    set price(x) {

        this._price = x;
    }
}


var productOne = new Product('Dress', 'Womans dress', 125.25);
console.log(productOne);