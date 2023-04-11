import React from 'react';
import {Calendar as Cal }from 'react-calendar';
import Navbar from '../Components/Navbar';
import "./Calendar.css";

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