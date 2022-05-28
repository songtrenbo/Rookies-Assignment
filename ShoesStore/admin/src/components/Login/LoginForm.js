import React, { useEffect, useState } from 'react';
import { Formik, Form } from 'formik';
import * as Yup from 'yup';
import { Link, useHistory } from 'react-router-dom';
import { NotificationManager } from 'react-notifications';
import SelectField from '../../shared-components/FormInputs/SelectField';
import Cookies from 'universal-cookie';
import swal from 'sweetalert';
import {getBrandsAsync, getCategoriesAsync} from '../../Constants/selectOptions'

import TextField from '../../shared-components/FormInputs/TextField';
import { LOGIN } from '../../Constants/pages';
import { authenticate} from "./services/request";

const validationSchema = Yup.object().shape({
    userName: Yup.string().required('Required'),
    password: Yup.string().required('Required'),
});

const ProductFormContainer = ({ initialProductForm = {
} }) => {

    const cookies = new Cookies();
    const history = useHistory(); 
    const ConfirmLogin = (values) =>{
      authenticate({ formValues: values });
      if(cookies.get("FullName", { path: '/' }) != null){                
      history.push("/product");      
      window.location.reload(false);
      }
      
    }
    return (
       <>
        <Formik
            initialValues={initialProductForm}
            enableReinitialize
            validationSchema={validationSchema}
            onSubmit={(values) => {
              ConfirmLogin(values);
            }}
        >
            {(actions) => (
                <Form className='container intro-y col-lg-5 mt-5 border p-5'>
                    <h2 className='d-flex justify-content-center'>Login</h2>
                    <hr/>
                    <TextField 
                        name="userName" 
                        label="User Name" 
                        placeholder="input username" 
                        isrequired />
                     <TextField 
                        name="password" 
                        label="Password" 
                        placeholder="input password" 
                        type = "password"
                        isrequired />                   
                    <div className="row d-flex justify-content-center">
                            <button className="btn btn-dark col-lg-6 col-12"
                                type="submit"
                            >
                                Login
                            </button>              
                    </div>
                </Form>
            )}
        </Formik>
       </>
    );
}

export default ProductFormContainer;
