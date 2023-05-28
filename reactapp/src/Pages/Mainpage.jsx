import React from 'react'

import Navbar from '../components/Navbar/Navbar'
import CategoryGrid from '../components/Categories/CategoryGrid'

function Mainpage() {
  const categories = [
    {
      id: 1,
      title: 'Music',
      category: 'music',
      description: 'Bilety na koncerty i festiwale muzyczne',
      buttonText: 'Zobacz więcej',
      image: 'https://images.unsplash.com/photo-1506157786151-b8491531f063?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1170&q=80',
    },
    {
      id: 2,
      title: 'Sport',
      category: 'sport',
      description: 'Bilety na wydarzenia sportowe',
      buttonText: 'Zobacz więcej',
      image: 'https://images.unsplash.com/photo-1541534741688-6078c6bfb5c5?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2069&q=80',
    },
    {
      id: 3,
      title: 'Teatr',
      category: 'theatre',
      description: 'Bilety do teatru',
      buttonText: 'Zobacz więcej',
      image: 'https://images.unsplash.com/photo-1503095396549-807759245b35?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=2071&q=80',
    },
    {
      id: 4,
      title: 'Kluby',
      category: 'clubs',
      description: 'Bilety do klubów',
      buttonText: 'Zobacz więcej',
      image: 'https://images.unsplash.com/photo-1578736641330-3155e606cd40?ixlib=rb-4.0.3&ixid=M3wxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8fA%3D%3D&auto=format&fit=crop&w=1470&q=80',
    },
  ];

  return (
   
    <div>
         <Navbar/>
          <div className='CategoryGrid'>
            <CategoryGrid categories={categories} />
          </div>
    </div>
    
  )
}

export default Mainpage