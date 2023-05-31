import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import axios from 'axios';
import './TicketDetails.css';

function TicketDetails() {
  const { id } = useParams();
  const [ticketData, setTicketData] = useState(null);
  const [isObserving, setIsObserving] = useState(false);

  useEffect(() => {
    fetchTicketData();
    checkObservingStatus();
  }, []);

  const fetchTicketData = async () => {
    try {
      const response = await fetch(`https://localhost:7027/E/${id}`, {
        headers: {
          'Content-Type': 'application/json',
          Authorization: 'Bearer ' + localStorage.getItem('token'),
        },
      });
      const data = await response.json();
      setTicketData(data);
    } catch (error) {
      console.log('Wystąpił błąd podczas pobierania danych biletu:', error);
    }
  };

  const checkObservingStatus = async () => {
    try {
      const userID = localStorage.id;
      const response = await axios.get(`https://localhost:7027/Events/MyTickets/${userID}`);
      const tickets = response.data;
      const isObserving = tickets.some((ticket) => ticket.ticketMasterId == id);
      setIsObserving(isObserving);
    } catch (error) {
      console.error(error);
    }
  };


  const handleObservationToggle = async () => {
    try {
      const userID = localStorage.id;
      if (isObserving) {
        await axios.post(`https://localhost:7027/Events/MyTickets/remove/${userID}?eventId=${id}`);
      } else {
        await axios.post(`https://localhost:7027/Events/MyTickets/add/${userID}?eventId=${id}`);
      }
      setIsObserving(!isObserving);
    } catch (error) {
      console.error(error);
    }
  };

  

  return (
    <div className='TicketData'>
      {ticketData ? (
        <div className='column'>
          <h1 className='ticket-name'>{ticketData.name}</h1>
          <h5>{ticketData.date}</h5>
          <div className='desc'>{ticketData.description}</div>
          <br />
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
          <button onClick={handleObservationToggle}>
            {isObserving ? 'Przestań obserwować' : 'Obserwuj wydarzenie'}
          </button>
        </div>
      </div>
    </div>
  );
}

export default TicketDetails;
