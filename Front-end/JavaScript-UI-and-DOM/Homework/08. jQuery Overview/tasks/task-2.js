/* globals $ */

/*
Create a function that takes a selector and:
* Finds all elements with class `button` or `content` within the provided element
  * Change the content of all `.button` elements with "hide"
* When a `.button` is clicked:
  * Find the topmost `.content` element, that is before another `.button` and:
    * If the `.content` is visible:
      * Hide the `.content`
      * Change the content of the `.button` to "show"
    * If the `.content` is hidden:
      * Show the `.content`
      * Change the content of the `.button` to "hide"
    * If there isn't a `.content` element **after the clicked `.button`** and **before other `.button`**, do nothing
* Throws if:
  * The provided ID is not a **jQuery object** or a `string`

*/
function solve() {
  return function (selector) {
    $(selector).find('.button', '.content');
    $(selector).find('.button').text('hide');
      if (!selector) {
          throw new Error;
      }
      if (!$(selector).length) {
          throw new Error;
      }
      $(".button").on("click", function () {
          var $this = $(this);
          var $node = $this.next();
          while ($node.length){
              if ($node.hasClass("hidden")) {
                  $node.removeClass("hidden")
              }else{
                  $node.addClass("hidden")
              }
              $node = $node.next();
          }

      });
  };
};

module.exports = solve;