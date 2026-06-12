/* Configurações Gerais */
* {
    margin: 0;
    padding: 0;
    box-sizing: border-box;
    font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;
    scroll-behavior: smooth;
}

body {
    background-color: #f4f9f4;
    color: #333;
}

.interface {
    max-width: 1200px;
    margin: 0 auto;
    padding: 0 4%;
}

/* Cabeçalho */
header {
    background-color: #ffffff;
    padding: 20px 0;
    position: fixed;
    width: 100%;
    top: 0;
    left: 0;
    box-shadow: 0 2px 10px rgba(0, 0, 0, 0.1);
    z-index: 1000;
}

header .interface {
    display: flex;
    justify-content: space-between;
    align-items: center;
}

.logo h1 {
    color: #2e7d32;
    font-size: 24px;
}

.logo span {
    color: #81c784;
}

nav ul {
    display: flex;
    list-style: none;
}

nav ul li a {
    color: #555;
    text-decoration: none;
    margin-left: 20px;
    font-weight: 600;
    transition: 0.3s;
}

nav ul li a:hover {
    color: #2e7d32;
}

/* Banner Principal */
.banner {
    background: linear-gradient(rgba(0,0,0,0.5), rgba(0,0,0,0.5)), url('https://images.unsplash.com/photo-1500937386664-56d1dfef3854?auto=format&fit=crop&w=1920&q=80') no-repeat center center/cover;
    height: 100vh;
    display: flex;
    align-items: center;
    color: #fff;
    margin-top: 60px;
}

.texto-banner h2 {
    font-size: 48px;
    margin-bottom: 20px;
}

.texto-banner p {
    font-size: 20px;
    margin-bottom: 30px;
    max-width: 600px;
}

.btn {
    background-color: #2e7d32;
    color: #fff;
    padding: 12px 30px;
    text-decoration: none;
    border-radius: 30px;
    font-weight: bold;
    transition: 0.3s;
}

.btn:hover {
    background-color: #1b5e20;
}

/* Seção Sobre */
.sobre {
    padding: 80px 0;
    text-align: center;
    background-color: #ffffff;
}

.sobre h2 {
    color: #2e7d32;
    font-size: 32px;
    margin-bottom: 20px;
}

.sobre p {
    font-size: 18px;
    max-width: 800px;
    margin: 0 auto;
    line-height: 1.6;
    color: #666;
}

/* Seção Pilares (Cards) */
.pilares {
    padding: 80px 0;
    text-align: center;
}

.pilares h2 {
    color: #2e7d32;
    font-size: 32px;
    margin-bottom: 40px;
}

.container-cards {
    display: flex;
    justify-content: space-between;
    gap: 20px;
    flex-wrap: wrap;
}

.card {
    background-color: #fff;
    padding: 40px 20px;
    border-radius: 10px;
    flex: 1;
    min-width: 250px;
    box-shadow: 0 4px 15px rgba(0,0,0,0.05);
    border-top: 5px solid #2e7d32;
    transition: 0.3s;
}

.card:hover {
    transform: translateY(-5px);
}

.card h3 {
    color: #333;
    margin-bottom: 15px;
    font-size: 22px;
}

.card p {
    color: #666;
    line-height: 1.5;
}

/* Seção Tecnologia */
.tecnologia {
    background: linear-gradient(rgba(46, 125, 50, 0.9), rgba(46, 125, 50, 0.9)), url('https://images.unsplash.com/photo-1592982537447-6f2a6a0c7c18?auto=format&fit=crop&w=1200&q=80') no-repeat center center/cover;
    padding: 100px 0;
    color: #fff;
    text-align: center;
}

.conteudo-tech h2 {
    font-size: 32px;
    margin-bottom: 20px;
}

.conteudo-tech p {
    font-size: 18px;
    max-width: 800px;
    margin: 0 auto;
    line-height: 1.6;
}

/* Rodapé */
footer {
    background-color: #1b5e20;
    color: #fff;
    padding: 30px 0;
    text-align: center;
    font-size: 14px;
}

/* Responsividade (Para funcionar no celular) */
@media (max-width: 768px) {
    header .interface {
        flex-direction: column;
    }
    
    nav ul {
        margin-top: 15px;
    }

    .texto-banner h2 {
        font-size: 32px;
    }

    .container-cards {
        flex-direction: column;
    }
}
