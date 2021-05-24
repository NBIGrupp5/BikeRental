import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { BookingForm } from './components/BookingForm'
import ShowAboutUs from './components/AboutUs'

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route exact path='/BookingForm' component={BookingForm} />
        <Route path='/AboutUs' component={ShowAboutUs} />
      </Layout>
    );
  }
}
