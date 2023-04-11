import React from 'react';
import Searchbar from '../Components/Searchbar';
import Navbar from '../Components/Navbar';
import Tickets from '../Components/Tickets';

function MyTickets() {
  return (
    <div className='MyTickets'>
        <Navbar>
          <Searchbar placeholder="Search here ... "/>
          <Tickets/>
        </Navbar>
     </div>
  )
}

export default MyTickets