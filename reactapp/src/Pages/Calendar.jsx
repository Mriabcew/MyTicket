import React from 'react';
import {Calendar as Cal }from 'react-calendar';
import Navbar from '../components/Navbar';
import "./CSS/Calendar.css";

function Calendar() {
  return (
    <div>
      <Navbar>
      <Cal/>
      </Navbar>
    </div>
  )
}

export default Calendar