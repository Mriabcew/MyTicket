import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import './TicketDetails.css';

function TicketDetails() {
  const { id } = useParams();
  const [ticketData, setTicketData] = useState(null);

  useEffect(() => {
    fetchTicketData();
  }, []);

  const fetchTicketData = async () => {
    try {
      const response = await fetch(`https://localhost:7027/E/${id}`);
      const data = await response.json();
      setTicketData(data);
    } catch (error) {
      console.log('Wystąpił błąd podczas pobierania danych biletu:', error);
    }
  };

  return (
    <div className='TicketData'>
      {ticketData ? (
        <div className='column'>
          <h1 className='ticket-name'>{ticketData.name}</h1>
          <div className='desc'>{ticketData.description}</div><br/>
        </div>
      ) : (
        <p>Ładowanie danych...</p>
      )}
      <div className='column'>
        {ticketData && ticketData.imageUrl ? (
          <img className='image' src={ticketData.imageUrl} alt='Ticket' />
        ) : (
          <img className='image' src='https://via.placeholder.com/300x300.png?text=img' alt='Ticket' />
        )}
        <div className='button-section'>
          <button>Kup bilet</button>
        </div>
      </div>
    </div>
  );
}

export default TicketDetails;
