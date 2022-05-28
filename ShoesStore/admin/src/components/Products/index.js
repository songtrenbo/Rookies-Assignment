import React, { lazy } from 'react';
import { Route, Switch } from 'react-router-dom';

import { CREATE_PRODUCT, PRODUCT, EDIT_PRODUCT } from '../../Constants/pages';

const CreateProduct = lazy(() => import("./Create"));
const ListProduct = lazy(() => import("./List"));
const UpdateProduct = lazy(() => import("./Update"));

const Product = () => {
    return (
        <Switch>
            <Route exact path={PRODUCT}>
                <ListProduct />
            </Route>
            <Route exact path={CREATE_PRODUCT}>
                <CreateProduct />
            </Route>
            <Route exact path={EDIT_PRODUCT}>
                <UpdateProduct />
            </Route>
        </Switch>
    )
};

export default Product;