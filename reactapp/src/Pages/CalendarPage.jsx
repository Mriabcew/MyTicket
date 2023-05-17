import React from 'react'
import Calendar from 'react-calendar'

import Navbar from '../components/Navbar/Navbar'

import './CalendarPageStyles.css';

function CalendarPage() {
  const handleDayClick = (date) => {
    console.log(`Clicked on date: ${date}`);
  };


  return (
    <div>
       <Navbar/>
          <div className='CalendarContainer'>
            <Calendar  onClickDay={handleDayClick}/>
          </div>
    </div>
  )
}

export default CalendarPage