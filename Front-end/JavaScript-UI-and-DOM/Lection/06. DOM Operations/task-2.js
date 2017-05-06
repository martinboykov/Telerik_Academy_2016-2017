/**
 * Created by martinboykov on 12.3.2017 г..
 */
let imgEl = document.createElement('img');
imgEl.src = '../01. Document Object Model/maxresdefault.jpg';
imgEl.style.width = '500px';
imgEl.className = 'img';
let el = document.getElementById('div3');
let t = 1000;
el.insertBefore(imgEl, el.children[1]);
/*setTimeout(()=>el.removeChild(el.children[1]),t);
setTimeout(()=>el.removeChild(el.children[2]),2*t);
setTimeout(()=>el.removeChild(el.children[1]),3*t);
setTimeout(()=>el.removeChild(el.children[0]),4*t);
for(let i = 0; i<3; i+=1){
    let newP = document.createElement('p');
    newP.innerText = 'Some text' + (i+1);
    setTimeout(()=>el.appendChild(newP),(5*t+(i*t)));
}

setTimeout(()=>el.insertBefore(imgEl, el.children[1]),8*t);*/
el.removeChild(el.children[1]);
el.removeChild(el.children[2]);
el.removeChild(el.children[1]);
el.removeChild(el.children[0]);
for(let i = 0; i<3; i+=1){
    let newP = document.createElement('p');
    newP.innerText = 'Some text' + (i+1);
    el.appendChild(newP);
}

el.insertBefore(imgEl, el.children[1]);
document.getElementsByTagName('p')[0].style.fontSize = '30px';
document.getElementsByTagName('p')[0].style.color = 'red';
document.getElementsByTagName('p')[0].style.borderColor = 'red';
document.getElementsByTagName('p')[0].style.borderSize = '1px';
document.getElementsByTagName('p')[0].style.borderStyle = 'solid';