function traverseElement(el, indent) {
    console.log(indent + '<' + el.tagName.toLowerCase() + '>');
    var children = [].slice.apply(el.children);
    children.forEach(child => traverseElement(child, indent + '  '));
    console.log(indent + '</' + el.tagName.toLowerCase() + '>');
}
//traverseElement(document.body, "");

function traverseBody() {

    var el = document.body;
    var indent = "";

    while (el !== null) {

        console.log(indent + '<' + el.tagName.toLowerCase() + '>');

        if (el.firstElementChild !== null) {
            indent += "  ";
            el = el.firstElementChild;
        }
        else {
            while (el.nextElementSibling === null) {
                console.log(indent + '</' + el.tagName.toLowerCase() + '>');
                indent = indent.substr(2);
                el = el.parentElement;
                if (el === document.body) {
                    console.log(indent + '</' + el.tagName.toLowerCase() + '>');
                    break;
                }
            }
            el = el.nextElementSibling;

        }
    }
}

traverseBody();

function traverseQueryBody() {
    var el = document.body.querySelectorAll('*');
    console.log(el);
    [].slice.call(el);
    el.forEach(x =>
        console.log(x.tagName.toLowerCase()));

}
//traverseQueryBody ();