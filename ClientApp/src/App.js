import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { BookingForm } from './components/BookingForm'
import { Bikes } from './components/Bikes'
import ShowAboutUs from './components/AboutUs'
import { NavMenu } from './components/NavMenu'
import './custom.css'
import { Skapakonto } from './components/Skapakonto';
import { Loggain } from './components/Loggain';

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
     <Layout>
      <div>       
        <Bikes />      
            <Route exact path='/BookingForm' component={BookingForm} />
            <Route exact path='/Bikes' component={Bikes} />
            <Route path='/AboutUs' component={ShowAboutUs} />
<<<<<<< HEAD


=======
            <Route path='/Loggain' component={Loggain} />
            <Route path='/Skapakonto' component={Skapakonto} />
>>>>>>> bbbb36232712e7ddeece82f621553b3d97b9ebe7
        </div>
        </Layout>
    );
  }
}
