import React from 'react'

import Navbar from '../components/Navbar/Navbar'
import CategoryGrid from '../components/Categories/CategoryGrid'

function Mainpage() {
  const categories = [
    {
      id: 1,
      title: 'Muzyka',
      description: 'Opis kategorii 1',
      buttonText: 'Zobacz więcej',
      image: 'https://via.placeholder.com/300x300.png?text=Music',
    },
    {
      id: 2,
      title: 'Sport',
      description: 'Opis kategorii 2',
      buttonText: 'Zobacz więcej',
      image: 'https://via.placeholder.com/300x300.png?text=Sport',
    },
    {
      id: 3,
      title: 'Teatr',
      description: 'Opis kategorii 3',
      buttonText: 'Zobacz więcej',
      image: 'https://sp1slupsk.pl/wp-content/uploads/2018/01/90522054_887708661642378_6670511967955845120_n.jpg',
    },
    {
      id: 4,
      title: 'Kino',
      description: 'Opis kategorii 4',
      buttonText: 'Zobacz więcej',
      image: 'https://via.placeholder.com/300x300.png?text=Kategoria+4',
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