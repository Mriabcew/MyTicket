import React from 'react';
import RegisterForm from '../components/RegisterForm/RegisterForm';
import './LoginPageStyles.css';
import Logo from '../components/Logo/Logo';

function LoginPage() {
  return (
    <div className='login-container'>
      <div className='login-form'>
      <RegisterForm/>
      </div>
      <div className='logo'><Logo/></div>
    </div>
  )
}

export default LoginPage