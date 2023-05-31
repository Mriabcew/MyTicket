import React, { useState } from 'react';
import { Link, useNavigate } from "react-router-dom";
import axios from 'axios';

import './RegisterFormStyles.css';

function RegisterForm() {
    const navigate = useNavigate();
    const [name, setName] = useState('');
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
    const [password2, setPassword2] = useState('');

    const handleSubmit = async (event) => {
        event.preventDefault();
        if(!name || !email || !password || !password2) {
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
            password: password,
            username: name
        };

        console.log(data);
        
        try {
            const response = await axios.post("https://localhost:7027/Security/Register", data);
            if (response.status === 200) {
                alert("Rejestracja zakończona sukcesem.");
                navigate('/');
            } else {
                alert("Wystąpił błąd podczas rejestracji.");
            }
        } catch (error) {
            console.error(error);
            alert("Wystąpił błąd podczas rejestracji: " + error.message);
        }
    };
  return (
    <form className='register' onSubmit={handleSubmit}>
        <label>
            Nazwa użytkownika:
        </label>
        <input type="text" value={name} onChange={(e) => setName(e.target.value)} />
      
        <label>
            Email:
        </label>
        <input type="email" value={email} onChange={(e) => setEmail(e.target.value)} />
      
        <label>
            Hasło:
        </label>    
        <input type="password" value={password} onChange={(e) => setPassword(e.target.value)} />
    
        <label>
            Powtórz Hasło:
        </label>    
        <input type="password" value={password2} onChange={(e) => setPassword2(e.target.value)} />

        <button type="submit">Rejstracja</button>
        <label>
             <a href="/">Masz konto zaloguj sie</a>
        </label>
    </form>
  )
}

export default RegisterForm;