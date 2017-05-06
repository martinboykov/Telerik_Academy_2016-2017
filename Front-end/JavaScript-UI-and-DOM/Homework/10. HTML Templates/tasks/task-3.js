function solve() {
    return function () {
        $.fn.listview = function (data) {
            var dataTemplateId = "#" + $(this).attr('data-template');

            var Hbtemplate = $(dataTemplateId).html();

            var template = handlebars.compile(Hbtemplate);

            var current = "";

            for (var i = 0, len = data.length; i < len; i += 1) {
                current = template(data[i]);
                $(this).append(current);
            }
            return this;
        };
    };
}
module.exports = solve;

/*
 var books = [
 {
 id: 1,
 title: 'JavaScript: The Good Parts'
 },
 {
 id: 2,
 title: 'Secrets of the JavaScript Ninja'
 },
 {
 id: 3,
 title: 'Core HTML5 Canvas'
 },
 {
 id: 4,
 title: 'JavaScript Patterns'
 },
 ];


 $.fn.listview = function (data) {
 var dataTemplateId = "#" + $(this).attr('data-template');

 var Hbtemplate = $(dataTemplateId).html();

 var template = Handlebars.compile(Hbtemplate);

 var current = "";

 for (var i = 0, len = data.length; i < len; i += 1) {
 current = template(data[i]);
 $(this).append(current);
 }
 return this;
 };

 $('#books-list').listview(books);
 console.log(books.length);*/
