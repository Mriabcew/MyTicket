import React, { useState, useEffect } from 'react';
import axios from 'axios';
import Navbar from '../components/Navbar/Navbar';
import './TicketsPageStyles.css';
import { Link } from 'react-router-dom';

function MyTicketPage(props) {
  const [tickets, setTickets] = useState([]);

  useEffect(() => {
    async function fetchData() {
      try {
        const response = await axios.get(`https://localhost:7027/Events/MyTickets/${localStorage.id}`);
        setTickets(response.data);
      } catch (error) {
        console.error(error);
      }
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
              <th className='photo'>Zdjecie</th>
              <th>Nazwa</th>
              <th>Data</th>
             
              <th>Przejdz do wydarzenia</th>
            </tr>
          </thead>
          <tbody>
            {tickets.map(ticket => (
              <tr key={ticket.id}>
                <td className='photo'><img className='Image' src={ticket.imageUrl}></img></td>
                <td className='Text'>{ticket.name}</td>
                <td className='Text'>{ticket.date}</td>
                <td> <Link to={`/mytickets/${ticket.ticketMasterId}`}><button className='GoTo'>
                    Przejdź do wydarzenia</button>
                  </Link></td>
              </tr>
            ))}
          </tbody>
        </table>
      </div>
    </div>
  );
}

export default MyTicketPage;