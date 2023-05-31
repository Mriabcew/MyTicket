import React, { useState } from "react";
import './Modals.css';
import axios from "axios";

function ChangeProfileImg() {
    const [modal, setModal] = useState(false);
    const [imgString,setImgString] = useState("");
    const [Message, setMessage] = useState('');

    const toggleModal = () => {
        setModal(!modal);
    };
    const [selectedImage, setSelectedImage] = useState(null);

    const handleImageChange = (event) => {
    const file = event.target.files[0];
    setSelectedImage(file);
  }

  const handleSaveClick = () => {
    const formData = new FormData();
    formData.append("file",selectedImage);
    formData.append("upload_preset","ei0tlz1v");

    axios.post(
      "https://api.cloudinary.com/v1_1/dlhfvkqas/image/upload",
      formData
    )
      .then((response) => {
        setImgString(response.data.url);
      }); 
    try{
      axios.post(`https://localhost:7027/Security/ProfileImage?cloudinaryString=${imgString}&id=${localStorage.id}`)
      .then((response) => {
        setMessage(response.data);
      });
    }
    catch(error){
      console.error(error);
      setMessage("Wystąpił błąd podczas zmiany zdjecia: " + error.message);
    }
    };

    return (
        <>
            <button onClick={toggleModal} className="btn-modal">
                Change profile photo
            </button>

            {modal && (
                <div className="modal">
                <div className="modal-content">
                  <input type="file" accept="image/*" onChange={handleImageChange} />
                  <button className='modal-submit' onClick={handleSaveClick}>Submit</button>
                  {Message && <div className="message">{Message}</div>}
                </div>
              </div>
            )}

        </>
    );
}
export default ChangeProfileImg;