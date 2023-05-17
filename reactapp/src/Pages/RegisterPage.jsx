import React from 'react'

import RegisterForm from '../components/RegisterForm/RegisterForm';
import Logo from '../components/Logo/Logo';

import './LoginPageStyles.css';


function RegisterPage() {
  return (
    <div className='login-container'>
      <div className='login-form'>
      <RegisterForm/>
      </div>
      <div className='logo'><Logo/></div>
    </div>
    )
}

export default RegisterPage