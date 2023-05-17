import React, { Component } from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';


import './styles/App.css';
import Mainpage from './pages/Mainpage';
import Profile from './pages/Profile';
import LoginPage from './pages/LoginPage';
import RegisterPage from './pages/RegisterPage';
import CalendarPage from './pages/CalendarPage';
import PasswordRestartPage from './pages/PasswordRestartPage';
import Logo from './components/Logo/Logo';
import TicketsPage from './pages/TicketsPage';
import Settings from './pages/Settings';
import Search from './components/Search/Search';
import CategoryPage from './pages/CategoryPage';

export default class App extends Component {
    static displayName = App.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <BrowserRouter>
                    <Routes>
                        <Route path='/' element={<LoginPage/>}/>
                        <Route path='/register' element={<RegisterPage/>}/>
                        <Route path="/home"element={<Mainpage/>}/>
                        <Route path="/calendar"element={<CalendarPage/>}/>
                        <Route path="/profile"element={<Profile/>}/>
                        <Route path="/passwordRestart"element={<PasswordRestartPage/>}/>
                        <Route path="/logo"element={<Logo/>}/>
                        <Route path="/mytickets"element={<TicketsPage/>}/>
                        <Route path="/settings"element={<Settings/>}/>
                        <Route path="/search"element={<Search/>}/>
                        <Route path="/category/:categoryTitle" component={<CategoryPage/>} />
                    </Routes>  
            </BrowserRouter>
         );
}
};