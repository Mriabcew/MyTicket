import React from 'react'
import Searchbar from '../Components/Searchbar'
import Container from '../Components/Container'

function Mainpage() {
  return (
        <div className='search-bar'>
          <Searchbar placeholder="Search here ... "/>
          <Container/>
        </div>
  )
}

export default Mainpage