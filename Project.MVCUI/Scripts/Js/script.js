latestChild = document.querySelectorAll('div.latest-widget > ul > li > a, div.categories-widget > ul > li > a, .post-title > a');

function mouseOver() {
    event.target.classList.add("link-hover");
}
function mouseOut() {
    event.target.classList.remove("link-hover");
}
for (i = 0; i < latestChild.length; i++) {
    latestChild[i].addEventListener("mouseover", mouseOver);
    latestChild[i].addEventListener("mouseout", mouseOut);
}


function isInViewport(el) {
    const rect = el.getBoundingClientRect();
    return (
        rect.top >= (window.innerHeight || document.documentElement.clientHeight) &&
        rect.left >= 0 
    );
}


const box = document.getElementById('myfooter');
const btn = document.getElementById('go-top');

document.addEventListener('scroll', function () {
    const bgColor = isInViewport(box) ?
        'hidden' :
        'visible';
    btn.style.visibility = bgColor;
}, {
    passive: true
});

/*
latestParent = document.querySelectorAll('div.latest-widget > ul > li ');
latestChild = document.querySelectorAll('div.latest-widget > ul > li > a');

categoryParent = document.querySelectorAll('div.categories-widget > ul > li ');
categoryChild = document.querySelectorAll('div.categories-widget > ul > li > a');

function mouseOver() {
    event.target.classList.add("link-hover");
}
function mouseOut() {
    event.target.classList.remove("link-hover");
}


for (i = 0; i < latestParent.length + categoryParent.length; i++) {
    latestChild[i].addEventListener("mouseover", mouseOver);
    latestChild[i].addEventListener("mouseout", mouseOut);

    categoryChild[i].addEventListener("mouseover", mouseOver);
    categoryChild[i].addEventListener("mouseout", mouseOut);

    if (i != latestParent.length - 1 && i != categoryParent.length - 1) {
        latestParent[i].style.borderBottom = "1px solid #e6e6e6";
        categoryParent[i].style.borderBottom = "1px solid #e6e6e6";
    }

}
*/