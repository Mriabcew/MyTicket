import React, { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';

import Navbar from '../components/Navbar/Navbar';
import TicketGrid from '../components/Tickets/TicketsGrid/TicketGrid';

import './TicketCatalog.css';

function TicketsCatalog() {
  const { category } = useParams();
  const [biletyKategorii, setBiletyKategorii] = useState([]);

  useEffect(() => {
    // Wywołanie funkcji pobierającej bilety z danego endpointu
    fetchBiletyKategorii();
  }, []);

  const fetchBiletyKategorii = async () => {
    try {
      const response = await fetch(`https://localhost:7027/${category}`);
      const data = await response.json();
      setBiletyKategorii(data);
    } catch (error) {
      console.log('Wystąpił błąd podczas pobierania biletów:', error);
    }
  };

  return (
    <div>
      <Navbar />
      
        {biletyKategorii.length > 0 ? (
          <div className='Ticket-grid'>
            <TicketGrid events={biletyKategorii} />
          </div>
        ) : (
          <p>Ładowanie ...</p>
        )}
    </div>
  );
}

export default TicketsCatalog;