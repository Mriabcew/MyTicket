import React from 'react'

import LogoImg from '../../assets/logo.svg';
import './LogoStyles.css';

function Logo() {
  return (
    <div className='logo-container'>
            <img src={LogoImg} alt="MyTicket Logo"/>
            <div className='text'>MyTicket</div>
        </div>
  )
}

export default Logo