import React, { useState } from "react";
import { PencilFill, XCircle } from "react-bootstrap-icons";
import { useHistory } from "react-router";
import ButtonIcon from "../../../shared-components/ButtonIcon";
import { NotificationManager } from "react-notifications";

import Table, { SortType } from "../../../shared-components/Table";
import Info from "../Info";
import { EDIT_CATEGORY_ID } from "../../../Constants/pages";
import ConfirmModal from "../../../shared-components/ConfirmModal";
import { DisableCategoryRequest } from "../services/request";

const columns = [
  { columnName: "categoryId", columnValue: "CategoryId" },
  { columnName: "categoryName", columnValue: "CategoryName" },
];

const CategoryTable = ({
  categories,
  handlePage,
  handleSort,
  sortState,
  fetchData,
}) => {
  const [showDetail, setShowDetail] = useState(false);
  const [categoryDetail, setCategoryDetail] = useState(null);
  const [disableState, setDisable] = useState({
    isOpen: false,
    categoryId: 0,
    title: "",
    message: "",
    isDisable: true,
  });

  const handleShowInfo = (categoryId) => {
    const category = categories?.items.find((item) => item.categoryId === categoryId);

    if (category) {
      setCategoryDetail(category);
      setShowDetail(true);
    }
  };

  const handleShowDisable = async (categoryId) => {
    setDisable({
      categoryId,
      isOpen: true,
      title: "Are you sure",
      message: "Do you want to disable this Category?",
      isDisable: true,
    });
  };

  const handleCloseDisable = () => {
    setDisable({
      isOpen: false,
      categoryId: 0,
      title: "",
      message: "",
      isDisable: true,
    });
  };

  const handleResult = async (result, message) => {
    if (result) {
      handleCloseDisable();
      await fetchData();
      NotificationManager.success(
        `Remove Category Successful`,
        `Remove Successful`,
        2000
      );
    } else {
      setDisable({
        ...disableState,
        title: "Can not disable Category",
        message,
        isDisable: result,
      });
    }
  };

  const handleConfirmDisable = async () => {
    let isSuccess = await DisableCategoryRequest(disableState.categoryId);
    if (isSuccess) {
      await handleResult(true, "");
    }
  };

  const handleCloseDetail = () => {
    setShowDetail(false);
  };

  const history = useHistory();
  const handleEdit = (categoryId) => {
    const existCategory = categories?.items.find((item) => item.categoryId === Number(categoryId));
    history.push(EDIT_CATEGORY_ID(categoryId), {
      existCategory: existCategory,
    });
  };

  return (
    <>
      <Table
        columns={columns}
        handleSort={handleSort}
        sortState={sortState}
        page={{
          currentPage: categories?.currentPage,
          totalPage: categories?.totalPages,
          handleChange: handlePage,
        }}
      >
        {categories &&
          categories?.items?.map((data, index) => (
            <tr
              key={index}
              className=""
              onClick={() => handleShowInfo(data.categoryId)}
            >
              <td>{data.categoryId}</td>
              <td>{data.categoryName}</td>
              <td className="">
                <ButtonIcon className="btn btn-primary" onClick={() => handleEdit(data.categoryId)}>
                  <PencilFill className="text-white" />                  
                </ButtonIcon>
                &#160;
                <ButtonIcon className="btn btn-danger" onClick={() => handleShowDisable(data.categoryId)}>
                  <XCircle className="text-white" />
                </ButtonIcon>
              </td>
            </tr>
          ))}
      </Table>
      {categoryDetail && showDetail && (
        <Info category={categoryDetail} handleClose={handleCloseDetail} />
      )}
      <ConfirmModal
        title={disableState.title}
        isShow={disableState.isOpen}
        onHide={handleCloseDisable}
      >
        <div>
          <div className="text-center">{disableState.message}</div>
          {disableState.isDisable && (
            <div className="text-center mt-3">
              <button
                className="btn btn-danger mr-3"
                onClick={handleConfirmDisable}
                type="button"
              >
                Disable
              </button>
              <button
                className="btn btn-outline-secondary"
                onClick={handleCloseDisable}
                type="button"
              >
                Cancel
              </button>
            </div>
          )}
        </div>
      </ConfirmModal>
    </>
  );
};

export default CategoryTable;
