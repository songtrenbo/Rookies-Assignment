var cart = [];
var quantity = 0;
var total = 0;

var productQuantity = 0;
if (window.localStorage) {
    cart = JSON.parse(window.localStorage.getItem("cart"));
}

if (!cart) {
    cart = [];
}

if (cart.length > 0) {
    for (var i = 0; i < cart.length; i++) {
        productQuantity += cart[i].quantity;
        total += cart[i].quantity * cart[i].productPrice;
        console.log(cart[i].quantity + " " + cart[i].productPrice)
    }

}

function AddToCart(id, name, price, stock, image) {
    var exist = false;
    for (var i = 0; i < cart.length; i++) {

        console.log(cart[i].stock);
        if (cart[i].productId == id) {
            cart[i].quantity += 1;
            productQuantity++;
            total += cart[i].productPrice;
            exist = true;
        }
    }

    if (!exist) {
        var product = { productId: id, productName: name, productPrice: price, quantity: 1, stock: stock, image: image };
        cart.push(product);
        productQuantity++;
        total += cart[cart.length - 1].productPrice;
    }
    window.localStorage.setItem("cart", JSON.stringify(cart));
    Swal.fire({
        position: "center",
        icon: "success",
        title: "Add to cart success!",
        showConfirmButton: true,
    });
}