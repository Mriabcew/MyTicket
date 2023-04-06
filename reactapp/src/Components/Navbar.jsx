import React, {useState} from 'react'
import {
  FaBars,
  FaUserAlt,
}from "react-icons/fa";
import {
    AiFillHome
}from "react-icons/ai";
import {
    BsCalendarWeek
}from "react-icons/bs";
import { NavLink } from 'react-router-dom';
import Logo from './Logo';

import { SlBriefcase } from "react-icons/sl";

const Navbar = ({children}) => {
  const[isOpen ,setIsOpen] = useState(false);
  const toggle = () => setIsOpen (!isOpen);
  const menuItem=[
    {
        path:"/",
        name:"Main",
        icon:<AiFillHome/>
    },
    {
        path:"/Calendar",
        name:"Calendar",
        icon:<BsCalendarWeek/>
    },
    {
        path:"/MyTickets",
        name:"My Ticets",
        icon:<SlBriefcase/>
    },
    {
        path:"/Profile",
        name:"Profile",
        icon:<FaUserAlt/>
    }
]
return (
  <div className="container">
     <div style={{width: isOpen ? "200px" : "50px"}} className="sidebar">
         <div className="top_section">
             <h1 style={{display: isOpen ? "block" : "none"}} className="logo"><Logo/></h1>
             <div style={{marginLeft: isOpen ? "50px" : "0px"}} className="bars">
                 <FaBars onClick={toggle}/>
             </div>
         </div>
         {
             menuItem.map((item, index)=>(
                 <NavLink to={item.path} key={index} className="link" activeclassName="active">
                     <div className="icon">{item.icon}</div>
                     <div style={{display: isOpen ? "block" : "none"}} className="link_text">{item.name}</div>
                 </NavLink>
             ))
         }
     </div>
     <main>{children}</main>
  </div>
);
};

export default Navbar