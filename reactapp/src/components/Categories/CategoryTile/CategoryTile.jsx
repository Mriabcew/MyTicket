import React from 'react'
import './CategoryTile.css';

function CategoryTile(props) {
    return (
        <div className="category-tile">
          {console.log(props)}
          <img src={props.category.image} alt={props.title} />
          <h3>{props.category.title}</h3>
          <p>{props.category.description}</p>
        </div>
      );
}

export default CategoryTile