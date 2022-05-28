import React, { lazy } from 'react';
import { Route, Switch } from 'react-router-dom';

import {LOGIN} from '../../Constants/pages';

const LoginUser = lazy(() => import("./LoginForm.js"));

const Login = () => {
    return (
        <Switch>
            <Route exact path={LOGIN}>
                <LoginUser />
            </Route>
        </Switch>
    )
};
export default Login;