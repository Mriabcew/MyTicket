import React from 'react';
import { Link } from 'react-router-dom';

import './TicketTile.css';

const TicketTile = ({ event }) => {
  return (
    
    <Link to={event.id} className='tile'><div className="event-tile">
      <img src={event.imageUrl}/>
      <h3>{event.name}</h3>
      <p>{event.description}</p>
      <p>Date: {event.date}</p>
    </div></Link>
  );
};

export default TicketTile;