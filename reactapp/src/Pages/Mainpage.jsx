import React from 'react'
import Searchbar from '../Components/Searchbar'
import Navbar from '../Components/Navbar'
import CategoriesPage from '../Components/Categories'

function Mainpage() {
  return (
        <div className='Mainpage'>
          <Navbar>
          <Searchbar placeholder="Search here ... "/>
          <CategoriesPage/>
          </Navbar>
        </div>
  )
}

export default Mainpage;