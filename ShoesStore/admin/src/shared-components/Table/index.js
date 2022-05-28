import React from "react";
import { CaretDownFill, CaretUpFill } from "react-bootstrap-icons";

import Paging, { PageType } from "./Paging";
import "./Table.css";

const ColumnIcon = ({ colValue, sortState }) => {
  if (colValue === sortState.columnValue) {
    if (sortState.orderBy === 'Accsending') {
      return <CaretDownFill />
    }
    else {
      return <CaretUpFill />
    }
  } 

  return (<CaretDownFill />);
};

const Table = ({ columns, children, page, sortState, handleSort }) => {

  return (
    <>
      <div className="table-container">
        <table className="table table-bordered table-striped custom-class">
          <thead>
            <tr>
              {
                columns.map((col, i) => (
                  <th className="sortable text-left align-middle" key={i}>
                    <a className="btn" onClick={() => handleSort(col.columnValue)}>
                      {col.columnName} &#160;
                      <ColumnIcon colValue={col.columnValue} sortState={sortState} />
                    </a>
                  </th>
                ))
              }
              <th className="text-center align-middle">
                Action
              </th>
            </tr>
          </thead>

          <tbody className="text-center align-middle">{children}</tbody>
        </table>
      </div>
      {
        (page && page.totalPage && page.totalPage > 1) && <Paging {...page} />
      }
    </>
  );
};

export default Table;
