import React, { useState } from 'react';
import { Link } from "react-router-dom";
function RegisterForm() {

    const [firstName, setFirstName] = useState('');
    const [lastName, setLastName] = useState('');
    const [email, setEmail] = useState('');
    const [password, setPassword] = useState('');
  
    const handleSubmit = (e) => {
      e.preventDefault();
      console.log('Form submitted:', firstName, lastName, email, password);
    }
  
  return (
    <div>
    <h1>Register</h1>
    <form className='RegisterForm' onSubmit={handleSubmit}>
      <label>
        First Name:
        <input type="text" value={firstName} onChange={(e) => setFirstName(e.target.value)} />
      </label>
      <label>
        Last Name:
        <input type="text" value={lastName} onChange={(e) => setLastName(e.target.value)} />
      </label>
      <label>
        Email:
        <input type="email" value={email} onChange={(e) => setEmail(e.target.value)} />
      </label>
      <label>
        Password:
        <input type="password" value={password} onChange={(e) => setPassword(e.target.value)} />
      </label>
      <button type="submit">Submit</button>
      <label>
      Nie masz konta <Link to="/">Zarejstruj sie</Link>
     </label>
    </form>
  </div>
  )
}

export default RegisterForm