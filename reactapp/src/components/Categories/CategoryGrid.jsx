import React from 'react';
import CategoryTile from './CategoryTile/CategoryTile';

import { Link } from 'react-router-dom';

import './CategoryGrid.css';

function CategoryGrid(props) {
  const categories = props.categories;

  return (
    <div className="category-grid">
      {console.log(categories)}
      {categories.map((category) => (
       
       <Link key={category.id} to={`/Tickets/${category.category}`}> <CategoryTile category={category}></CategoryTile></Link>
     
      ))}
    </div>
  );
}

export default CategoryGrid;