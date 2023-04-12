import React, { Component } from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './App.css';
import Calendar from './Pages/Calendar';
import Mainpage from './Pages/Mainpage';
import MyTickets from './Pages/MyTickets';
import Profile from './Pages/Profile';
import Login from './Pages/Login';
import Register from './Pages/Register';
import Settings from './Pages/Settings';


export default class App extends Component {
    static displayName = App.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <div>
            <BrowserRouter>
                    <Routes>
                        <Route path="/"element={<Login/>}/>
                        <Route path='/Register'element={<Register/>}/>
                        <Route path="/Calendar"element={<Calendar/>}/>
                        <Route path="/MyTickets"element={<MyTickets/>}/>
                        <Route path="/Profile"element={<Profile/>}/>
                        <Route path='/Mainpage'element={<Mainpage/>}/>
                        <Route path='/Settings'element={<Settings/>}/>
                    </Routes>  
            </BrowserRouter>
            </div>
        );
    }
}
