import React, { useEffect, useState } from "react";
import { FunnelFill } from "react-bootstrap-icons";
import { Search } from "react-feather";

import { Link } from "react-router-dom";
import UserTable from "./UserTable";
import { getUsersRequest } from "../services/request";
import {
  ACCSENDING,
  DECSENDING,
  DEFAULT_USER_SORT_COLUMN_NAME,
  DEFAULT_PAGE_LIMIT,
} from "../../../Constants/paging";

const ListUser = () => {
  const [query, setQuery] = useState({
    sortColumn: DEFAULT_USER_SORT_COLUMN_NAME,
    limit: DEFAULT_PAGE_LIMIT,
    sortOrder: ACCSENDING,
    page: 1,
  });

  const [search, setSearch] = useState("");
  const [users, setUsers] = useState("");

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
    let data = await getUsersRequest(query);
    console.log("fetchDataCallbackAsync");
    console.log(data);
    setUsers(data);
  };


  useEffect(() => {
    async function fetchDataAsync() {
      let result = await getUsersRequest(query);
      setUsers(result.data);
    }

    fetchDataAsync();
  }, [query, users]);

  return (
    <>
      <div className="container">
        <br />
        <h2>User list</h2>
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
        </div>
        <br />
        <UserTable
          users={users}
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

export default ListUser;
