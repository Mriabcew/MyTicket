import React, { useState } from 'react';
import {BiSearchAlt} from 'react-icons/bi';

const Search = () => {
  const [searchInput, setSearchInput] = useState("");
  const [showSearch, setShowSearch] = useState(false);

  const handleChange = (e) => {
    e.preventDefault();
    setSearchInput(e.target.value);
  };

  const handleSearchIconClick = () => {
    setShowSearch(!showSearch);
  };

  return (
    <div className='search'>
      {!showSearch && (
          <BiSearchAlt className='icon' onClick={handleSearchIconClick}></BiSearchAlt>
      )}

      {showSearch && (
        <div className='search-bar'>
          <input
            type="search"
            placeholder="Search here"
            onChange={handleChange}
            value={searchInput}
            
          />
          <button>search</button>
          <BiSearchAlt className='icon' onClick={handleSearchIconClick}></BiSearchAlt>
        </div>
      )}
    </div>
  );
};

export default Search;