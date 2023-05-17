import React from 'react'

import './ProfilePhotoStyles.css';
import image from '../../assets/profile/userImg/alaProfile.png'

function ProfilePhoto() {
  return (
    <div className='image'>
       <img className='profile' src={image} alt="Avatar"></img> 
    </div>
  )
}

export default ProfilePhoto