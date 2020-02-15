import React from 'react';
import './App.css';
import './main.scss';
import 'bootstrap/dist/css/bootstrap.min.css';
import Header from './common/template/header'
import Iframe from 'react-iframe'


export default props =>(
    <div className="App">
      <Header>app</Header>
      <Iframe url="http://localhost:3000"
        width="100%"
        height="450px"
        id="myId"
        display="initial"
        position="relative"/>
    </div>
);
