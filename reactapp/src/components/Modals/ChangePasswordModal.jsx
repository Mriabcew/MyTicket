import React, { useState } from "react";
import axios from "axios";
import './Modals.css';


function ChangePasswordModal() {
    const [modal, setModal] = useState(false);
    const [Message, setMessage] = useState('');

    const toggleModal = () => {
        setModal(!modal);
    };

    const handleSubmit = async (e) => {
        e.preventDefault();
        const id = localStorage.id;
        const formData = new FormData(e.target);
        const passwordOld = formData.get("passwordOld");
        const passwordNew = formData.get("passwordNew");

        const payload = {
            id,
            passwordOld,
            passwordNew 
        };
        try {
            const response = await axios.post('https://localhost:7027/Security/SetNewPassword', payload)
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
                Change password
            </button>

            {modal && (
                <div className="modal">
                    <div onClick={toggleModal} className="overlay"></div>
                    <div className="modal-content">
                        <form onSubmit={handleSubmit}>
                            <input name="passwordOld" type="password" placeholder="Old Password"/>
                            <input name="passwordNew" type="password" placeholder="New Password"/>
                            <input name="passwordNewRepeat" type="password" placeholder="Repeat New Password"/>
                            <button className="modal-submit" type="submit">Submit</button>
                        </form>
                        {Message && <div className="message">{Message}</div>}
                    </div>
                </div>
            )}

        </>
    );
}
export default ChangePasswordModal;