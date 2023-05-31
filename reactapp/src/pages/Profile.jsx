import React, { useState, useEffect } from 'react';
import Navbar from '../components/Navbar/Navbar';
import ProfilePhoto from '../components/ProfilePhoto/ProflePhoto';
import ProfileData from '../components/ProfileData/ProfileData';
import { Image,Transformation } from 'cloudinary-react';
import axios from 'axios';

import './ProfileStyles.css';

function Profile() {
  const [image, setImage] = useState('');

  useEffect(() => {
    fetchUserImage();
  }, []);

  const fetchUserImage = async () => {
    try {
      const response = await axios.get(`https://localhost:7027/User/${localStorage.id}`);
      setImage(response.data.backgroundImage);
    } catch (error) {
      console.error('Wystąpił błąd podczas pobierania obrazu:', error);
    }
  };

  return (
    <div>
      <Navbar />
        <Image className="backgroundImg" cloudName="dlhfvkqas" publicId={image} >
          <Transformation rawTransformation="h_150,w_150,c_fill,e_sepia,r_20" />
        </Image>
        <div className='main'>
          <div className='profileImg'>
            <ProfilePhoto />
          </div>
          <div className='profileData'>
            <ProfileData />
          </div>
        </div>
      </div>
  );
}

export default Profile;
