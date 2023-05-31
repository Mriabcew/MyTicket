import {React,useEffect,useState} from 'react'
import axios from 'axios';
import { Image,Transformation } from 'cloudinary-react';
import './ProfilePhotoStyles.css';



function ProfilePhoto() {
  const [image, setImage] = useState('');

  useEffect(() => {
    fetchProfilePhoto();
  }, []);

  const fetchProfilePhoto = async () => {
    try {
      const response = await axios.get(`https://localhost:7027/User/${localStorage.id}`);
      const imageData = response.data.image;
      console.log(imageData);
      setImage(imageData);
    } catch (error) {
      console.error(error);
    }
  };

  return (
    <div className='image'>
       <Image cloudName="dlhfvkqas" publicId={image} radious="50">
       </Image>
    </div>
  )
}

export default ProfilePhoto