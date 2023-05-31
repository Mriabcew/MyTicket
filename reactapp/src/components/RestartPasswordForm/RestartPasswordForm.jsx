import React from 'react'
import { useState } from 'react';
import axios from 'axios';

function RestartPasswordForm() {
    const [email, setEmail] = useState('');

    const handleSubmit = async (event) => {
        event.preventDefault();
        if(!email ) {
            alert("Wypełnij wszystkie pola formularza");
            return;
        }

        const emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/;
        if(!emailRegex.test(email)) {
            alert("Podaj poprawny adres e-mail.");
            return;
        }

        const data = {
            email: email,
        };
        console.log(data);
        try {
        }
        catch(ex)
        {

        }
    };

  return (
    <form className='register' onSubmit={handleSubmit}>
    <label>
        Email:
    </label>
    <input type="email" value={email} onChange={(e) => setEmail(e.target.value)} />
    <button type="submit">Wyślij</button>
    <label>
         <a href="/">Masz konto, zaloguj sie</a>
    </label>
</form>
  )
}

export default RestartPasswordForm;