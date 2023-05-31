import React, { useState } from 'react';
import { AiOutlineSetting } from 'react-icons/ai';
import { BiLogOutCircle,BiSearchAlt } from 'react-icons/bi';
import { HiOutlineMenuAlt4 } from 'react-icons/hi';
import { AiOutlineClose } from 'react-icons/ai';
import { FaFacebook, FaInstagram, FaPinterest, FaTwitter, FaYoutube } from 'react-icons/fa';

import { Link } from 'react-router-dom';

import './NavbarStyles.css';
import Search from '../Search/Search';



function Navbar() {
    const [nav, setNav] = useState(false);
    const [darkMode, setDarkMode]= useState(false);
    const [showSearchBar, setShowSearchBar] = useState(false);

    const handleNav = () => setNav(!nav);
    const handleShowSearchBar = () => setShowSearchBar(!showSearchBar);

    const handleLogout = () => {
        localStorage.clear();
      };
    

return (
    <div name='home' className={nav ? 'navbar navbar-bg' : 'navbar'}>
    <div className={nav ? 'logo dark' : 'logo-text'}>
        <h2>MyTicket</h2>
    </div>
    <ul className="nav-menu">
        <Link to='/home' smooth={true} duration={500} ><li>Home</li></Link>
        <Link to='/calendar' smooth={true} duration={500} ><li>Calendar</li></Link>
        <Link to='/mytickets' smooth={true} duration={500} ><li>My Tickets</li></Link>
        <Link to='/profile' smooth={true} duration={500} ><li>Profile</li></Link>
       
    </ul>
    <div className="nav-icons">
        <Link className='nav-link' to='/settings'><AiOutlineSetting className='icon' style={{ marginRight: '1rem' }} /></Link>
        <Link className='nav-link' to='/'><BiLogOutCircle className='icon' onClick={handleLogout}/></Link>
    </div>
    <div className="hamburger" onClick={handleNav}>
        {!nav ? (<HiOutlineMenuAlt4 className='icon' />) : (<AiOutlineClose style={{ color: '#000' }} className='icon' />)}

    </div>

    <div className={nav ? 'mobile-menu active' : 'mobile-menu'}>
        <ul className="mobile-nav">
        <Link to='/home' smooth={true} duration={500} ><li>Home</li></Link>
        <Link to='/calendar' smooth={true} duration={500} ><li>Calendar</li></Link>
        <Link to='/mytickets' smooth={true} duration={500} ><li>My Tickets</li></Link>
        <Link to='/profile' smooth={true} duration={500} ><li>Profile</li></Link>
       
        </ul>
        <div className="mobile-menu-bottom">
            <div className="menu-icons">
                <Link to='/settings'><button> Settings</button></Link>
                <Link to='/'><button onClick={handleLogout}>Logout</button></Link>
            </div>
            <div className="social-icons">
                <FaFacebook className='icon' />
                <FaInstagram className='icon' />
                <FaTwitter className='icon' />
                <FaPinterest className='icon' />
                <FaYoutube className='icon' />
            </div>
        </div>
    </div>

</div>
)
};

export default Navbar
