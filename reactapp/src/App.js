import React, { Component } from 'react';
import { BrowserRouter, Routes, Route } from 'react-router-dom';


import './styles/App.css';
import Mainpage from './pages/Mainpage';
import Profile from './pages/Profile';
import LoginPage from './pages/LoginPage';
import RegisterPage from './pages/RegisterPage';


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
                        <Route path="/profile"element={<Profile/>}/>
                    </Routes>  
            </BrowserRouter>
         );
}
};