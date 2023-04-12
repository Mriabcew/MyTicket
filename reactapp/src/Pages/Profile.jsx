import React from 'react'
import Navbar from '../Components/Navbar'
import "./CSS/Profile.css";

function Profile() {
  return (
    <div>
    <Navbar>  
    <div className="profile-container">
      <div className="profile-header">
        <h1>John Doe</h1>
        <img src="https://via.placeholder.com/150" alt="Profile Picture" />
      </div>
      <div className="profile-info">
        <div className="profile-section">
          <h2>Contact Information</h2>
          <p>Email: johndoe@example.com</p>
          <p>Phone: 123-456-7890</p>
        </div>
        <div className="profile-section">
          <h2>Personal Information</h2>
          <p>Age: 35</p>
          <p>Gender: Male</p>
          <p>Occupation: Developer</p>
        </div>
      </div>
    </div>    
    </Navbar>
    </div>
  )
}

export default Profile