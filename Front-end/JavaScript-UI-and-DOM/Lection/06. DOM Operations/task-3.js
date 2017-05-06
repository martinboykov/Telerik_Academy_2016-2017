/**
 * Created by martinboykov on 12.3.2017 г..
 */
let dateStart = new Date();
let ul =  document.createElement('ul');
for (let i =0 ; i<50000; i+=1){
    let li = document.createElement('li');
    li.innerHTML='Some text '+(i+1);
    ul.appendChild(li);
}
document.getElementById('div3').appendChild(ul);
let dateEnd = new Date();
let time = dateEnd - dateStart;
console.log('Only createElement = ' + time);


/*let dateStart = new Date();
let ul =  document.createElement('ul');
let li = document.createElement('li');
for (let i =0 ; i<50000; i+=1){
    li = li.cloneNode(true);
    li.innerHTML='Some text '+(i+1);
    ul.appendChild(li);
}
document.getElementById('div3').appendChild(ul);
let dateEnd = new Date();
let time = dateEnd - dateStart;
console.log('cloneNode = ' + time);*/



/*let dateStart = new Date();

let ul =  document.createDocumentFragment();
for (let i =0 ; i<50000; i+=1){
    let li = document.createElement('li');
    li.innerHTML='Some text '+(i+1);
    ul.appendChild(li);
}
document.getElementById('div3').appendChild(ul);
let dateEnd = new Date();
let time = dateEnd - dateStart;
console.log('createDocumentFragment = ' + time);*/

/*let dateStart = new Date();

let ul =  document.createDocumentFragment();
let li = document.createElement('li');
for (let i =0 ; i<50000; i+=1){
    let newLi = li.cloneNode(true);
    newLi.innerHTML='Some text '+(i+1);
    ul.appendChild(newLi);
}
document.getElementById('div3').appendChild(ul);
let dateEnd = new Date();
let time = dateEnd - dateStart;
console.log('createDocumentFragment, ' + 'cloneNode = ' + time);*/
