function solve() {
    function getProduct(productType, name, price) {

        return {
            productType: productType,
            name: name,
            price: price
        }
    }

    function getShoppingCart() {

        const products = [];

        function add(product) {
            //TODO: validations!!!if necessary!!!
            products.push(product);
            return this; //provides chaining
        }

        function remove(product) {
            const index = products.findIndex(p => p.name === product.name && p.productType === product.productType && p.price === product.price);
            if (index < 0) {
                throw 'Product not found';
            }
            products.splice(index, 1);
            return this;
        }

        function showCost() {
            return products.reduce((cost, product) => cost + product.price, 0);
        }

        function showProductTypes() {
            const uniqueTypesObj = {};
            products.forEach(product => uniqueTypesObj[product.productType] = true);
            return Object.keys(uniqueTypesObj).sort();
        }

        function getInfo() {
            const groupedByName = {};
            products.forEach(p => {//p=product
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
                products: groups,
                totalPrice: showCost()
            }
        }

        return {

            products: products,
            add: add,
            remove: remove,
            showCost: showCost,
            showProductTypes: showProductTypes,
            getInfo: getInfo
        }

    }

    return {
        getProduct: getProduct,
        getShoppingCart: getShoppingCart
    };
}

module.exports = solve();
const {getProduct, getShoppingCart} = solve();

let cart = getShoppingCart();

let pr1 = getProduct("Sweets", "Shokolad Milka", 2);
cart.add(pr1);
console.log(cart.showCost());
// prints `2`

let pr2 = getProduct("Groceries", "Salad", 0.5);
cart.add(pr2);
cart.add(pr2);
console.log(cart.showCost());
// prints `3`

console.log(cart.showProductTypes());
// prints [ 'Groceries', 'Sweets' ]

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

//cart.remove({name:"salad", productType: "Groceries", price: 0.5})
// throws: "salad" is not equal to "Salad"

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