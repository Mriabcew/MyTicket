import React, { useState } from "react";
import { useNavigate } from 'react-router-dom';
import Cookies from "js-cookie";
import axios from "axios";

import "./LoginFormStyles.css";

function LoginForm() {
  const navigate = useNavigate();
  const [usernameOrEmail, setUsernameOrEmail] = useState('');
  const [password, setPassword] = useState('');
  const [errorMessage, setErrorMessage] = useState('');


  const handleSubmit = (event) => {
    event.preventDefault();
    setErrorMessage('');

    axios
      .post('https://localhost:7027/Security/Login', {
        usernameOrEmail: usernameOrEmail,
        password: password,
      })
      .then((response) => {
        console.log(response.data);
        navigate('/home');
      })
      .catch((error) => {
        console.log(error.response);
        setErrorMessage('Niepoprawna nazwa użytkownika lub hasło.');
      });
  };

  return (
      <form className="login" onSubmit={handleSubmit}>
        <label htmlFor="usernameOrEmail">Nazwa użytkownika lub adres e-mail</label>
        <input
              type="text"
              id="usernameOrEmail"
              name="usernameOrEmail"
              value={usernameOrEmail}
              onChange={(event) => setUsernameOrEmail(event.target.value)}
        />
        <label htmlFor="password">Hasło</label>
        <input
              type="password"
              className="form-control"
              id="password"
              name="password"
              value={password}
              onChange={(event) => setPassword(event.target.value)}
        />
         {errorMessage && <div className="alert alert-danger">{errorMessage}</div>}
        <button type="submit">Zaloguj się</button>
        <a href="passwordRestart">Nie pamietasz hasla?</a>
        <a href="Register">Nie masz konta?</a>
      </form>
  );
};

export default LoginForm;