import React from "react";
import { Modal, } from "react-bootstrap";

const Info = ({ user, handleClose }) => {

  return (
    <>
      <Modal
        show={true}
        onHide={handleClose}
        dialogClassName="modal-90w"
      >
        <Modal.Header closeButton>
          <Modal.Title id="login-modal">
            Detailed User Infomation
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
              <td className="form-control">{user.userId}</td>
            </tr>
<br/>
            <tr>
              <td>Name:</td>
              <td className="form-control">{user.name}</td>
            </tr>
            <br/>
            <tr>
              <td>Email:</td>
              <td className="form-control">{user.userEmail}</td>
            </tr>
            <br/>
            <tr>
              <td>Address:</td>
              <td className="form-control">{user.address}</td>
            </tr>
            <br/>
            <tr>
              <td>Phone:</td>
              <td className="form-control">{user.phone}</td>
            </tr>
          </table>
        </Modal.Body>
      </Modal>
    </>
  );
}

export default Info;