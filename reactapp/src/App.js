import React, { Component } from 'react';

export default class App extends Component {
    static displayName = App.name;

    constructor(props) {
        super(props);
    }
    
    render() {
        return (
            <div>
                <h1>Mainpage </h1>
            </div>
        );
    }
}
