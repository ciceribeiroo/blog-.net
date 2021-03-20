$(window).scroll(function () {
    if ($(window).scrollTop() >= 150) {
        $('nav').css('background','white');
    } else {
    $('nav').css('background','transparent');
    }
});

const navSlide = () => {
    const burguer = document.querySelector('.burguer');
    const nav = document.querySelector('.nav-links');
    const navLinks = document.querySelectorAll('.nav-links li');

    burguer.addEventListener('click', ()=>{
        nav.classList.toggle('nav-active');
        navLinks.forEach((link, index)=>{
            if(link.style.animation){
                link.style.animation = '';
            }else{
                link.style.animation = `navLinkFade 0.5s ease forwards ${index/8+ 0.5}s`;
            }
        });
        burguer.classList.toggle('toggle');
    });
}

navSlide();
