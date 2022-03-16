import React, { useEffect, useState } from 'react'
import { Redirect, useParams, useLocation } from 'react-router';

import CategoryForm from '../CategoryForm';

const UpdateCategoryContainer = () => {
  const [category, setCategory] = useState(undefined);
  const {state} = useLocation();
  const { existCategory } = state; // Read values passed on state
  
  useEffect(() => {
    if (existCategory) {
      setCategory({
        categoryId: existCategory.categoryId,
        categoryName: existCategory.categoryName
      });
    }
  }, [existCategory]);

  return (
    <div className='ml-5 container'>
        <br/>      
        <h2> Update Category {existCategory?.categoryName}</h2>
      <div className='row'>
        {
          category && (<CategoryForm
            initialCategoryForm={category}  
          />)
        }
      </div>
    </div>
  )
};

export default UpdateCategoryContainer;
