/* globals module */

"use strict";

function solve() {
    const VALIDATOR = {
        IS_VALID_STRING: function(x) {
            if ((x === undefined) || (x === NaN) || (typeof x !== 'string')) {
                throw Error('invalid string');
            }
        },
        IS_VALID_NUMBER: function(x) {
            if ((x === undefined) || (x === NaN) || (typeof x !== 'number')) {
                throw Error('invalid number');
            }
        },
        IS_VALID_PRODUCT: function(product) {
            if (typeof product != 'object') {
                throw Error('invalid product');
            }
        }
    };
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
            VALIDATOR.IS_VALID_STRING(x);
            this._productType = x;
        }
        get name() {
            return this._name;
        }
        set name(x) {
            VALIDATOR.IS_VALID_STRING(x);
            this._name = x;
        }
        get price() {

            return this._price;
        }
        set price(x) {
            VALIDATOR.IS_VALID_NUMBER(x);
            this._price = x;
        }
    }


    class ShoppingCart {
        constructor() {
            this._products = [];
        }

        get products() {
            return this._products;
        }

        add(product) {
            VALIDATOR.IS_VALID_PRODUCT(product);
            if (!(Object.keys(product).every(key => product[key] != undefined))) {
                throw Error('invalid');
            }
            this.products.push(product);
            return this; //provides chaining
        }

        remove(product) {
            const index = this.products.findIndex(p => p.name === product.name && p.productType === product.productType && p.price === product.price);
            if (index < 0) {
                throw 'Product not found';
            }
            this.products.splice(index, 1);
            return this;
        }

        showCost() {
            /*let cost = 0;
             for (const product of this.products) {
             cost +=product.price;
             }
             return cost;*/
            return this.products.reduce((cost, product) => cost + product.price, 0);
        }

        showProductTypes() {

            //Variant 1
            /*const uniqueTypes = [];
             for (const product of this.products){
             if (uniqueTypes.indexOf(product.productType) < 0) {
             uniqueTypes.push(product.productType)
             }
             }
             return uniqueTypes.sort();*/

            //Variant 2
            /*const uniqueTypes = [];
             function extractUniqueTypes(product) {
             if (uniqueTypes.indexOf(product.productType) < 0) {
             uniqueTypes.push(product.productType)
             }
             }
             this.products.forEach(extractUniqueTypes);
             return uniqueTypes.sort();*/

            //Variant 3
            /*return this.products
             .map(p => p.productType)
             .sort()
             .filter((p, i, ps)=> i===0 || p !== ps[i - 1]); //(this.products,index,allproducts) */

            //Variant 4.1
            let uniqueTypesObj = {};
            this.products.forEach(p => uniqueTypesObj[p.productType] = true);
            return Object.keys(uniqueTypesObj).sort();

            //Variant 4.2
            /*const uniqueTypes = [];
             for (const type in uniqueTypesObj) {
             uniqueTypes.push(type);
             }
             return uniqueTypes.sort();*/


        }

        getInfo() {
            //Variant 1
            /*const uniqueNames = this.products
             .map(p => p.name)
             .sort()
             .filter((p, i, ps) => i===0 || p !== ps[i - 1])
             .map(name => {
             const withThisName = this.products.filter(p => p.name === name);

             return {
             name:name,
             quantity: withThisName.length,
             totalPrice:withThisName.reduce((cost, product) => cost + product.price, 0)
             }
             });

             return {
             this.products: [uniqueNames], //groups products by their name
             totalPrice:showCost()
             }*/

            //Variant 2
            const groupedByName = {};
            this.products.forEach(p => {//p=product
                if (groupedByName.hasOwnProperty(p.name)) {
                    groupedByName[p.name].quantity += 1;
                    groupedByName[p.name].totalPrice += p.price;

                }
                else {//because it doesn't exist we must create it
                    groupedByName[p.name] = {
                        name: p.name,
                        quantity: 1,
                        totalPrice: p.price
                    };
                }
            });

            const groups = Object.keys(groupedByName)
                .sort()
                .map(n=> {
                    return {
                        name: n,
                        quantity: groupedByName[n].quantity,
                        totalPrice: groupedByName[n].totalPrice
                    }
                });
            return {
                /*this.products: [uniqueNames], //groups products by their name*/
                products: groups,
                totalPrice: this.showCost()
            }
        }
    }
    return {
        Product, 
        ShoppingCart
    };
}


module.exports = solve;
let {Product, ShoppingCart} = solve();

let cart = new ShoppingCart();

let pr1 = new Product("Sweets", "Shokolad Milka", 2);
cart.add(pr1);
console.log(cart.showCost());
//prints `2`

let pr2 = new Product("Groceries", "Salad", 0.5);
cart.add(pr2);
cart.add(pr2);
console.log(cart.showCost());
//prints `3`

console.log(cart.showProductTypes());
//prints ["Sweets", "Groceries"]

console.log(cart.getInfo());
/* prints
 {
 totalPrice: 3
 products: [{
 name: "Salad",
 totalPrice: 1,
 quantity: 2
 }, {
 name: "Shokolad Milka",
 totalPrice: 2,
 quantity: 1
 }]
 }
 */

/*cart.remove({name:"salad", productType: "Groceries", price: 0.5})*/
//throws: "salad" is not equal to "Salad"

cart.remove({name:"Salad", productType: "Groceries", price: 0.5})
console.log(cart.getInfo());
/* prints
 {
 totalPrice: 2.5
 products: [{
 name: "Salad",
 totalPrice: 0.5,
 quantity: 1
 }, {
 name: "Shokolad Milka",
 totalPrice: 2,
 quantity: 1
 }]
 }
 */
