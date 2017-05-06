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
            /*let cost = 0;
             for (const product of products) {
             cost +=product.price;
             }
             return cost;*/
            return products.reduce((cost, product) => cost + product.price, 0);
        }

        function showProductTypes() {

            //Variant 1
            /*const uniqueTypes = [];
             for (const product of products){
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
             products.forEach(extractUniqueTypes);
             return uniqueTypes.sort();*/

            //Variant 3
            /*return products
             .map(p => p.productType)
             .sort()
             .filter((p, i, ps)=> i===0 || p !== ps[i - 1]); //(products,index,allproducts) */

            //Variant 4.1
            const uniqueTypesObj = {};
            products.forEach(product => uniqueTypesObj[product.productType] = true);
            return Object.keys(uniqueTypesObj).sort();

            //Variant 4.2
            /*const uniqueTypes = [];
             for (const type in uniqueTypesObj) {
             uniqueTypes.push(type);
             }
             return uniqueTypes.sort();*/


        }

        function getInfo() {
            //Variant 1
            /*const uniqueNames = products
             .map(p => p.name)
             .sort()
             .filter((p, i, ps) => i===0 || p !== ps[i - 1])
             .map(name => {
             const withThisName = products.filter(p => p.name === name);

             return {
             name:name,
             quantity: withThisName.length,
             totalPrice:withThisName.reduce((cost, product) => cost + product.price, 0)
             }
             });

             return {
             products: [uniqueNames], //groups products by their name
             totalPrice:showCost()
             }*/

            //Variant 2
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
                /*products: [uniqueNames], //groups products by their name*/
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
const result = solve();
const cart = result.getShoppingCart();
cart.add(result.getProduct("Sweets", "Shokolad Milka", 2))
    .add(result.getProduct("Sauer", "Salad", 12))
    .add(result.getProduct("SauerSweet", "Salad", 1))
    .add(result.getProduct("Juice", "Hot Beverage", 4));

/*console.log(cart.products);
 cart.remove(result.getProduct("Sweets", "Shokolad Milka", 2));
 cart.remove(result.getProduct("Sweets", "Coco", 1));
 console.log(cart.products);
 console.log(cart.showCost());*/
console.log(cart.showProductTypes());