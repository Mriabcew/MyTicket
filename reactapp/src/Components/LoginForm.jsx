import React, { useState } from "react";
import "./CSS/LoginForm.css";
import { Link } from "react-router-dom";

const LoginForm = () => {
  const [username, setUsername] = useState("");
  const [password, setPassword] = useState("");

  const handleUsernameChange = (event) => {
    setUsername(event.target.value);
  };

  const handlePasswordChange = (event) => {
    setPassword(event.target.value);
  };

  const handleSubmit = (event) => {
    event.preventDefault();
    console.log(`Username: ${username}, Password: ${password}`);
  };

  return (
    <div className="form-container">
      <form className="LoginForm"onSubmit={handleSubmit}>
        <label>
          Username:
          <input className="LoginInput" type="text" value={username} onChange={handleUsernameChange} />
        </label>
        <label>
          Password:
          <input className="LoginInput" type="password" value={password} onChange={handlePasswordChange} />
        </label>
        <button type="submit"><Link to="/Mainpage">Log In</Link></button>
       <label>
        Nie masz konta <Link to="/Register">Zarejstruj sie</Link>
       </label>
      </form>
    </div>
  );
};

export default LoginForm;