import React, { useEffect, useState } from 'react';
import { Formik, Form } from 'formik';
import * as Yup from 'yup';
import { Link, useHistory } from 'react-router-dom';
import { NotificationManager } from 'react-notifications';

import TextField from '../../shared-components/FormInputs/TextField';
import SelectField from '../../shared-components/FormInputs/SelectField';
import { CATEGORY } from '../../Constants/pages';
import { createCategoryRequest, UpdateCategoryRequest } from "./services/request";


const validationSchema = Yup.object().shape({
    categoryName: Yup.string().required('Required'),
    description: Yup.string().required('Required')
});

const CategoryFormContainer = ({ initialCategoryForm = {
} }) => {
    const [loading, setLoading] = useState(false);

    const isUpdate = initialCategoryForm.categoryId ? true : false;

    const history = useHistory();

    const handleResult = (result, message) => {
        if (result) {
            NotificationManager.success(
                `${isUpdate ? 'Updated' : 'Created'} Successful Category ${message}`,
                `${isUpdate ? 'Update' : 'Create'} Successful`,
                2000,
            );

            setTimeout(() => {
                history.push(CATEGORY);
            }, 1000);

        } else {
            NotificationManager.error(message, 'Create failed', 2000);
        }
    }

    const updateCategoryAsync = async (form) => {
        console.log('update category async');
        let data = await UpdateCategoryRequest(form.formValues);
        if (data)
        {
            handleResult(true, data.categoryName);
        }
    }

    const createCategoryAsync = async (form) => {  
        console.log('create category async');
        let data = await createCategoryRequest(form.formValues);
        if (data)
        {
            handleResult(true, data.categoryName);
        }
    }

    return (
        <Formik
            initialValues={initialCategoryForm}
            enableReinitialize
            validationSchema={validationSchema}
            onSubmit={(values) => {
                setLoading(true);

                setTimeout(() => {
                    if (isUpdate) {
                        updateCategoryAsync({ formValues: values });
                    }
                    else {
                        createCategoryAsync({ formValues: values });
                    }

                    setLoading(false);
                }, 1000);
            }}
        >
            {(actions) => (
                <Form className='container intro-y col-lg-6 col-12'>
                    <TextField 
                        name="categoryName" 
                        label="Category Name" 
                        placeholder="input category name" 
                        isrequired />
                      <TextField 
                        name="description" 
                        label="Description" 
                        placeholder="input description" 
                        isrequired />
                    <div className="row">
                            <button className="btn btn-danger col-lg-5 col-12"
                                type="submit" disabled={loading}
                            >
                                Save {(loading) && <img src="/oval.svg" className='w-4 h-4 ml-2 inline-block' />}
                            </button>                            
                            <div className="col-lg-2"><br/></div>
                            <Link to={CATEGORY} className="btn btn-outline-secondary col-lg-5 col-12">
                                Cancel
                            </Link>
                    </div>
                </Form>
            )}
        </Formik>
    );
}

export default CategoryFormContainer;
