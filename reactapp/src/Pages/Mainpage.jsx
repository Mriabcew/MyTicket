import React from 'react'
import Searchbar from '../components/Searchbar'
import Navbar from '../components/Navbar'
import CategoriesPage from '../components/Categories'

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