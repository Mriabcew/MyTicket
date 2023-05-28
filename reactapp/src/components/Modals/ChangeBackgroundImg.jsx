import React, { useState } from "react";
import './Modals.css';


function ChangeBackgroundImg() {
    const [modal, setModal] = useState(false);

    const toggleModal = () => {
        setModal(!modal);
    };
    const [selectedImage, setSelectedImage] = useState(null);

    const handleImageChange = (event) => {
    const file = event.target.files[0];
    setSelectedImage(file);
  }

  const handleSaveClick = () => {
  };

    return (
        <>
            <button onClick={toggleModal} className="btn-modal">
                Change background photo
            </button>

            {modal && (
                <div className="modal">
                <div className="modal-content">
                  <h2>Change Background Photo</h2>
                  <input type="file" accept="image/*" onChange={handleImageChange} />
                  <button className="modal-submit" onClick={handleSaveClick}>Submit</button>
                  <button className="close-modal" onClick={toggleModal}>X</button>
                </div>


              </div>
            )}

        </>
    );
}
export default ChangeBackgroundImg;