import React from 'react';
import Searchbar from '../components/Searchbar';
import Navbar from '../components/Navbar';
import Tickets from '../components/Tickets';

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