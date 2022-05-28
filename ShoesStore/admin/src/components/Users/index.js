import React, { lazy } from 'react';
import { Route, Switch } from 'react-router-dom';

import { USER } from '../../Constants/pages';

const ListUser = lazy(() => import("./List"));

const User = () => {
    return (
        <Switch>
            <Route exact path={USER}>
                <ListUser />
            </Route>
        </Switch>
    )
};

export default User;