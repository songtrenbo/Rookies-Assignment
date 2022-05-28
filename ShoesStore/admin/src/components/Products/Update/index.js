import React, { useEffect, useState } from 'react'
import { Redirect, useParams, useLocation } from 'react-router';

import ProductForm from '../ProductForm';

const UpdateProductContainer = () => {
  const [product, setProduct] = useState(undefined);
  const {state} = useLocation();
  const { existProduct } = state; // Read values passed on state
  
  useEffect(() => {
    if (existProduct) {
      setProduct({
        productId: existProduct.productId,
        productName: existProduct.productName,
        productDesc: existProduct.productDesc,
        price: existProduct.price,
        brandId: existProduct.brandId,
        categoryId: existProduct.categoryId,
        stock: existProduct.stock,
      });
    }
  }, [existProduct]);

  return (
    <div className='ml-5 container'>
        <br/>      
        <h2> Update Product {existProduct?.productName}</h2>
      <div className='row'>
        {
          product && (<ProductForm
            initialProductForm={product}  
          />)
        }
      </div>
    </div>
  )
};

export default UpdateProductContainer;
