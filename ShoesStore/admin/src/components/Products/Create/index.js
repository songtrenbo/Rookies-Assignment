import React, { useState } from "react";

import ProductFormContainer from "../ProductForm";

const CreateProductContainer = () => {

  return (
    <div className='ml-5 container'>
        <br/>
        <h2>Create New Product</h2>
      <div className='row'>
        <ProductFormContainer />

      </div>

    </div>
  );
};

export default CreateProductContainer;
