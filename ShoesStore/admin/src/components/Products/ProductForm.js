import React, { useEffect, useState } from 'react';
import { Formik, Form } from 'formik';
import * as Yup from 'yup';
import { Link, useHistory } from 'react-router-dom';
import { NotificationManager } from 'react-notifications';
import SelectField from '../../shared-components/FormInputs/SelectField';

import {getBrandsAsync, getCategoriesAsync} from '../../Constants/selectOptions'

import TextField from '../../shared-components/FormInputs/TextField';
import { PRODUCT } from '../../Constants/pages';
import { createProductRequest, UpdateProductRequest } from "./services/request";

const validationSchema = Yup.object().shape({
    productName: Yup.string().required('Required'),
    productDesc: Yup.string().required('Required'),
    price: Yup.string().required('Required'),
    stock: Yup.string().required('Required'),
    brandId: Yup.string().required('Required'),
    categoryId: Yup.string().required('Required'),
});
const ProductFormContainer = ({ initialProductForm = {
} }) => {
    const [loading, setLoading] = useState(false);

    const isUpdate = initialProductForm.productId ? true : false;

    const history = useHistory();

    const handleResult = (result, message) => {
        if (result) {
            NotificationManager.success(
                `${isUpdate ? 'Updated' : 'Created'} Successful Product ${message}`,
                `${isUpdate ? 'Update' : 'Create'} Successful`,
                2000,
            );

            setTimeout(() => {
                history.push(PRODUCT);
            }, 1000);

        } else {
            NotificationManager.error(message, 'Create failed', 2000);
        }
    }

    const updateProductAsync = async (form) => {
        console.log('update product async');
        let data = await UpdateProductRequest(form.formValues);
        if (data)
        {
            handleResult(true, data.productName);
        }
    }

    const createProductAsync = async (form) => {  
        console.log('create product async');
        let data = await createProductRequest(form.formValues);
        if (data)
        {
            handleResult(true, data.productName);
        }
    }
    

    const selectOptionsBrand = [];
    const selectOptionsCategory = [];
    getBrandsAsync(selectOptionsBrand);
    getCategoriesAsync(selectOptionsCategory);

    return (
        <Formik
            initialValues={initialProductForm}
            enableReinitialize
            validationSchema={validationSchema}
            onSubmit={(values) => {
                setLoading(true);

                setTimeout(() => {
                    if (isUpdate) {
                        updateProductAsync({ formValues: values });
                    }
                    else {
                        createProductAsync({ formValues: values });
                    }

                    setLoading(false);
                }, 1000);
            }}
        >
            {(actions) => (
                <Form className='container intro-y col-lg-6 col-12'>
                    <TextField 
                        name="productName" 
                        label="Product Name" 
                        placeholder="input product name" 
                        isrequired />
                     <TextField 
                        name="productDesc" 
                        label="Product Description" 
                        placeholder="input product description" 
                        isrequired />
                    <TextField 
                        name="price" 
                        label="Price" 
                        placeholder="input price" 
                        isrequired />
                    <TextField 
                        name="stock" 
                        label="Stock" 
                        placeholder="input stock" 
                        isrequired />
                    <SelectField 
                        name="brandId" 
                        label="Brand" 
                        options={selectOptionsBrand} 
                        isrequired />
                          <SelectField 
                        name="categoryId" 
                        label="Category" 
                        options={selectOptionsCategory} 
                        isrequired />
                    <div className="row">
                            <button className="btn btn-danger col-lg-5 col-12"
                                type="submit" disabled={loading}
                            >
                                Save {(loading) && <img src="/oval.svg" className='w-4 h-4 ml-2 inline-block' />}
                            </button>                            
                            <div className="col-lg-2"><br/></div>
                            <Link to={PRODUCT} className="btn btn-outline-secondary col-lg-5 col-12">
                                Cancel
                            </Link>
                    </div>
                </Form>
            )}
        </Formik>
    );
}

export default ProductFormContainer;
