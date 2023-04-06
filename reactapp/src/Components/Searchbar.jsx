import React from 'react'
import {BiSearchAlt2} from "react-icons/bi";
import "./Searchbar.css";

function Searchbar({placeholder}) {
  return (
   <div className='search'>
        <div className='searchInput'>
            <input type='text' 
            placeholder={placeholder}/>
            <div className='searchIcon'>
                <BiSearchAlt2/>
            </div>
        </div>
   </div>
  )
}

export default Searchbar