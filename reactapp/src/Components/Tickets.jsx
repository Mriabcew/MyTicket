import React from 'react';
import './CSS/Tickets.css';

const tickets = [
  {
    id: 1,
    name: 'Avatar:Istota wody',
    date: '2/04/2023',
    image: 'https://encrypted-tbn1.gstatic.com/images?q=tbn:ANd9GcTbziOzbDmW3nOyfvjUscRiaqSqEWA8GivtmG783Rkk9K8r-k34'
  },
  {
    id: 2,
    name: 'The Future Past Tour',
    date: '13.06.2023',
    image: 'https://www.tauronarenakrakow.pl/content/uploads/2022/10/Iron-Maiden_TAK_2023_1016x748-475x350.jpg'
  },
  {
    id: 3,
    name: 'F1 | Austria | Spielberg',
    date: '2.02.2023',
    image: 'https://www.gptickets.store/uploads/images/482/f1-results-statistics-austria-red-bull-ring-2023.jpg'
  }
];

const Tickets = () => {
  return (
    <div>
      <h2>MyTickets</h2>
      <ul>
        {tickets.map((ticket) => (
          <div key={ticket.id}>
            <img className="categoryImg" src={ticket.image} alt={ticket.name} />
            <h2>{ticket.name}</h2>
            <p>{ticket.date} </p>
          </div>
        ))}
      </ul>
    </div>
  );
};

export default Tickets;
