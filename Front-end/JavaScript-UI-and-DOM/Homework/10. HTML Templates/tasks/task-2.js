/* globals $ */

function solve() {
  
  return function (selector) {
    var template = `
 <div class="container">
 <h1>Animals</h1>
 <ul class="animals-list">  
 {{#each animals}}
 {{#if this.url}}

 <li>
 <a href={{this.url}}>See a {{this.name}}</a>                
 </li>        
 {{else}}
 <li>
 <a href="http://cdn.playbuzz.com/cdn/3170bee8-985c-47bc-bbb5-2bcb41e85fe9/d8aa4750-deef-44ac-83a1-f2b5e6ee029a.jpg">No link for {{this.name}}, here is Batman!</a>                
 </li>
 {{/if}}
 {{/each}}
 </ul>
 </div>`;

    $(selector).html(template);
  };
};

module.exports = solve;

/*

 var HbTemplate = `
<div class="container">
  <h1>Animals</h1>
  <ul class="animals-list">  
             {{#each animals}}
             {{#if this.url}}
             
    <li>
      <a href={{this.url}}>See a {{this.name}}</a>                
    </li>        
            {{else}}
    <li>
      <a href="http://cdn.playbuzz.com/cdn/3170bee8-985c-47bc-bbb5-2bcb41e85fe9/d8aa4750-deef-44ac-83a1-f2b5e6ee029a.jpg">No link for {{this.name}}, here is Batman!</a>                
    </li>
    {{/if}}
                {{/each}}
  </ul>
</div>`;

var data = {
    animals: [{
        name: 'Lion',
        url: 'http://www.crystal-life.com/blog/wp-content/uploads/2016/09/lion.jpg'
    }, {
        name: 'Turtle',
        url: 'http://www.enkivillage.com/s/upload/images/a231e4349b9e3f28c740d802d4565eaf.jpg'
    }, {
        name: 'Dog'
    }, {
        name: 'Cat',
        url: 'http://i.imgur.com/Ruuef.jpg'
    }, {
        name: 'Dog Again'
    }]
};


 var container = document.getElementById('hb-container');
 var template = Handlebars.compile(HbTemplate);
 container.innerHTML = template(data);
*/


