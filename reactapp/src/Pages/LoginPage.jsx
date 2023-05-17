import React from 'react';
import LoginForm from '../components/LoginForm/LoginForm';
import './LoginPageStyles.css';
import Logo from '../components/Logo/Logo';

function LoginPage() {
  return (
    <div className='login-container'>
      <div className='login-form'>
      <LoginForm/>
      </div>
      <div className='logo'><Logo/></div>
    </div>
  )
}

export default LoginPage