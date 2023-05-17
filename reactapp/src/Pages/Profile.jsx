import React from 'react';
import Navbar from '../components/Navbar/Navbar';
import ProfilePhoto from '../components/ProfilePhoto/ProflePhoto';
import ProfileData from '../components/ProfileData/ProfileData';

import './ProfileStyles.css';

function Profile() {
  return (
    <div className='background'>
    <Navbar/>
    <div className='main'>
      
          <div className='profileImg'>
            <ProfilePhoto/>
          </div>
          <div className='profileData'>
          <ProfileData/>
          </div>
    </div>
    </div>
    
  )
}

export default Profile