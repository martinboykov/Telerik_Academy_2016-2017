function solve() {

    var library = (function () {
        var books = [];
        var categories = [];


        function addBook(book) {
            if (book.title.length < 2 || book.title.length > 100) {
                throw "Book title and category name must be between 2 and 100";
            }
            if (book.category.length < 2 || book.category.length > 100) {
                throw "Book title and category name must be between 2 and 100";
            }

            if (book.author.length = 0 || typeof book.author !== 'string') {
                throw "Author is any non-empty string";
            }
            if (book.isbn.length !== 10 && book.isbn.length !== 13) {
                throw "Book ISBN is an unique code that contains either 10 or 13 digits";
            }
            if (CheckIfUniqueTitle(book.title)) {
                throw "Unique params are Book title and Book ISBN";
            }
            if (CheckIfUniqueISBN(book.isbn)) {
                throw "Unique params are Book title and Book ISBN";
            }

            function CheckIfUniqueTitle(title) {
                "use strict";
                let check = false;
                for (let book of books) {
                    if (book.title === title) {
                        check = true;
                    }
                }
                return check;
            }

            function CheckIfUniqueISBN(ISBN) {
                "use strict";
                let check = false;
                for (let book of books) {
                    if (book.isbn === ISBN) {
                        check = true;
                    }
                }
                return check;
            }


            book.ID = books.length + 1;
            books.push(book);

            var newCategory = {
                category: book.category,
                ID: categories.length + 2
            };
            if (!categories.some(function (categoryX) {
                    return categoryX.category === newCategory.category; //returns true/false
                })) {//if its false --> push
                categories.push(newCategory);
            }
            return book;
        }

        function listCategories() {
            categories.sort(function (a, b) {
                return a.ID - b.ID;
            });

            return categories.map(function (element) {
                return element.category;
            })
        }

        function listBooks(args) {

            if (books.length === 0) {
                return [];
            }
            if (args) {
                filtred = books.filter(function (book) {
                    return book.category === args.category;//extract all book with that category
                });
            }
            if (!args) {
                filtred = books;
            }
            return filtred.sort(function (a, b) {
                return a.ID - b.ID;
            })

        }


        return {
            books: {
                list: listBooks,
                add: addBook
            },
            categories: {
                list: listCategories
            }
        };
    }());
    return library;
}
module.exports = solve;

