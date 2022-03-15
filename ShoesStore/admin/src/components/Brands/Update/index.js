import React, { useEffect, useState } from 'react'
import { Redirect, useParams, useLocation } from 'react-router';

import BrandForm from '../BrandForm';

const UpdateBrandContainer = () => {
  const [brand, setBrand] = useState(undefined);
  const {state} = useLocation();
  const { existBrand } = state; // Read values passed on state
  
  useEffect(() => {
    if (existBrand) {
      setBrand({
        brandId: existBrand.brandId,
        brandName: existBrand.brandName
      });
    }
  }, [existBrand]);

  return (
    <div className='ml-5 container'>
        <br/>      
        <h2> Update Brand {existBrand?.brandName}</h2>
      <div className='row'>
        {
          brand && (<BrandForm
            initialBrandForm={brand}  
          />)
        }
      </div>
    </div>
  )
};

export default UpdateBrandContainer;
