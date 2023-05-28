import React, { useState } from "react";
import './Modals.css';


function ChangeUserInformations() {
    const [modal, setModal] = useState(false);

    const toggleModal = () => {
        setModal(!modal);
    };

    return (
        <>
            <button onClick={toggleModal} className="btn-modal">
                Change user informations
            </button>

            {modal && (
                <div className="modal">
                    <div onClick={toggleModal} className="overlay"></div>
                    <div className="modal-content">
                        <form className="modal-form">
                            <input name="Name" type="text" placeholder="Set name"/>
                            <input name="Surname" type="text" placeholder="Set surname"/>
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
export default ChangeUserInformations;