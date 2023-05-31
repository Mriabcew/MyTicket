import React, { useState, useEffect } from 'react';
import axios from 'axios';

import './ProfileDataStyles.css';

function ProfileData() {

  const [userData, setUserData] = useState({
    user: null,
    isLoading: true,
    error: null
  });

  useEffect(() => {
    axios
      .get(`https://localhost:7027/user/${localStorage.id}`)
      .then((response) => {
        setUserData({ user: response.data, isLoading: false, error: null });
      })
      .catch((error) => {
        setUserData({ user: null, isLoading: false, error: error.message });
      });
  }, []);

  if (userData.isLoading) {
    return (
        <h2>Loading...</h2>
    );
  }

  if (!userData.user) {
    return (
      <div className='container'>
      <h1>User not found</h1>
      <h5 className='error'>{userData.error}</h5>
      </div>
    );
  }

  return (
    <div className='container'>
        <h1>{userData.user.username}</h1>
        <h4>Emial: {userData.user.email}</h4>
        <h4>Name: {userData.user.name}</h4>
        <h4>Surname: {userData.user.surname}</h4>
    </div>
  )
}

export default ProfileData;
