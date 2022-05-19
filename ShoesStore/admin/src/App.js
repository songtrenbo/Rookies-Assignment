import React,{ lazy, Suspense, useEffect } from "react";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import Navbar from "./components/Navbar/navbar";
import InLineLoader from "./shared-components/InlineLoader";
import { BRAND, CATEGORY, PRODUCT, USER, LOGIN } from "./Constants/pages";
// import Category from "./components/Categories";
const Brand = lazy(() => import('./components/Brands'));
const Category = lazy(() => import('./components/Categories'));
const Product = lazy(() => import('./components/Products'));
const User = lazy(() => import('./components/Users'));
const Login = lazy(()=>import('./components/Login'))
const SusspenseLoading = ({ children }) => (
  <Suspense fallback={<InLineLoader />}>
    {children}
  </Suspense>
);

function App() {
  return (
     <Router>
     <div className="App">
      <Navbar />

       <SusspenseLoading>
         <Switch>
           <Route exact path="/">
             {/* <Home bootcamp={this.state.bootcamp} /> */}
           </Route>
           <Route path={CATEGORY}>
             <Category />
           </Route>
           <Route path={PRODUCT}>
             <Product />
           </Route>
           <Route path={USER}>
             <User />
           </Route>
           <Route path={BRAND}>
             <Brand />
           </Route>
           <Route path={LOGIN}>
             <Login />
           </Route>
       </Switch>
      </SusspenseLoading>
     </div>
   </Router>
  );
}

export default App;
