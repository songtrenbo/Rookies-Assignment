import React, { useState } from "react";
import { PencilFill, XCircle } from "react-bootstrap-icons";
import { useHistory } from "react-router";
import ButtonIcon from "../../../shared-components/ButtonIcon";
import { NotificationManager } from "react-notifications";

import Table, { SortType } from "../../../shared-components/Table";
import Info from "../Info";
import { EDIT_PRODUCT_ID } from "../../../Constants/pages";
import ConfirmModal from "../../../shared-components/ConfirmModal";
import { DisableProductRequest } from "../services/request";

const columns = [
  { columnName: "productId", columnValue: "ProductId" },
  { columnName: "productName", columnValue: "ProductName" },
  { columnName: "productDesc", columnValue: "ProductDesc" },
  { columnName: "price", columnValue: "Price" },
  { columnName: "categoryName", columnValue: "CategoryName" },
  { columnName: "brandName", columnValue: "BrandName" },
  { columnName: "stock", columnValue: "Stock" },
];

const ProductTable = ({
  products,
  handlePage,
  handleSort,
  sortState,
  fetchData,
}) => {
  const [showDetail, setShowDetail] = useState(false);
  const [productDetail, setProductDetail] = useState(null);
  const [disableState, setDisable] = useState({
    isOpen: false,
    productId: 0,
    title: "",
    message: "",
    isDisable: true,
  });

  const handleShowInfo = (productId) => {
    const product = products?.items.find((item) => item.productId === productId);

    if (product) {
      setProductDetail(product);
      setShowDetail(true);
    }
  };

  const handleShowDisable = async (productId) => {
    setDisable({
      productId,
      isOpen: true,
      title: "Are you sure",
      message: "Do you want to disable this Product?",
      isDisable: true,
    });
  };

  const handleCloseDisable = () => {
    setDisable({
      isOpen: false,
      productId: 0,
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
        `Remove Product Successful`,
        `Remove Successful`,
        2000
      );
    } else {
      setDisable({
        ...disableState,
        title: "Can not disable Product",
        message,
        isDisable: result,
      });
    }
  };

  const handleConfirmDisable = async () => {
    let isSuccess = await DisableProductRequest(disableState.productId);
    if (isSuccess) {
      await handleResult(true, "");
    }
  };

  const handleCloseDetail = () => {
    setShowDetail(false);
  };

  const history = useHistory();
  const handleEdit = (productId) => {
    const existProduct = products?.items.find((item) => item.productId === Number(productId));
    history.push(EDIT_PRODUCT_ID(productId), {
      existProduct: existProduct,
    });
  };

  return (
    <>
      <Table
        columns={columns}
        handleSort={handleSort}
        sortState={sortState}
        page={{
          currentPage: products?.currentPage,
          totalPage: products?.totalPages,
          handleChange: handlePage,
        }}
      >
        {products &&
          products?.items?.map((data, index) => (
            <tr
              key={index}
              className=""
              onClick={() => handleShowInfo(data.productId)}
            >
              <td>{data.productId}</td>
              <td>{data.productName.length>20?data.productName.substring(0,19) + "...":(data.productName)}</td>              
              <td>{data.productDesc.length>20?data.productDesc.substring(0,19) + "...":(data.productDesc)}</td>
              <td>$ {data.price}</td>
              <td>{data.categoryName}</td>
              <td>{data.brandName}</td>
              <td>{data.stock}</td>
              <td className="">
                <ButtonIcon className="btn btn-primary" onClick={() => handleEdit(data.productId)}>
                  <PencilFill className="text-white" />                  
                </ButtonIcon>
                &#160;
                <ButtonIcon className="btn btn-danger" onClick={() => handleShowDisable(data.productId)}>
                  <XCircle className="text-white" />
                </ButtonIcon>
              </td>
            </tr>
          ))}
      </Table>
      {productDetail && showDetail && (
        <Info product={productDetail} handleClose={handleCloseDetail} />
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

export default ProductTable;
