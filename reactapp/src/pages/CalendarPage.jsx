import React, { useState } from 'react';
import Calendar from 'react-calendar';
import axios from 'axios';

import Navbar from '../components/Navbar/Navbar';
import './CalendarPageStyles.css';
import { Link } from 'react-router-dom';

function CalendarPage() {
  const [selectedDate, setSelectedDate] = useState(null);
  const [showModal, setShowModal] = useState(false);
  const [events, setEvents] = useState([]);

  const handleDayClick = async (date) => {
    setSelectedDate(date);
    try {
      const userID = localStorage.id; // Pobierz userID z sesji
      const formattedDate = formatDate(date); // Sformatuj datę do odpowiedniego formatu
      console.log(formattedDate);
      const response = await axios.get(`https://localhost:7027/Events/Calendar/events/${formattedDate}?id=${userID}`);
      setEvents(response.data);
      setShowModal(true);
    } catch (error) {
      console.error(error);
    }
  };

  const handleCloseModal = () => {
    setSelectedDate(null);
    setShowModal(false);
    setEvents([]);
  };

  const formatDate = (date) => {
    const year = date.getFullYear();
    const month = (date.getMonth() + 1).toString().padStart(2, '0');
    const day = date.getDate().toString().padStart(2, '0');
    return `${year}-${month}-${day}`;
  };

  return (
    <div>
      <Navbar />
      <div className='CalendarContainer'>
        <Calendar onClickDay={handleDayClick} />
      </div>

      {showModal && (
        <div className='ModalOverlay'>
          <div className='ModalContent'>
            <h3>Selected Date: {selectedDate.toLocaleDateString()}</h3>
            <h4>Events:</h4>
            <ul>
              {events.map((event) => (
                <li key={event.id}>{event.name}<Link to={`/calendar/${event.ticketMasterId}`}> <button className='goto'>Go to event</button></Link></li>
              ))}
            </ul>
            <button className="close"onClick={handleCloseModal}>Close</button>
          </div>
        </div>
      )}
    </div>
  );
}

export default CalendarPage;
