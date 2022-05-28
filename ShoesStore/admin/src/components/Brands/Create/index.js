import React, { useState } from "react";

import BrandFormContainer from "../BrandForm";

const CreateBrandContainer = () => {

  return (
    <div className='ml-5 container'>
        <br/>
        <h2>Create New Brand</h2>
      <div className='row'>
        <BrandFormContainer />

      </div>

    </div>
  );
};

export default CreateBrandContainer;
