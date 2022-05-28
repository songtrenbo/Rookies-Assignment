import React from "react";
import { Modal, } from "react-bootstrap";

// import { 
//   NormalBrandType,
//   NormalBrandTypeLabel,
//   LuxuryBrandType, 
//   LuxyryBrandTypeLabel 
// } from "../../../Constants/Brand/BrandConstants";

const Info = ({ brand, handleClose }) => {
  // const getBrandTypeName = (id) => {
  //   return id == LuxuryBrandType ? LuxyryBrandTypeLabel : NormalBrandTypeLabel;
  // }

  return (
    <>
      <Modal
        show={true}
        onHide={handleClose}
        dialogClassName="modal-90w"
      >
        <Modal.Header closeButton>
          <Modal.Title id="login-modal">
            Detailed Brand Infomation
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
              <td className="form-control">{brand.brandId}</td>
            </tr>
<br/>
            <tr>
              <td>Name:</td>
              <td className="form-control">{brand.brandName}</td>
            </tr>

            {/* <div className='row -intro-y'>
              <div className='col-4'>Type:</div>
              <div>{getBrandTypeName(brand.type)}</div>
            </div> */}

            {/* <div className='row -intro-y'>
              <div className='col-4'>Image:</div>
              <div>
                <img src={brand.imagePath} className='object-center w-full rounded-md' />
              </div>
            </div> */}

          </table>
        </Modal.Body>
      </Modal>
    </>
  );
}

export default Info;