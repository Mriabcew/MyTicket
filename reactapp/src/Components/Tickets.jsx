import React from 'react';
import './Tickets.css';

const tickets = [
  {
    id: 1,
    name: 'Kubek termiczny',
    price: 39.99,
    image: 'https://source.unsplash.com/400x400/?mug'
  },
  {
    id: 2,
    name: 'Książka kucharska',
    price: 49.99,
    image: 'https://source.unsplash.com/400x400/?cookbook'
  },
  {
    id: 3,
    name: 'Słuchawki bezprzewodowe',
    price: 199.99,
    image: 'https://source.unsplash.com/400x400/?headphones'
  }
];

const Tickets = () => {
  return (
    <div>
      <h2>MyTickets</h2>
      <ul>
        {tickets.map((ticket) => (
          <li key={ticket.id}>
            <img src={ticket.image} alt={ticket.name} />
            <h3>{ticket.name}</h3>
            <p>{ticket.price} zł</p>
          </li>
        ))}
      </ul>
    </div>
  );
};

export default Tickets;