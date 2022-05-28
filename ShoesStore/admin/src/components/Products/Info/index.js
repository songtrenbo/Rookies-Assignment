import React from "react";
import { Modal, } from "react-bootstrap";

const Info = ({ product, handleClose }) => {
  return (
    <>
      <Modal
        show={true}
        onHide={handleClose}
        dialogClassName="modal-90w"
      >
        <Modal.Header closeButton>
          <Modal.Title id="login-modal">
            Detailed Product Infomation
          </Modal.Title>
        </Modal.Header>

        <Modal.Body>
          <table className="form-group container-fluid">
            <th>
              <td></td>
              <td></td>
            </th>
            <tr>
              <td>Id:</td>
              <td className="form-control">{product.productId}</td>
            </tr>
<br/>
            <tr>
              <td>Name:</td>
              <td className="form-control">{product.productName}</td>
            </tr>
            <br/>
            <tr>
              <td>Description:</td>
              <td className="form-control">{product.productDesc}</td>
            </tr><br/>
            <tr>
              <td>Price:</td>
              <td className="form-control">{product.price}</td>
            </tr><br/>
            <tr>
              <td>Category Name:</td>
              <td className="form-control">{product.categoryName}</td>
            </tr><br/>
            <tr>
              <td>Brand Name:</td>
              <td className="form-control">{product.brandName}</td>
            </tr><br/>
            <tr>
              <td>Stock:</td>
              <td className="form-control">{product.stock}</td>
            </tr>
          </table>
        </Modal.Body>
      </Modal>
    </>
  );
}

export default Info;