document.addEventListener("DOMContentLoaded", () => {
    
    // 1. Efeito no Cabeçalho ao rolar a página
    const header = document.querySelector("header");
    
    window.addEventListener("scroll", () => {
        if (window.scrollY > 50) {
            header.style.padding = "10px 0";
            header.style.backgroundColor = "rgba(255, 255, 255, 0.95)";
            header.style.boxShadow = "0 4px 20px rgba(0, 0, 0, 0.15)";
        } else {
            header.style.padding = "20px 0";
            header.style.backgroundColor = "#ffffff";
            header.style.boxShadow = "0 2px 10px rgba(0, 0, 0, 0.1)";
        }
    });

    // 2. Efeito de surgimento (Fade-in) dos elementos ao rolar a tela
    const elementosAnimar = document.querySelectorAll(".card, .sobre, .conteudo-tech");

    // Configura o estilo inicial dos elementos para a animação
    elementosAnimar.forEach(el => {
        el.style.opacity = "0";
        el.style.transform = "translateY(30px)";
        el.style.transition = "opacity 0.8s ease-out, transform 0.8s ease-out";
    });

    const checarScroll = () => {
        const gatilhoAtivacao = window.innerHeight * 0.85;

        elementosAnimar.forEach(el => {
            const topoElemento = el.getBoundingClientRect().top;

            if (topoElemento < gatilhoAtivacao) {
                el.style.opacity = "1";
                el.style.transform = "translateY(0)";
            }
        });
    };

    // Executa uma vez ao carregar e depois a cada scroll
    checarScroll();
    window.addEventListener("scroll", checarScroll);
});
