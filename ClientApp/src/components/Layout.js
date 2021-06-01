import React, { Component } from 'react';
import { Container } from 'reactstrap';
import { NavMenu } from './NavMenu';
import { Home } from './Home';


export class Layout extends Component {
  static displayName = Layout.name;

  render () {
    return (
      <div>

        <Home />
        <NavMenu />
        <Container>
          {this.props.children}
        </Container>
      </div>
    );
  }
}
