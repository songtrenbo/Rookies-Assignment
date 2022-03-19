import React, { useState } from "react";
import { PencilFill, XCircle } from "react-bootstrap-icons";
import { useHistory } from "react-router";
import ButtonIcon from "../../../shared-components/ButtonIcon";
import { NotificationManager } from "react-notifications";

import Table, { SortType } from "../../../shared-components/Table";
import Info from "../Info";
const columns = [
  { columnName: "userId", columnValue: "UserId" },
  { columnName: "name", columnValue: "Name" },
  { columnName: "userEmail", columnValue: "UserEmail" },
  { columnName: "address", columnValue: "Address" },
  { columnName: "phone", columnValue: "Phone" }
];

const UserTable = ({
  users,
  handlePage,
  handleSort,
  sortState,
  fetchData,
}) => {
  const [showDetail, setShowDetail] = useState(false);
  const [userDetail, setUserDetail] = useState(null);

  const handleShowInfo = (userId) => {
    const user = users?.items.find((item) => item.userId === userId);

    if (user) {
      setUserDetail(user);
      setShowDetail(true);
    }
  };



  const handleCloseDetail = () => {
    setShowDetail(false);
  };

  return (
    <>
      <Table
        columns={columns}
        handleSort={handleSort}
        sortState={sortState}
        page={{
          currentPage: users?.currentPage,
          totalPage: users?.totalPages,
          handleChange: handlePage,
        }}
      >
        {users &&
          users?.items?.map((data, index) => (
            <tr
              key={index}
              onClick={() => handleShowInfo(data.userId)}
            >
              <td>{data.userId}</td>
              <td>{data.name}</td>
              <td>{data.userEmail}</td>
              <td>{data.address}</td>
              <td>{data.phone}</td>
              <td>              
              </td>
            </tr>
          ))}
      </Table>
      {userDetail && showDetail && (
        <Info user={userDetail} handleClose={handleCloseDetail} />
      )}
    
    </>
  );
};

export default UserTable;
