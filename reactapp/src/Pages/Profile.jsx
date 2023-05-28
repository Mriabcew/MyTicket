import React from 'react';
import Navbar from '../components/Navbar/Navbar';
import ProfilePhoto from '../components/ProfilePhoto/ProflePhoto';
import ProfileData from '../components/ProfileData/ProfileData';

import image from '../assets/profile/background/background-profile.jpg';

import './ProfileStyles.css';

function Profile() {
  return (
    <div>
      <Navbar />
      <div className='background-image' style={{ backgroundImage: `url(${image})` }}>
        <div className='main'>
          <div className='profileImg'>
            <ProfilePhoto />
          </div>
          <div className='profileData'>
            <ProfileData />
          </div>
        </div>
      </div>
    </div>
  );
}

export default Profile;