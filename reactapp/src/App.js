import React, { Component } from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import './styles/App.css';
import Calendar from './pages/Calendar';
import Mainpage from './pages/Mainpage';
import MyTickets from './pages/MyTickets';
import Profile from './pages/Profile';
import Login from './pages/Login';
import Register from './pages/Register';
import Settings from './pages/Settings';


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
