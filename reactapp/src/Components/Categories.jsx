import React from 'react';
import { Link } from "react-router-dom";
import './CSS/Categories.css';

function CategoriesPage() {
  const categories = [
    { id: 1, name: 'Kino', image: 'https://source.unsplash.com/400x400/?cinema',url:'/category/cinema' },
    { id: 2, name: 'Teatr',image: 'https://source.unsplash.com/400x400/?theater',url:'/category/theater' },
    { id: 3, name: 'Muzyka',image: 'https://source.unsplash.com/400x400/?music',url:'/category/music'  },
    { id: 4, name: 'Sport',image: 'https://source.unsplash.com/400x400/?sport' ,url:'/category/sport' },
  ];

  return (
    <div className="categories-container">
      <h1>Kategorie</h1>
      <div className="categories-list">
        {categories.map(category => (
          <div key={category.id} className="category">
             <Link to={category.url}>
            <img className="categoryImg"src={category.image} alt={category.name} />
            <h2>{category.name}</h2>
            <p>
              Wiecej informacji
            </p>
            </Link>
          </div>
        ))}
      </div>
    </div>
  );
}

export default CategoriesPage;