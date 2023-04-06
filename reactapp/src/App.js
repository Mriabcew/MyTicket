import React, { Component } from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './App.css';
import Navbar from './Components/Navbar';
import Searchbar from './Components/Searchbar';
import Calendar from './Pages/Calendar';
import Mainpage from './Pages/Mainpage';
import MyTickets from './Pages/MyTickets';
import Profile from './Pages/Profile';


export default class App extends Component {
    static displayName = App.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
            <BrowserRouter>
                <Navbar>
                    <Routes>
                        <Route path="/"element={<Mainpage/>}/>
                        <Route path="/Calendar"element={<Calendar/>}/>
                        <Route path="/MyTickets"element={<MyTickets/>}/>
                        <Route path="/Profile"element={<Profile/>}/>
                    </Routes>
                </Navbar>  
            </BrowserRouter>
            </div>
        );
    }
}
