const Endpoints = {
    
    brand: '/api/Brands',
    brandId: (id) => `api/Brands/${id}`,

    category: '/api/Categories',
    categoryId: (id)=>`api/Categories/${id}`,
};

export default Endpoints;
