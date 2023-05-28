import React, { useState, useEffect } from 'react';
import axios from 'axios';
import Navbar from '../components/Navbar/Navbar';
import './TicketsPageStyles.css';

function MyTicketPage(props) {
  const [tickets, setTickets] = useState([]);

  useEffect(() => {
    async function fetchData() {
      const response = await axios.get('https://localhost:7027/Ticket/12');
      setTickets(response.data);
    }

    fetchData();
  }, [props.userId]);

  return (
    <div>
      <Navbar></Navbar>
      <div className='Table'>
        <table className='TicketsTable'>
          <thead>
            <tr>
              <th>Data zakupu</th>
              <th>Cena</th>
              <th>Numer miejsca</th>
              <th>Rząd</th>
              <th>Sektor</th>
              <th>Status</th>
              <th>Kod QR</th>
            </tr>
          </thead>
          <tbody>
            {tickets.map(ticket => (
              <tr key={ticket.id}>
                <td>{ticket.purchaseDate}</td>
                <td>{ticket.price}</td>
                <td>{ticket.seatNumber}</td>
                <td>{ticket.row}</td>
                <td>{ticket.sector}</td>
                <td>{ticket.status}</td>
                <td><button type="submit">Generuj kod QR</button></td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}

export default MyTicketPage;
