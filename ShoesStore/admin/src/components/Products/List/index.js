import React, { useEffect, useState } from "react";
import { FunnelFill } from "react-bootstrap-icons";
import { Search } from "react-feather";

import { Link } from "react-router-dom";
import ProductTable from "./ProductTable";

import { getProductsRequest } from "../services/request";
import {
  ACCSENDING,
  DECSENDING,
  DEFAULT_PRODUCT_SORT_COLUMN_NAME,
  DEFAULT_PAGE_LIMIT,
} from "../../../Constants/paging";

const ListProduct = () => {
  const [query, setQuery] = useState({
    sortColumn: DEFAULT_PRODUCT_SORT_COLUMN_NAME,
    limit: DEFAULT_PAGE_LIMIT,
    sortOrder: ACCSENDING,
    page: 1,
  });

  const [search, setSearch] = useState("");
  const [products, setProducts] = useState("");


  const handleChangeSearch = (e) => {
    e.preventDefault();

    const search = e.target.value;
    setSearch(search);
  };

  const handlePage = (page) => {
    setQuery({
      ...query,
      page,
    });
  };

  const handleSearch = () => {
    setQuery({
      ...query,
      search,
    });
  };

  const handleSort = (sortColumn) => {
    const sortOrder = query.sortOrder === ACCSENDING ? DECSENDING : ACCSENDING;

    setQuery({
      ...query,
      sortColumn,
      sortOrder,
    });
  };

  const fetchDataCallbackAsync = async () => {
    let data = await getProductsRequest(query);
    console.log("fetchDataCallbackAsync");
    console.log(data);
    setProducts(data);
  };

  useEffect(() => {
    async function fetchDataAsync() {
      let result = await getProductsRequest(query);
      setProducts(result.data);
    }

    fetchDataAsync();
  }, [query]);

  return (
    <>
      <div className="container">
        <br />
        <h2>Product list</h2>
        <div className="d-flex intro-x">
          <div className="d-flex align-items-center w-md mr-5">

            <div className="border p-2">
              <FunnelFill />
            </div>
          </div>

          <div className="d-flex align-items-center w-ld ml-auto">
            <div className="input-group">
              <input
                onChange={handleChangeSearch}
                value={search}
                type="text"
                className="form-control"
              />
              <span onClick={handleSearch} className="border p-2 pointer">
                <Search />
              </span>
            </div>
          </div>
          &ensp;
        <div className="d-flex">
          <Link to="/product/create" type="button" className="btn btn-danger">
            Create new Product
          </Link>
        </div>
        </div>
        <br />
        <ProductTable
          products={products}
          handlePage={handlePage}
          handleSort={handleSort}
          sortState={{
            columnValue: query.sortColumn,
            orderBy: query.sortOrder,
          }}
          fetchData={fetchDataCallbackAsync}
        />
      </div>
    </>
  );
};

export default ListProduct;
