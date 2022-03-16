import React from "react";
import { Modal, } from "react-bootstrap";
const Info = ({ category, handleClose }) => {
  return (
    <>
      <Modal
        show={true}
        onHide={handleClose}
        dialogClassName="modal-90w"
      >
        <Modal.Header closeButton>
          <Modal.Title id="login-modal">
            Detailed Category Infomation
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
              <td className="form-control">{category.categoryId}</td>
            </tr>
<br/>
            <tr>
              <td>Name:</td>
              <td className="form-control">{category.categoryName}</td>
            </tr>
          </table>
        </Modal.Body>
      </Modal>
    </>
  );
}

export default Info;