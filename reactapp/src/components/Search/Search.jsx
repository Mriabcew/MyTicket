import React, {useState} from 'react'


const Search = () => {

 const [searchInput, setSearchInput] = useState("");

const handleChange = (e) => {
  e.preventDefault();
  setSearchInput(e.target.value);
};




return( 
<div>
<input
   type="search"
   placeholder="Search here"
   onChange={handleChange}
   value={searchInput} />
</div>

);
};

export default Search;