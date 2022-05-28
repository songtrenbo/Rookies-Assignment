import React from "react";
import { Link } from "react-router-dom";
import "./navbar.css";
import { FontAwesomeIcon } from "@fortawesome/react-fontawesome";
import { faUser } from "@fortawesome/free-solid-svg-icons";
import Cookies from "universal-cookie";
const navbar = () => {
  const cookies = new Cookies();
  const Logout = () => {
    cookies.remove("FullName", { path: "/" });
    cookies.remove("AccessToken", { path: "/" });
  };
  return (
    <header>
      <nav className="navbar navbar-expand-lg navbar-light shadow">
        <div className="container d-flex justify-content-between align-items-center">
          <a
            className="navbar-brand text-success logo h1 align-self-center"
            href="/"
          >
            <img src={process.env.PUBLIC_URL + "/Logo.png"} alt="Logo" className="img-fluid" />
          </a>

          <button
            className="navbar-toggler border-0"
            type="button"
            data-bs-toggle="collapse"
            data-bs-target="#templatemo_main_nav"
            aria-controls="navbarSupportedContent"
            aria-expanded="false"
            aria-label="Toggle navigation"
          >
            <span className="navbar-toggler-icon"></span>
          </button>

          <div
            className="align-self-center collapse navbar-collapse flex-fill  d-lg-flex justify-content-lg-between"
            id="templatemo_main_nav"
          >
            {cookies.get("FullName", { path: "/" }) != null ? (
              <>
                <div className="flex-fill">
                  <ul className="nav navbar-nav d-flex justify-content-between mx-lg-auto">
                    <Link to="/product" className="nav-link">
                      <li className="nav-item">Product</li>
                    </Link>
                    <Link to="/category" className="nav-link">
                      <li className="nav-item">Categories</li>
                    </Link>
                    <Link to="/user" className="nav-link">
                      <li className="nav-item">Customer</li>
                    </Link>
                    <Link to="/brand" className="nav-link">
                      <li className="nav-item">Brand</li>
                    </Link>
                  </ul>
                </div>
                <div className="navbar align-self-center d-flex">
                  <a
                    className="nav-icon position-relative text-decoration-none"
                    href="#"
                  >
                    {cookies.get("FullName", { path: "/" })}
                  </a>
                  <a
                    className="nav-icon position-relative text-decoration-none"
                    href="/login"
                    onClick={Logout}
                  >
                    <span>Logout</span>
                  </a>
                </div>
              </>
            ) : (
              <>
                <div className="flex-fill">
                  <ul className="nav navbar-nav d-flex justify-content-between mx-lg-auto">                
                  </ul>
                </div>
                <div className="navbar align-self-center d-flex">
                  <a
                    className="nav-icon position-relative text-decoration-none"
                    href="#"
                  >
                    <Link to="/login" className="nav-link">
                      <FontAwesomeIcon icon={faUser}></FontAwesomeIcon>
                    </Link>
                  </a>
                </div>
              </>
            )}
          </div>
        </div>
      </nav>
    </header>
  );
};
export default navbar;
