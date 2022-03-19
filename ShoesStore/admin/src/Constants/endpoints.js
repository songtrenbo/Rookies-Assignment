const Endpoints = {
    
    brand: '/api/Brands',
    brandId: (id) => `api/Brands/${id}`,
    brands: '/api/Brands/List',

    category: '/api/Categories',
    categoryId: (id)=>`api/Categories/${id}`,
    categories: '/api/Categories/List',

    product: '/api/Products',
    productId: (id)=> `api/Products/${id}`,

    user: '/api/Users',
    userId: (id)=> `api/Users/${id}`,
};

export default Endpoints;
