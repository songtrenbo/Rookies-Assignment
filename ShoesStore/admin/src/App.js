import React,{ lazy, Suspense, useEffect } from "react";
import { BrowserRouter as Router, Switch, Route } from "react-router-dom";
import Navbar from "./components/Navbar/navbar";
import InLineLoader from "./shared-components/InlineLoader";
import { BRAND, CATEGORY } from "./Constants/pages";
import Category from "./components/Categories";
const Brand = lazy(() => import('./components/Brands'));
const SusspenseLoading = ({ children }) => (
  <Suspense fallback={<InLineLoader />}>
    {children}
  </Suspense>
);

function App() {
  return (
    // <div>
    //   <Router>
    //   <div className="App">
    //     <Navbar />
    //   <SusspenseLoading>
    //     <Switch>
    //       <Route path={BRAND}>
    //         <Brand />
    //       </Route>
    //     </Switch>
    //   </SusspenseLoading>
    //   </div>
    //   </Router>
    // </div>
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
           <Route path={BRAND}>
             <Brand />
           </Route>
       </Switch>
      </SusspenseLoading>
     </div>
   </Router>
  );
}

export default App;
