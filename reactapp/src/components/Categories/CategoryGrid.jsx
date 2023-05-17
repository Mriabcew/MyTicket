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
       
       <CategoryTile category={category}><Link key={category.id} to={`/category/${category.title}`}></Link></CategoryTile>
     
      ))}
    </div>
  );
}

export default CategoryGrid;