import React, { useState } from 'react';
import Calendar from 'react-calendar';

import Navbar from '../components/Navbar/Navbar';
import './CalendarPageStyles.css';

function CalendarPage() {
  const [selectedDate, setSelectedDate] = useState(null);
  const [showModal, setShowModal] = useState(false);

  const handleDayClick = (date) => {
    setSelectedDate(date);
    setShowModal(true);
  };

  const handleCloseModal = () => {
    setSelectedDate(null);
    setShowModal(false);
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
            <button onClick={handleCloseModal}>Close</button>
          </div>
        </div>
      )}
    </div>
  );
}

export default CalendarPage;

