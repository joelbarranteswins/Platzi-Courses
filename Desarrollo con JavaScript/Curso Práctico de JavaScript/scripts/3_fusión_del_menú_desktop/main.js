const $ = (selector) => document.querySelector(selector);

const menuEmail = $('.navbar-email');
const desktopMenu = $('.desktop-menu');
const menuBurger = $('.menu')
const menuCart = $('.navbar-shopping-cart');
const mobileMenu = $('.mobile-menu');
const shoppingCartContainer = $('#shoppingCartContainer');
const cardsContainer = $('.cards-container');
const productDetailContainer = $('#productDetail');
const productDetaiCloseIcon = $('.product-detail-close');

menuEmail.addEventListener('click', toggleDesktopMenu);
menuBurger.addEventListener('click', toggleMobileMenu);
menuCart.addEventListener('click', toggleCartAside);
productDetaiCloseIcon.addEventListener('click', closeProductDetailAside);

function toggleDesktopMenu() {
    console.log('Click');
    shoppingCartContainer.classList.add('inactive');
    mobileMenu.classList.add('mobile-menu-hide');
    productDetailContainer.classList.add('inactive');
    desktopMenu.classList.toggle('inactive');
}

function toggleMobileMenu() {
    productDetailContainer.classList.add('inactive');
    shoppingCartContainer.classList.add('inactive');
    desktopMenu.classList.add('inactive');
    mobileMenu.classList.toggle('mobile-menu-hide');
}

function toggleCartAside() {
    mobileMenu.classList.add('mobile-menu-hide');
    productDetailContainer.classList.add('inactive');
    desktopMenu.classList.add('inactive');
    shoppingCartContainer.classList.toggle('inactive');    
}

function openProductDetailAside() {
    shoppingCartContainer.classList.add('inactive');
    mobileMenu.classList.add('mobile-menu-hide');
    desktopMenu.classList.add('inactive');
    productDetailContainer.classList.remove('inactive');
}

function closeProductDetailAside() {
    productDetailContainer.classList.add('inactive');
}

const productList = [];
productList.push(
    {
        name: 'computer',
        price: 1500,
        image: 'https://images.pexels.com/photos/9393252/pexels-photo-9393252.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'

    },
    {
        name: 'mouse',
        price: 50,
        image: 'https://images.pexels.com/photos/2115256/pexels-photo-2115256.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1'
    },
    {
        name: 'keyboard',
        price: 100,
        image: 'https://hiraoka.com.pe/media/mageplaza/blog/post/c/o/como_elegir_un_teclado.jpg'
    }
);

function renderProducts(arrayProduct) {
    for (product of arrayProduct){
        const productCart = document.createElement('div');
        productCart.classList.add('product-card');

        const productImage = document.createElement('img');
        productImage.classList.add('product-detail-image-selection');
        productImage.setAttribute('src', product.image)
        productImage.addEventListener('click', openProductDetailAside);

        const productInfo = document.createElement('div');
        productInfo.classList.add('product-info');

        const productDetails = document.createElement('div');
        
        const productPrice = document.createElement('p');
        productPrice.textContent = `$${product.price}`;

        const productName = document.createElement('p');
        productName.textContent = product.name;

        const productButtonFigure = document.createElement('figure');
        const productButtonAddImage = document.createElement('img');
        productButtonAddImage.src = './icons/bt_add_to_cart.svg';

        productButtonFigure.appendChild(productButtonAddImage);
        productDetails.append(productPrice, productName);
        productInfo.append(productDetails, productButtonFigure);
        productCart.append(productImage, productInfo);
        cardsContainer.appendChild(productCart);
    }
}

renderProducts(productList);


