import React from 'react';
import './Categories.css';

function CategoriesPage() {
  const categories = [
    { id: 1, name: 'Technology' },
    { id: 2, name: 'Science' },
    { id: 3, name: 'Art' },
    { id: 4, name: 'Sports' },
  ];

  return (
    <div className="categories-container">
      <h1>Categories</h1>
      <div className="categories-list">
        {categories.map(category => (
          <div key={category.id} className="category">
            <h2>{category.name}</h2>
            <p>Click to explore more</p>
          </div>
        ))}
      </div>
    </div>
  );
}

export default CategoriesPage;