import React from 'react';
import './LoginPageStyles.css';
import Logo from '../components/Logo/Logo';
import RestartPasswordForm from '../components/RestartPasswordForm/RestartPasswordForm';

function LoginPage() {
  return (
    <div className='login-container'>
      <div className='login-form'>
      <RestartPasswordForm/>
      </div>
      <div className='logo'><Logo/></div>
    </div>
  )
}

export default LoginPage