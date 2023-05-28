import React from 'react';
import TicketTile from '../TicketTile/TicketTile';

import './TicketGrid.css';

function TicketGrid(props)
{
  const events = props.events;

  return(
    <div className='Ticket-Grid'>
      {events.map((event) => (
        <TicketTile event ={event}></TicketTile>
      ))}
    </div>
  )
}

export default TicketGrid;