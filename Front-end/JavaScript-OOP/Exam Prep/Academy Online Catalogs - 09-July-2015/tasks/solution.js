function solve() {
    "use strict";
    function createCounter() {
        let counterID = 0;
        return function () {
            counterID += 1;
            return counterID;
        }
    };
    let counterID = createCounter();

    function createCounterCatalog() {
        let counterCatalogID = 0;
        return function () {
            counterCatalogID += 1;
            return counterCatalogID;
        }
    };
    let counterCatalogID = createCounterCatalog();

    const validator = {
        validItemDescription: function (x) {
            if (typeof x !== "string" || x.length === 0) {
                throw new Error("Item Description A non-empty string");
            }
        },
        validItemName: function (x) {
            if (typeof x !== "string" || x.length < 2 || x.length > 40) {
                throw new Error("Item Name A string with length between 2 and 40 characters, inclusive");
            }
        },
        validBookIsbn: function (x) {
            if ((/[^0-9]/).test(x)) {
                throw new Error("Book - isbn can contain only digits");
            }
            if (x.length !== 10 && x.length !== 13) {
                throw new Error("Book - isbn is a string with length exactly 10 or 13");
            }
        },
        validBookGenre: function (x) {
            if (typeof x !== "string" || x.length < 2 || x.length > 20) {
                throw new Error("Book - Genre is a string with length between 2 and 20 characters, inclusive");
            }
        },
        validMediaRating: function (x) {
            if (typeof x !== "number" || x < 1 || x > 5) {
                throw new Error("Media - rating is a number between 1 and 5, inclusive");
            }
        },
        validMediaDuration: function (x) {
            if (typeof x !== "number" || x <= 0) {
                throw new Error("Media - Duration a number greater than 0");
            }
        },
        validCatalogName: function (x) {
            if (typeof x !== "string" || x.length < 2 || x.length > 40) {
                throw new Error("Catalog - Name is a string with length between 2 and 40 characters, inclusive");
            }
        },
        validAddedItemsCount: function (args) {
            if (!args) {
                throw new Error("Catalog - AddedItems(Count) No items are passed");
            }
            let container = [];

            for (let arg of args) {
                if (arg instanceof Item) {
                    container.push(arg);
                } else {
                    throw new Error("Catalog - AddedItems(Count) is not an Instance");
                }
            }
            return container;
        },
        validAddedItemsArray: function (x) {
            if (!Array.isArray(x)) {
                throw new Error("Catalog - AddedItems(Array) is Array");
            }
            if (x.length === 0) {
                throw new Error("Catalog - AddedItems(Array) can be one or more");
            }
            for (let y of x) {//item of newItemsArray
                if (!(y instanceof Item)) {
                    throw new Error("Catalog - AddedItems(Array) Any of the items is not an Item instance or not an Item-like object")
                }
            }
            return x;
        },
        validCatalogFindID: function (x) {
            if (!x || typeof x !== "number") {
                throw new Error("Catalog - Find ID no arguments are passed");
            }
        },
        validCatalogPattern: function (x) {
            if (!x || typeof x !== "string") {
                throw new Error("Catalog - Search Pattern is a string containing at least 1 character");
            }
        },
        validMediaCatalogGetTop: function (x) {
            if (typeof x !== "number" || x < 1) {
                throw new Error("MediaCatalog - GetTop Count is not a number Count is less than 1");
            }
        },
    };

    class Item {
        constructor(description, name) {
            this._id = counterID();
            this.description = description;
            this.name = name;
        }

        get id() {
            return this._id;
        }

        get description() {
            return this._description;
        }

        set description(x) {
            validator.validItemDescription(x);
            this._description = x;
        }

        get name() {
            return this._name;
        }

        set name(x) {
            validator.validItemName(x);
            this._name = x;
        }
    }
    class Book extends Item {
        constructor(name, isbn, genre, description) {
            super(description, name);
            this.isbn = isbn;
            this.genre = genre;
        }

        get isbn() {
            return this._isbn;
        }

        set isbn(x) {
            validator.validBookIsbn(x);
            this._isbn = x;
        }

        get genre() {
            return this._genre;
        }

        set genre(x) {
            validator.validBookGenre(x);
            this._genre = x;
        }


    }
    class Media extends Item {
        constructor(name, rating, duration, description) {
            super(description, name);
            this.rating = rating;
            this.duration = duration;
        }

        get rating() {
            return this._rating;
        }

        set rating(x) {
            validator.validMediaRating(x);
            this._rating = x;
        }

        get duration() {
            return this._duration;
        }

        set duration(x) {
            validator.validMediaDuration(x);
            this._duration = x;
        }
    }
    class Catalog {
        constructor(name, items) {
            this._id = counterCatalogID();
            this.name = name;
            this._items = [];
        }

        get id() {
            return this._id;
        }

        get name() {
            return this._name;
        }

        set name(x) {
            validator.validCatalogName(x);
            this._name = x;
        }

        get items() {
            return this._items;
        }

        /*set items(x) {
            let args = [...arguments];
            if (!x || args.length === 0) {
                this._items = [];
            }
            else if (args.length === 1 && Array.isArray(args[0])) {
                validator.validAddedItemsArray(args[0]);
                this._items = args[0];
            } else if (args.length !== 0) {
                let container = validator.validAddedItemsCount(args);
                this._items = container;
            }
            else {
                this._items = [];
            }
        }*/

        add(...items) {

            if (items.length === 0) {
                throw new Error("Catalog - AddedItems No items are passed");
            }
            if (items.length === 1 && Array.isArray(items[0])) {
                let container = validator.validAddedItemsArray(items[0]);
                for (let c of container) {
                    this._items.push(c);
                }

            } else if (items.length !== 0) {
                let container = validator.validAddedItemsCount(items);
                this._items.push(...items);
            }
            return this;
            /*let args = [...arguments];
             if (args.length === 0) {
             return this;
             }
             validator.validAddedItemsCount(args);

             this._items.push(container);*/

        }

        find(id) {
            //TODO: find(options)

            validator.validCatalogFindID(id);
            let result = this._items.filter(function (obj) {
                return obj.id === id;
            });
            if (result.length === 0) {
                return null;
            }
            return result.shift();
        }

        search(pattern) {
            validator.validCatalogPattern(pattern);
            let conteiner = [];
            for (let item of this._items) {
                if (item.name.search(pattern) > -1) {
                    conteiner.push(item);
                } else if (item.description.search(pattern) > -1) {
                    conteiner.push(item);
                }
            }
            return conteiner;
        }
    }


    class BookCatalog extends Catalog {
        constructor(name, items) {
            super(name, items)
            this._id = counterCatalogID();
        }

        get id() {
            return this._id;
        }

        getGenres() {
            let conteiner = [];

            for (let item of this._items) {
                if (!conteiner.some(p => p === item.genre)) {
                    conteiner.push(item.genre)
                }
            }
            for (let i = 0; i < conteiner.length; i += 1) {
                conteiner[i] = conteiner[i].toLowerCase()
            }
            return conteiner;
        }
    }

    class MediaCatalog extends Catalog {
        constructor(name, items) {
            super(name, items);
            this._id = counterCatalogID();
        }

        get id() {
            //TODO: Look at it later
            return this._id;
        }

        getTop(count) {
            validator.validMediaCatalogGetTop(count);

            return this._items
                .slice()
                .sort((x, y) => y.rating - x.rating)
                .slice(0, count)
                .map(x => {
                    return {
                        name: x.name,
                        id: x.id
                    };
                });
        }

        getSortedByDuration() {
            return this._items.filter(function (p) {
                return p instanceof Media;
            }).sort(function (x, y) {
                if (x.duration === y.duration) {
                    return x.id - y.id;
                }
                return y.duration - x.duration;
            });
        }
    }

    return {

        getBook: function (name, isbn, genre, description) {
            return new Book(name, isbn, genre, description);
        },
        getMedia: function (name, rating, duration, description) {
            return new Media(name, rating, duration, description);
        },
        /*getCatalog: function (name, items) {
         return new Catalog(name, items)
         },*/
        getBookCatalog: function (name) {
            return new BookCatalog(name)
        },
        getMediaCatalog: function (name) {
            return new MediaCatalog(name)
        }
    };
}

module.exports = solve;
let academyOnlineCatalogs = solve();
let newItemOne = academyOnlineCatalogs.getMedia("Name1", 1, 5, "Desc");
let newItemTwo = academyOnlineCatalogs.getMedia("Name2", 4, 11, "Descr");
let newItemThree = academyOnlineCatalogs.getMedia("Name3", 3, 2, "Descr");
let newCatalog = academyOnlineCatalogs.getMediaCatalog("Catalog One");
newCatalog.add([newItemOne, newItemTwo, newItemThree]);
/*console.log("---items---");
 console.log(newCatalog.items);
 console.log("---find---");
 console.log(newCatalog.find(1));
 console.log("---search---");
 console.log(newCatalog.search("Descr"));*/
console.log("---getTop---");
console.log(newCatalog.getTop(2));
/*console.log("---getSortedByDuration---")
 console.log(newCatalog.getSortedByDuration());*/

/*console.log("---getGenres---");
 console.log(newCatalog.getGenres());*/
/*newCatalog.add();
 newCatalog.showItemBase();*/

