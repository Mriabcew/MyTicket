import React, { useState } from "react";
import './Modals.css';


function ChangeEmailModal() {
    const [modal, setModal] = useState(false);

    const toggleModal = () => {
        setModal(!modal);
    };

    return (
        <>
            <button onClick={toggleModal} className="btn-modal">
                Change email
            </button>

            {modal && (
                <div className="modal">
                    <div onClick={toggleModal} className="overlay"></div>
                    <div className="modal-content">
                        <form className="modal-form">
                            <input name="OldEmail" type="text" placeholder="Old Email"/>
                            <input name="NewEmail" type="text" placeholder="New Email"/>
                            <input name="passwd" type="password" placeholder="Confirm with your password"/>
                            <button className="modal-submit" type="submit">Submit</button>
                        </form>

                        <button className="close-modal" onClick={toggleModal}>
                            X
                        </button>
                    </div>
                </div>
            )}

        </>
    );
}
export default ChangeEmailModal;